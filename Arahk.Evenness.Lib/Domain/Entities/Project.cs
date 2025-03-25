
using Arahk.Evenness.Lib.Domain.ValueObjects;

namespace Arahk.Evenness.Lib.Domain.Entities;

public class Project
{
    public IdValueObject Id { get; set; } = default!;
    public string Name { get; set; } = string.Empty;
    public DescriptionValueObject Description { get; set; } = default!;
    public DateRangeValueObject Duration { get; set; } = default!;
    public StateValueObject State { get; set; } = default!;
    public bool IsValid()
    {
        return Name.Trim().Length <= 20 && Description.IsValid();
    }
}
