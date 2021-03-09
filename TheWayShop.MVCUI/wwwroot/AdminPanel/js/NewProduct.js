$(function () {

    $("#txtDescription").summernote();
    $("#txtDescriptionUpdate").summernote();

    $.validator.addMethod("roleCheck", function (contentToControl) {
        return contentToControl != "-1";
    });

    $("#btnSave").click(function () {
        $("#frmNewProduct").validate({
            rules: {
                txtProductName: {
                    required: true,
                    minlength: 2
                },
                txtPrice: {
                    required: true,
                    number: true
                },
                txtStock: {
                    required: true,
                    number: true
                },
                ddlCategoryList: {
                    roleCheck: true,
                },
                ddlBradnList: {
                    roleCheck: true,
                }
            },
            messages: {
                txtProductName: {
                    required: "Ürün Adı Boş Bırakılmaz",
                    minlength: "En Az İki Karakter Olmalıdır."
                },
                txtPrice: {
                    required: "Fiyat Boş Bırakılamaz",
                    number: "Rakam Girilmelidir"
                },
                txtStock: {
                    required: "Stok Boş Bırakılamaz",
                    number: "Rakam Girilmelidir"
                },
                ddlCategoryList: {
                    roleCheck: "Kategori Seçilmelidir.",
                },
                ddlBradnList: {
                    roleCheck: "Marka Seçilmelidir."
                }
            
                   
                 
            }

        });

        var isFormValid = $("#frmNewProduct").valid();
        if (isFormValid) {
            var vm = {
                ProductName: $("#txtProductName").val(),
                Price: $("#txtPrice").val(),
                Discount: $("#txtDiscount").val(),
                Stock: $("#txtStock").val(),
                CategoryId: $("#ddlCategoryList").val(),
                BrandId: $("#ddlBradnList").val(),
                ShortDescription: $("#txtShortDescription").val(),
                Description: $("#txtDescription").val(),
                IsActive: $("#gridCheckActive").is(":checked")

            };
            $.ajax({
                url: "/new-product-newPage",
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
        }
       
    });

    //$(".btnEdit").click(function () {
    
    //});

    $("#btnSaveUpdate").click(function () {
        $("#frmUpdateProduct").validate({
            rules: {
                txtProductNameUpdate: {
                    required: true,
                    minlength: 2
                },
                txtPriceUpdate:{
                    required: true,
                    number:true 
                },
                txtStockUpdate: {
                    required: true,
                    number: true 
                },
                ddlCategoryListUpdate: {
                    roleCheck: true
                },
                ddlBradnListUpdate: {
                    roleCheck: true
                }
            },
            messages:{
                txtProductNameUpdate: {
                    required: "Ürün Adı Boş Bırakılamaz",
                    minlength: "En Az iki Karakter Girilmelidir."
                },
                txtPriceUpdate: {
                    required: "Fiyat Boş Bırakılamaz",
                    number: "Rakam Girilmelidir."
                },
                txtStockUpdate: {
                    required: "Stok Boş Bırakılamaz",
                    number: "Rakam Girilmelidir."
                },
                ddlCategoryListUpdate: {
                    roleCheck:"Kategori Seçilmelidir."
                },
                ddlBradnListUpdate: {
                    roleCheck: "Marka Seçilmelidir."
                }
            }
        });

        var isFormValide = $("#frmUpdateProduct").valid();
        if (isFormValide) {
            var vm = {
                Id: $("#hfProductIdUpdate").val(),
                ProductName: $("#txtProductNameUpdate").val(),
                Price: $("#txtPriceUpdate").val(),
                Discount: $("#txtDiscountUpdate").val(),
                Stock: $("#txtStockUpdate").val(),
                CategoryId: $("#ddlCategoryListUpdate").val(),
                BrandId: $("#ddlBradnListUpdate").val(),
                ShortDescription: $("#txtShortDescriptionUpdate").val(),
                Description: $("#txtDescriptionUpdate").val(),
                IsActive: $("#gridCheckActiveUpdate").is(":checked")
            };
            $.ajax({
                url: "/save-update-product",
                method: "post",
                datatype: "json",
                data: { vm: vm },
                success: function (respo) {
                    if (respo.result) {

                        var formData = new FormData();
                        var files = $("#fuPhotoUpdate")[0].files;
                        for (var i = 0; i < files.length; i++) {
                            formData.append(i.toString(), files[i]);
                        }
                        $.ajax({
                            url: "/product-photo-update/" + respo.updatedProductId,
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
        }
       

    });

 
    

});