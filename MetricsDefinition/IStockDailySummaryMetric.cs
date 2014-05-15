﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StockAnalysis.Share;

namespace MetricsDefinition
{
    interface IStockDailySummaryMetric : IMetric
    {
        IEnumerable<double> Calculate(IEnumerable<StockDailySummary> input);
    }
}
