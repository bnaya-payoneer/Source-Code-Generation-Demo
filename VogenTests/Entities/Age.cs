using Vogen;

namespace Bnaya.Samples;

[ValueObject<int>(Conversions.SystemTextJson | Conversions.TypeConverter, 
                comparison: ComparisonGeneration.UseUnderlying)]
[Instance("Unspecified", -1)]
public readonly partial record struct Age
{
    public static Validation Validate(int value) => value switch
    {
        < 0 => Validation.Invalid("Must be greater than zero."),
        > 120 => Validation.Invalid("Are you kidding."),
        _ => Validation.Ok
    };
}
