using Fast.Shared.Time;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Fast.Shared;

internal static class Extensions
{
    public static WebApplicationBuilder AddShared(this WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<IClock, UtcClock>();
        return builder;
    }
    
    public static WebApplication UseShared(this WebApplication app)
    {
        return app;
    }
}