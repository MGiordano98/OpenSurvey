using System.Linq.Expressions;
using OpenSurvey.Domain.Entities;
using OpenSurvey.Domain.Repositories.Interfaces;

namespace OpenSurvey.Infrastructure.Repositories.Implementations
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> List(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}