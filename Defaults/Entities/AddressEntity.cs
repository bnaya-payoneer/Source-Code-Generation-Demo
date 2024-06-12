using Generator.Equals;

namespace Bnaya.Samples;

// see https://github.com/diegofrata/Generator.Equals

[Equatable]
public partial struct AddressEntity
{
    public AddressEntity()
    {
        Type = string.Empty;
        Country = string.Empty;
        City = string.Empty;
        Street = string.Empty;
    }

    public AddressEntity(
        string type,
        string country,
        string city,
        string street,
        int house)
    {
        Type = type;
        Country = country;
        City = city;
        Street = street;
        House = house;
    }

    public string Type { get; init; }
    public string Country { get; init; }
    public string City { get; init; }
    public string Street { get; init; }
    public int House { get; init; }
}
