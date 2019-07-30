import React, { Component } from 'react'
import { ContentHeader } from './content-header/ContentHeader'

export class Header extends Component {
    render() {
        return (
            <header id="page-header">


                <ContentHeader />


                <div id="page-header-search" className="overlay-header bg-white">
                    <div className="content-header">
                        <form className="w-100" action="be_pages_generic_search.html" method="POST">
                            <div className="input-group input-group-sm">
                                <div className="input-group-prepend">

                                    <button type="button" className="btn btn-danger" data-toggle="layout" data-action="header_search_off">
                                        <i className="fa fa-fw fa-times-circle"></i>
                                    </button>
                                </div>
                                <input type="text" className="form-control" placeholder="Search or hit ESC.." id="page-header-search-input" name="page-header-search-input" />
                            </div>
                        </form>
                    </div>
                </div>




                <div id="page-header-loader" className="overlay-header bg-white">
                    <div className="content-header">
                        <div className="w-100 text-center">
                            <i className="fa fa-fw fa-circle-notch fa-spin"></i>
                        </div>
                    </div>
                </div>

            </header>
        )
    }
}