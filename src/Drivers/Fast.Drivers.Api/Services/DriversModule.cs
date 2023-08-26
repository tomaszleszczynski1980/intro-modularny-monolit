using Fast.Customers.Shared;
using Fast.Customers.Shared.DTO;

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
}