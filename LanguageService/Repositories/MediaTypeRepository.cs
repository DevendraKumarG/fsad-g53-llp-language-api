using Llp.Language.Repositories.Contracts;

namespace Llp.Language.Repositories
{
    public class MediaTypeRepository : RepositoryBase<Models.MediaType>, IMediaTypeRepository
    {
        public MediaTypeRepository(LlpDbContext context, ILogger<LlpDbContext> logger) : base(context, logger)
        {
        }
    }
}
