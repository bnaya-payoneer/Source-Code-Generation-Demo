using Generator.Equals;
using System.Collections.Immutable;

namespace Bnaya.Samples;

// see https://github.com/diegofrata/Generator.Equals

[Equatable]
public readonly partial record struct Person(
    int Id,
    string Name,
    DateTimeOffset DateOfBirth)
{
    #region public static Person Default { get;  } = ...

    public static Person Default { get;  } = new Person(10, "Marry", DateTimeOffset.UtcNow.AddYears(-50))
    {
        Addresses = Enumerable.Range(0, 10)
                        .Select(i => new Address($"Type {i}",
                                                 $"Country {i}",
                                                 $"City {i}",
                                                 $"Street {i}",
                                                 i))
                        .ToList()
        //.ToImmutableArray()
    };

    #endregion //  public static Person Default { get;  } = ...

    [OrderedEquality]
    public List<Address> Addresses { get; init; } 
    //public ImmutableArray<Address> Addresses { get; init; }  // Not supported by AutoMapper
}
