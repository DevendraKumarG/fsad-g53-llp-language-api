using Llp.Language.Repositories.Contracts;

namespace Llp.Language.Repositories
{
    public class LanguageRepository : RepositoryBase<Models.Language>, ILanguageRepository
    {
        public LanguageRepository(LlpDbContext context, ILogger<LlpDbContext> logger) : base(context, logger)
        {
        }
    }
}
