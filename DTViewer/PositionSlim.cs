﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TradingStrategy;

namespace DTViewer
{
    internal sealed class PositionSlim
    {
        public string Code { get; private set; }

        public DateTime BuyTime { get; private set; }

        public DateTime SellTime { get; private set; }

        public int Volume { get; private set; }

        public double BuyPrice { get; private set; }

        public double SellPrice { get; private set; }

        public double Gain { get; private set; }

        public double R { get; private set; }

        public string Annotation { get; private set; }

        public PositionSlim(Position position)
        {
            Code = position.Code;
            BuyTime = position.BuyTime;
            SellTime = position.SellTime;
            Volume = position.Volume;
            BuyPrice = position.BuyPrice;
            SellPrice = position.SellPrice;
            Gain = Volume * (SellPrice - BuyPrice);
            R = Gain / position.InitialRisk;
            
            StringBuilder builder = new StringBuilder();
                
            builder.AppendFormat("Buy Action: {0}", position.BuyAction);
            builder.AppendLine();
            builder.AppendFormat("Sell Action: {0}", position.SellAction);
            builder.AppendLine();
            builder.AppendFormat("Buy Commission: {0:0.000}", position.BuyCommission);
            builder.AppendLine();
            builder.AppendFormat("Sell Commission: {0:0.000}", position.SellCommission);
            builder.AppendLine();
            builder.AppendFormat("Initial Risk: {0:0.000}", position.InitialRisk);
            builder.AppendLine();
            builder.AppendFormat("Stoploss Price: {0:0.000}", position.StopLossPrice);
            builder.AppendLine();
            builder.AppendLine(position.Comments);
            
            Annotation = builder.ToString();
        }
    }
}
