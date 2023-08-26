using Fast.Customers.Shared;
using Fast.Customers.Shared.DTO;
using Fast.Customers.Shared.Events;

namespace Fast.Customers.Api.Services;

internal sealed class DriversModule : IDriversModule
{
    private readonly DriversService _driversService;

    public DriversModule(DriversService driversService)
    {
        _driversService = driversService;
    }

    public IEnumerable<DriverDto> GetDrivers()
        => _driversService.Find();

    public event EventHandler<DriverRegistered>? DriverRegistered;
    
    public void PublishDriverRegistered(Guid driverId)
        => DriverRegistered?.Invoke(this, new DriverRegistered(driverId));   
}