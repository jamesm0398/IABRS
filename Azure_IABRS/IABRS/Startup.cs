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
using IABRS.ModelsFromDB;
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

            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<testsForNADContext>();

            services.AddIdentity<IdentityUser, IdentityRole>()
               .AddEntityFrameworkStores<testsForNADContext>()
               .AddDefaultUI()
               .AddDefaultTokenProviders();

            //We build the AuthCookie's OnValidatePrincipal 
            var sp = services.BuildServiceProvider();
            var multiTenantDbContextOptions = sp.GetRequiredService<DbContextOptions<testsForNADContext>>();
            var authCookieValidate = new DataCookieValidate(multiTenantDbContextOptions);

            //see https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity-configuration?view=aspnetcore-2.1#cookie-settings
            services.ConfigureApplicationCookie(options =>
            {
                options.Events.OnValidatePrincipal = authCookieValidate.ValidateAsync;
            });

            //Register the Permission policy handlers
            services.AddSingleton<IAuthorizationPolicyProvider, AuthorizationPolicyProvider>();
            services.AddSingleton<IAuthorizationHandler, PermissionHandler>();

            //This is needed by PersonalDbContext to get the userId from claims
            services.AddScoped<IGetClaimsProvider, GetClaimsFromUser>();



            PermissionController.LoadPermissions();
           testsForNADContext db = new testsForNADContext();



            var roles = from u in db.Group select u;
            //services.AddMvc(obj =>
            //{
            //    var policy = new AuthorizationPolicyBuilder()
            //        .RequireAuthenticatedUser()
            //        .Build();
            //    obj.Filters.Add(new AuthorizeFilter(policy));
            //});
            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("User", policy =>
            //           policy.RequireRole("SysAdmin"));
            //});
            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = true;
               // options.Password.RequireLowercase = true;
               // options.Password.RequireNonAlphanumeric = true;
              //  options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 3;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;
            });

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

                options.LoginPath = "/Identity/Account/Login";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

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
          //app.UseStaticFiles();
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
