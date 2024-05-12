using Llp.Language.Models;

namespace Llp.Language.Repositories.Contracts
{
    public interface ILanguageSectionRepository : IRepositoryBase<LanguageSection>
    {
        Task<IEnumerable<LanguageSection>> GetSectionsByLanguage(int languageId);
        Task<LanguageSection?> GetLanguageSectionById(int sectionId);
    }
}
