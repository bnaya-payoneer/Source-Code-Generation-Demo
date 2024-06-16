#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using BenchmarkDotNet.Attributes;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using System.Net.Http.Json;

namespace Bnaya.Samples;

//[IterationCount(6)]
//[WarmupCount(1)]
public class Benchmark: BenchmarkBase
{
    private HttpClient _mediatRHttpClient;
    private HttpClient _mediatorHttpClient;

    [GlobalSetup]
    public void Setup()
    {
        var factoryMediatR = new WebApplicationFactory<Bnaya.MediatRSamples.Program>();
        _mediatRHttpClient = factoryMediatR.CreateClient();
        var factoryMediator = new WebApplicationFactory<Bnaya.MediatorSamples.Program>();
        _mediatorHttpClient = factoryMediatR.CreateClient();
    }

    //[GlobalCleanup]
    //public void Cleanup()
    //{
    //}

    [Benchmark(Baseline = true)]
    public async Task MediatR()
    {
        var request = new MediatorSamples.DemoRequest { Id = 1, Amount = 2, Price = 49, ProductName = "test" };
        var response = await _mediatRHttpClient.PostAsJsonAsync("/demo", request);
        if(!response.IsSuccessStatusCode)
            throw new Exception("not successful");
        var data = await response.Content.ReadFromJsonAsync<MediatorSamples.DemoResponse>();
        if(data.Id != request.Id)
            throw new 
                Exception("not equals");
    }

    [Benchmark]
    public async Task Mediator()
    {
        var request = new MediatorSamples.DemoRequest { Id = 1, Amount = 2, Price = 49, ProductName = "test" };
        var response = await _mediatorHttpClient.PostAsJsonAsync("/demo", request);
        if (!response.IsSuccessStatusCode)
            throw new Exception("not successful");
        var data = await response.Content.ReadFromJsonAsync<MediatorSamples.DemoResponse>();
        if (data.Id != request.Id)
            throw new Exception("not equals");
    }

}
