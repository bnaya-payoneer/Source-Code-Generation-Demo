using BenchmarkDotNet.Running;
using Bnaya.Samples;

Console.WriteLine("Start!");

//var b = new Benchmark();
//b.Default();
//b.Generator();

var summary = BenchmarkRunner.Run<Benchmark>();

Console.WriteLine(summary);
