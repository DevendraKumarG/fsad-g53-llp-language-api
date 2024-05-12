using Llp.Language.DTOs;
using Llp.Language.Models;

namespace Llp.Language.Services.Contracts
{
    public interface IAssessmentService
    {
        Task<Assessment> GetAssessmentById(int assessmentId);
        Task<IEnumerable<Assessment>> GetAssessmentsByLanguageId(int languageId);
        Task SubmitAssessment(int assessmentId, AssessmentResultRequest result);
    }
}
