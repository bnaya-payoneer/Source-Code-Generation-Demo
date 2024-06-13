using BenchmarkDotNet.Attributes;
using CommandLine.Text;
using System.Diagnostics.Metrics;
using System;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace Bnaya.Samples;

public class Benchmark : BenchmarkBase
{
    private static readonly string[] _invalidUrls = [
            "htt://invalid-url.com", // (missing 'p' in 'http')
            "http://example..com", // (double dots)
            "http://.example.com", // (leading dot)
            "http:/example.com", // (single forward slash after 'http:')
            "http://example_com", // (underscore in domain name)
        ];
    private static readonly string[] _validUrls = [
            "https://www.google.com",
            "http://example.org",
            "https://subdomain.example.co.uk",
            "http://www.example.com/path/to/page?name=ferret&color=purple",
            "https://example.com/#section"
        ];

    [Benchmark]
    public void Generator()
    {
        foreach (var url in _invalidUrls)
        {
            if (GenUrlValidator.IsValidUrl(url))
                throw new Exception("Invalid url should not match");
        }
        foreach (var url in _validUrls)
        {
            if (!GenUrlValidator.IsValidUrl(url))
                throw new Exception("Valid url should match");
        }
    }

    [Benchmark(Baseline = true)]
    public void Default()
    {
        foreach (var url in _invalidUrls)
        {
            if (ClassicUrlValidator.IsValidUrl(url))
                throw new Exception("Invalid url should not match");
        }
        foreach (var url in _validUrls)
        {
            if (!ClassicUrlValidator.IsValidUrl(url))
                throw new Exception("Valid url should match");
        }
    }
}
