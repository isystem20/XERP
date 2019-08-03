import React, { Component } from 'react'
import axios from 'axios'
import LoadScript from '../../functions/load-scripts/LoadScript';
import { Link } from 'react-router-dom';

export class PasswordReminder extends Component {
    constructor(props) {
        super(props);

        this.state = {
            userNameOrEmail : "",
            sending : false
        }

    }

    componentDidMount() {
        //load required scripts for this page
        const scripts = ['validate', 'op_auth_reminder']
        LoadScript(scripts, document.body, false);
    }

    handleOnChange = (e) => {
        //console.log(this.state)
        this.setState({ [e.target.name]: e.target.value });
    }

    handleSendMail = (e) => {

        e.preventDefault();

        // Disable controls to prevent spammers
        this.setState({ 
            sending : true
        });  

        // Hold the current component
        let component = this;

        // Prepare postData
        let postData = {
            userNameOrEmail: this.state.userNameOrEmail
        }
        // Valid credential for test API email: "eve.holt@reqres.in", password: "cityslicka"

        // TODO : API to check the ff
        // - password was sent to mail; return 200
        // - username or email not exists; return -104
        // ------------------------
        // POST KEYS
        //      userNameOrEmail
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
            //console.log(response);
            component.setState({ 
                response : response,
                sending : false
            });   
        })
        .catch(function (error) {
            //console.log(error);
            component.setState({ sending : false });  
        });

    }

    render(){

        let spinner =   !this.state.sending 
                        ?   ""
                        :   <div className="col-md-6 col-xl-5" >
                                <div className="spinner-border text-primary" role="status">
                                    <span className="sr-only">Loading...</span>
                                </div>
                            </div> 
        return( 
            <main id="main-container">                            
                <div className="bg-image bg-image-signin">
                    <div className="hero-static bg-white-95">
                        <div className="content">
                            <div className="row justify-content-center">
                                <div className="col-md-8 col-lg-6 col-xl-4">
                                    
                                    <div className="block block-themed block-fx-shadow mb-0">
                                        <div className="block-header">
                                            <h3 className="block-title">Password Reminder</h3>
                                            <div className="block-options">                                            
                                                <Link className="btn-block-option" to="/signin" data-toggle="tooltip" data-placement="left" title="Sign In">
                                                    <i className="fa fa-sign-in-alt"></i>
                                                </Link>
                                            </div>
                                        </div>
                                        <div className="block-content">
                                            <div className="p-sm-3 px-lg-4 py-lg-5">
                                                <h1 className="mb-2">OneUI</h1>
                                                <p>Please provide your account’s email and we will send you your password.</p>    
                                                <div>   
                                                    <div className="form-group">
                                                        <input 
                                                            onChange={e => this.handleOnChange(e)}
                                                            type="text" 
                                                            className="form-control form-control-lg form-control-alt" 
                                                            name="userNameOrEmail" 
                                                            placeholder="Username or Email"
                                                            autoComplete="off"                              
                                                            disabled={this.state.sending}/>
                                                            <div className="invalid-feedback">{this.state.nameStateDesc}</div>  
                                                    </div>
                                                    <div className="form-group row">
                                                        <div className="col-md-6 col-xl-5">
                                                            <button 
                                                                onClick={e => this.handleSendMail(e)}
                                                                type="submit" 
                                                                className="btn btn-block btn-primary"
                                                                disabled={this.state.sending}>
                                                                <i className="fa fa-fw fa-envelope mr-1"></i> Send Mail
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
                            <strong>OneUI 4.2</strong> &copy; <span data-toggle="year-copy"></span>
                        </div>
                    </div>
                </div>
            </main>
        );
    }

}