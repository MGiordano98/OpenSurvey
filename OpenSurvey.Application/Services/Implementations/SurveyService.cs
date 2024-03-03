using OpenSurvey.Domain.Entities.Survey;
using OpenSurvey.Domain.Services.Interfaces;


namespace OpenSurvey.Application.Services.Implementations
{
    public class SurveyServices : ISurveyService
    {
        public SurveyServices ()
        {
            // Add your code here
        }

        public Task<Survey> CreateSurveyAsync(Survey survey)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSurveyAsync(long surveyId)
        {
            throw new NotImplementedException();
        }

        public Task<Survey> GetSurveyAsync(long surveyId)
        {
            throw new NotImplementedException();
        }

        public Task<SurveyResponse[]> GetSurveyResponsesAsync(long surveyId)
        {
            throw new NotImplementedException();
        }

        public Task<SurveyResponse> SubmitSurveyResponseAsync(SurveyResponse surveyResponse)
        {
            throw new NotImplementedException();
        }

        public Task<Survey> UpdateSurveyAsync(Survey survey)
        {
            throw new NotImplementedException();
        }
    }
}