using BenchmarkDotNet.Running;
using Bnaya.Samples;

Console.WriteLine("Start!");

//var b = new Benchmark();
//b.FellowDefault();
//b.FellowGenerator();
//b.FellowGeneratorWithOptions();
//b.Generator();
//b.GeneratorWithOptions();
//b.Default();

var summary = BenchmarkRunner.Run<Benchmark>();

Console.WriteLine(summary);
