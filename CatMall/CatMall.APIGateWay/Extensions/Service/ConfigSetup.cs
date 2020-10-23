using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CatMall.APIGateWay.OpenApi.Extensions.Service
{
    public static class ConfigSetup
    {
        public static void AddConfigSetup(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(new ConfigHelper.ConfigHelper(configuration));
        }
    }
}