using Arahk.Evenness.Lib.Domain.Interfaces;

namespace Arahk.Evenness.Lib.Domain.ValueObjects;

public class StateValueObject : IValidate
{
    public string Value { get; private set; }

    public StateValueObject() => Value = string.Empty;

    public StateValueObject(string state) => Value = state;

    public bool IsValid() => !string.IsNullOrEmpty(Value);
}