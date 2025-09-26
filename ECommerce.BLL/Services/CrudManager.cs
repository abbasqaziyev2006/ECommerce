using AutoMapper;
using ECommerce.BLL.Services.Contracts;
using ECommerce.DAL.DataContext.Entities;
using ECommerce.DAL.Repositories.Contracts;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Petshop.BLL.Services;

public class CrudManager<TEntity, TViewModel, TCreateViewModel, TUpdateViewModel> : ICrudService<TEntity, TViewModel, TCreateViewModel, TUpdateViewModel>
where TEntity : Entity
{
    internal readonly IRepository<TEntity> Repository;
    private readonly IMapper _mapper;

    public CrudManager(IRepository<TEntity> repository, IMapper mapper)
    {
        Repository = repository;
        _mapper = mapper;
    }


    public virtual async Task CreateAsync(TCreateViewModel model)
    {
        var entity = _mapper.Map<TEntity>(model);
        await Repository.CreateAsync(entity);
    }


    public virtual async Task<bool> DeleteAsync(int id)
    {
        var entity = await Repository.GetByIdAsync(id);

        if (entity == null) return false;

        await Repository.DeleteAsync(entity);

        return true;
    }

    public async Task<List<TViewModel>> GetAllAsync(Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, bool asnotracking = false)
    {
        var categoriesFromDb = await Repository.GetAllAsync(predicate, include, orderBy, asnotracking);

        var categories = _mapper.Map<List<TViewModel>>(categoriesFromDb);

        return categories.ToList();

    }

    public virtual async Task<IEnumerable<TViewModel>> GetAllAsync(Expression<Func<TEntity, bool>>? predicate = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, bool AsNoTracking = false)
    {
        var entities = await Repository.GetAllAsync(predicate, include, orderBy, AsNoTracking);

        var viewModels = _mapper.Map<IEnumerable<TViewModel>>(entities);

        return viewModels;


    }


    public virtual async Task<TViewModel?> GetAsync(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, bool AsNoTracking = false)
    {
        var entity = await Repository.GetAsync(predicate, include, AsNoTracking);

        var viewModel = _mapper.Map<TViewModel>(entity);

        return viewModel;
    }

    public virtual async Task<TViewModel?> GetByIdAsync(int id)
    {
        var entity = await Repository.GetByIdAsync(id);

        if (entity == null) return default;

        var viewModel = _mapper.Map<TViewModel>(entity);

        return viewModel;
    }

    public virtual async Task<bool> UpdateAsync(int id, TUpdateViewModel model)
    {
        var entity = await Repository.GetByIdAsync(id);

        if (entity == null) return false;

        _mapper.Map(model, entity);

        await Repository.UpdateAsync(entity);

        return true;
    }
}


