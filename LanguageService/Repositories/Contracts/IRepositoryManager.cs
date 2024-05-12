namespace Llp.Language.Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IUserRepository User { get; }
        ILanguageRepository Language { get; }
        IResultRepository Result { get; }
        IAssessmentRepository Assessment { get; }
        ILanguageSectionRepository LanguageSection { get; }
        IMediaTypeRepository MediaType { get; }
    }
}
