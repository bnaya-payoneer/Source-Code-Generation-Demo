using Generator.Equals;

namespace Bnaya.Samples;

// see https://github.com/diegofrata/Generator.Equals

[Equatable]
public partial class Fellow
{
    #region public static Fellow Default { get;  } = ...

    public static Fellow Default { get; } = new Fellow
    { 
        Id = 10,
        Name = "Marry",
        DateOfBirth = DateTimeOffset.UtcNow.AddYears(-50),
        Addresses = Enumerable.Range(0, 10)
                        .Select(i => new Address($"Type {i}",
                                                 $"Country {i}",
                                                 $"City {i}",
                                                 $"Street {i}",
                                                 i))
                        .ToList()
    };

    #endregion //  public static Fellow Default { get;  } = ...

    public int Id { get; set; }
    public string Name { get; set; }
    public DateTimeOffset DateOfBirth { get; set; }

    [OrderedEquality]
    public List<Address> Addresses { get; init; }
}
