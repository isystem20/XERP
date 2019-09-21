function AddPageLoader(node) {

    const div = document.createElement("div");
    div.className = "show"
    div.id = "page-loader"
    node.appendChild(div)

}

// visibility = show / hide
function Loader(visibility = "show") {
    // One.loader('show')
    // One.loader('hide')
    window["One"]["loader"](visibility);
}

export default { AddPageLoader, Loader }