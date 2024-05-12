using Llp.Language.Repositories.Contracts;

namespace Llp.Language.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly LlpDbContext _context;
        private readonly ILogger<LlpDbContext> _logger;
        private IResultRepository _resultRepository;
        private IUserRepository _userRepository;
        private ILanguageRepository _languageRepository;
        private IAssessmentRepository _assessmentRepository;
        private ILanguageSectionRepository _languageSectionRepository;
        private IMediaTypeRepository _mediaTypeRepository;

        public RepositoryManager(LlpDbContext context, ILogger<LlpDbContext> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IUserRepository User
        {
            get
            {
                _userRepository ??= new UserRepository(_context, _logger);
                return _userRepository;
            }
        }

        public ILanguageRepository Language
        {
            get
            {
                _languageRepository ??= new LanguageRepository(_context, _logger);
                return _languageRepository;
            }
        }

        public IResultRepository Result
        {
            get
            {
                _resultRepository ??= new ResultRepository(_context, _logger);
                return _resultRepository;
            }
        }

        public IAssessmentRepository Assessment
        {
            get
            {
                _assessmentRepository ??= new AssessmentRepository(_context, _logger);
                return _assessmentRepository;
            }
        }

        public ILanguageSectionRepository LanguageSection
        {
            get
            {
                _languageSectionRepository ??= new LanguageSectionRepository(_context, _logger);
                return _languageSectionRepository;
            }
        }

        public IMediaTypeRepository MediaType
        {
            get
            {
                _mediaTypeRepository ??= new MediaTypeRepository(_context, _logger);
                return _mediaTypeRepository;
            }
        }
    }
}
