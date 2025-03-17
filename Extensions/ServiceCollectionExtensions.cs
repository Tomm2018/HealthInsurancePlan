using HealthInsuranceApi.Repositories;
using HealthInsuranceApi.Services;

namespace HealthInsuranceApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<InsuranceRepository>();
            services.AddScoped<InsuranceService>();

            return services;
        }
    }

}
