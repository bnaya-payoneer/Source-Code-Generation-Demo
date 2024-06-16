#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using BenchmarkDotNet.Attributes;
using System.Text.Json;

namespace Bnaya.Samples;

[AllCategoriesFilter("string", "Fellow")]
//[AllCategoriesFilter("string", "Person")]
public class Benchmark : BenchmarkBase
{
    private static readonly Person _person = Person.Default;
    private static readonly Fellow _fellow = Fellow.Default;

    #region Fellow

    [Benchmark]
    [BenchmarkCategory("string", "Fellow")]
    public void FellowGenerator()
    {

        var json = JsonSerializer.Serialize(_fellow, MyJsonContext.Default.Fellow);
        var fellow = JsonSerializer.Deserialize<Fellow>(json, MyJsonContext.Default.Fellow);
        if (!fellow.Equals(_fellow))
            throw new Exception("not equals");
    }

    [Benchmark]
    [BenchmarkCategory("string", "Fellow")]
    public void FellowGeneratorWithOptions()
    {
        var json = JsonSerializer.Serialize(_fellow, MyJsonContext.Default.Options);
        var fellow = JsonSerializer.Deserialize<Fellow>(json, MyJsonContext.Default.Options);
        if (!fellow.Equals(_fellow))
            throw new Exception("not equals");
    }

    [Benchmark(Baseline = true)]
    [BenchmarkCategory("string", "Fellow")]
    public void FellowDefault()
    {
        var json = JsonSerializer.Serialize(_fellow);
        var fellow = JsonSerializer.Deserialize<Fellow>(json);
        if (!fellow.Equals(_fellow))
            throw new Exception("not equals");
    }

    #endregion //  Fellow

    #region Person string

    [Benchmark]
    [BenchmarkCategory("string", "Person")]
    public void Generator()
    {
        var json = JsonSerializer.Serialize(_person, MyJsonContext.Default.Person);
        var person = JsonSerializer.Deserialize<Person>(json, MyJsonContext.Default.Person);
        if (!person.Equals(_person))
            throw new Exception("not equals");
    }

    [Benchmark]
    [BenchmarkCategory("string", "Person")]
    public void GeneratorWithOptions()
    {
        var json = JsonSerializer.Serialize(_person, MyJsonContext.Default.Options);
        var person = JsonSerializer.Deserialize<Person>(json, MyJsonContext.Default.Options);
        if (!person.Equals(_person))
            throw new Exception("not equals");
    }

    [Benchmark(Baseline = true)]
    [BenchmarkCategory("string", "Person")]
    public void Default()
    {
        var json = JsonSerializer.Serialize(_person);
        var person = JsonSerializer.Deserialize<Person>(json);
        if (!person.Equals(_person))
            throw new Exception("not equals");
    }

    #endregion //  Person string

    #region Person byte[]

    [Benchmark]
    [BenchmarkCategory("byte[]", "Person")]
    public void GeneratorBytes()
    {
        var json = JsonSerializer.SerializeToUtf8Bytes(_person, MyJsonContext.Default.Person);
        var person = JsonSerializer.Deserialize<Person>(json, MyJsonContext.Default.Person);
        if (!person.Equals(_person))
            throw new Exception("not equals");
    }

    [BenchmarkCategory("byte[]", "Person")]
    [Benchmark]
    public void GeneratorWithOptionsBytes()
    {
        var json = JsonSerializer.SerializeToUtf8Bytes(_person, MyJsonContext.Default.Options);
        var person = JsonSerializer.Deserialize<Person>(json, MyJsonContext.Default.Options);
        if (!person.Equals(_person))
            throw new Exception("not equals");
    }

    [Benchmark(Baseline = true)]
    [BenchmarkCategory("byte[]", "Person")]
    public void DefaultBytes()
    {
        var json = JsonSerializer.SerializeToUtf8Bytes(_person);
        var person = JsonSerializer.Deserialize<Person>(json);
        if (!person.Equals(_person))
            throw new Exception("not equals");
    }

    #endregion //  Person byte[]
}
