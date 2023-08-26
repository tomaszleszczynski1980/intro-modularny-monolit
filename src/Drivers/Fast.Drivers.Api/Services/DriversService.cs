using Fast.Customers.Api.Commands;
using Fast.Customers.Api.Entities;
using Fast.Customers.Shared.DTO;

namespace Fast.Customers.Api.Services;

internal class DriversService
{
    // TODO: Should be an actual DB
    private readonly List<Driver> _drivers = new();

    public Guid Register(RegisterDriver command)
    {
        // TODO: implement the application logic
        var driver = new Driver
        {
            Id = Guid.NewGuid(),
            Name = command.Name,
            Vehicle = command.Vehicle,
            Rating = 5,
            Available = true
        };
        _drivers.Add(driver);
        return driver.Id;
    }

    public IEnumerable<DriverDto> Find(string? vehicle = default)
    {
        var drivers = _drivers.AsEnumerable();
        if (!string.IsNullOrWhiteSpace(vehicle))
        {
            drivers = drivers.Where(x => x.Vehicle == vehicle);
        }

        return drivers.Select(x => new DriverDto(x.Name, x.Vehicle, x.Available));
    }
}