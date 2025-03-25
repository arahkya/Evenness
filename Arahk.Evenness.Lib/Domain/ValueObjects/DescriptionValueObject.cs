using Arahk.Evenness.Lib.Domain.Interfaces;

namespace Arahk.Evenness.Lib.Domain.ValueObjects;

public class DescriptionValueObject(string value) : IValidate
{
    public string Value { get; private set; } = value;

    public bool IsValid() => !string.IsNullOrEmpty(Value) && Value.Trim().Length <= 500;
}