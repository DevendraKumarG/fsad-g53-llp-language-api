
using Llp.Language.Models;

namespace Llp.Language.Services.Contracts
{
    public interface ILanguageService
    {
        Task<LanguageSection> GetSectionById(int sectionId);
        Task<IEnumerable<LanguageSection>> GetSectionsByLanguageId(int languageId);
    }
}
