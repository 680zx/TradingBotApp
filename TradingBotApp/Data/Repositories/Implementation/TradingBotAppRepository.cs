using TradingBotApp.Data.Repositories.Interfaces;
using TradingBotApp.Models;

namespace TradingBotApp.Data.Repositories.Implementation
{
    public class TradingBotAppRepository : ITradingBotAppRepository
    {
        private DataContext _dbContext;

        public TradingBotAppRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<User> Users => _dbContext.Users;
        public IQueryable<RamvQualifierTool> RamvQualifiers  => _dbContext.RamvQualifiers;
    }
}
