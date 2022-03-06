using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await FindAll()
                .OrderBy(i => i.Id)
                .ToListAsync();
        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            return await FindByCondition(i => i.Id.Equals(id))
                .FirstOrDefaultAsync();
        }
    }
}
