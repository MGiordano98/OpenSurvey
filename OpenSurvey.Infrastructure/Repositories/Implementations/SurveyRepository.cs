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
    public class SurveyRepository : ISurveyRepository
    {
        public SurveyRepository() { }

        public void Add(Survey entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Survey entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Survey entity)
        {
            throw new NotImplementedException();
        }

        public Survey GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Survey> List()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Survey> List(Expression<Func<Survey, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
