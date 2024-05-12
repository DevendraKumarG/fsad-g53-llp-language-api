using Llp.Language.Models;

namespace Llp.Language.Repositories.Contracts
{
    public interface IUserRepository : IRepositoryBase<Models.User>
    {
        Task<Models.User> GetUserByEmail(string email);
    }
}
