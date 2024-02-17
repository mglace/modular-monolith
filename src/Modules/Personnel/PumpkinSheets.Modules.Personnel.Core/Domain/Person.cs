using PumpkinSheets.Abstractions.Entities;

namespace PumpkinSheets.Modules.Personnel.Core.Domain;

public class Person : EntityBase
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private Person() : base(Guid.Empty) { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    public Person(Guid id, string name) : base(id)
    {
        Name = name;
    }

    public string Name { get; private set; }
}
