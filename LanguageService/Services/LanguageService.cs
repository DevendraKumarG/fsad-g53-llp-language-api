using Llp.Language.Middleware;
using Llp.Language.Models;
using Llp.Language.Repositories.Contracts;
using Llp.Language.Services.Contracts;

namespace Llp.Language.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly ILogger<LanguageService> _logger;
        private readonly IRepositoryManager _repositoryManager;
        private readonly IConfiguration _configuration;

        public LanguageService(ILogger<LanguageService> logger, IRepositoryManager repositoryManager, IConfiguration configuration)
        {
            _logger = logger;
            _repositoryManager = repositoryManager;
            _configuration = configuration;
        }

        public async Task<LanguageSection> GetSectionById(int sectionId)
        {
            LanguageSection? section = await _repositoryManager.LanguageSection.GetLanguageSectionById(sectionId);
            return section == null ? throw new NotFoundException($"Section with id {sectionId} not found") : section;
        }

        public async Task<IEnumerable<LanguageSection>> GetSectionsByLanguageId(int languageId)
        {
            IEnumerable<LanguageSection> sections = await _repositoryManager.LanguageSection.GetSectionsByLanguage(languageId);
            return sections;
        }
    }
}
