using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWayShop.MVCUI.Extensions
{
    public static class ShopRouteExtension
    {
        public static void Shop(this IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                name: "shopIndex",
                pattern: "shop/{categoryId}",
                defaults: new { controller = "Shop", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "shopIndexSearch",
                    pattern: "product-search",
                    defaults: new { controller = "Shop", action = "SearchProduct" });

                endpoints.MapControllerRoute(
                   name: "shopIndexSearch",
                   pattern: "product-search-by-productName",
                   defaults: new { controller = "Shop", action = "SearchProductByProductName" });

                endpoints.MapControllerRoute(
                 name: "productDetails",
                 pattern: "{productNameSeoFriendly}-{productId}",
                 defaults: new { controller = "Shop", action = "ProductDetails" });

                endpoints.MapControllerRoute(
                    name: "viewedProduct",
                    pattern: "viewed-product",
                    defaults: new { controller = "Shop", action = "ViewedProductInsert" });
            });
        }
        public static void User(this IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
               name: "myAccount",
               pattern: "my-account",
               defaults: new { controller = "User", action = "MyAccount" });

                endpoints.MapControllerRoute(
                    name: "userLogIn",
                    pattern: "user-login",
                    defaults: new { controller = "User", action = "LogIn" });

                endpoints.MapControllerRoute(
                    name: "userLogOut",
                    pattern: "user-logout",
                    defaults: new { controller = "User", action = "LogOut" });

                endpoints.MapControllerRoute(
                 name: "newUser",
                 pattern: "new-user",
                 defaults: new { controller = "User", action = "NewUser" });

                endpoints.MapControllerRoute(
                    name:"userMyProfile",
                    pattern:"my-profile",
                    defaults:new { controller="User",action= "MyProfile" });

                endpoints.MapControllerRoute(
                    name: "userMyProfile",
                    pattern: "my-profile-update",
                    defaults: new { controller = "User", action = "UserUpdate" });

                endpoints.MapControllerRoute(
                   name: "useCreditCart",
                   pattern: "credit-cart-list/{userId}",
                   defaults: new { controller = "User", action = "UserCreditCartList" });

                endpoints.MapControllerRoute(
                  name: "useCreditCart",
                  pattern: "credit-cart-new",
                  defaults: new { controller = "User", action = "UserCreditCartInsert" });

                endpoints.MapControllerRoute(
                 name: "useCreditCartDetails",
                 pattern: "credit-cart-details",
                 defaults: new { controller = "User", action = "CreditCartDetails" });

                endpoints.MapControllerRoute(
               name: "useCreditCartUpdate",
               pattern: "credit-cart-update",
               defaults: new { controller = "User", action = "CreditCartUpdate" });

                endpoints.MapControllerRoute(
              name: "useCreditCartUpdate",
              pattern: "delete-credit-cart",
              defaults: new { controller = "User", action = "DeleteCreditCart" });

                endpoints.MapControllerRoute(
             name: "userForgotPassword",
             pattern: "forgot-password-user",
             defaults: new { controller = "User", action = "ForgotPassword" });


                endpoints.MapControllerRoute(
                     name: "userDelete",
                     pattern: "user-delete",
                     defaults: new { controller = "USer", action = "UserProfileDelete" });
            });
        }
        public static void Cart(this IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                 name: "addToCart",
                 pattern: "add-to-cart",
                 defaults: new { controller = "Cart", action = "Add" });

                endpoints.MapControllerRoute(
                    name: "userCart",
                    pattern: "user-cart",
                    defaults: new { controller = "Cart", action = "UserCart" });

                endpoints.MapControllerRoute(
                    name: "updateCart",
                    pattern: "update-cart",
                    defaults: new { controller = "Cart", action = "Update" });

                endpoints.MapControllerRoute(
                    name: "updateCart",
                    pattern: "update-cart-by-list",
                    defaults: new { controller = "Cart", action = "UpdateCartByList" });

                endpoints.MapControllerRoute(
                   name: "updateCart",
                   pattern: "update-cart-by-quantity-input",
                   defaults: new { controller = "Cart", action = "UpdateCartByQuantityInput" });

                endpoints.MapControllerRoute(
                    name: "removeFromCart",
                    pattern: "remove-from-cart",
                    defaults: new { controller = "Cart", action = "RemoveFromCart" });
            });
        }
        public static void Home(this IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "ContactUs",
                  pattern: "contact-us",
                  defaults: new { controller = "Home", action = "ContactUs" });

                endpoints.MapControllerRoute(
                    name: "Messages",
                    pattern: "send-message",
                    defaults: new { controller = "Home", action = "SendMessage" });
            });
        }
    }
}
