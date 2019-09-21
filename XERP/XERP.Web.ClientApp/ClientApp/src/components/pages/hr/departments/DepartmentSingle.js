import React, { Component } from 'react'
import axios from 'axios'
import LoadScript from '../../../functions/load-scripts/LoadScript';
import Notify from '../../../functions/Notify';
import { CircularLoading } from '../../../forms/CircularLoading';
import One from '../../../functions/One';
import Swal from 'sweetalert2';

export class DepartmentSingle extends Component {
    constructor(props) {
        super(props);

        this.state = {

            addRecord: this.props.match.params.id == null,      // True when view is for Add, otherwise user is Updating.
            isSaving: false,                                    // True when user clicks on Submit, otherwise False.

            id: this.props.match.params.id,
            loading: true,                                      // True when data is being requested.
            data: [],                                           // Holds the masterlist record.

            deptid: null,
            code: "",
            name: "",
            companyid: "25708efb-6ff3-46bc-ad26-b0879d6650a5",
            description: "",
            createdbyid: "25708efb-6ff3-46bc-ad26-b0879d6650a5",
            lastmodifiedbyid: "25708efb-6ff3-46bc-ad26-b0879d6650a5",

        }

        this.fetchData = this.fetchData.bind(this);
        console.log(this.state)

    }

    //Will load after render.
    componentWillMount() {

        //load notification script
        LoadScript(['notification', 'notificationhelper'], document.body, false);

        //add page-loader div
        One.AddPageLoader(document.body);

        this.fetchData();
    }


    fetchData() {

        if (this.state.id) {
            //set the current component (Department) into variable
            let component = this;

            axios({
                method: 'get', //get to fetch the data
                url: 'http://dummy.restapiexample.com/api/v1/employee/' + this.state.id,
            }).then(function (response) {
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

        One.Loader('show');

        let component = this;
        this.setState({ isSaving: true });

        const { id, code, name, description } = this.state;
        let postData = {
            id: id,
            name: name,
            age: code,
            salary: description
        };

        axios({
            method: 'post',
            url: 'http://dummy.restapiexample.com/api/v1/create',
            data: postData
        }).then(function (response) {
            //console.log(response);
            //Notify('hi', 'success');
            One.Loader('hide');
            Swal.fire('Department added!', '', 'success')
            component.setState({ isSaving: false });
        }).catch(function (error) {
            //console.log(error);
            One.Loader('hide');
            Swal.fire('Department not saved!', '', 'error')
            component.setState({ isSaving: false });
        });
    }

    renderHeader() {
        let isSaving = this.state.isSaving;
        if (this.state.addRecord) {
            return (
                <div className="block-header block-header-default">
                    <h3 className="block-title">Add new department</h3>
                    <div className="block-options">
                        <button
                            onClick={e => this.handleSubmit(e)}
                            type="submit"
                            className="btn btn-success btn-sm btn-primary"
                            data-toggle="click-ripple"
                            disabled={isSaving}>
                            Submit
                        </button>
                        <button
                            onClick={() => this.handleReset()}
                            type="reset"
                            className="btn btn-warning btn-sm btn-secondary"
                            data-toggle="click-ripple"
                            disabled={isSaving}>
                            Reset
                        </button>
                    </div>
                </div>);
        } else {
            return (
                <div className="block-header block-header-default">
                    <h3 className="block-title">Update department</h3>
                    <div className="block-options">
                        <CircularLoading className="float-right" show={isSaving} />
                        <button
                            onClick={e => this.handleSubmit(e)}
                            type="submit"
                            className="btn btn-success btn-sm btn-primary"
                            data-toggle="click-ripple">
                            Update
                        </button>
                    </div>
                </div>);
        }
    }

    renderCreationFields() {
        return (
            <div class="form-group form-row">
                <div class="col-4">
                    <label>Created By</label>
                    <input
                        disabled="true"
                        type="text"
                        className="form-control" />
                </div>
                <div class="col-4">
                    <label>Created On</label>
                    <input
                        disabled="true"
                        type="text"
                        className="form-control" />
                </div>
            </div>
        );
    }

    render() {
        let isAdding = this.state.addRecord;
        let isSaving = this.state.isSaving;
        return (
            <main id="main-container">                   
                <div className="bg-body-light">
                    <div className="content content-full">
                        <div className="d-flex flex-column flex-sm-row justify-content-sm-between align-items-sm-center">
                            <h1 className="flex-sm-fill h3 my-2">
                                Departments <br/><small className="d-block d-sm-inline-block mt-2 mt-sm-0 font-size-base font-w400 text-muted">Add or modify department information.</small>
                            </h1>
                            <nav className="flex-sm-00-auto ml-sm-3" aria-label="breadcrumb">
                                <ol className="breadcrumb breadcrumb-alt">
                                    <li className="breadcrumb-item">Maintenance</li>
                                    <li className="breadcrumb-item" aria-current="page">
                                        <a className="link-fx" href="">Departments</a>
                                    </li>
                                </ol>
                            </nav>
                        </div>
                    </div>
                </div>

                <div className="content">
                    <div class="block">
                        {this.renderHeader()}
                        <div class="block-content block-content-full">
                            <div class="row push">
                                <div class="col-lg-10">
                                    <div>
                                        <div class="form-group form-row">
                                            <div class="col-4">
                                                <label>Code</label>
                                                <input
                                                    name="code"
                                                    onChange={e => this.handleOnChange(e)}
                                                    value={this.state.code}
                                                    disabled={!isAdding || isSaving}
                                                    type="text"
                                                    className="form-control"
                                                    autoComplete="false"
                                                    autoCorrect="false"/>
                                            </div>
                                        </div>
                                        <div class="form-group form-row">
                                            <div class="col-10">
                                                <label>Name</label>
                                                <input
                                                    name="name"
                                                    onChange={e => this.handleOnChange(e)}
                                                    value={this.state.name}
                                                    disabled={isSaving}
                                                    type="text"
                                                    className="form-control"
                                                    autoComplete="false"
                                                    autoCorrect="false" />
                                            </div>
                                        </div>
                                        <div class="form-group form-row">
                                            <div class="col-10">
                                                <label>Description</label>
                                                <textarea
                                                    name="description"
                                                    onChange={e => this.handleOnChange(e)}
                                                    value={this.state.description}
                                                    disabled={isSaving}
                                                    className="form-control"
                                                    rows="3"
                                                    autoComplete="false"
                                                    autoCorrect="false"/>
                                            </div>
                                        </div>
                                        {isAdding ? null : this.renderCreationFields()}
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