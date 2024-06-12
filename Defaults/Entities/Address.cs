using Generator.Equals;

namespace Bnaya.Samples;

// see https://github.com/diegofrata/Generator.Equals

[Equatable]
public readonly partial record struct Address(
    string Type,
    string Country,
    string City,
    string Street,
    int House);
