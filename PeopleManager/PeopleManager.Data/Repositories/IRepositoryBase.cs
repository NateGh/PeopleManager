using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager.Data.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<T> AddAsync(T entity);
        void Remove(T entity);
        Task<T> GetAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
    }
}
