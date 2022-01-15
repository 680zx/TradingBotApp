﻿using Microsoft.EntityFrameworkCore;
using TradingBotApp.Models;

namespace TradingBotApp.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<MarketTool> MarketTools { get; set; }
    }
}
