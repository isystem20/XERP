import React, { Component } from 'react'

export class UserNotification extends Component {
    render() {
        return (

                <div className="dropdown d-inline-block ml-2">
                    <button type="button" className="btn btn-sm btn-dual" id="page-header-notifications-dropdown" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        <i className="si si-bell"></i>
                        <span className="badge badge-primary badge-pill">6</span>
                    </button>
                    <div className="dropdown-menu dropdown-menu-lg dropdown-menu-right p-0 border-0 font-size-sm" aria-labelledby="page-header-notifications-dropdown">
                        <div className="p-2 bg-primary text-center">
                            <h5 className="dropdown-header text-uppercase text-white">Notifications</h5>
                        </div>
                        <ul className="nav-items mb-0">
                            <li>
                                <a className="text-dark media py-2" href="javascript:void(0)">
                                    <div className="mr-2 ml-3">
                                        <i className="fa fa-fw fa-check-circle text-success"></i>
                                    </div>
                                    <div className="media-body pr-2">
                                        <div className="font-w600">You have a new follower</div>
                                        <small className="text-muted">15 min ago</small>
                                    </div>
                                </a>
                            </li>
                            <li>
                                <a className="text-dark media py-2" href="javascript:void(0)">
                                    <div className="mr-2 ml-3">
                                        <i className="fa fa-fw fa-plus-circle text-info"></i>
                                    </div>
                                    <div className="media-body pr-2">
                                        <div className="font-w600">1 new sale, keep it up</div>
                                        <small className="text-muted">22 min ago</small>
                                    </div>
                                </a>
                            </li>
                            <li>
                                <a className="text-dark media py-2" href="javascript:void(0)">
                                    <div className="mr-2 ml-3">
                                        <i className="fa fa-fw fa-times-circle text-danger"></i>
                                    </div>
                                    <div className="media-body pr-2">
                                        <div className="font-w600">Update failed, restart server</div>
                                        <small className="text-muted">26 min ago</small>
                                    </div>
                                </a>
                            </li>
                            <li>
                                <a className="text-dark media py-2" href="javascript:void(0)">
                                    <div className="mr-2 ml-3">
                                        <i className="fa fa-fw fa-plus-circle text-info"></i>
                                    </div>
                                    <div className="media-body pr-2">
                                        <div className="font-w600">2 new sales, keep it up</div>
                                        <small className="text-muted">33 min ago</small>
                                    </div>
                                </a>
                            </li>
                            <li>
                                <a className="text-dark media py-2" href="javascript:void(0)">
                                    <div className="mr-2 ml-3">
                                        <i className="fa fa-fw fa-user-plus text-success"></i>
                                    </div>
                                    <div className="media-body pr-2">
                                        <div className="font-w600">You have a new subscriber</div>
                                        <small className="text-muted">41 min ago</small>
                                    </div>
                                </a>
                            </li>
                            <li>
                                <a className="text-dark media py-2" href="javascript:void(0)">
                                    <div className="mr-2 ml-3">
                                        <i className="fa fa-fw fa-check-circle text-success"></i>
                                    </div>
                                    <div className="media-body pr-2">
                                        <div className="font-w600">You have a new follower</div>
                                        <small className="text-muted">42 min ago</small>
                                    </div>
                                </a>
                            </li>
                        </ul>
                        <div className="p-2 border-top">
                            <a className="btn btn-sm btn-light btn-block text-center" href="javascript:void(0)">
                                <i className="fa fa-fw fa-arrow-down mr-1"></i> Load More..
                                    </a>
                        </div>
                    </div>
                </div>


            )
    }
}