import React, { Component } from 'react'
import LoadScript from '../../functions/load-scripts/LoadScript';
import { Link } from 'react-router-dom';
import AxiosRequest from '../../functions/axios/AxiosRequest';
import axios from 'axios';

export class Signin extends Component {
    constructor(props) {
        super(props);

        this.state = {

            name : "",
            password : "",
            remember : false,
        
            response: null,
            success: false,
            result: "",  
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
            response : null,
            validating : true 
        });  

        // Hold the current component
        let component = this;

        // Prepare postData
        const { username, password } = this.state
        let postData = {
            username: username,        // Change email key in future 
            password: password
        }
        // axios('post', 'http://localhost:5000/api/auth/login', postData)
        axios({ method: 'post', url: 'http://localhost:5000/api/auth/login', data: postData })
        .then(function (response) {
            //console.log(response);
            component.handleLoginData(response);
        })
        .catch(function (error) {
            //console.log(error.response);
            component.handleLoginData(error.response);
        });

    }

    handleLoginData(response) {
        if (response != null) {
            let data = response.data;
            if (response.status == 200 && data.success) {
                this.setState({ success: data.success, result: data.result });
                this.props.history.push('/dashboard');
                localStorage.setItem('token', data.token);
                localStorage.setItem('username', this.state.username);
                localStorage.setItem('password', this.state.password);
            } else if (response.status == 401 && !data.success) {
                this.setState({ success: data.success, result: data.result });
            } else {
                this.setState({ success: false, result: "Cannot be validated. Please try again." });
            }
        } else {
            this.setState({ success: false, result: "Cannot be validated. Please try again." });
        }
        this.setState({ validating: false, response: response });    
    }

    resultInfo() {
        let result = this.state.result;
        let success = this.state.success;
        return (
            <div className={(success ? "alert alert-success" : "alert alert-warning") + " d-flex align-items-center justify-content-between"} role="alert">
                <div className="flex-fill mr-3">
                    <p className="mb-0">{result}</p>
                </div>
                <div className="flex-00-auto">
                    <i className={(success ? "fa fa-fw fa-check" : "fa fa-fw fa-exclamation-circle")}></i>
                </div>
            </div>);
    }

    render() {
        let spinner =   !this.state.validating 
                        ?   ""
                        :   <div className="col-md-6 col-xl-5" >
                                <div className="spinner-border text-primary" role="status">
                                    <span className="sr-only">Loading...</span>
                                </div>
                            </div>;
        let result = this.state.response == null ? "" : this.resultInfo()
                
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
                                                <center><h1 className="mb-2">{"Sign in"}</h1></center>
                                                <center><p>to continue to XERP</p></center>
                                                <div>
                                                    <div className="py-3">   
                                                        <div className="form-group">
                                                            <input 
                                                                onChange={e => this.handleOnChange(e)}
                                                                type="text"
                                                                className="form-control"
                                                                name="username" 
                                                                placeholder="Username"                          
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
                                                    </div>  
                                                    { result }
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