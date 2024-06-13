using System.Text.RegularExpressions;

namespace Bnaya.Samples;

public static partial class ClassicUrlValidator
{
    private const string REGEX_EXPRESSION = @"^(https?:\/\/)?([a-zA-Z0-9-]+\.)*[a-zA-Z0-9-]+\.[a-zA-Z]{2,}(\/.*)?$";

    private static readonly RegexOptions OPTIONS =  RegexOptions.Compiled | RegexOptions.CultureInvariant;

    private static Regex UrlRegex = new Regex(REGEX_EXPRESSION, OPTIONS, TimeSpan.FromSeconds(1));
    public static bool IsValidUrl(string url) => UrlRegex.IsMatch(url);
}
