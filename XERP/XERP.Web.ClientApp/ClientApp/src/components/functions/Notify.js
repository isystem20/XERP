function Notify(message = "Success", type = "info", icon = "fa fa-info-circle mr-1") {
    window["One"]["helpers"]('notify', { type: type, icon: icon, message: message });
}

export default Notify