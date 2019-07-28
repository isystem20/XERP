import React, { Component } from 'react'
import { UserMenu } from './UserMenu'
import { UserNotification } from './UserNotification'

export class UserHeader extends Component {
    render() {
        return (
            <div className="d-flex align-items-center">


                <UserMenu />


                <UserNotification />



                <button type="button" className="btn btn-sm btn-dual ml-2" data-toggle="layout" data-action="side_overlay_toggle">
                    <i className="fa fa-fw fa-list-ul fa-flip-horizontal"></i>
                </button>

            </div>


            )
    }
}