using Assignment9.Models;
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

namespace Assignment9
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
            services.AddControllersWithViews(); // allows us to create our own endpoints by using the controller

            services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseSqlite(Configuration["ConnectionStrings:MovieDBConnection"]); //this is going to connect us to a database
            });

            services.AddScoped<IMovieRepository, EFMovieRepository>(); //give people their own scope for what's happening When we register a type as Scoped, one instance is available throughout the application per request. When a new request comes in, the new instance is created. Add scoped specifies that a single object is available per request.
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            //app.UseSession(); //sets up the session for us on startup

            //these next two app settings will protect against xss and enable certificate pinning
            app.Use(async (context, next) =>
            {
                context.Response.Headers.Add("X-Xss-Protection", "1");
                await next();
            });

            app.UseHsts();

            app.Use(async (ctx, next) =>
            {
                ctx.Response.Headers.Add("Content-Security-Policy",
                "default-src 'self'");
                await next();
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => //change this a bit to make things nicer
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");                           
            });
            
            SeedData.EnsurePopulated(app);
        }
    }
}
