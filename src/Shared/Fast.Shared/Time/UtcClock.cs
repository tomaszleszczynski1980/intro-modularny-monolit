namespace Fast.Shared.Time;

internal sealed class UtcClock : IClock
{
    public DateTime Current() => DateTime.UtcNow;
}