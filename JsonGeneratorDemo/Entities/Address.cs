using Generator.Equals;

namespace Bnaya.Samples;

// see https://github.com/diegofrata/Generator.Equals

[Equatable]
public partial class Location
{
    public string Type { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public int House { get; set; }
}
