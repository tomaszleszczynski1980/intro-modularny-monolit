using Fast.Customers.Api;
using Fast.Pricings.Api;
using Fast.Rides.Api;
using Fast.Shared;

var builder = WebApplication.CreateBuilder(args);
builder
    .AddShared()
    .Services
    .AddDrivers()
    .AddPricings()
    .AddRides();

var app = builder.Build();
app.UseShared();
app.MapGet("/", () => "Fast API");
app.MapDriversApi();
app.MapRidesApi();
app.Run();
