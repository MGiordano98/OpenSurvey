namespace OpenSurvey.Domain.Entities.Survey
{
    public class Survey : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public SurveyQuestion[]? Questions { get; set; }
    }

    public class SurveyQuestion : BaseEntity
    {
        public long SurveyId { get; set; }
        public string Question { get; set; } = string.Empty;
        public SurveyQuestionType Type { get; set; }
        public string[]? Options { get; set; }
    }

    public class SurveyResponse : BaseEntity
    {
        public long SurveyId { get; set; }
        public long SurveyQuestionId { get; set; }
        public long UserId { get; set; }
        public string[]? Answers { get; set; }
    }
}