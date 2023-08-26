using Fast.Customers.Shared;
using Fast.Customers.Shared.Events;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Fast.Pricings.Api.Services;

internal sealed class EventsHandler : IHostedService
{
    private readonly IDriversModule _driversModule;
    private readonly ILogger<EventsHandler> _logger;

    public EventsHandler(IDriversModule driversModule, ILogger<EventsHandler> logger)
    {
        _driversModule = driversModule;
        _logger = logger;
    }
    
    public Task StartAsync(CancellationToken cancellationToken)
    {
        _driversModule.DriverRegistered += OnDriverRegistered;
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _driversModule.DriverRegistered -= OnDriverRegistered;
        return Task.CompletedTask;
    }
    
    private void OnDriverRegistered(object? sender, DriverRegistered e)
    {
        _logger.LogInformation($"Driver registered: {e.DriverId}");
    }
}