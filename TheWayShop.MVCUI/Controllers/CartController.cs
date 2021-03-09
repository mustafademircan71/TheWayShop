using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheWayShop.Business.Abstract;
using TheWayShop.Model.Entity;
using TheWayShop.Model.ViewModels.Shop;
using TheWayShop.MVCUI.Aspects;
using TheWayShop.MVCUI.Extensions;

namespace TheWayShop.MVCUI.Controllers
{
    [UserSessionAspect]
    public class CartController : Controller
    {
        private readonly ICartBs _cartBs;
        private readonly IProductPhotoBs _productPhotoBs;

        public CartController(ICartBs cartBs, IProductPhotoBs productPhotoBs)
        {
            _cartBs = cartBs;
            _productPhotoBs = productPhotoBs;
        }

        public IActionResult Add(AddToCartVm vm)
        {
            Cart cartItem = _cartBs.GetByUserIdAndProductId(vm.UserId, vm.ProductId);
            if (cartItem != null)
                return Json(new { Result = true, Message = "Bu ürün zaten sepetinizde var, seçtiğiniz adet miktarı var olanın üzerine eklenecektir. Devam etmek istiyor musunuz ?", OperationType = "update" });



            cartItem = new Cart();

            cartItem.IsActive = true;
            cartItem.ProductId = vm.ProductId;
            cartItem.UserId = vm.UserId;
            cartItem.Quantity = vm.Quantity;

            _cartBs.Insert(cartItem);

            return Json(new { Result = true, Message = "Ürün sepete eklendi", OperationType = "insert" });
        }

        public IActionResult Update(AddToCartVm vm)
        {
            Cart cartItem = _cartBs.GetByUserIdAndProductId(vm.UserId, vm.ProductId);
            cartItem.Quantity += vm.Quantity;

            _cartBs.Update(cartItem);

            return Json(new { Result = true, Message = "Sepetteki ürünüzün adedi güncellendi" });
        }

        public IActionResult UserCart()
        {
            User activeUser = HttpContext.Session.GetObject<User>("ActiveUser");

            List<Cart> userCart = _cartBs.CartListByUserId(activeUser.Id, "Product");

            foreach (var cartItem in userCart)
            {
                cartItem.Product.ProductPhotos = _productPhotoBs.ProductPhotosByProductId(cartItem.ProductId);
            }

            return View(userCart);
        }

        public IActionResult RemoveFromCart(int cartId)
        {
            _cartBs.Delete(cartId);

            return Json(new { Result = true });
        }

        public IActionResult UpdateCartByList(List<UpdateCartByListVm> vm)
        {
            foreach (var cartItem in vm)
            {
                Cart cart = _cartBs.GetById(cartItem.CartId);
                cart.Quantity = cartItem.Quantity;

                _cartBs.Update(cart);
            }

            return Json(new { Result = true, Message = "Sepetiniz Güncellendi" });
        }

        public IActionResult UpdateCartByQuantityInput(UpdateCartByListVm vm)
        {

            Cart cart = _cartBs.GetById(vm.CartId,"Product");
            cart.Quantity = vm.Quantity;

            _cartBs.Update(cart);

            decimal total = cart.Product.DiscountRate.HasValue ? ((1 - (cart.Product.DiscountRate.Value / 100.0M)) * cart.Product.Price.Value) * cart.Quantity : (cart.Product.Price * cart.Quantity).Value;

            return Json(new { Result = true, Message = "Sepetiniz Güncellendi",Total= total});
        }

       
   }
}