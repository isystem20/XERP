
// ['chart', 'dashboard', 'datatable']


//list of Scripts needed in the application
const scriptList = {
    chart: "theme/src/assets/js/plugins/chart.js/Chart.bundle.min.js",
    dashboard: "theme/src/assets/js/pages/be_pages_dashboard.min.js",

    //datatable
    datatable: "theme/src/assets/js/plugins/datatables/jquery.dataTables.min.js",
    datatablebs: "theme/src/assets/js/plugins/datatables/dataTables.bootstrap4.min.js",
    datatablebuttons: "theme/src/assets/js/plugins/datatables/buttons/dataTables.buttons.min.js",
    datatableprint: "theme/src/assets/js/plugins/datatables/buttons/buttons.print.min.js",
    datatablehtml5: "theme/src/assets/js/plugins/datatables/buttons/buttons.html5.min.js",
    datatableflash: "theme/src/assets/js/plugins/datatables/buttons/buttons.flash.min.js",
    datatablecolvis: "theme/src/assets/js/plugins/datatables/buttons/buttons.colVis.min.js",
    datatablepage: "theme/src/assets/js/pages/be_tables_datatables.min.js",

    //notification
    notification: "theme/src/assets/js/plugins/bootstrap-notify/bootstrap-notify.min.js",
    notificationhelper: "theme/src/assets/js/notif.js",

    //signin    
    validate: "theme/src/assets/js/plugins/jquery-validation/jquery.validate.min.js",        
    op_auth_signin: "theme/src/assets/js/pages/op_auth_signin.min.js",     
    op_auth_reminder: "theme/src/assets/js/pages/op_auth_reminder.min.js"

    //register new
}


function LoadScript(requiredScript, node, isFirst) {

    //loop in for each item inside the requiredScript
    requiredScript.forEach(function (s) {

        //check the requiredscript item in the scriptList if registered
        Object.keys(scriptList).forEach(function (key) {

            //if the requiredscript matched in the list..
            if (key === s) {
                const script = document.createElement("script");

                //set the value as the source of the script based on the value from the scriptList registry
                script.src = scriptList[key];
                script.async = true;

                //if isFirst, it will display on the first node inside the "node" 
                if (isFirst) {

                    //node = the specific node where the script will be added. e.q <body>
                    node.prepend(script);
                }
                else {
                    node.appendChild(script)
                }
                
            }

        });
    })

}


export default LoadScript