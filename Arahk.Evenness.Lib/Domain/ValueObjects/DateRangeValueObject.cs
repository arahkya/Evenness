using Arahk.Evenness.Lib.Domain.Interfaces;

namespace Arahk.Evenness.Lib.Domain.ValueObjects;

public class DateRangeValueObject(DateTimeOffset start, DateTimeOffset end) : IValidate
{
    public DateTimeOffset Start { get; private set; } = start;
    public DateTimeOffset End { get; private set; } = end;

    public bool IsValid() => End != DateTimeOffset.MaxValue && Start != DateTimeOffset.MinValue && End > Start;
}