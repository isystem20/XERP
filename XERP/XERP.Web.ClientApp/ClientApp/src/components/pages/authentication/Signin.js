import React, { Component } from 'react'
import LoadScript from '../../functions/load-scripts/LoadScript';
import { Link } from 'react-router-dom';
import AxiosRequest from '../../functions/axios/AxiosRequest';

export class Signin extends Component {
    constructor(props) {
        super(props);

        this.state = {

            name : "",
            password : "",
            remember : false,
        
            validationErrorDesc : "",   
            validating : false
        }

    }

    componentDidMount() {
        //load required scripts for this page
        const scripts = ['validate', 'op_auth_signin']
        LoadScript(scripts, document.body, false);
    }

    handleOnChange = (e) => {
        //console.log(this.state)
        this.setState({ [e.target.name]: e.target.value });
    }

    handleSubmit = (e) => {

        e.preventDefault();

        // Disable controls to prevent spammers
        this.setState({  
            validationErrorDesc : "",
            validating : true 
        });  

        // Hold the current component
        let component = this;

        // Prepare postData
        const { username, password } = this.state
        let postData = {
            email: username,        // Change email key in future 
            password: password
        }
        // Valid credential for test API email: "eve.holt@reqres.in", password: "cityslicka"
        let axios = AxiosRequest('post', 'https://reqres.in/api/login', postData);
        axios.then(function (response) {
            // console.log(response);
            component.setState({ 
                response : response,
                validating : false
            });   
            component.handleLoginData();
        })
        .catch(function (error) {
            // console.log(error);
            component.setState({ 
                validating : false,
                validationErrorDesc:"Cannot be validated. Please try again." 
             });  
        });

    }

    handleLoginData() {
        let response = this.state.response;
        if (response != null && response.status == 200) {
            let data = { success:true, result:"message" };  // test data
            // let data = response.data;
            if (data != null) {
                if (data.success) {
                    localStorage.setItem('token', data.token);
                    this.props.history.push('/dashboard');
                } else {
                    this.setState({ validationErrorDesc:data.result });
                }
                // console.log('Done handling reponse.data');
                console.log(this.state);
            } else {
                console.log('reponse.data is empty');
                this.setState({  validationErrorDesc:"Cannot be validated. Please try again." });
            }
        } else {
            console.log('reponse.status is not 200');
            this.setState({  validationErrorDesc:"Cannot be validated. Please try again." });
        }
               
        this.setState({ validating : false });  
    }

    render() {
        let spinner =   !this.state.validating 
                        ?   ""
                        :   <div className="col-md-6 col-xl-5" >
                                <div className="spinner-border text-primary" role="status">
                                    <span className="sr-only">Loading...</span>
                                </div>
                            </div>;
        let validationErrorDesc = this.state.validationErrorDesc == ""
                        ?   ""
            :               <div className="alert alert-warning d-flex align-items-center justify-content-between" role="alert">
                                <div className="flex-fill mr-3">
                                    <p className="mb-0">{this.state.validationErrorDesc}</p>
                                </div>
                                <div className="flex-00-auto">
                                    <i className="fa fa-fw fa-exclamation-circle"></i>
                                </div>
                            </div> 

        
        return (
            <main id="main-container">
                <div className="bg-image bg-image-signin">
                    <div className="hero-static bg-white-95">
                        <div className="content">
                            <div className="row justify-content-center">
                                <div className="col-md-8 col-lg-6 col-xl-4">                                    
                                    <div className="block block-themed block-fx-shadow mb-0">
                                        <div className="block-header">
                                            <h3 className="block-title">Sign In</h3>
                                            <div className="block-options">
                                                <Link className="btn-block-option font-size-sm"  to="/passwordReminder">Forgot Password?</Link>
                                            </div>
                                        </div>
                                        <div className="block-content">
                                            <div className="p-sm-3 px-lg-4 py-lg-5">
                                                <h1 className="mb-2">{"{ Company name here!!! }"}</h1>
                                                <p>Welcome, please login.</p>
                                                <div>
                                                    <div className="py-3">
                                                        <div className="form-group">
                                                            <input 
                                                                onChange={e => this.handleOnChange(e)}
                                                                type="text" 
                                                                className="form-control"
                                                                name="username" 
                                                                placeholder="Username"          
                                                                autoComplete="off"                              
                                                                disabled={this.state.validating}/>     
                                                        </div>
                                                        <div className="form-group">
                                                            <input 
                                                                onChange={e => this.handleOnChange(e)}
                                                                type="password" 
                                                                className="form-control"
                                                                name="password" 
                                                                placeholder="Password"                                                  
                                                                disabled={this.state.validating}/>   
                                                        </div>
                                                        <div className="form-group">
                                                            <div className="custom-control custom-checkbox">
                                                                <input 
                                                                    onChange={e => this.handleOnChange(e)}
                                                                    type="checkbox" 
                                                                    className="custom-control-input" 
                                                                    name="remember"
                                                                    disabled={this.state.validating}/>
                                                                <label className="custom-control-label font-w400" for="login-remember">Remember Me</label>
                                                            </div>
                                                        </div>
                                                    </div>  
                                                    { validationErrorDesc }
                                                    <div className="form-group row"> 
                                                        <div className="col-md-6 col-xl-5">
                                                            <button 
                                                                onClick={e => this.handleSubmit(e)}
                                                                type="submit" 
                                                                className="btn btn-block btn-primary"
                                                                disabled={this.state.validating}>
                                                                <i className="fa fa-fw fa-sign-in-alt mr-1"></i> Sign In
                                                            </button>      
                                                        </div>
                                                        { spinner }                                                        
                                                    </div>
                                                </div>                                                
                                            </div>
                                        </div>
                                    </div>                                    
                                </div>
                            </div>
                        </div>
                        <div className="content content-full font-size-sm text-muted text-center">
                            <strong>{"{ App name here 0.0 }"}</strong> &copy; <span data-toggle="year-copy"></span>
                        </div>
                    </div>
                </div>
            </main>            
            )
    }
}