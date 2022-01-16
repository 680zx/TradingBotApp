﻿using TradingBotApp.DAL.Repositories.Interfaces;
using TradingBotApp.Models;

namespace TradingBotApp.DAL.Implementation
{
    public class FakeMarketToolRepository : ITradingBotAppRepository
    {
        public IQueryable<MarketTool> MarketTools => new List<MarketTool>
        {
            new MarketTool { Name = "FakeTool1", Enabled = true },
            new MarketTool { Name = "FakeTool2", Enabled = true },
            new MarketTool { Name = "FakeTool3", Enabled = true },
            new MarketTool { Name = "FakeTool4", Enabled = true },
        }.AsQueryable();
    }
}