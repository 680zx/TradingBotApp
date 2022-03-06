namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IUserRepository UserRepository { get; }
        Task SaveAsync();
    }
}
