using System.IO;
using System.Linq;

namespace Bnaya.Samples;

internal sealed class Fellow
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Location[] Locations { get; set; } = Array.Empty<Location>();
}