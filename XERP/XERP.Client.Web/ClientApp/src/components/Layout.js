import React, { Component } from 'react';
import { Container } from 'reactstrap';
import { NavMenu } from './NavMenu';
import { RightBar } from '../layoutParts/RightBar';
import { LeftBar } from '../layoutParts/LeftBar';
import { Header } from '../layoutParts/Header';
import { Footer } from '../layoutParts/Footer';
import { AppModal } from '../layoutParts/AppModal';


export class Layout extends Component {
  static displayName = Layout.name;

  render () {
    return (
        <div id="page-container" class="sidebar-o sidebar-dark enable-page-overlay side-scroll page-header-fixed">
            <RightBar />
            <LeftBar />
            <Header />

            <Container>
                {this.props.children}
            </Container>

            <Footer />

            <AppModal />
      </div>
    );
  }
}
