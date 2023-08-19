namespace Fast.Rides.Api.Entities;

internal class Ride
{
    public required Guid Id { get; init; }
    public required string From { get; init; }
    public required string To { get; init; }
    public required decimal Price { get; init; }
    public bool Confirmed { get; set; }
    public string? Driver { get; set; }
}