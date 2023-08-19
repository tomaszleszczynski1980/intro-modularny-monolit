using Fast.Pricings.Api.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Fast.Pricings.Api;

internal static class Extensions
{
    public static IServiceCollection AddPricings(this IServiceCollection services)
    {
        services.AddSingleton<PricingEngine>();
        
        return services;
    }
}