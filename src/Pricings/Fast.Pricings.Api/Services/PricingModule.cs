using Fast.Pricings.Api.Commands;
using Fast.Pricings.Shared;
using Fast.Shared.Time;

namespace Fast.Pricings.Api.Services;

internal class PricingModule : IPricingModule
{
    private readonly PricingEngine _engine;
    private readonly IClock _clock;

    public PricingModule(PricingEngine engine, IClock clock)
    {
        _engine = engine;
        _clock = clock;
    }

    public decimal Calculate(string from, string to)
        => _engine.Calculate(new CalculatePricing(from, to, _clock.Current()));
}