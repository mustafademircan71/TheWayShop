$(function () {
  

    $("#btnSave").click(function () {
        $("#frmNewSlider").validate({
            rules:{
                txtHeader: {
                    required: true,
                    minlength:2
                },
                txtDescription: {
                    required: true,
                    minlength: 15
                },
                txtLink: {
                    required: true
                }
            },
            messages: {
                txtHeader: {
                    required: "Başlık Zorunludur",
                    minlength:"En Az İki Karakterden Oluşmaldır."
                },
                txtDescription: {
                    required: "Açıklama Zorunludur.",
                    minlength:"Açıklama En Az 15 Karakter Olmalıdır."
                },
                txtLink: {
                    required: "Link Zorunludur."
                    
                }
            }
        });

        var isFormValid = $("#frmNewSlider").valid();
        if (isFormValid) {

       

             var formData = new FormData();
             var file = $("#fuPhoto")[0].files[0];
             formData.append("photo", file);

             $.ajax({
            url: "/slider-image-upload",
            method: "post",
            data: formData,
            contentType: false,
            processData: false,
            success: function (response) {
                if (response.result) {
                    var vm = {
                        Header: $("#txtHeader").val(),
                        Description: $("#txtDescription").val(),
                        Link: $("#txtLink").val(),
                        IsActive: $("#gridCheck").is(":checked"),
                        SliderImage: response.photoPath
                    };
                    $.ajax({
                        url: "/save-new-slider",
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

    $(".btnEdit").click(function () {
      
        var sliderId = $(this).attr("sliderid");
        $.ajax({
            url: "/slider-details",
            method: "post",
            datatype: "json",
            data: { id: sliderId },
            success: function (response) {
                $("#txtHeaderUpdate").val(response.sliderInfo.header);
                $("#txtDescriptionUpdate").val(response.sliderInfo.description);
                $("#txtLinkUpdate").val(response.sliderInfo.link);
                $("#gridCheckUpdate").prop('checked', response.sliderInfo.isActive);
                $("#hfSliderIdUpdate").val(response.sliderInfo.id);
                $("#imgSliderPhotoUpdate").attr("src", response.sliderInfo.sliderImage);
            }
        });

        $("#divUpdateSliderForm").modal("show");
    });

    $("#btnSaveUpdate").click(function () {
        $("#frmUpdateSlider").validate({
            rules:{
                txtHeaderUpdate: {
                    required: true,
                    minlength:2
                },
                txtDescriptionUpdate: {
                    required: true,
                    minlength: 15
                },
                txtLinkUpdate: {
                    required: true
                }
            },
            messages: {
                txtHeaderUpdate: {
                    required: "Başlık Girmek Zorunludur.",
                    minlength: "En Az İki karakter olmalıdır."
                },
                txtDescriptionUpdate: {
                    required: "Açıklama Zorunludur",
                    minlength: "En Az 15 Karakter Olmalıdır."
                },
                txtLinkUpdate: {
                    required: "Link Boş Bırakılamaz."
                }
            }
        });

        var isFormValide = $("#frmUpdateSlider").valid();
        if (isFormValide) {
            var formData = new FormData();
            var file = $("#fuPhotoUpdate")[0].files[0];
            formData.append("photo", file);

            $.ajax({
                url: "/slider-photo-update",
                method: "post",
                data: formData,
                contentType: false,
                processData: false,
                success: function (response) {
                    if (response.result) {
                        var vm = {
                            Id: $("#hfSliderIdUpdate").val(),
                            Header: $("#txtHeaderUpdate").val(),
                            Description: $("#txtDescriptionUpdate").val(),
                            Link: $("#txtLinkUpdate").val(),
                            IsActive: $("#gridCheckUpdate").is(":checked"),
                            SliderImage: response.photoPath
                        };
                        $.ajax({
                            url: "/slider-update",
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

    $(".btnDelete").click(function () {
      
        Swal.fire({
            title: 'Silmek İstiyor musunuz?',
            text: "Bunu geri alamayacaksın!",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Evet!',
            cancelButtonText:'Vazgeç'
        }).then((result) => {
            if (result.isConfirmed) {
                var clickedS = $(this);
                var sId = clickedS.attr("sliderid");
                
                $.ajax({
                    url: "/slider-delete",
                    method: "post",
                    dataType: "json",
                    data: { sliderId: sId },
                    success: function (respons) {
                        if (respons.result) {
                            var dlt = clickedS.parent().parent();
                            dlt.remove();

                            Swal.fire(
                                'Silindi!',
                                'Ürün Sepetten Silindi',
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