using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bnaya.Samples;

public static partial class GenUrlValidator
{
    [GeneratedRegex(
        @"^(https?:\/\/)?([a-zA-Z0-9-]+\.)*[a-zA-Z0-9-]+\.[a-zA-Z]{2,}(\/.*)?$",
        RegexOptions.Compiled | RegexOptions.CultureInvariant,
        matchTimeoutMilliseconds: 1000)]
    private static partial Regex MatchIfValidUrl();
    public static bool IsValidUrl(string url) => MatchIfValidUrl().IsMatch(url);
}
