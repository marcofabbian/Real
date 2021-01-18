using Microsoft.Extensions.DependencyInjection;
using Real.DomainServices;
using Real.DomainServices.PropertyRepository;

namespace Real.WebApi.Dependencies
{
    public static class ServicesDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddTransient<IPropertyRepository, PropertyRepository>();
        }
    }
}