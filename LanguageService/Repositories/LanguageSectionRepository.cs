using Llp.Language.Models;
using Llp.Language.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Llp.Language.Repositories
{
    public class LanguageSectionRepository : RepositoryBase<Models.LanguageSection>, ILanguageSectionRepository
    {
        public LanguageSectionRepository(LlpDbContext context, ILogger<LlpDbContext> logger) : base(context, logger)
        {
        }

        public async Task<LanguageSection?> GetLanguageSectionById(int sectionId)
        {
            return await _context.LanguageSections
                .Include(ls => ls.Language)
                .Include(ls => ls.MediaType)
                .FirstOrDefaultAsync(ls => ls.SectionId == sectionId);
        }

        public async Task<IEnumerable<LanguageSection>> GetSectionsByLanguage(int languageId)
        {
            return await _context.LanguageSections
                .Include(ls => ls.Language)
                .Include(ls => ls.MediaType)
                .Where(ls => ls.LanguageId == languageId)
                .ToListAsync();
        }
    }
}
