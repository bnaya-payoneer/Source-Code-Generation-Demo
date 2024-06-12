using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Jobs;

namespace Bnaya.Samples;

//[SimpleJob(RuntimeMoniker.Net80)]
[ShortRunJob(RuntimeMoniker.Net80)]
//[IterationCount(6)]
//[WarmupCount(3)]
//[MeanColumn, RankColumn]
//[RankColumn]
[RPlotExporter]
[MemoryDiagnoser]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
[Config(typeof(BenchmarkConfig))]
public abstract class BenchmarkBase
{

}
