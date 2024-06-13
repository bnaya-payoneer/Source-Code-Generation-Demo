using Vogen;

namespace Bnaya.Samples;

[ValueObject<int>(
            Conversions.SystemTextJson | Conversions.TypeConverter,
            toPrimitiveCasting: CastOperator.Implicit,
            fromPrimitiveCasting: CastOperator.Implicit)]
[Instance("Unspecified", -1)]
public partial struct AccountId
{
    public static Validation Validate(int value) =>
        value > 0 ? Validation.Ok : Validation.Invalid("Must be greater than zero.");
}
