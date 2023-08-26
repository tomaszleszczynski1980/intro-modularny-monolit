namespace Fast.Pricings.Shared;

public interface IPricingModule
{
    decimal Calculate(string from, string to);
}