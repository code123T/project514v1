
using WebShopping.Models.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace EcommerceWebUILab
{
    public class Startup
    {

        readonly IConfiguration configuration;
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }



        public void ConfigureServices(IServiceCollection services)
        {
         
            services.AddMvc();
            services.AddSession();
            var connection = configuration.GetConnectionString("DefaultConnection");
            NewMethod(services, connection);
        }

        private void AddCookie(Action<object> value)
        {
            throw new NotImplementedException();
        }

        private static void NewMethod(IServiceCollection services, string connection)
        {
           
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSession();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute("adminArea",
                areaName: "Admin",
                pattern: "admin/{controller=SiteManaged}/{action=index}/{id?}");


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

            });
        }
    }
}

    