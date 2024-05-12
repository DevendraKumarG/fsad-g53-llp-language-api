using Llp.Language.DTOs;
using Llp.Language.Middleware;
using Llp.Language.Models;
using Llp.Language.Repositories.Contracts;
using Llp.Language.Services.Contracts;

namespace Llp.Language.Services
{
    public class AssessmentService : IAssessmentService
    {
        private readonly ILogger<AssessmentService> _logger;
        private readonly IRepositoryManager _repositoryManager;
        private readonly IConfiguration _configuration;

        public AssessmentService(ILogger<AssessmentService> logger, IRepositoryManager repositoryManager, IConfiguration configuration)
        {
            _logger = logger;
            _repositoryManager = repositoryManager;
            _configuration = configuration;
        }

        public async Task<Assessment> GetAssessmentById(int assessmentId)
        {
            Assessment? assessment = await _repositoryManager.Assessment.GetAssessmentById(assessmentId);
            return assessment ?? throw new NotFoundException($"Assessment with id {assessmentId} not found");
        }

        public async Task<IEnumerable<Assessment>> GetAssessmentsByLanguageId(int languageId)
        {
            IEnumerable<Assessment> assessments = await _repositoryManager.Assessment.GetAssessmentsByLanguage(languageId);
            return assessments;
        }

        public async Task SubmitAssessment(int assessmentId, AssessmentResultRequest result)
        {
            // Check if the result record already exists in the database
            Result? existingResult = await _repositoryManager.Assessment.GetAssessmentResultByUserIdAndAssessmentId(result.UserId, assessmentId);

            if (existingResult != null)
            {
                // Update the existing result record
                existingResult.Score = result.Score;
                existingResult.AttemptsCount = result.AttemptsCount;

                await _repositoryManager.Result.UpdateAsync(existingResult);
            }
            else
            {
                // Create a new result record
                Result newResult = new()
                {
                    UserId = result.UserId,
                    AssessmentId = assessmentId,
                    Score = result.Score,
                    AttemptsCount = result.AttemptsCount
                };

                await _repositoryManager.Result.AddAsync(newResult);
            }
        }
    }
}
