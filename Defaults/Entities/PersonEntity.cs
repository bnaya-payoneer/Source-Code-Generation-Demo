using Generator.Equals;

namespace Bnaya.Samples;

// see https://github.com/diegofrata/Generator.Equals

[Equatable]
public partial class PersonEntity
{
    public PersonEntity(
        int id,
        string name,
        DateTimeOffset dateOfBirth)
    {
        Id = id;
        Name = name;
        DateOfBirth = dateOfBirth;
    }

    public int Id { get; init; }
    public string Name { get; init; }
    public DateTimeOffset DateOfBirth { get; init; }

    [OrderedEquality]
    public List<Address> Addresses { get; init; }
    //public ImmutableArray<Address> Addresses { get; init; }  // Not supported by AutoMapper
}
