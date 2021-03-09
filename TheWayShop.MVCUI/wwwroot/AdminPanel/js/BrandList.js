$(function () {
    $('#tblAdminList').DataTable({
        "paging": true,
        "lengthChange": true,
        "searching": true,
        "ordering": true,
        "info": true,
        "autoWidth": true,
        "responsive": true,
    });

    $("#btnSave").click(function () {
        $("#frmNewBrand").validate({
            rules: {
                txtBrandName: {
                    required: true,
                    minlength: 2
                }
            },
            messages: {
                txtBrandName: {
                    required: "Marka Zorunludur.",
                    minlength: "En Az 2 Karakter Olmalıdır."
                }
              
            }
        });

        var isFormValid = $("#frmNewBrand").valid();
        if (isFormValid) {
            var vm = {
                BrandName: $("#txtBrandName").val(),
                IsActive: $("#gridCheck").is(":checked"),
            };

            $.ajax({
                url: "/brand-new-save",
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

    $(".btnEdit").click(function () {
        var brandId = $(this).attr("brandid");
        $.ajax({
            url: "/brand-details",
            method: "post",
            datatype: "json",
            data: { brandId: brandId },
            success: function (response) {
                $("#txtBrandUpdate").val(response.brandInfo.brandName);
                $("#gridCheckUpdate").prop('checked', response.brandInfo.isActive);
                $("#hfBrandIdUpdate").val(response.brandInfo.id);
            }
        });


         $("#divUpdateBrandForm").modal("show");
    });

    $("#btnSaveUpdate").click(function () {

        $("#frmUpdateBrand").validate({
            rules: {
                txtBrandUpdate: {
                    required: true,
                    minlength:2
                }
            },
            messages:{
                txtBrandUpdate: {
                    required: "Marka Zorunludur.",
                    minlength: "En Az İki Karkter Girilmelidir."
                }
            }
        });

        var isFormValide = $("#frmUpdateBrand").valid();
        if (isFormValide) {
            var vm = {
                Id: $("#hfBrandIdUpdate").val(),
                BrandName: $("#txtBrandUpdate").val(),
                IsActive: $("#gridCheckUpdate").is(":checked"),
            };
            $.ajax({
                url: "/brand-update",
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
                }
            });
        }
       
    });

    $(".btnDelete").click(function () {

        Swal.fire({
            title: 'Are you sure?',
            text: "You won't be able to revert this!",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Yes, delete it!'
        }).then((result) => {
            if (result.isConfirmed) {
                var clickedS = $(this);
                var bId = clickedS.attr("brandid");

                $.ajax({
                    url: "/brand-delete",
                    method: "post",
                    dataType: "json",
                    data: { brandId: bId },
                    success: function (respons) {
                        if (respons.result) {
                            var dlt = clickedS.parent().parent();
                            dlt.remove();

                            Swal.fire(
                                'Deleted!',
                                'Your file has been deleted.',
                                'success'
                            )
                        }

                    }
                });



            }
        })

      

         
    });
});





