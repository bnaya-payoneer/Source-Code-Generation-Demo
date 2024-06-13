using System.Text.Json;
using BenchmarkDotNet.Attributes;

namespace Bnaya.Samples;

public class Benchmark: BenchmarkBase
{
    private MemoryStream _memoryStream;
    private Utf8JsonWriter _jsonWriter;

    private Person1 _person;

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
    public void Default()
    {
        JsonSerializer.Serialize(_jsonWriter, _person);
        _memoryStream.Position = 0;
        _jsonWriter.Reset();
        var person = JsonSerializer.Deserialize<Person1>(_memoryStream);
        _memoryStream.SetLength(0);
    }

    [Benchmark]
    public void SrcGenSerializer()
    {
        JsonSerializer.Serialize(_jsonWriter, _person, MyJsonContext.Default.Person1);
        _memoryStream.Position = 0;
        _jsonWriter.Reset();
        var person = JsonSerializer.Deserialize<Person1>(_memoryStream, MyJsonContext.Default.Person1);
        _memoryStream.SetLength(0);
    }
}
