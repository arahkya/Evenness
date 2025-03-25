using Arahk.Evenness.Lib.Domain.Interfaces;

namespace Arahk.Evenness.Lib.Domain.ValueObjects;

public class IdValueObject : IValidate
{
    public Guid Value { get; private set; } = Guid.Empty;

    public bool IsValid() => Guid.Empty != Value;

    public void GenerateId()
    {
        Value = Guid.CreateVersion7();
    }
}