$(document).ready(function () {
    $(".btnRemoveFromCart").click(function () {
        Swal.fire({
            title: 'Ürünü Sepetten Silmek İstiyor musunuz?',
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
                var cartId = $(this).attr("cartid");
                $.ajax({
                    url: "/remove-from-cart",
                    method: "post",
                    datatype: "json",
                    data: { cartId: cartId },
                    success: function (response) {
                        if (response.result)
                            var dlt = clickedS.parent().parent();
                        dlt.remove(); 
                            
                        Swal.fire(
                            'Silindi!',
                            'Ürün Sepetten Silindi',
                            'success'
                            )
                       
                    }
                });


            }
        })

       
    });
    
    // UPDATE butonu ile sepetin güncellenmesi
    $("#btnUpdateCart").click(function () {
        var updateList = [];

        var trs = $("#tBodyCartItems tr");
        trs.each(function (idx) {
            var vm =
            {
                CartId: $(this).attr("cartid"),
                Quantity: $(this).find("td.quantity-box input").val()
            };

            updateList.push(vm);
        });

        $.ajax({
            url: "/update-cart-by-list",
            method: "post",
            datatype: "json",
            data: { vm: updateList },
            success: function (response) {
                if (response.result) {
                    //alert(response.message);
                    Swal.fire('Sepetiniz Güncellendi')
                    window.location.reload();
                }
            }
        });
    });

    // quantity input u ile sepetin güncellenmesi
    $(".c-input-text").change(function () {
        var vm =
        {
            CartId: $(this).attr("cartid"),
            Quantity: $(this).val()
        };

        $.ajax({
            url: "/update-cart-by-quantity-input",
            method: "post",
            datatype: "json",
            data: { vm: vm },
            success: function (response) {
                if (response.result) {
                    //alert(response.message);
                    Swal.fire('Sepetiniz Güncellendi')
                    $("td.total-pr[cartid='" + vm.CartId + "']").html("<p>" + response.total + " TL</p>");
                }
            }
        });
    });
});