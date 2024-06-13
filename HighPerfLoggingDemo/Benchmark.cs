using BenchmarkDotNet.Attributes;
using CommandLine.Text;
using System.Diagnostics.Metrics;
using System;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace Bnaya.Samples;

public class Benchmark : BenchmarkBase
{
    [Benchmark]
    public void Generator()
    {
    }

    [Benchmark(Baseline = true)]
    public void Default()
    {
    }
}
