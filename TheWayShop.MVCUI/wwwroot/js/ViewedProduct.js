$(document).ready(function () {
    $("#btnAddToCart").click(function () {

        var activeUserId = $("#hfUserId").val();

        if (activeUserId == "-1") {
            Swal.fire({
                icon: 'error',
                title: 'Hata',
                text: 'Bu İşleme Devam Edebilmek İçin Giriş Yapmalısınız.',
            })
           
          
        }
        else {
            var vm =
            {
                UserId: activeUserId,
                ProductId: $("#hfProductId").val(),
                Quantity: $("#txtQuantity").val()
            };

            $.ajax({
                url: "/add-to-cart",
                method: "post",
                datatype: "json",
                data: { vm: vm },
                success: function (response) {
                    if (response.result && response.operationType == "insert") {
                        Swal.fire({
                            icon: 'success',
                            title: 'Ürün Sepete Eklendi',
                            text: response.message
                        }).then((result) => {
                            if (result.isConfirmed) {
                                window.location.href = "/user-cart";
                            }
                        });
                       
                    }
                    else if (response.result && response.operationType == "update") {
                        //alert(response.message);
                        Swal.fire({
                            title: 'Ürün Sepetinizde Mevcut Güncellemek İstiyor musunuz?',
                            text: "Bunu geri alamayacaksın!",
                            icon: 'question',
                            showCancelButton: true,
                            confirmButtonColor: '#3085d6',
                            cancelButtonColor: '#d33',
                            confirmButtonText: 'Evet',
                            cancelButtonText: 'Vazgeç'
                        }).then((result) => {
                            if (result.isConfirmed) {
                                //var clickedS = $(this);
                                //var cartId = $(this).attr("cartid");
                                $.ajax({
                                    url: "/update-cart",
                                    method: "post",
                                    datatype: "json",
                                    data: { vm: vm },
                                    success: function (resp) {
                                        if (resp.result) {
                                            //alert(resp.message);
                                            Swal.fire(
                                                'Güncellendi!',
                                                'Ürün Sepette Güncellendi',
                                                'success'
                                            )
                                            window.location.href = "/user-cart";
                                        }
                                    }
                                });


                            }
                        })
       
                    
                      
                    }
                }
            });
        }

    });
                     // sweetalert e bağlayıp eğer OK e tıkladıysa update methoduna post etmek lazım
                        ////// eğer OK e tıkladıysa aşağıdaki rutin işletielecek :
   
        var vm = {
            ProductId: $("#hfProductId").val(),
            UserId: $("#hfUserId").val()
        };
        $.ajax({
            url: "/viewed-product",
            method: "post",
            dataType: "json",
            data: { vm: vm }
        });
 




});