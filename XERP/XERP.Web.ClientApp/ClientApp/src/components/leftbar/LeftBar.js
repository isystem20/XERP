import React, { Component } from 'react'
import NavigationMenu from './navigationMenu/NavigationMenu';

export class LeftBar extends Component {

    renderUserModules() {

        return 
        (
            <li className="nav-main-item">
                <a className="nav-main-link nav-main-link-submenu" data-toggle="submenu" aria-haspopup="true" aria-expanded="false" href="#">
                    <i className="nav-main-link-icon si si-energy"></i>
                    <span className="nav-main-link-name">Blocks</span>
                </a>
                <ul className="nav-main-submenu">
                    <li className="nav-main-item">
                        <a className="nav-main-link" href="be_blocks_styles.html">
                            <span className="nav-main-link-name">Styles</span>
                        </a>
                    </li>
                </ul>
            </li>
        );
    }
    render() {
        return (
            <nav id="sidebar" aria-label="Main Navigation">

                <div className="content-header bg-white-5">

                    <a className="font-w600 text-dual" href="index.html">
                        <i className="fa fa-circle-notch text-primary"></i>
                        <span className="smini-hide">
                            <span className="font-w700 font-size-h5">ne</span> <span className="font-w400">4.2</span>
                        </span>
                    </a>



                    <div>

                        <div className="dropdown d-inline-block ml-3">
                            <a className="text-dual font-size-sm" id="sidebar-themes-dropdown" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false" href="#">
                                <i className="si si-drop"></i>
                            </a>
                            <div className="dropdown-menu dropdown-menu-right font-size-sm smini-hide border-0" aria-labelledby="sidebar-themes-dropdown">


                                <a className="dropdown-item d-flex align-items-center justify-content-between" data-toggle="theme" data-theme="default" href="#">
                                    <span>Default</span>
                                    <i className="fa fa-circle text-default"></i>
                                </a>
                                <a className="dropdown-item d-flex align-items-center justify-content-between" data-toggle="theme" data-theme="assets/css/themes/amethyst.min.css" href="#">
                                    <span>Amethyst</span>
                                    <i className="fa fa-circle text-amethyst"></i>
                                </a>
                                <a className="dropdown-item d-flex align-items-center justify-content-between" data-toggle="theme" data-theme="assets/css/themes/city.min.css" href="#">
                                    <span>City</span>
                                    <i className="fa fa-circle text-city"></i>
                                </a>
                                <a className="dropdown-item d-flex align-items-center justify-content-between" data-toggle="theme" data-theme="assets/css/themes/flat.min.css" href="#">
                                    <span>Flat</span>
                                    <i className="fa fa-circle text-flat"></i>
                                </a>
                                <a className="dropdown-item d-flex align-items-center justify-content-between" data-toggle="theme" data-theme="assets/css/themes/modern.min.css" href="#">
                                    <span>Modern</span>
                                    <i className="fa fa-circle text-modern"></i>
                                </a>
                                <a className="dropdown-item d-flex align-items-center justify-content-between" data-toggle="theme" data-theme="assets/css/themes/smooth.min.css" href="#">
                                    <span>Smooth</span>
                                    <i className="fa fa-circle text-smooth"></i>
                                </a>


                                <div className="dropdown-divider"></div>



                                <a className="dropdown-item" data-toggle="layout" data-action="sidebar_style_light" href="#">
                                    <span>Sidebar Light</span>
                                </a>
                                <a className="dropdown-item" data-toggle="layout" data-action="sidebar_style_dark" href="#">
                                    <span>Sidebar Dark</span>
                                </a>


                                <div className="dropdown-divider"></div>



                                <a className="dropdown-item" data-toggle="layout" data-action="header_style_light" href="#">
                                    <span>Header Light</span>
                                </a>
                                <a className="dropdown-item" data-toggle="layout" data-action="header_style_dark" href="#">
                                    <span>Header Dark</span>
                                </a>

                            </div>
                        </div>




                        <a className="d-lg-none text-dual ml-3" data-toggle="layout" data-action="sidebar_close" href="javascript:void(0)">
                            <i className="fa fa-times"></i>
                        </a>

                    </div>

                </div>


                <div className="content-side content-side-full">

                    <NavigationMenu />

                </div>
            </nav> 
            )
    }
}