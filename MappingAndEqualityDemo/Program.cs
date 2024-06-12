using BenchmarkDotNet.Running;
using Bnaya.Samples;

Console.WriteLine("Start!");

//var b = new Benchmark();
//b.Setup();
//b.Generator();
//b.AutoMap();

var summary = BenchmarkRunner.Run<Benchmark>();

Console.WriteLine(summary);
