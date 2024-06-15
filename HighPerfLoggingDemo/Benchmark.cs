using BenchmarkDotNet.Attributes;
using Bnaya.Samples;
using FakeItEasy;
using Microsoft.Extensions.Logging;

namespace Bnaya.Samples;

public class Benchmark : BenchmarkBase
{
    private readonly ILogger _logger = A.Fake<ILogger>();
    private readonly Metadata _metadata = new Metadata { Env = "Test", Shard = "AAA" };


    [Benchmark]
    public void Generator()
    {
        _logger.DoneSomething("some-action", _metadata);
    }

    [Benchmark(Baseline = true)]
    public void Default()
    {
        _logger.LogInformation("Done Something: {action} {metadata}", "some-action", _metadata);
    }
}
