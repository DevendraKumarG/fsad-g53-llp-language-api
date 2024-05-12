using Llp.Language.DTOs;
using Llp.Language.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Llp.Language.Controllers
{
    [ApiController]
    [Route("languages")]
    public class AssessmentController : ControllerBase
    {
        private readonly IAssessmentService _assessmentService;

        public AssessmentController(IAssessmentService assessmentService)
        {
            _assessmentService = assessmentService;
        }

        [HttpGet("{languageId}/assessments")]
        [Authorize]
        public async Task<IActionResult> GetAssessmentsByLanguageId(int languageId)
        {
            IEnumerable<Models.Assessment> assessments = await _assessmentService.GetAssessmentsByLanguageId(languageId);
            return Ok(assessments);
        }

        [HttpGet("assessments/{assessmentId}")]
        [Authorize]
        public async Task<IActionResult> GetAssessmentById(int assessmentId)
        {
            Models.Assessment assessment = await _assessmentService.GetAssessmentById(assessmentId);
            return Ok(assessment);
        }

        [HttpPost("assessments/{assessmentId}/submit")]
        [Authorize]
        public async Task<IActionResult> SubmitAssessment(int assessmentId, [FromBody] AssessmentResultRequest result)
        {
            await _assessmentService.SubmitAssessment(assessmentId, result);
            return Ok("Result updated successfully");
        }
    }
}
