using Fast.Pricings.Api.Commands;

namespace Fast.Pricings.Api.Services;

internal class PricingEngine
{
    private readonly Random _random = new();
    
    public decimal Calculate(CalculatePricing command)
    {
        // TODO: Implement sophisticated dynamic pricing
        var pricing = _random.Next(10, 100);

        return pricing;
    }
}