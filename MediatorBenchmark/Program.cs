using BenchmarkDotNet.Running;
using Bnaya.Samples;

Console.WriteLine("Start!");

//var b = new Benchmark();
//b.Setup();
//await b.Mediator();
//await b.MediatR();

var summary = BenchmarkRunner.Run<Benchmark>();

Console.WriteLine(summary);
