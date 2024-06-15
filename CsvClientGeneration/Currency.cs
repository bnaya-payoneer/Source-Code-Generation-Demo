using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public readonly record struct Currency
{
    public string Code { get; init; }
    public string Symbol { get; init; }
    public string Name { get; init; }
}
