using BenchmarkDotNet.Running;
using Bnaya.Samples;

Console.WriteLine("Start!");

//var b = new Benchmark();
//b.Setup();
//b.SrcGenSerializer();
//b.Default();
//b.Cleanup();

var summary = BenchmarkRunner.Run<Benchmark>();

Console.WriteLine(summary);
