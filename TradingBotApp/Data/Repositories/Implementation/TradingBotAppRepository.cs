﻿using MarketProcessor.MarketConditionQualifiers.Interfaces;
using TradingBotApp.Data.Repositories.Interfaces;
using TradingBotApp.Models;

namespace TradingBotApp.Data.Repositories.Implementation
{
    public class TradingBotAppRepository : ITradingBotAppRepository
    {
        private AppDbContext _dbContext;

        public TradingBotAppRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<MarketTool> MarketTools => _dbContext.MarketTools;

        public IQueryable<MarketQualifier> MarketQualifiers => _dbContext.MarketQualifiers;
    }
}
