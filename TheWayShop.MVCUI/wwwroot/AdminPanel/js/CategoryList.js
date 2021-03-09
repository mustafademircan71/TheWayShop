

$(function () {


    $("#btnSave").click(function () {
        $("#frmNewCategory").validate({
            rules: {
                txtCategoryName: {
                    required: true,
                    minlength: 2
                }
            },
            messages: {
                txtCategoryName: {
                    required: "Kategori Adı Zorunludur.",
                    minlength: "En Az iki Karakter Olmalıdır."
                }

            },
        });
        var isFormValid = $("#frmNewCategory").valid();
        if (isFormValid) {


            var formData = new FormData();
            var file = $("#fuPhoto")[0].files[0];
            formData.append("photo", file);
            $.ajax({
                url: "/category-photo-upload",
                method: "post",
                data: formData,
                contentType: false,
                processData: false,
                success: function (resp) {
                    if (resp.result) {
                        var vm =
                        {
                            CategoryName: $("#txtCategoryName").val(),
                            TopCategoryId: $("#ddlCategoryList").val(),
                            IsShownInMainPage: $("#gridCheck").is(":checked"),
                            Priority: $("#txtPriority").val(),
                            IsActive: $("#gridCheckActive").is(":checked"),
                            CategoryPhoto: resp.photoPath
                        };

                        $.ajax({
                            url: "/save-new-category",
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
                    else {
                        Swal.fire({
                            icon: 'error',
                            title: 'Hata!!!',
                            text: resp.message
                        });
                    }

                }

            });

        }


    });

    $(".btnEdit").click(function () {
        var categoryId = $(this).attr("categoryid");
        $.ajax({
            url: "/category-details",
            type: "post",
            dataType: "json",
            data: { id: categoryId },
            success: function (response) {
                $("#txtCategoryNameUpdate").val(response.categoryInfo.categoryName);
                $("#ddlCategoryListUpdate").val(response.categoryInfo.topCategoryId);
                $("#txtPriorityUpdate").val(response.categoryInfo.priority);
                $("#fuPhotoUpdate").attr("src", response.categoryInfo.categoryPhoto);
                $("#gridCheckUpdate").prop('checked', response.categoryInfo.isShownInMainPage);
                $("#gridCheckActiveUpdate").prop('checked', response.categoryInfo.isActive);
                $("#hfCategoryIdUpdate").val(response.categoryInfo.id);
                $("#imgCategoryPhotoUpdate").attr("src", response.categoryInfo.categoryPhoto);
            }
        });

        $("#divUpdateCategoryForm").modal("show");
    });

    $("#btnSaveUpdate").click(function () {
        var formData = new FormData();
        var file = $("#fuPhotoUpdate")[0].files[0];
        formData.append("photo", file);

        $.ajax({
            url: "/category-photo-update",
            method: "post",
            data: formData,
            contentType: false,
            processData: false,
            success: function (response) {
                if (response.result) {
                    var vm = {
                        Id: $("#hfCategoryIdUpdate").val(),
                        CategoryName: $("#txtCategoryNameUpdate").val(),
                        TopCategoryId: $("#ddlCategoryListUpdate").val(),
                        Priority: $("#txtPriorityUpdate").val(),
                        IsActive: $("#gridCheckActiveUpdate").is(":checked"),
                        IsShownInMainPage: $("gridCheckUpdate").is(":checked"),
                        CategoryPhoto: response.photoPath
                    };
                    $.ajax({
                        url: "/category-update",
                        method: "post",
                        datatype: "json",
                        data: { vm: vm },
                        success: function (resp) {
                            if (resp.result) {
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
                var sId = clickedS.attr("categoryid");

                $.ajax({
                    url: "/delete-category",
                    method: "post",
                    dataType: "json",
                    data: { categoryId: sId },
                    success: function (respons) {
                        if (respons.result) {
                            var dlt = clickedS.parent().parent();
                            dlt.remove();

                            Swal.fire(
                                'Silindi!',
                                'Kategori Silindi',
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
