using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;

namespace Bnaya.Samples;

public class BenchmarkConfig : ManualConfig
    {
        public BenchmarkConfig()
        {
            //AddColumn(
            //    StatisticColumn.P95);

            HideColumns(
                StatisticColumn.StdDev,
                BaselineRatioColumn.RatioStdDev,
                StatisticColumn.Error);
        }
    }
