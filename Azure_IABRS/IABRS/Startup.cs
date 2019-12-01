/*###############################################################
 *  File:           Startup.cs
 *  Project :       NAD Assignment 4
 *  Programmer :    John Hall, James Milne
 *  Date :          11/10/2019
 *  
 *  Name:           Startup
 *  Purpose:        Handles setting all web apps settings on start up 
 * ##############################################################*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IABRS.Models;
using IABRS.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IABRS
{
    public class Startup
    {
        /// <summary>
        /// Sets the config on start 
        /// </summary>
        /// <param name="configuration">config params</param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            
        }

        public IConfiguration Configuration { get; }

        /// <summary>
        /// This method gets called by the runtime. 
        /// Use this method to add services to the container.
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<testsForNADContext>(item => item.UseSqlServer(Configuration.GetConnectionString("MyWebApiConection")));

            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequiredUniqueChars = 4;
            }).AddEntityFrameworkStores<testsForNADContext>();

            services.AddMvc(options => {
                var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser().Build();
                options.Filters.Add(new AuthorizeFilter(policy));
            }).AddXmlSerializerFormatters();


            services.AddAuthentication().AddGoogle(options =>
            {
                options.ClientId = "627011426493-l3q2005enlug9o628k0rfr2it3g15h8v.apps.googleusercontent.com";
                options.ClientSecret = "-ydTTOIOiAV_cxFwnJ2ty1AX";
            });

          //  services.AddDefaultIdentity<IABRS.ModelsFromDB.IdentityUser>().AddDefaultUI(Microsoft.AspNetCore.Identity.UI.UIFramework.Bootstrap4).AddEntityFrameworkStores<testsForNADContext>();

    



            PermissionController.LoadPermissions();
           testsForNADContext db = new testsForNADContext();


        }

        /// <summary>
        /// This method gets called by the runtime.
        /// Use this method to configure the HTTP request pipeline.
        /// </summary>
        /// <param name="app">this application</param>
        /// <param name="env">the host environment</param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
          app.UseStaticFiles();
           // app.UseRouting();

            app.UseAuthentication();
          //  app.UseAuthorization();
            app.UseCookiePolicy();
           
           

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
