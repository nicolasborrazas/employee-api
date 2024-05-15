using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EmployeeApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method configures the services the application will use.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add the controllers service.
            services.AddControllers();
        }

        // This method configures the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configure for development environment, errors, etc.
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Configure routing, controllers, etc.
            app.UseRouting();

            // Configure API endpoints.
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
