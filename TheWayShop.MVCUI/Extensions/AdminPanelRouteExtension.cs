using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWayShop.MVCUI.Extensions
{
    public static class AdminPanelRouteExtension
    {
        public static void AdminPanel(this IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "adminLogin",
                    areaName: "AdminPanel",
                    pattern: "admin",
                    defaults: new { controller = "Admin", action = "LogIn" });

                endpoints.MapAreaControllerRoute(
                    name: "adminHome",
                    areaName: "AdminPanel",
                    pattern: "admin-home",
                    defaults: new { controller = "Home", action = "Index" });

                endpoints.MapAreaControllerRoute(
                    name: "adminList",
                    areaName: "AdminPanel",
                    pattern: "admin-list",
                    defaults: new { controller = "Admin", action = "List" });

                endpoints.MapAreaControllerRoute(
                    name: "adminForgotPassword",
                    areaName: "AdminPanel",
                    pattern: "forgot-password",
                    defaults: new { controller = "Admin", action = "ForgotPassword" });

                endpoints.MapAreaControllerRoute(
                    name: "adminLogOut",
                    areaName: "AdminPanel",
                    pattern: "logout",
                    defaults: new { controller = "Admin", action = "LogOut" });

                endpoints.MapAreaControllerRoute(
                    name: "adminPhotoUpload",
                    areaName: "AdminPanel",
                    pattern: "admin-photo-upload",
                    defaults: new { controller = "Admin", action = "PhotoUpload" });

                endpoints.MapAreaControllerRoute(
                    name: "adminNew",
                    areaName: "AdminPanel",
                    pattern: "save-new-admin",
                    defaults: new { controller = "Admin", action = "New" });

                endpoints.MapAreaControllerRoute(
                    name: "adminDetailsById",
                    areaName: "AdminPanel",
                    pattern: "admin-details",
                    defaults: new { controller = "Admin", action = "DetailsById" });

                endpoints.MapAreaControllerRoute(
                    name: "adminUpdate",
                    areaName: "AdminPanel",
                    pattern: "update-admin",
                    defaults: new { controller = "Admin", action = "Update" });

                endpoints.MapAreaControllerRoute(
                    name: "adminPhotoUpdate",
                    areaName: "AdminPanel",
                    pattern: "admin-photo-update",
                    defaults: new { controller = "Admin", action = "PhotoUpdate" });

                endpoints.MapAreaControllerRoute(
                     name: "adminDelete",
                     areaName: "AdminPanel",
                     pattern: "delete-admin",
                     defaults: new { controller = "Admin", action = "Delete" });

                endpoints.MapAreaControllerRoute(
                  name: "messages",
                  areaName: "AdminPanel",
                  pattern: "message-list",
                  defaults: new { controller = "MessageList", action = "List" });

                endpoints.MapAreaControllerRoute(
                  name: "messagesDetails",
                  areaName: "AdminPanel",
                  pattern: "message-details",
                  defaults: new { controller = "MessageList", action = "MessageDetails" });

                endpoints.MapAreaControllerRoute(
                name: "sendMessages",
                areaName: "AdminPanel",
                pattern: "send-messages",
                defaults: new { controller = "MessageList", action = "NewMessage" });

                endpoints.MapAreaControllerRoute(
                name: "sendMessages",
                areaName: "AdminPanel",
                pattern: "send-messages-list",
                defaults: new { controller = "MessageList", action = "SendMessageList" });

                endpoints.MapAreaControllerRoute(
                name: "MessagesDelete",
                areaName: "AdminPanel",
                pattern: "messages-delete",
                defaults: new { controller = "MessageList", action = "MessageDelete" });

                endpoints.MapAreaControllerRoute(
              name: "sendMessagesDelete",
              areaName: "AdminPanel",
              pattern: "send-messages-delete",
              defaults: new { controller = "MessageList", action = "SendMessageDelete" });

                endpoints.MapAreaControllerRoute(
                    name:"adminUserList",
                    areaName:"AdminPanel",
                    pattern:"admin-panel-user-list",
                    defaults:new { controller= "AdminPanelUser",action= "UserList" });


            });
        }
        public static void CategoryAdminPanel(this IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                   name: "adminCategoryList",
                   areaName: "AdminPanel",
                   pattern: "category-list",
                   defaults: new { controller = "Category", action = "List" });

                endpoints.MapAreaControllerRoute(
                    name: "categoryNew",
                    areaName: "AdminPanel",
                    pattern: "save-new-category",
                    defaults: new { controller = "Category", action = "New" });

                endpoints.MapAreaControllerRoute(
                    name: "categoryPhotoUpload",
                    areaName: "AdminPanel",
                    pattern: "category-photo-upload",
                    defaults: new { controller = "Category", action = "CategoryPhotoUpload" });

                endpoints.MapAreaControllerRoute(
                    name: "cateogryDetails",
                    areaName: "AdminPanel",
                    pattern: "category-details",
                    defaults: new { controller = "Category", action = "DetailsCategory" });

                endpoints.MapAreaControllerRoute(
                    name: "categoryPhotoUpdate",
                    areaName: "Admin Panel",
                    pattern: "category-photo-update",
                    defaults: new { controller = "Category", action = "CategoryPhotoUpdate" });

                endpoints.MapAreaControllerRoute(
                    name: "categoryUpdate",
                    areaName: "AdminPanel",
                    pattern: "category-update",
                    defaults: new { controller = "Category", action = "CategoryUpdate" });

                endpoints.MapAreaControllerRoute(
                   name: "categoryPhotoUpdate",
                   areaName: "AdminPanel",
                   pattern: "category-photo-update",
                   defaults: new { controller = "Category", action = "CategoryPhotoUpdate" });

                endpoints.MapAreaControllerRoute(
                    name: "CategoryDelete",
                    areaName: "AdminPanel",
                    pattern: "delete-category",
                    defaults: new { controller = "Category", action = "CategoryDelete" });

            });
        }
        public static void ProductAdminPanel(this IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                   name: "adminProductList",
                   areaName: "AdminPanel",
                   pattern: "product-list",
                   defaults: new { controller = "Product", action = "List" });

                endpoints.MapAreaControllerRoute(
                   name: "productPhotoUpload",
                   areaName: "AdminPanel",
                   pattern: "product-photo-upload/{id}",
                   defaults: new { controller = "Product", action = "PhotoUpload" });

                endpoints.MapAreaControllerRoute(
                    name: "productNew",
                    areaName: "AdminPanel",
                    pattern: "save-new-product",
                    defaults: new { controller = "Product", action = "New" });

                endpoints.MapAreaControllerRoute(
                name: "newProductNewPage",
                areaName: "AdminPanel",
                pattern: "new-product-newPage",
                defaults: new { controller = "Product", action = "NewProductNewPage" });

                endpoints.MapAreaControllerRoute(
                 name: "newProductDetails",
                 areaName: "AdminPanel",
                 pattern: "product-update-page-{ProductId}",
                 defaults: new { controller = "Product", action = "ProductDeatilsAndUpdate" });

                endpoints.MapAreaControllerRoute(
               name: "newProductUpdate",
               areaName: "AdminPanel",
               pattern: "save-update-product",
               defaults: new { controller = "Product", action = "ProductDeatilsAndUpdate" });

                endpoints.MapAreaControllerRoute(
                  name: "productPhotoUpdate",
                  areaName: "AdminPanel",
                  pattern: "product-photo-update/{id}",
                  defaults: new { controller = "Product", action = "PhotoUpdate" });

                endpoints.MapAreaControllerRoute(
                name: "productPhotoDelete",
                areaName: "AdminPanel",
                pattern: "product-delete",
                defaults: new { controller = "Product", action = "Delete" });


            });
        }
        public static void SliderAdminPanel(this IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {

                endpoints.MapAreaControllerRoute(
                    name: "sliderList",
                    areaName: "AdminPanel",
                    pattern: "slider-list",
                    defaults: new { controller = "Slider", action = "List" });

                endpoints.MapAreaControllerRoute(
                    name: "sliderImage",
                    areaName: "AdminPanel",
                    pattern: "slider-image-upload",
                    defaults: new { controller = "Slider", action = "SliderPhotoUpload" });

                endpoints.MapAreaControllerRoute(
                    name: "sliderNew",
                    areaName: "AdminPanel",
                    pattern: "save-new-slider",
                    defaults: new { controller = "Slider", action = "New" });


                endpoints.MapAreaControllerRoute(
                     name: "sliderDetails",
                     areaName: "AdminPanel",
                     pattern: "slider-details",
                     defaults: new { controller = "Slider", action = "SliderDetails" });

                endpoints.MapAreaControllerRoute(
                    name: "sliderPhotoUpdate",
                    areaName: "AdminPanel",
                    pattern: "slider-photo-update",
                    defaults: new { controller = "Slider", action = "SliderPhotoUpdate" });

                endpoints.MapAreaControllerRoute(
                   name: "sliderUpdate",
                   areaName: "AdminPanel",
                   pattern: "slider-update",
                   defaults: new { controller = "Slider", action = "SliderUpdate" });

                endpoints.MapAreaControllerRoute(
                     name: "sliderDelete",
                     areaName: "AdminPanel",
                     pattern: "slider-delete",
                     defaults: new { controller = "Slider", action = "SliderDelete" });
            });
        }
        public static void BrandAdminPanel(this IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                 name: "brandList",
                 areaName: "AdminPanel",
                 pattern: "brand-list",
                 defaults: new { controller = "Brand", action = "List" });

                endpoints.MapAreaControllerRoute(
                 name: "brandNew",
                 areaName: "AdminPanel",
                 pattern: "brand-new-save",
                 defaults: new { controller = "Brand", action = "New" });

                endpoints.MapAreaControllerRoute(
                 name: "brandDetails",
                 areaName: "AdminPanel",
                 pattern: "brand-details",
                 defaults: new { controller = "Brand", action = "BrandDetails" });

                endpoints.MapAreaControllerRoute(
                 name: "brandUpdate",
                 areaName: "AdminPanel",
                 pattern: "brand-update",
                 defaults: new { controller = "Brand", action = "BrandUpdate" });

                endpoints.MapAreaControllerRoute(
               name: "brandDelete",
               areaName: "AdminPanel",
               pattern: "brand-delete",
               defaults: new { controller = "Brand", action = "BrandDelete" });
            });
        }
        public static void AdminPanelUser(this IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
              endpoints.MapAreaControllerRoute(
              name: "AdminPanelUser",
              areaName: "AdminPanel",
              pattern: "user-list-admin",
              defaults: new { controller = "AdminPanelUserController", action = "List" });
            });
        }
    }
}
