import React, { Component } from 'react'
import axios from 'axios'
import LoadScript from '../../../functions/load-scripts/LoadScript';
import Notify from '../../../functions/Notify';

export class DepartmentSingle extends Component {
    constructor(props) {
        super(props);

        this.state = {
            id: this.props.match.params.id,
            loading: true,
            data: [],
            deptid: null,
            code: "",
            name: "",
            companyid: "25708efb-6ff3-46bc-ad26-b0879d6650a5",
            description: "",
            createdbyid: "25708efb-6ff3-46bc-ad26-b0879d6650a5",
            lastmodifiedbyid: "25708efb-6ff3-46bc-ad26-b0879d6650a5",
        }

        this.fetchData = this.fetchData.bind(this);

    }

    //Will load after render.
    componentWillMount() {

        //load notification script
        LoadScript(['notification','notificationhelper'], document.body, false);

        this.fetchData();
    }


    fetchData() {

        if (this.state.id) {
            //set the current component (Department) into variable
            let component = this;

            axios({
                method: 'get', //get to fetch the data
                url: 'http://dummy.restapiexample.com/api/v1/employee/' + this.state.id,
            })
                .then(function (response) {

                    component.setState({
                        data: response.data, // new Promise ..
                        loading: false
                    });

                });
        }

    }

    handleOnChange = (e) => {
        this.setState({ [e.target.name]: e.target.value });
        console.log(this.state)

    }

    handleReset = () => {
        this.setState({ code: "", name: "", description: "" })
    }

    handleSubmit = (e) => {

        e.preventDefault();

        const { code, name, description } = this.state

        let postData = {
            name: name,
            age: code,
            salary: description
        }

        //Use axios as http post
        axios({
            method: 'post',
            url: 'http://dummy.restapiexample.com/api/v1/create',
            data: postData
        })
            .then(function (response) {

                Notify('hi','success');
                console.log(response);

            });
    }



    render() {

        //let data = this.state.loading ? ;

        return (
            <main id="main-container">

    
                <div className="bg-body-light">
                    <div className="content content-full">
                        <div className="d-flex flex-column flex-sm-row justify-content-sm-between align-items-sm-center">
                            <h1 className="flex-sm-fill h3 my-2">
                                Block Forms <small className="d-block d-sm-inline-block mt-2 mt-sm-0 font-size-base font-w400 text-muted">Easily integrated in your blocks.</small>
                            </h1>
                            <nav className="flex-sm-00-auto ml-sm-3" aria-label="breadcrumb">
                                <ol className="breadcrumb breadcrumb-alt">
                                    <li className="breadcrumb-item">Blocks</li>
                                    <li className="breadcrumb-item" aria-current="page">
                                        <a className="link-fx" href="">Forms</a>
                                    </li>
                                </ol>
                            </nav>
                        </div>
                    </div>
                </div>
    
                <div className="content">
        
                    <div className="row">
                        <div className="col-md-12">
                                <div className="block">
                                    <div className="block-header block-header-default">
                                        <h3 className="block-title">Block Form</h3>
                                    <div className="block-options">
                                            <button onClick={e => this.handleSubmit(e)} type="submit" className="btn btn-sm btn-primary">
                                                Submit
                                            </button>
                                            <button onClick={() => this.handleReset()} type="reset" className="btn btn-sm btn-secondary">
                                                Reset
                                            </button>
                                        </div>
                                    </div>
                                    <div className="block-content">
                                        <div className="row justify-content-center py-sm-3 py-md-5">
                                            <div className="col-sm-10 col-md-8">
                                                <div className="form-group">
                                                    <label for="block-form1-username">Code</label>
                                                    <input type="text"
                                                        onChange={e => this.handleOnChange(e)}
                                                        className="form-control"
                                                        name="code"
                                                        value={this.state.code}
                                                        placeholder="Please input unique code" />
                                                </div>
                                                <div className="form-group">
                                                    <label for="block-form1-password">Name</label>
                                                    <input type="text"
                                                        onChange={e => this.handleOnChange(e)}
                                                        className="form-control"
                                                        name="name"
                                                        value={this.state.name}
                                                        placeholder="Please enter record name" />
                                                </div>
                                                <div className="form-group">
                                                    <label for="block-form1-password">Description</label>
                                                    <textarea
                                                        className="form-control"
                                                        onChange={e => this.handleOnChange(e)}
                                                        name="description" rows="4"
                                                        value={this.state.description}
                                                        placeholder="Short description for this record"></textarea>
                                                </div>


                                                <div className="form-group">
                                                    <div className="custom-control custom-checkbox custom-control-primary">
                                                        <input type="checkbox" className="custom-control-input" id="block-form1-remember-me" name="block-form1-remember-me" />
                                                        <label className="custom-control-label" for="block-form1-remember-me">Remember Me?</label>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                        </div>
                    </div>
        
                </div>
   

            </main>            
            
            )
    }
}