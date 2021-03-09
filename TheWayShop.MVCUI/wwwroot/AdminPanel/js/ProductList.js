
$(function () {

    $("#txtDescription").summernote();

    $("#btnSave").click(function () {
        var vm =
        {
            ProductName: $("#txtProductName").val(),
            Price: $("#txtPrice").val(),
            Discount: $("#txtDiscount").val(),
            Stock: $("#txtStock").val(),
            ShortDescription: $("#txtShortDescription").val(),
            Description: $("#txtDescription").summernote('code'),
            CategoryId: $("#ddlCategoryList").val(),
            BrandId: $("#ddlBrandList").val()
        };

        $.ajax({
            url: "/save-new-product",
            method: "post",
            datatype: "json",
            data: { vm: vm },
            success: function (resp) {
                if (resp.result) {

                    var formData = new FormData();
                    var files = $("#fuPhoto")[0].files;
                    for (var i = 0; i < files.length; i++) {
                        formData.append(i.toString(), files[i]);
                    }

                    $.ajax({
                        url: "/product-photo-upload/" + resp.insertedProductId,
                        method: "post",
                        data: formData,
                        contentType: false,
                        processData: false,
                        success: function (response) {
                            if (response.result) {
                                Swal.fire({
                                    icon: 'success',
                                    title: 'İşlem Başarılı',
                                    text: response.message
                                })

                                window.location.reload();
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

    $(".btnDelete").click(function () {
        Swal.fire({
            title: 'Silmek İstiyor musunuz?',
            text: "Bunu geri alamayacaksın!",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Evet',
            cancelButtonText:'Vazgeç'
        }).then((result) => {
            if (result.isConfirmed) {
                var clickedS = $(this);
                var pId = clickedS.attr("productid");

                $.ajax({
                    url: "/product-delete",
                    method: "post",
                    dataType: "json",
                    data: { productId: pId },
                    success: function (respons) {
                        if (respons.result) {
                            var dlt = clickedS.parent().parent();
                            dlt.remove();

                            Swal.fire(
                                'Silindi!',
                                'Kayıt Silindi.',
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
});
