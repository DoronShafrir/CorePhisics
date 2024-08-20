function checkLogInValidity(e, msgBox) {
    const reg = /^[a-zA-Z0-9]+$/;
    const msgName = document.getElementById(msgBox);

    if (!e.value.match(reg)) {
        msgName.style = "color:red"
        msgName.innerHTML = "English letters/digits only"
    }
    else {
        msgName.style = "color:green"
        msgName.innerHTML = "ALL GOOD"
    }
}
//function reset2(msgBox1, msgBox2) {
//    let messages = document.querySelectorAll(".messages");
//    messages.forEach((message) => {
//        message.innerHTML = null;
//    })
// }
//function login1(e) {
//    let result = true;
//    let messages = document.querySelectorAll(".messages");
//    messages.forEach((message) => {
//        if (message.innerHTML != "ALL GOOD") { result = false }
//    });
//    return result;

// }
function reset2(msgBox1, msgBox2) {
    const msgBox = document.getElementById("msgBox")
    const msgBox11 = document.getElementById(msgBox1)
    const msgBox12 = document.getElementById(msgBox2)
    msgBox.innerHTML = "";
    msgBox11.innerHTML = "";
    msgBox12.innerHTML = "";

}