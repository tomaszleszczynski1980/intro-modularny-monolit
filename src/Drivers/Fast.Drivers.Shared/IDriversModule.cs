using Fast.Customers.Shared.DTO;
using Fast.Customers.Shared.Events;

namespace Fast.Customers.Shared;

public interface IDriversModule
{
    IEnumerable<DriverDto> GetDrivers();
    event EventHandler<DriverRegistered> DriverRegistered;
}