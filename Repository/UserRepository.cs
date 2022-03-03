using Entities;
using Entities.Models;

namespace Repository
{
    public class UserRepository : RepositoryBase<User>
    {
        public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}
