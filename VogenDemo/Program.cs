﻿using BenchmarkDotNet.Running;
using Bnaya.Samples;

Console.WriteLine("Start!");

//var b = new Benchmark();
//b.Native();
//b.Domain();

var summary = BenchmarkRunner.Run<Benchmark>();

Console.WriteLine(summary);
