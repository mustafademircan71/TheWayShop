$(function () {
    $(".btnSend").click(function () {
        var messageId = $(this).attr("messageid");
        $.ajax({
            url: "/message-details",
            type: "post",
            datatype: "json",
            data: { id: messageId },
            success: function (response) {
                $("#txtEmail").val(response.messageInfo.email);
                $("#txtSubject").val(response.messageInfo.subject);
                $("#hfMessageId").val(response.messageInfo.id);
                $("#txtFullName").val(response.messageInfo.fullName);

            }
        });
        $("#divNewMessageForm").modal("show");
    });
    $("#btnSend").click(function () {
        var vm = {
            Mail: $("#txtEmail").val(),
            Subject: $("#txtSubject").val(),
            Id: $("#hfMessageId").val(),
            FullName: $("#txtFullName").val(),
            Message: $("#txtMessage").val()
        };
        $.ajax({
            url: "/send-messages",
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
                var aId = clickedS.attr("messageid");

                $.ajax({
                    url: "/messages-delete",
                    method: "post",
                    dataType: "json",
                    data: { id: aId },
                    success: function (respons) {
                        if (respons.result) {
                            var dlt = clickedS.parent().parent();
                            dlt.remove();

                            Swal.fire(
                                'Silindi!',
                                'Mesaj Silindi.',
                                'success'
                            )
                        }

                    }
                });



            }
        })
    });

    $(".btnSendDelete").click(function () {

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
                var aId = clickedS.attr("messageid");

                $.ajax({
                    url: "/send-messages-delete",
                    method: "post",
                    dataType: "json",
                    data: { id: aId },
                    success: function (respons) {
                        if (respons.result) {
                            var dlt = clickedS.parent().parent();
                            dlt.remove();

                            Swal.fire(
                                'Silindi!',
                                'Mesaj Silindi.',
                                'success'
                            )
                        }

                    }
                });



            }
        })
    });

    $('#tblAdminList').DataTable({
        "paging": true,
        "ordering": false,
        "searching": true,
        "language": {
            "sDecimal": ",",
            "sEmptyTable": "Tabloda herhangi bir veri mevcut değil",
            "sInfo": "_TOTAL_ kayıttan _START_ - _END_ arasındaki kayıtlar gösteriliyor",
            "sInfoEmpty": "Kayıt yok",
            "sInfoFiltered": "(_MAX_ kayıt içerisinden bulunan)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Sayfada _MENU_ kayıt göster",
            "sLoadingRecords": "Yükleniyor...",
            "sProcessing": "İşleniyor...",
            "sSearch": "Ara:",
            "sZeroRecords": "Eşleşen kayıt bulunamadı",
            "oPaginate": {
                "sFirst": "İlk",
                "sLast": "Son",
                "sNext": "Sonraki",
                "sPrevious": "Önceki"
            },
            "oAria": {
                "sSortAscending": ": artan sütun sıralamasını aktifleştir",
                "sSortDescending": ": azalan sütun sıralamasını aktifleştir"
            },
            "select": {
                "rows": {
                    "_": "%d kayıt seçildi",
                    "0": "",
                    "1": "1 kayıt seçildi"
                }
            }
        }
    });

    $('#tblMessageList').DataTable({
        "paging": true,
        "ordering": false,
        "searching": true,
        "language": {
            "sDecimal": ",",
            "sEmptyTable": "Tabloda herhangi bir veri mevcut değil",
            "sInfo": "_TOTAL_ kayıttan _START_ - _END_ arasındaki kayıtlar gösteriliyor",
            "sInfoEmpty": "Kayıt yok",
            "sInfoFiltered": "(_MAX_ kayıt içerisinden bulunan)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Sayfada _MENU_ kayıt göster",
            "sLoadingRecords": "Yükleniyor...",
            "sProcessing": "İşleniyor...",
            "sSearch": "Ara:",
            "sZeroRecords": "Eşleşen kayıt bulunamadı",
            "oPaginate": {
                "sFirst": "İlk",
                "sLast": "Son",
                "sNext": "Sonraki",
                "sPrevious": "Önceki"
            },
            "oAria": {
                "sSortAscending": ": artan sütun sıralamasını aktifleştir",
                "sSortDescending": ": azalan sütun sıralamasını aktifleştir"
            },
            "select": {
                "rows": {
                    "_": "%d kayıt seçildi",
                    "0": "",
                    "1": "1 kayıt seçildi"
                }
            }
        }
    });
});