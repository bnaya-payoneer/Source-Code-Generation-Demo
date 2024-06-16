// See https://aka.ms/new-console-template for more information
using Bnaya.CodeGeneration.BuilderPatternGeneration;

namespace Bnaya.Samples;

[GenerateBuilderPattern]
public partial record Person(int Id, string Name)
{
    public required string Email { get; init; }
    public DateTime Birthday { get; init; }
}

