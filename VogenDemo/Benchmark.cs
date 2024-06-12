using BenchmarkDotNet.Attributes;

namespace Bnaya.Samples;

[AnyCategoriesFilter("Runnable")]
public class Benchmark : BenchmarkBase
{
    [Benchmark(Baseline = true)]
    [BenchmarkCategory("Runnable")]
    public void Native()
    {
        int i = 10;
        int j = 10;
        if (i != j)
            throw new Exception("not equals");
    }

    [Benchmark]
    [BenchmarkCategory("Runnable")]
    public void Domain()
    {
        var i = AccountId.From(10);
        var j = AccountId.From(10);
        if (i != j)
            throw new Exception("not equals");
    }

    [Benchmark]
    [BenchmarkCategory("Runnable")]
    public void DomainMix()
    {
        var i = AccountId.From(10);
        int j = (int)AccountId.From(10);
        if (i != j)
            throw new Exception("not equals");
    }

}
