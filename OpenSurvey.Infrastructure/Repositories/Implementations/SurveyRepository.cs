using OpenSurvey.Domain.Entities.Survey;
using OpenSurvey.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OpenSurvey.Infrastructure.Repositories.Implementations
{
    public class SurveyRepository : Repository<Survey>, ISurveyRepository
    {
        public SurveyRepository() { }
    }
}
