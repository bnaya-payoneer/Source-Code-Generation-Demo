using System.Text.Json;
using BenchmarkDotNet.Attributes;

namespace Bnaya.Samples;

[AllCategoriesFilter("string")]

public class Benchmark: BenchmarkBase
{
    private MemoryStream _memoryStream;
    private Utf8JsonWriter _jsonWriter;

    private Fellow _person;

    [GlobalSetup]
    public void Setup()
    {
        _memoryStream = new MemoryStream();
        _jsonWriter = new Utf8JsonWriter(_memoryStream);

        _person = DataGenerator.GetPerson();
    }

    [GlobalCleanup]
    public void Cleanup()
    {
        _memoryStream.Dispose();
        _jsonWriter.Dispose();
    }

    [Benchmark(Baseline = true)]
    [BenchmarkCategory("stream")]
    public void Default()
    {
        JsonSerializer.Serialize(_jsonWriter, _person);
        _memoryStream.Position = 0;
        _jsonWriter.Reset();
        var person = JsonSerializer.Deserialize<Fellow>(_memoryStream);
        _memoryStream.SetLength(0);
    }

    [Benchmark]
    [BenchmarkCategory("stream")]
    public void SrcGenSerializer()
    {
        JsonSerializer.Serialize(_jsonWriter, _person, MyJsonContext.Default.Fellow);
        _memoryStream.Position = 0;
        _jsonWriter.Reset();
        var person = JsonSerializer.Deserialize<Fellow>(_memoryStream, MyJsonContext.Default.Fellow);
        _memoryStream.SetLength(0);
    }

    [Benchmark(Baseline = true)]
    [BenchmarkCategory("string")]
    public void DefaultString()
    {
        string json = JsonSerializer.Serialize(_person);
        var person = JsonSerializer.Deserialize<Fellow>(json);
    }

    [Benchmark]
    [BenchmarkCategory("string")]
    public void SrcGenSerializerString()
    {
        string json = JsonSerializer.Serialize(_person, MyJsonContext.Default.Fellow);
        var person = JsonSerializer.Deserialize<Fellow>(json, MyJsonContext.Default.Fellow);
    }
}
