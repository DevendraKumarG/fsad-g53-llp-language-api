using Llp.Language.Models;
using Llp.Language.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Llp.Language.Repositories
{
    public class AssessmentRepository : RepositoryBase<Models.Assessment>, IAssessmentRepository
    {
        public AssessmentRepository(LlpDbContext context, ILogger<LlpDbContext> logger) : base(context, logger)
        {
        }

        public async Task<Assessment?> GetAssessmentById(int assessmentId)
        {
            return await _context.Assessments
                .Include(a => a.Language)
                .Include(a => a.MediaType)
                .FirstOrDefaultAsync(a => a.AssessmentId == assessmentId);
        }

        public async Task<Result?> GetAssessmentResultByUserIdAndAssessmentId(int userId, int assessmentId)
        {
            return await _context.Results
                .FirstOrDefaultAsync(r => r.UserId == userId && r.AssessmentId == assessmentId);
        }

        public async Task<IEnumerable<Assessment>> GetAssessmentsByLanguage(int languageId)
        {
            return await _context.Assessments
                .Include(a => a.Language)
                .Include(a => a.MediaType)
                .Where(a => a.LanguageId == languageId)
                .ToListAsync();
        }
    }
}
