using BenchmarkDotNet.Running;
using Bnaya.Samples;
using Cocona;
using Microsoft.Extensions.DependencyInjection;

//var builder = CoconaApp.CreateBuilder();
//var services = builder.Services;


Console.WriteLine("Start!");

//var b = new Benchmark();
//b.Default();
//b.Generator();

var summary = BenchmarkRunner.Run<Benchmark>();

Console.WriteLine(summary);
