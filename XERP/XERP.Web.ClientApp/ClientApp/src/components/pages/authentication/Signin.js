import React, { Component } from 'react'
import axios from 'axios'
import LoadScript from '../../functions/load-scripts/LoadScript';
import { Link } from 'react-router-dom';

export class Signin extends Component {
    constructor(props) {
        super(props);

        this.state = {

            name : "",
            password : "",
            remember : false,
        
            nameStateDesc : "",
            passwordStateDesc : "",    

            validating : false
        }

    }

    componentDidMount() {
        //load required scripts for this page
        const scripts = ['validate', 'op_auth_signin']
        LoadScript(scripts, document.body, false);
    }

    handleOnChange = (e) => {
        this.setState({ [e.target.name]: e.target.value });
        console.log(this.state)
    }

    handleSubmit = (e) => {

        e.preventDefault();

        // Disable controls to prevent spammers
        this.setState({ 
            nameStateDesc : "",
            passwordStateDesc : "",    
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

        // TODO : API to check the ff
        // - username exists in company; return 101 if not exists
        // - username and password is correct; return 102 if password is incorrect
        // - user is not currently locked due to ff; return 103 if locked
        //      - failed login attempts
        // - return 200 if credential is valid
        // ------------------------
        // POST KEYS
        //      username, password
        // RESPONSE KEYS
        //      responseCode, responseMessage, token??
        // ------------------------
        // as of 20190729 by rmo
        axios({
            method: 'post',
            url: 'https://reqres.in/api/login',
            data: postData
        })
        .then(function (response) {
            console.log(response);
            component.setState({ 
                response : response,
                validating : false
            });   
            component.handleLoginData();
        })
        .catch(function (error) {
            console.log(error);
            component.setState({ validating : false });  
        });

    }

    handleLoginData() {
        let response = this.state.response;

        if (response != null && response.status == 200) {
            // Debug data 
            // let data = { responseCode:101, responseMessage:"Unknown username." };
            // let data = { responseCode:102, responseMessage:"The password you've entered is incorrect." };
            // let data = { responseCode:103, responseMessage:"Account is locked." };
            let data = { responseCode:200, responseMessage:"OK" };
            // Actual data
            // let data = response.data;
            if (data != null) {
                let responseCode = data.responseCode;
                let responseMessage = data.responseMessage;
                if (responseCode == 101) {
                    // responseCode == 101 is "Unknown username."
                    this.setState({ nameStateDesc:responseMessage });
                } else if (responseCode == 102) {
                    // responseCode == 102 is "The password you've entered is incorrect."
                    this.setState({ passwordStateDesc:responseMessage });
                } else if (responseCode == 103) {
                    // responseCode == 103 is "Account is locked."
                    this.setState({ nameStateDesc:responseMessage });
                } else if (responseCode == 200) {
                    this.props.history.push('/dashboard')
                }
                // console.log('Done handling reponse.data');
                // console.log(this.state);
            } else {
                // console.log('reponse.data is empty');
            }
        } else {
            // console.log('reponse.status is not 200');
        }
               
        this.setState({ validating : false });  
    }

    render() {
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
                                                                class={this.state.nameStateDesc === "" ? "form-control":"form-control form-control-alt is-invalid"} 
                                                                name="username" 
                                                                placeholder="Username"          
                                                                autocomplete="off"                              
                                                                disabled={this.state.validating}/>    
                                                            <div class="invalid-feedback">{this.state.nameStateDesc}</div>                                                     
                                                            
                                                        </div>
                                                        <div className="form-group">
                                                            <input 
                                                                onChange={e => this.handleOnChange(e)}
                                                                type="text" 
                                                                class={this.state.passwordStateDesc === "" ? "form-control":"form-control form-control-alt is-invalid"} 
                                                                name="password" 
                                                                placeholder="Password"                                                  
                                                                disabled={this.state.validating}/>   
                                                            <div class="invalid-feedback">{this.state.passwordStateDesc}</div>                                                           
                                                            
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