using Fast.Customers.Shared.DTO;

namespace Fast.Customers.Shared;

public interface IDriversModule
{
    IEnumerable<DriverDto> GetDrivers();
}