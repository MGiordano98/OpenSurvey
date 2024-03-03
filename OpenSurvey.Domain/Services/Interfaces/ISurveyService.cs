using OpenSurvey.Domain.Entities.Survey;

namespace OpenSurvey.Domain.Services.Interfaces
{
    public interface ISurveyService
    {
        Task<Survey> CreateSurveyAsync(Survey survey);
        Task<Survey> GetSurveyAsync(long surveyId);
        Task<Survey> UpdateSurveyAsync(Survey survey);
        Task DeleteSurveyAsync(long surveyId);
        Task<SurveyResponse> SubmitSurveyResponseAsync(SurveyResponse surveyResponse);
        Task<SurveyResponse[]> GetSurveyResponsesAsync(long surveyId);
    }
}