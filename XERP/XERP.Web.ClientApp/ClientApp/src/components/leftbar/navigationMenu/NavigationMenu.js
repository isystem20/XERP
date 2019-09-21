import React, { Component } from 'react';
import { Link } from 'react-router-dom';

const MenuList = props => {

    const _menus = props.menus;
    const menus = props.menus.map((menu) => {
        let _menu = _menus.filter(x => (x.Id == menu.Id));
        if (_menu.length > 0) {
            return (GetChildMenu(menu, 0));
        }
    })

    function GetItem(menu, _childMenus = null) {
        if (_childMenus!=null && _childMenus.length > 0) {
            return (
                <li className="nav-main-item" key={menu.Id}>
                    <Link className="nav-main-link nav-main-link-submenu" data-toggle="submenu" aria-haspopup="true" aria-expanded="false" to={menu.Controller!=null ? menu.Controller : ""}>
                        {menu.Icon == null ? "" : <i className={"nav-main-link-icon fa fa-" + menu.Icon}></i>}
                        <span className="nav-main-link-name">{menu.Name}</span>
                    </Link>
                    <ul className="nav-main-submenu">
                        {_childMenus}
                    </ul> 
                </li>
            );
        } else {
            return (
                <li className="nav-main-item">
                    <Link className="nav-main-link" to={menu.Controller != null ? menu.Controller : ""}>
                        {menu.Icon == null ? "" : <i className={"nav-main-link-icon fa fa-" + menu.Icon}></i>}
                        <span className="nav-main-link-name">{menu.Name}</span>
                    </Link>
                </li>
            );
        }
    }

    function GetHeader(menu) {
        return (
            <li className="nav-main-heading">{menu.Name}</li>
        );
    }

    function GetChildMenu(menu, level) {
        let isHeader = level == 0;  
        let childMenus = _menus.filter(x => (x.ParentId == menu.Id));   // Filter all sub items
        if (childMenus.length > 0) {
            // Create child items
            const _childMenus = childMenus.map((cm) => {
                _menus.splice(_menus.indexOf(cm), 1);
                return (
                    GetChildMenu(cm, level + 1)
                );
            })
            // If header attach Header item before childs
            return isHeader ?  [GetHeader(menu), _childMenus] : GetItem(menu, _childMenus);            
        } else {
            return isHeader ? GetHeader(menu) : GetItem(menu);
        }
    }

    return (
        <ul className="nav-main">
            <li className="nav-main-item">
                <a className="nav-main-link active">
                    <i className="nav-main-link-icon si si-speedometer"></i>
                    <span className="nav-main-link-name">Dashboard</span>
                </a>
            </li>
            {menus}
        </ul>
    );
}

class NavigationMenu extends Component {

    render() {
        const menus = [
            { Id: "Menu-1", Name: "Management", Controller: "", ParentId: "", Order: "" },

            { Id: "SubMenu-1-1", Name: "Employees", Controller: "", ParentId: "Menu-1", Order: "", Icon: "users" },
            { Id: "SubMenu-1-1-1", Name: "Positions", Controller: "", ParentId: "SubMenu-1-1", Order: "" },
            { Id: "SubMenu-1-1-2", Name: "Rank", Controller: "", ParentId: "SubMenu-1-1", Order: "" },
            { Id: "SubMenu-1-1-3", Name: "Type", Controller: "", ParentId: "SubMenu-1-1", Order: "" },

            { Id: "SubMenu-1-2", Name: "Companies", Controller: "", ParentId: "Menu-1", Order: "", Icon: "building" },
            { Id: "SubMenu-1-2-1", Name: "Sites", Controller: "/passwordReminder", ParentId: "SubMenu-1-2", Order: "" },
            { Id: "SubMenu-1-2-2", Name: "Cost Centers", Controller: "/signin", ParentId: "SubMenu-1-2", Order: "" },
            { Id: "SubMenu-1-2-3", Name: "Department", Controller: "/department", ParentId: "SubMenu-1-2", Order: "" }
        ];

        return (
            <React.Fragment>
                <MenuList menus={menus} />
            </React.Fragment>
        )
    }
}

export default NavigationMenu;