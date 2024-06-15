using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parser;

namespace Bnaya.Samples;
internal static partial class CurrencyParser
{
    [CSVParser([
                nameof(Currency.Code),
                nameof(Currency.Symbol),
                nameof(Currency.Name)], HasHeader = true)]

    [CSVPTransformer(nameof(Currency.Code), nameof(ToLower))]
    public static partial IEnumerable<Currency> ParseData(ReadOnlySpan<char> data);

    private static string ToLower(ReadOnlySpan<char> data) => data.ToString().ToLower();
}
