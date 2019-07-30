import React, { Component } from 'react';
import { Route } from 'react-router';
import { Switch } from 'react-router-dom';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { Dashboard } from './components/pages/dashboard/Dashboard';
import { Departments } from './components/pages/hr/departments/Department';
import { DepartmentSingle } from './components/pages/hr/departments/DepartmentSingle';

export default class App extends Component {
  static displayName = App.name;



  render () {
      return (
          <div>
              <Switch>
                  
                  <Layout>

                      <Route path='/dashboard' component={Dashboard} />
                      <Route exact path='/' component={Dashboard} />
                      <Route exact path='/departments' component={Departments} />
                      <Route exact path='/departments/:id' component={DepartmentSingle} />
                  </Layout>


              </Switch>
          </div>

    );
  }
}
