$(document).ready(function () {

    $.validator.addMethod("passwordCheck", function (value) {
        return /^[A-Za-z0-9\d=!\-@._*]*$/.test(value) // consists of only these
            && /[a-z]/.test(value) // has a lowercase letter
            && /\d/.test(value) // has a digit
    });
    $("#btnLogIn").click(function () {
        var vm =
            {
                Email: $("#txtEmail").val(),
                Password: $("#txtPassword").val(),
               
            };

            $.ajax({
                url: "/user-login",
                method: "post",
                datatype: "json",
                data: { vm: vm },
                success: function (response) {
                    if (response.result) {
                        window.location.href = "/my-account";
                    }
                    else {
                        Swal.fire({
                            icon: 'error',
                            title: 'Hata!!!',
                            text: response.message
                        })
                    }
                }
            });
    });

    $("#btnSave").click(function () {
        $("#frmNewUser").validate({
            rules: {
                txtEmailNew: {
                    required: true,
                    email: true
                },
                txtFullNameNew: {
                    required: true,
                    minlength: 2
                },
                txtPasswordNew: {
                    required: true,
                    minlength: 8,
                    passwordCheck: true
                },
            },
            messages: {
                txtEmailNew: {
                    required: "Email Alanı Zorunludur",
                    email: "Girdiğiniz email adresi geçerli bir formatta olmalıdır "
                },
                txtFullNameNew: {
                    required:  "Ad Soyad zorunludur",
                    minlength: "Ad Soyad En az 2 karakter olmalıdır"
                },
                txtPasswordNew: {
                    required: "Şifre zorunludur",
                    minlength: "Şifre En az 8 karakter olmalıdır",
                    passwordCheck: "Şifrede en az 1 küçük harf ve en az 1 rakam olmalıdır"
                }
            }
        });
        var isFormValide = $("#frmNewUser").valid();
        if (isFormValide) {
            var vm = {
                Email: $("#txtEmailNew").val(),
                FullName: $("#txtFullNameNew").val(),
                Password: $("#txtPasswordNew").val()
            };
            $.ajax({
                url: "/new-user",
                method: "post",
                datatype: "json",
                data: { vm: vm },
                success: function (response) {
                    if (response.result) {
                        Swal.fire({
                            icon: 'success',
                            title: 'İşlem Başarılı',
                            text: response.message
                        }).then((result) => {
                            if (result.isConfirmed) {
                                window.location.reload();
                            }
                        });
                    }
                    else {
                        Swal.fire({
                            icon: 'error',
                            title: 'Hata!!!',
                            text: response.message
                        })
                    }
                }
            });
        }
      
    });

    $("#btnSendPassword").click(function () {
        var email = $("#txtEmailForgotPassword").val();

        $.ajax({
            url: "/forgot-password-user",
            method: "post",
            dataType: "json",
            data: { email: email },
            success: function (response) {oyun
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
})