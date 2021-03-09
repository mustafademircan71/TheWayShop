using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TheWayShop.Business.Abstract;
using TheWayShop.Business.Concrete;
using TheWayShop.DataAccess.Abstract;
using TheWayShop.DataAccess.Concrete;
using TheWayShop.DataAccess.Concrete.EntityFramework.Repositories;
using TheWayShop.MVCUI.Extensions;

namespace TheWayShop.MVCUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            // arka taraftaki ioc container �zerinden ilgili nesnelerin inject edilmesi

            services.AdminConfigureServices();

            services.RoleConfigureServices();

            services.CategoryConfigureServices();

            services.ProductConfigureServices();

            services.ProductPhotoConfigureServices();

            services.BrandConfigureServices();

            services.SliderConfigureServices();

            services.CartConfigureServices();

            services.UserConfigureServices();

            services.ViewedProductConfigureServices();

            services.MessageConfigureServices();

            services.SendMessageConfigureServices();

            services.CreditCartConfigureServices();

            // Singleton : ram de nesnein sadece 1 �rne�i olmas�n� ve o �rnek �zerinden i�lem yap�lmas�n� sa�lar
            // Transient : her isteyene yeni bir tane �retip g�nderir
            // Scoped : ilgili scope i�erisinde e�er ayn� tipte 1 den fazla obje isteniyorsa onlar�n herbirine yeni �rnek yarat�l�p g�nderilir.

            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();

           

            app.UseEndpoints(endpoints =>
            {
                app.AdminPanel();

                app.BrandAdminPanel();

                app.CategoryAdminPanel();

                app.ProductAdminPanel();

                app.SliderAdminPanel();

                app.Shop();

                app.Cart();

                app.User();

                app.Home();
               
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}
