using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using TradingBotApp.Models;

namespace TradingBotApp.Data.Configuration
{
    public class MarketToolConfiguration : IEntityTypeConfiguration<MarketTool>
    {
        public void Configure(EntityTypeBuilder<MarketTool> builder)
        {
            builder.Property(i => i.MarketConditionQualifier).HasConversion(
                v => JsonConvert.SerializeObject(v, new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.Auto
                }),
                v => (MarketProcessor.MarketConditionQualifiers.Interfaces.IMarketConditionQualifier)JsonConvert.DeserializeObject(v, new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.Auto
                }));
        }
    }
}
