using Generator.Equals;

namespace Bnaya.Samples;

// see https://github.com/diegofrata/Generator.Equals

[Equatable]
public partial class Location
{
    public string Country { get; set; }
    public string City { get; set; }
}
