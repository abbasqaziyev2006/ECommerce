using ECommerce.DAL.DataContext.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;
using System.Threading.Tasks;
namespace ECommerce.BLL.Services.Contracts
{
    public interface ICrudService<TEntity, TViewModel, TCreateViewModel, TUpdateViewModel> where TEntity : Entity
    {
        Task<TViewModel?> GetByIdAsync(int id);

        Task<TViewModel?> GetAsync(
            Expression<Func<TEntity, bool>> predicate,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
            bool asnotracking = false);

        Task<List<TViewModel>> GetAllAsync(
            Expression<Func<TEntity, bool>>? predicate = null,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
            bool asnotracking = false);

        Task<TViewModel> AddAsync(TCreateViewModel entity);

        Task<bool> UpdateAsync(TUpdateViewModel entity);

        Task<bool> DeleteAsync(int id);
    }
}



