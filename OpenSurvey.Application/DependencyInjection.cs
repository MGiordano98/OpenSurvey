using Microsoft.Extensions.DependencyInjection;
using OpenSurvey.Application.Services.Implementations;
using OpenSurvey.Domain.Services.Interfaces;

namespace OpenSurvey.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            // Add your services here
            services.AddScoped<ISurveyService, SurveyServices>();

            return services;
        }
    }
}