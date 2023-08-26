using Fast.Rides.Api.Commands;
using Fast.Rides.Api.Entities;

namespace Fast.Rides.Api.Services;

internal class RidesService
{
    private readonly List<Ride> _rides = new();

    public void Request(RequestRide command)
    {
        var ride = new Ride
        {
            Id = Guid.NewGuid(),
            From = command.From,
            To = command.To,
            Price = 0
        };
        _rides.Add(ride);
    }
}