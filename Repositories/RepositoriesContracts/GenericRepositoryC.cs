using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Projet.Repositories.RepositoriesContracts
{
    public interface GenericRepositoryC<T> where T : class
    {
        Task<T> GetByIdAsync(long id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);

        Task<IEnumerable<T>> FindAsync(
            Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null
            );

    }
}
