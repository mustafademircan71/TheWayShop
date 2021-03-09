$(document).ready(function () {
    $("#btnSearchByPrice").click(function () {
        var parameters =
        {
            CategoryId: $("#hfActiveCategoryId").val(),
            PriceRange: $("#amount").val()
        };

        $.ajax({
            url: "/product-search",
            method: "post",
            datatype: "json",
            data: { parameters: parameters},
            success: function (response) {
                $("#divProductList").html(response);
            }
        });
    });

    $("#amount").change(function () {
        var parameters =
        {
            CategoryId: $("#hfActiveCategoryId").val(),
            PriceRange: $(this).val()
        };

        $.ajax({
            url: "/product-search",
            method: "post",
            datatype: "json",
            data: { parameters: parameters },
            success: function (response) {
                $("#divProductList").html(response);
            }
        });
    })

    $("#txtSearchByProductName").on("input",function () {
        var text = $(this).val();

        $.ajax({
            url: "/product-search-by-productName",
            method: "post",
            datatype: "json",
            data: { productName: text },
            success: function (response) {
                $("#divSearchByProductNameList").html(response);
            }
        });
    });
});