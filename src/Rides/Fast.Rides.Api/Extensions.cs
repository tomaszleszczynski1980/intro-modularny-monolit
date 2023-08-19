using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace Fast.Rides.Api;

internal static class Extensions
{
    public static IServiceCollection AddRides(this IServiceCollection services)
    {
        return services;
    }

    public static IEndpointRouteBuilder MapRidesApi(this IEndpointRouteBuilder routeBuilder)
    {
        return routeBuilder;
    }
}