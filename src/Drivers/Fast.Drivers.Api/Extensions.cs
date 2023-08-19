using Fast.Customers.Api.Commands;
using Fast.Customers.Api.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;

namespace Fast.Customers.Api;

internal static class Extensions
{
    public static IServiceCollection AddDrivers(this IServiceCollection services)
    {
        services.AddSingleton<DriversService>();

        return services;
    }

    public static IEndpointRouteBuilder MapDriversApi(this IEndpointRouteBuilder routeBuilder)
    {
        var api = routeBuilder.MapGroup("drivers");

        api.MapPost("", (RegisterDriver command, DriversService service) =>
        {
            service.Register(command);
            return Results.NoContent();
        });

        return routeBuilder;
    }
}