import React, { Component } from 'react';
import { Route } from 'react-router';
import { Switch } from 'react-router-dom';
import { Layout } from './components/Layout';
import { Dashboard } from './components/pages/dashboard/Dashboard';
import { Departments } from './components/pages/hr/departments/Department';
import { DepartmentSingle } from './components/pages/hr/departments/DepartmentSingle';
import { Signin } from './components/pages/authentication/Signin';
import { PasswordReminder } from './components/pages/authentication/PasswordReminder';

export default class App extends Component {
    static displayName = App.name;

    render () {
      return (
            <div>
                <Switch>

                    <Route exact path='/' component={Signin} />
                    <Route exact path='/signin' component={Signin} />
                    <Route exact path='/passwordReminder' component={PasswordReminder} />

                    <Layout>
                        <Route exact path='/dashboard' component={Dashboard} />
                        <Route exact path='/departments' component={Departments} />
                        <Route exact path='/department/:id' component={DepartmentSingle} />
                    </Layout>


                </Switch>
            </div>

    );
  }
}
