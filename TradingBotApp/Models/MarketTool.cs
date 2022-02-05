﻿using MarketProcessor.MarketConditionQualifiers.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TradingBotApp.Models
{
    public class MarketTool
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public bool? Enabled { get; set; }

        public int MarketConditionQualifierID { get; set; }

        [NotMapped]
        public IMarketConditionQualifier MarketConditionQualifier { get; set; }
    }
}
