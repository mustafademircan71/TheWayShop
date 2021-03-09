$(document).ready(function () {
    $("#btnLogIn").click(function () {
        var vm = {
            Email: $("#txtEmail").val(),
            Password: $("#txtPassword").val(),
            RememberMe: $("#remember").is(":checked")
        }

        $.ajax({
            url: "/admin",
            method: "post",
            dataType: "json",
            data: { vm: vm },
            success: function (response) {
                if (response.result)
                    window.location.href = "/admin-home";
                else
                    Swal.fire({
                        icon: 'error',
                        title: 'Hata!!!',
                        text: response.message
                    })
            }
        });

    });

    $("#btnSendPassword").click(function () {
        var email = $("#txtEmailForgotPassword").val();

        $.ajax({
            url: "/forgot-password",
            method: "post",
            dataType: "json",
            data: { email: email },
            success: function (response) {
                if (response.result) {
                    Swal.fire({
                        icon: 'success',
                        title: 'İşlem Başarılı',
                        text: response.message
                    }).then((result) => {
                        if (result.isConfirmed) {
                            //window.location.reload();
                            $("#divForgotPassword").modal("hide");
                        }
                    });
                }
                else {
                    Swal.fire({
                        icon: 'error',
                        title: 'Hata!!!',
                        text: response.message
                    });
                }
            }
        });
    });
});