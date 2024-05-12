using Llp.Language.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Llp.Language.Controllers
{
    [ApiController]
    [Route("languages")]
    public class LanguageController : ControllerBase
    {
        private readonly ILanguageService _languageService;

        public LanguageController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        [HttpGet("{languageId}/sections")]
        [Authorize]
        public async Task<IActionResult> GetSectionsByLanguageId(int languageId)
        {
            IEnumerable<Models.LanguageSection> sections = await _languageService.GetSectionsByLanguageId(languageId);
            return Ok(sections);
        }

        [HttpGet("sections/{sectionId}")]
        [Authorize]
        public async Task<IActionResult> GetSectionById(int sectionId)
        {
            Models.LanguageSection section = await _languageService.GetSectionById(sectionId);
            return Ok(section);
        }
    }
}
