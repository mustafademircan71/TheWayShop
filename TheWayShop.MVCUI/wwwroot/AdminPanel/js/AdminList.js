
$(function () {
 

    $.validator.addMethod("passwordCheck", function (value) {
        return /^[A-Za-z0-9\d=!\-@._*]*$/.test(value) // consists of only these
            && /[a-z]/.test(value) // has a lowercase letter
            && /\d/.test(value) // has a digit
    });

    $.validator.addMethod("roleCheck", function (contentToControl) {
        return contentToControl != "-1";
    });

    $("#btnSave").click(function () {
        $("#frmNewAdmin").validate({
            rules: {
                txtEmail: {
                    required: true,
                    email: true
                },
                txtPassword: {
                    required: true,
                    minlength: 8,
                    passwordCheck:true
                },
                txtFullName: {
                    required: true,
                    minlength: 2
                },
                ddlRoleList: {
                    roleCheck:true
                }
            },
            messages: {
                txtEmail: {
                    required: "Email zorunlu bir alandır",
                    email: "Girdiğiniz email adresi geçerli bir formatta olmalıdır"
                },
                txtPassword: {
                    required: "Şifre zorunludur",
                    minlength: "Şifre En az 8 karakter olmalıdır",
                    passwordCheck:"Şifrede en az 1 küçük harf ve en az 1 rakam olmalıdır"
                },
                txtFullName: {
                    required: "Ad Soyad zorunludur",
                    minlength: "Ad Soyad En az 2 karakter olmalıdır"
                },
                ddlRoleList: {
                    roleCheck: "Yöneticinin rolü seçilmelidir"
                }
            }
        });

        var isFormValid = $("#frmNewAdmin").valid();
        if (isFormValid) {
            var formData = new FormData();
            var file = $("#fuPhoto")[0].files[0];
            formData.append("photo", file);

            $.ajax({
                url: "/admin-photo-upload",
                method: "post",
                data: formData,
                contentType: false,
                processData: false,
                success: function (response) {
                    if (response.result) {
                        var vm = {
                            Email: $("#txtEmail").val(),
                            Password: $("#txtPassword").val(),
                            FullName: $("#txtFullName").val(),
                            RoleId: $("#ddlRoleList").val(),
                            IsActive: $("#gridCheck").is(":checked"),
                            Photo: response.photoPath
                        };

                        $.ajax({
                            url: "/save-new-admin",
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
        }

    });

    // EDIT BUTONUNA BASILDIĞINDA CLIENT DA ZATEN VAR OLAN VERİYİ OKUYUP MODAL A BASMAK
    //$(".btnEdit").click(function () {

    //    var tr = $(this).parent().parent();
    //    var tdFullName = tr.find("td:nth-child(2)");
    //    var tdEmail = tr.find("td:nth-child(3)");

    //    $("#txtFullNameUpdate").val(tdFullName.text());
    //    $("#txtEmailUpdate").val(tdEmail.text());

    //    $("#divUpdateAdminForm").modal("show");
    //});
    //------------------------------------------------------------------------------


    $(".btnEdit").click(function () {
        var adminId = $(this).attr("adminid");

        $.ajax({
            url: "/admin-details",
            type: "post",
            datatype: "json",
            data: { id: adminId },
            success: function (response) {
                $("#txtFullNameUpdate").val(response.adminInfo.fullName);
                $("#txtPasswordUpdate").val(response.adminInfo.password);
                $("#txtEmailUpdate").val(response.adminInfo.email);
                $("#ddlRoleListUpdate").val(response.adminInfo.roleId);
                $("#gridCheckUpdate").prop('checked', response.adminInfo.isActive);
                $("#imgAdminPhotoUpdate").attr("src", response.adminInfo.photo);
                $("#hfAdminIdUpdate").val(response.adminInfo.id);
            }
        });

        $("#divUpdateAdminForm").modal("show");
    });

     $("#btnSaveUpdate").click(function () {
        $("#frmUpdateAdmin").validate({
            rules: {
                txtEmailUpdate: {
                    required: true,
                    email: true
                },
                txtPasswordUpdate: {
                    required: true,
                    minlength: 8,
                    passwordCheck: true
                },
                txtFullNameUpdate: {
                    required: true,
                    minlength: 2
                },
                ddlRoleListUpdate: {
                    roleCheck: true
                }
            },
            messages: {
                txtEmailUpdate:{
                    required: "Email zorunlu bir alandır",
                    email: "Girdiğiniz email adresi geçerli bir formatta olmalıdır"
                },
                txtPasswordUpdate: {
                    required: "Şifre zorunludur",
                    minlength: "Şifre En az 8 karakter olmalıdır",
                    passwordCheck: "Şifrede en az 1 küçük harf ve en az 1 rakam olmalıdır"
                },
                txtFullNameUpdate: {
                    required: "Ad Soyad Zorunludur.",
                    minlength: "En Az İki Karakter Olmalıdır."
                },
                ddlRoleListUpdate: {
                    roleCheck: "Yönetici Rolü Seçmek Zorunldur."
                }
            }
        });

        var isFormValide = $("#frmUpdateAdmin").valid();
        if (isFormValide) {
            var formData = new FormData();
            var file = $("#fuPhotoUpdate")[0].files[0];
            formData.append("photo", file);

            $.ajax({
                url: "/admin-photo-update",
                method: "post",
                data: formData,
                contentType: false,
                processData: false,
                success: function (resp) {
                    if (resp.result) {
                        var vm = {
                            Email: $("#txtEmailUpdate").val(),
                            Password: $("#txtPasswordUpdate").val(),
                            FullName: $("#txtFullNameUpdate").val(),
                            RoleId: $("#ddlRoleListUpdate").val(),
                            IsActive: $("#gridCheckUpdate").is(":checked"),
                            Photo: resp.photoPath

                        };
                        $.ajax({
                            url: "/update-admin",
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
                    }



                }


            });
        }
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
            cancelButtonText:'Vazgeç'
        }).then((result) => {
            if (result.isConfirmed) {
                var clickedS = $(this);
                var aId = clickedS.attr("adminid");

                $.ajax({
                    url: "/delete-admin",
                    method: "post",
                    dataType: "json",
                    data: { adminId: aId },
                    success: function (respons) {
                        if (respons.result) {
                            var dlt = clickedS.parent().parent();
                            dlt.remove();

                            Swal.fire(
                                'Silindi!',
                                'Yönetici Silindi.',
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
