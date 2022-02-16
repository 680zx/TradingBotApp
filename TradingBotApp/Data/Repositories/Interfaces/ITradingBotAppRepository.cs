using TradingBotApp.Models;

namespace TradingBotApp.Data.Repositories.Interfaces
{
    public interface ITradingBotAppRepository
    {
        public IQueryable<User> Users { get; }
        public IQueryable<RamvQualifierTool> RamvQualifiers { get; }
    }
}
