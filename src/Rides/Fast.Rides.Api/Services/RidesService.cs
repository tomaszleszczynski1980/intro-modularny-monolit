using Fast.Customers.Shared;
using Fast.Pricings.Shared;
using Fast.Rides.Api.Commands;
using Fast.Rides.Api.DTO;
using Fast.Rides.Api.Entities;

namespace Fast.Rides.Api.Services;

internal class RidesService
{
    private readonly List<Ride> _rides = new();
    private readonly IDriversModule _driversModule;
    private readonly IPricingModule _pricingModule;

    public RidesService(IDriversModule driversModule, IPricingModule pricingModule)
    {
        _driversModule = driversModule;
        _pricingModule = pricingModule;
    }

    public RideRequestDto Request(RequestRide command)
    {
        var drivers = _driversModule.GetDrivers();
        if (!drivers.Any(x => x.Available))
        {
            throw new InvalidOperationException("No available drivers.");
        }

        var price = _pricingModule.Calculate(command.From, command.To);
        var ride = new Ride
        {
            Id = Guid.NewGuid(),
            From = command.From,
            To = command.To,
            Price = price
        };
        _rides.Add(ride);

        return new RideRequestDto(ride.Id, ride.Price);
    }
}