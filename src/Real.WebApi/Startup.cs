using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Real.DomainServices.PropertyRepository;
using Real.WebApi.Dependencies;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;


namespace Real.WebApi
{
    public class Startup
    {
        private WebapiInfo WebapiInfo = new WebapiInfo()
        {
            Title = "Real Estate Web Api",
            Version = "v1",
            Description = "Web Api for Real Estate application",
            Url = "v1/swagger.json"
        };

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PropertyContext>(opt => opt.UseInMemoryDatabase("Properties"));
            services.AddControllers();
            services.AddServiceDependency();
            services.AddSwaggerGen(x => x.SwaggerDoc(WebapiInfo.Version, new OpenApiInfo() { Title= WebapiInfo.Title, Version = WebapiInfo.Version, Description = WebapiInfo.Description }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(x => x.SwaggerEndpoint(WebapiInfo.Url, WebapiInfo.Title));
        }
    }

    public class WebapiInfo
    {
        public string Title { get; set; }
        public string Version { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
    }
}
