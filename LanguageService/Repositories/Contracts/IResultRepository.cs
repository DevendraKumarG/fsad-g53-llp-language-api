using Llp.Language.Models;

namespace Llp.Language.Repositories.Contracts
{
    public interface IResultRepository : IRepositoryBase<Result>
    {
        Task<IEnumerable<Result>> GetResultsByUserId(int userId);
    }
}
