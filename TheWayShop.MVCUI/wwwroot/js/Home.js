$(document).ready(function () {

    $("#sendMessage").click(function () {
        var vm = {
            FullName: $("#fullName").val(),
            Mail: $("#email").val(),
            Subject: $("#subject").val(),
            Messages: $("#message").val()
        };
        $.ajax({
            url: "/send-message",
            method: "post",
            datatype: "json",
            data: { vm: vm },
            success: function (resp) {
                if (resp.result) {
                    Swal.fire({
                        icon: 'success',
                        title: 'İşlem Başarılı',
                        text: resp.message
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
                        text: resp.message
                    })
                }
            }
        })
    });
})