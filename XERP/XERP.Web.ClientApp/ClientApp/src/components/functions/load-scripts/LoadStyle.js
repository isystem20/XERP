
// ['chart', 'dashboard', 'datatable']


//list of Scripts needed in the application
const styleList = {
    datatablebs: "theme/src/assets/js/plugins/datatables/dataTables.bootstrap4.css",
    datatablebuttons: "theme/src/assets/js/plugins/datatables/buttons-bs4/buttons.bootstrap4.min.css",
    //register new
}


function LoadStyle(requiredStyle, node, isFirst) {

    //loop in for each item inside the requiredScript
    requiredStyle.forEach(function (s) {

        //check the requiredscript item in the scriptList if registered
        Object.keys(styleList).forEach(function (key) {

            //if the requiredscript matched in the list..
            if (key === s) {
                const script = document.createElement("link");

                //set the value as the source of the script based on the value from the scriptList registry
                script.href = styleList[key];
                script.rel = "stylesheet";

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


export default LoadStyle