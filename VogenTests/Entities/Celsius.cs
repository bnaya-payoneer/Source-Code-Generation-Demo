using Vogen;

namespace Bnaya.Samples;

[ValueObject(typeof(float))]
[Instance("Freezing", 0)]
[Instance("Boiling", 100)]
public readonly partial struct Celsius
{
    public static Validation Validate(float value) =>
        value >= -273 ? Validation.Ok : Validation.Invalid("Cannot be colder than absolute zero");
}
