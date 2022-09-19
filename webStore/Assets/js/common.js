

function getMessage() {
    var username = document.getElementById("user_name").value;
    var password = document.getElementById("password").value;

    if (username != "" || password != "") {

        alert("Tài khoản hoặc mật khẩu không đúng !")
        return false;
    }

}


