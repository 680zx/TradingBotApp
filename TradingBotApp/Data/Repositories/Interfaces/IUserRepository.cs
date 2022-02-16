using TradingBotApp.Models;

namespace TradingBotApp.Data.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public IQueryable<User> Users { get; }
    }
}
