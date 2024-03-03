using Microsoft.Extensions.DependencyInjection;
using OpenSurvey.Domain.Repositories.Interfaces;
using OpenSurvey.Infrastructure.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenSurvey.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ISurveyRepository, SurveyRepository>();

            return services;
        }
    }
}
