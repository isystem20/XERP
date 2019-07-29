import React, { Component } from 'react'
import LoadScript from '../../../functions/load-scripts/LoadScript';
import LoadStyle from '../../../functions/load-scripts/LoadStyle';
import axios from 'axios'

export class Departments extends Component {
    constructor(props) {
        super(props);

        this.state = {
            loading : true,
            data : []
        }

        this.fetchData = this.fetchData.bind(this);

    }

    //Will load after render.
    componentWillMount() {

        //Load required style for this page
        LoadStyle(['datatablebs', 'datatablebuttons'], document.head, false);
        this.fetchData();

    }

    componentDidMount() {
        //load required scripts for this page
        const scripts = ['datatable', 'datatablebs', 'datatablebuttons', 'datatableprint', 'datatablehtml5', 'datatableflash', 'datatablecolvis','datatablepage']
        LoadScript(scripts, document.body, false);
    }

    fetchData() {

        //set the current component (Department) into variable
        let component = this;

        axios({
            method: 'get', //get to fetch the data
            url: 'http://dummy.restapiexample.com/api/v1/employees',
        })
            .then(function (response) {

                component.setState({
                    data: response.data,
                    loading: false
                });

            });

    }

    renderData(objectData) {
        return (

            objectData.map(data =>

                <tr key={data.id}>
                    <td className="text-center font-size-sm">{data.id}</td>
                    <td className="font-w600 font-size-sm">{data.employee_name}</td>
                    <td className="d-none d-sm-table-cell font-size-sm">
                    {data.employee_salary}<em className="text-muted">@example.com</em>
                    </td>
                    <td className="d-none d-sm-table-cell">
                    <span className="badge badge-primary">{data.employee_age}</span>
                    </td>
                    <td>
                    <em className="text-muted font-size-sm">{data.profile_image}</em>
                    </td>
                </tr>

            )

        )
    }



    render() {

        let contents = this.state.loading
            ? <tr id="-1"><td colSpan="5"><center>Nothing to display</center></td></tr>
            :
            this.renderData(this.state.data);


        return (
            <main id="main-container">


                <div className="bg-body-light">
                    <div className="content content-full">
                        <div className="d-flex flex-column flex-sm-row justify-content-sm-between align-items-sm-center">
                            <h1 className="flex-sm-fill h3 my-2">
                                Departments <small className="d-block d-sm-inline-block mt-2 mt-sm-0 font-size-base font-w400 text-muted">Tables transformed with dynamic features.</small>
                            </h1>
                            <nav className="flex-sm-00-auto ml-sm-3" aria-label="breadcrumb">
                                <ol className="breadcrumb breadcrumb-alt">
                                    <li className="breadcrumb-item">Tables</li>
                                    <li className="breadcrumb-item" aria-current="page">
                                        <a className="link-fx" href="">DataTables</a>
                                    </li>
                                </ol>
                            </nav>
                        </div>
                    </div>
                </div>



                <div className="content">

                    <div className="block">
                        <div className="block-header">
                            <h3 className="block-title">Dynamic Table <small>Full pagination</small></h3>
                        </div>
                        <div className="block-content block-content-full">

                            <table className="table table-bordered table-striped table-vcenter js-dataTable-full-pagination">
                                <thead>
                                    <tr>
                                        <th className="text-center w80">ID</th>
                                        <th>Name</th>
                                        <th className="d-none d-sm-table-cell w30p">Description</th>
                                        <th className="d-none d-sm-table-cell w15p">Last Modified</th>
                                        <th className="w15p">Status</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    {contents}
                                </tbody>
                            </table>
                        </div>
                    </div>


                </div>


            </main>
            
            )
    }
}