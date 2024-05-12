using Llp.Language.Models;

namespace Llp.Language.Repositories.Contracts
{
    public interface IAssessmentRepository : IRepositoryBase<Assessment>
    {
        Task<Assessment?> GetAssessmentById(int assessmentId);
        Task<Result?> GetAssessmentResultByUserIdAndAssessmentId(int userId, int assessmentId);
        Task<IEnumerable<Assessment>> GetAssessmentsByLanguage(int languageId);
    }
}
