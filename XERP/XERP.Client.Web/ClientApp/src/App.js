import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { HRDashboard } from './pages/hr/HRDashboard';
import { Departments } from './pages/hr/Departments';

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
        <Layout>
            <Route exact path='/' component={HRDashboard} />
            <Route path='/hr/departments' component={Departments} />
        <Route path='/fetch-data' component={FetchData} />
      </Layout>
    );
  }
}
