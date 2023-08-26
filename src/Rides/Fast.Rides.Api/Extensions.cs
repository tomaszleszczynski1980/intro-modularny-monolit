using Fast.Rides.Api.Commands;
using Fast.Rides.Api.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace Fast.Rides.Api;

internal static class Extensions
{
    public static IServiceCollection AddRides(this IServiceCollection services)
    {
        services.AddSingleton<RidesService>();
        
        return services;
    }

    public static IEndpointRouteBuilder MapRidesApi(this IEndpointRouteBuilder routeBuilder)
    {
        var api = routeBuilder.MapGroup("rides");

        api.MapPost("", (RequestRide command, RidesService service) =>
        {
            var request = service.Request(command);
            return Results.Ok(request);
        });
        
        return routeBuilder;
    }
}