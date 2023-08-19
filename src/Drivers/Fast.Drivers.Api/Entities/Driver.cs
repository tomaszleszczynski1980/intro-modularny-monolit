namespace Fast.Customers.Api.Entities;

internal class Driver
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
    public required string Vehicle { get; init; }
    public bool Available { get; set; }
    public decimal Rating { get; set; }
}