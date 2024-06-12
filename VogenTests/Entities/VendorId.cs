using Bnaya.Samples;
using Vogen;

namespace Bnaya.Samples;

[ValueObject<int>(Conversions.SystemTextJson | Conversions.TypeConverter)]
[Instance("None", -1)]
public partial struct VendorId
{
    public static Validation Validate(int value) =>
        value > 0 ? Validation.Ok : Validation.Invalid("Must be greater than zero.");
}
