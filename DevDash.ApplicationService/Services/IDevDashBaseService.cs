using DevDash.Domain.BaseModels;
using System.Linq.Expressions;

namespace DevDash.ApplicationService.Services
{
    public interface IDevDashBaseService<T> where T : DashObject
    {
        Task<IQueryable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<IQueryable<T>> FindAsync(Expression<Func<T,bool>> predicate);
        Task InsertAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
