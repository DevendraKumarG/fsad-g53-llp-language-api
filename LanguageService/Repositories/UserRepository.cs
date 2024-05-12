using Llp.Language.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Llp.Language.Repositories
{
    public class UserRepository : RepositoryBase<Models.User>, IUserRepository
    {
        public UserRepository(LlpDbContext context, ILogger<LlpDbContext> logger) : base(context, logger)
        {
        }

        public async Task<Models.User> GetUserByEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
