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
        Locations = Enumerable.Range(0, 10)
                        .Select(i => new Location
                        {
                            Type = $"Type {i}",
                            Country = $"Country {i}",
                            City = $"City {i}",
                            Street = $"Street {i}",
                            House = i
                        })
                        .ToList()
    };

    #endregion //  public static Fellow Default { get;  } = ...

    public int Id { get; set; }
    public string Name { get; set; }
    public DateTimeOffset DateOfBirth { get; set; }

    [OrderedEquality]
    public List<Location> Locations { get; set; }
}
