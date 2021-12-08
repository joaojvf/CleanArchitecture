using CleanArchitecture.Application;
using CleanArchitecture.Infrastructure.CrossCutting;
using CleanArchitecture.Infrastructure.CrossCutting.Configuration;
using CleanArchitecture.Infrastructure.CrossCutting.Configuration.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CleanArchitecture.Presentation.Web
{
    public class Startup
    {
        private IApplicationSettings applicationSettings;

        private readonly IConfiguration configuration;

        private readonly IWebHostEnvironment env;

        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            this.configuration = configuration;
            this.env = env;
        }
               

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            this.applicationSettings = this.configuration.Get<ApplicationSettings>();
            services.Configure<ApplicationSettings>(this.configuration);
            services.AddSingleton(this.applicationSettings);

            services.RegisterApplicationServices(configuration);
            services.RegisterInfrastructerServices(configuration);

            services.AddRazorPages();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
