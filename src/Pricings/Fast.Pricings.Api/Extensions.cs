using Fast.Pricings.Api.Services;
using Fast.Pricings.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace Fast.Pricings.Api;

internal static class Extensions
{
    public static IServiceCollection AddPricings(this IServiceCollection services)
    {
        services.AddSingleton<PricingEngine>();
        services.AddSingleton<IPricingModule, PricingModule>();
        
        return services;
    }
}