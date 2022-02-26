using TradingBotApp.Models;

namespace TradingBotApp.Data.Repositories.Implementation
{
    public class UserRepository
    {
        private DataContext _dbContext;

        public UserRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<User> Users => _dbContext.Users;
    }
}
