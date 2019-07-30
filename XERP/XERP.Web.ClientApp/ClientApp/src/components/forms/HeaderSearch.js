import React, { Component } from 'react'

export class HeaderSearch extends Component {
    render() {
        return (
            <form className="d-none d-sm-inline-block" action="be_pages_generic_search.html" method="POST">
                <div className="input-group input-group-sm">
                    <input type="text" className="form-control form-control-alt" placeholder="Search.." id="page-header-search-input2" name="page-header-search-input2" />
                    <div className="input-group-append">
                        <span className="input-group-text bg-body border-0">
                            <i className="si si-magnifier"></i>
                        </span>
                    </div>
                </div>
            </form>

            )
    }
}