namespace Llp.Language.DTOs
{
    public class AssessmentResultRequest
    {
        public required int UserId { get; set; }
        public required int AssessmentId { get; set; }
        public int AttemptsCount { get; set; }
        public int Score { get; set; }
    }
}
