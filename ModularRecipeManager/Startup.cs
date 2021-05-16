using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace ModularRecipeManager
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        private ServerVersion ServerVersion { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

            ServerVersion = new MariaDbServerVersion(new Version(10, 5, 0));
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContextPool<RecipeManagerDBContext>(
                dbContextOptions => dbContextOptions
                    .UseMySql(Configuration.GetConnectionString("mrm-recipes"), ServerVersion)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors() //TODO: remove for production
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}