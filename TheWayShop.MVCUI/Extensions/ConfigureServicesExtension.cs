using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheWayShop.Business.Abstract;
using TheWayShop.Business.Concrete;
using TheWayShop.DataAccess.Abstract;
using TheWayShop.DataAccess.Concrete;
using TheWayShop.DataAccess.Concrete.EntityFramework.Repositories;

namespace TheWayShop.MVCUI.Extensions
{
    public static class ConfigureServicesExtension
    {
        public static void AdminConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<IAdminBs, AdminBs>();
            services.AddSingleton<IAdminRepository, AdminRepositoryEntityFramework>();
        }
        public static void RoleConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<IRoleBs, RoleBs>();
            services.AddSingleton<IRoleRepository, RoleRepositoryEntityFramework>();
        }
        public static void CategoryConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<ICategoryBs, CategoryBs>();
            services.AddSingleton<ICategoryRepository, CategoryRepositoryEntityFramework>();
        }
        public static void ProductConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductBs, ProductBs>();
            services.AddSingleton<IProductRepository, ProductRepositoryEntityFramework>();
        }
        public static void ProductPhotoConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<IProductPhotoBs, ProductPhotoBs>();
            services.AddSingleton<IProductPhotoRepository, ProductPhotoRepositoryEntityFramework>();
        }
        public static void BrandConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<IBrandBs, BrandBs>();
            services.AddSingleton<IBrandRepository, BrandRepositoryEntityFramework>();
        }
        public static void SliderConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<ISliderBs, SliderBs>();
            services.AddSingleton<ISliderRepository, SliderRepositoryEntityFramework>();
        }
        public static void UserConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<IUserBs, UserBs>();
            services.AddSingleton<IUserRepository, UserRepositoryEntityFramework>();
        }
        public static void CartConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<ICartBs, CartBs>();
            services.AddSingleton<ICartRepository, CartRepositoryEntityFramework>();
        }
        public static void ViewedProductConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<IViewedProductBs, ViewedProductBs>();
            services.AddSingleton<IViewedProductRepository, ViewedRepositoryEntityFramework>();
        }
        public static void MessageConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<IMessageBs, MessageBs>();
            services.AddSingleton<IMessageRepository, MessageRepositoryEntityFramework>();
        }
        public static void SendMessageConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<ISendMessageBs, SendMessageBs>();
            services.AddSingleton<ISendMessageRepository, SendMessageRepositoryEntityFramework>();
        }
        public static void CreditCartConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<ICreditCartBs, CreditCartBs>();
            services.AddSingleton<ICreditCartRepository, CreditCartRepositoryEntityFramework>();
        }
    }
}
