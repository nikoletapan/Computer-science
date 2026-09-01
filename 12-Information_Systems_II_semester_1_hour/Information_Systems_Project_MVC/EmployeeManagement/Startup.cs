using EmployeeManagement.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc; 
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Startup
    {
        private IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        } 

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
           services.AddMvc(option => option.EnableEndpointRouting = false);
           services.AddSingleton<IEmployeeRepository, MockEmployeeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
              app.UseDeveloperExceptionPage();
                
                DeveloperExceptionPageOptions a = new DeveloperExceptionPageOptions();
                a.SourceCodeLineCount = 5;
                /*
                DeveloperExceptionPageOptions b = new DeveloperExceptionPageOptions();
                b.SourceCodeLineCount = 10;

                DeveloperExceptionPageOptions c = new DeveloperExceptionPageOptions();
                c.SourceCodeLineCount = 20;

                app.UseDeveloperExceptionPage(c);     
                // many rows code
                app.UseDeveloperExceptionPage(b);  */
            }
            
           /* DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            defaultFilesOptions.DefaultFileNames.Clear();
            defaultFilesOptions.DefaultFileNames.Add("about.html"); 

            app.UseDefaultFiles(defaultFilesOptions); */

            app.UseDefaultFiles();
            app.UseStaticFiles();

            // app.UseDirectoryBrowser(); 

            /* FileServerOptions fileServerOptions = new FileServerOptions();
               fileServerOptions.DefaultFilesOptions.DefaultFileNames.Clear();
               fileServerOptions.DefaultFilesOptions.DefaultFileNames.Add("page1.html");
               app.UseFileServer(fileServerOptions);  */

            app.UseMvc(rb => 
               {
                   rb.MapRoute(
                       name: "default",
                       template: "{controller}/{action}/{id?}",
                       defaults: new {controller = "home", action = "index"});
               }); 
/*
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{Id?}");
                endpoints.MapRazorPages();
            }); */

            app.UseRouting();

         /*
            app.Use(async (context, next) =>
                { 
                // await context.Response.WriteAsync("Hello from 1-st Middleware!");
                    logger.LogInformation("MW1: Incoming Request");
                    await next();
                    logger.LogInformation("MW1: Outgoing Response");
                });

            app.Use(async (context, next) =>
                {
                    logger.LogInformation("MW2: Incoming Request");
                    await next();
                    logger.LogInformation("MW2: Outgoing Response");
                }); */
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    throw new Exception("Error message!");
                    await context.Response.WriteAsync("Hello world!");
                    // await context.Response.WriteAsync(System.Diagnostics.Process.GetCurrentProcess().ProcessName);
                    // await context.Response.WriteAsync(_config ["MyKey"]);
                    // await context.Response.WriteAsync(" + Hello from 2-nd Middleware!");
                    //await context.Response.WriteAsync("MW3");
                    //logger.LogInformation("MW3: Request handled and response produced");
                });
            });             

        }
    }
}

