import React, { Component } from 'react'
import axios from 'axios'
import LoadScript from '../../functions/load-scripts/LoadScript';
import { Link } from 'react-router-dom';

export class PasswordReminder extends Component {
    constructor(props) {
        super(props);

        this.state = {
            email : ""
        }

    }

    componentDidMount() {
        //load required scripts for this page
        const scripts = ['validate', 'op_auth_reminder']
        LoadScript(scripts, document.body, false);
    }

    render(){
        return(
            <main id="main-container">                            
                <div class="bg-image bg-image-signin">
                    <div class="hero-static bg-white-95">
                        <div class="content">
                            <div class="row justify-content-center">
                                <div class="col-md-8 col-lg-6 col-xl-4">
                                    
                                    <div class="block block-themed block-fx-shadow mb-0">
                                        <div class="block-header">
                                            <h3 class="block-title">Password Reminder</h3>
                                            <div class="block-options">                                            
                                                <Link class="btn-block-option" to="/signin" data-toggle="tooltip" data-placement="left" title="Sign In">
                                                    <i class="fa fa-sign-in-alt"></i>
                                                </Link>
                                            </div>
                                        </div>
                                        <div class="block-content">
                                            <div class="p-sm-3 px-lg-4 py-lg-5">
                                                <h1 class="mb-2">OneUI</h1>
                                                <p>Please provide your account’s email and we will send you your password.</p>                                               
                                                <form class="js-validation-reminder" action="be_pages_auth_all.html" method="POST">
                                                    <div class="form-group py-3">
                                                        <input 
                                                            type="text" 
                                                            class="form-control form-control-lg form-control-alt" 
                                                            id="reminder-credential" 
                                                            name="reminder-credential" 
                                                            placeholder="Username or Email"/>
                                                    </div>
                                                    <div class="form-group row">
                                                        <div class="col-md-6 col-xl-5">
                                                            <button type="submit" class="btn btn-block btn-primary">
                                                                <i class="fa fa-fw fa-envelope mr-1"></i> Send Mail
                                                            </button>
                                                        </div>
                                                    </div>
                                                </form>
                                                
                                            </div>
                                        </div>
                                    </div>
                                    
                                </div>
                            </div>
                        </div>
                        <div class="content content-full font-size-sm text-muted text-center">
                            <strong>OneUI 4.2</strong> &copy; <span data-toggle="year-copy"></span>
                        </div>
                    </div>
                </div>


                </main>
        );
    }

}