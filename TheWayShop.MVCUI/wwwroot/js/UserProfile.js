$(function () {
    $("#btnSaveUpdate").click(function () {
        var vm = {
            Id: $("#hfUSerIdUpdate").val(),
            FullName: $("#txtFullName").val(),
            EMail: $("#txtEmail").val(),
            City: $("#txtCity").val(),
            Country: $("#txtCountry").val(),
            Adress: $("#txtAdres").val(),
            Phone: $("#txtPhone").val(),
        };
        $.ajax({
            url: "/my-profile-update",
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
        });
    });

    $("#btnSave").click(function () {
        var vm = {
            UserId: $("#hfUserId").val(),
            CartName: $("#txtFullName").val(),
            CartNo: $("#txtCartNo").val(),
            ExpirationDate: $("#txtExpirationDate").val(),
            Cvv: $("#txtCvv").val()
        };
        $.ajax({
            url: "/credit-cart-new",
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
    });

    $(".btnEdit").click(function () {
        var credtiCartId = $(this).attr("creditcartid");
        $.ajax({
            url: "/credit-cart-details",
            method: "post",
            datatype: "json",
            data: { id: credtiCartId },
            success: function (responsive) {
                $("#txtCartNameUpdate").val(responsive.creditCartInfo.cartName);
                $("#txtCartNoUpdate").val(responsive.creditCartInfo.cartNo);
                $("#txtExpirationDateUpdate").val(responsive.creditCartInfo.expirationDate);
                $("#txtCvvUpdate").val(responsive.creditCartInfo.cvv);
                $("#hfCreditCartUpdate").val(responsive.creditCartInfo.id);
            }
        });

        $("#divUpdateCreditCart").modal("show");
    });

    $("#btnSaveUpdateCreditCart").click(function () {
        var vm = {
            CartName: $("#txtCartNameUpdate").val(),
            CartNo: $("#txtCartNoUpdate").val(),
            ExpirationDate: $("#txtExpirationDateUpdate").val(),
            Cvv: $("#txtCvvUpdate").val(),
            Id: $("#hfCreditCartUpdate").val()
        };
        $.ajax({
            url: "/credit-cart-update",
            method: "post",
            datatype: "json",
            data: { vm: vm },
            success: function (respons) {
                if (response.result) {
                    Swal.fire({
                        icon: 'success',
                        title: 'İşlem Başarılı',
                        text: respons.message
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
                        text: respons.message
                    })
                }
            }

        });
    });

    $(".btnDelete").click(function () {

        Swal.fire({
            title: 'Silmek İstiyor musnuz?',
            text: "Bunu geri alamayacaksın!",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Evet',
            cancelButtonText: 'Vazgeç'
        }).then((result) => {
            if (result.isConfirmed) {
                var clickedS = $(this);
                var aId = clickedS.attr("creditcartid");

                $.ajax({
                    url: "/delete-credit-cart",
                    method: "post",
                    datatype: "json",
                    data: { id: aId },
                    success: function (responsi) {
                        if (responsi.result) {
                            var dlt = clickedS.parent().parent();
                            dlt.remove();

                            Swal.fire(
                                'Silindi!',
                                'Kart Silindi.',
                                'success'
                            )
                        }

                    }
                });



            }
        })
    });

    $("#btnDeleteUser").click(function () {

        Swal.fire({
            title: 'Hesabı Kapatmak İstiyor musunuz?',
            text: "Bunu geri alamayacaksın!",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Evet',
            cancelButtonText: 'Vazgeç'
        }).then((result) => {
            if (result.isConfirmed) {
                var clickedS = $(this);
                var aId = clickedS.attr("userid");

                $.ajax({
                    url: "/user-delete",
                    method: "post",
                    datatype: "json",
                    data: { id: aId },
                    success: function (responss) {
                        if (responss.result) {
                            window.location.href = "/user-login";

                            Swal.fire(
                                'Silindi!',
                                'Kart Silindi.',
                                'success'
                            )
                        }

                    }
                });



            }
        })
    });
});

