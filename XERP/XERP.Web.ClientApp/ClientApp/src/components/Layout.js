import React, { Component } from 'react';
import { RightBar } from './rightbar/RightBar';
import { LeftBar } from './leftbar/LeftBar';
import { Header } from './header/Header';
import { Footer } from './footer/Footer';
import { ModalAppList } from './modals/ModalAppList';

//no Braces = namespace, function
//with braces = component(class)

export class Layout extends Component {
  static displayName = Layout.name;


  //predefined function being used by React to render or display to the browser.
  render () {
    return (

        <div id="page-container" className="sidebar-o sidebar-dark enable-page-overlay side-scroll page-header-fixed">

            <RightBar />

            <LeftBar />

            <Header />

            {this.props.children}

            <Footer />

            <ModalAppList />
            
        </div>


    );
  }
}
