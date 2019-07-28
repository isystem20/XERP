import React, { Component } from 'react'
import { HeaderSearch } from '../../forms/HeaderSearch'
import { UserHeader } from './user-header/UserHeader'

export class ContentHeader extends Component {
    render() {
        return (
            <div className="content-header">

                <div className="d-flex align-items-center">
                    <button type="button" className="btn btn-sm btn-dual mr-2 d-lg-none" data-toggle="layout" data-action="sidebar_toggle">
                        <i className="fa fa-fw fa-bars"></i>
                    </button>

                    <button type="button" className="btn btn-sm btn-dual mr-2 d-none d-lg-inline-block" data-toggle="layout" data-action="sidebar_mini_toggle">
                        <i className="fa fa-fw fa-ellipsis-v"></i>
                    </button>

                    <button type="button" className="btn btn-sm btn-dual mr-2" data-toggle="modal" data-target="#one-modal-apps">
                        <i className="si si-grid"></i>
                    </button>

                    <button type="button" className="btn btn-sm btn-dual d-sm-none" data-toggle="layout" data-action="header_search_on">
                        <i className="si si-magnifier"></i>
                    </button>

                    <HeaderSearch />

                </div>

                <UserHeader />

            </div>
            )
    }
}
