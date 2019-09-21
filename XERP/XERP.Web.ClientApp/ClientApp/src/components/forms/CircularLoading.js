import React, { Component } from 'react'

export class CircularLoading extends Component {
    render() {
        return !this.props.show ? null :
            <div className="spinner-border text-primary vertical-center" role="status">
                <span className="sr-only">Loading...</span>
            </div>;
    }
}
