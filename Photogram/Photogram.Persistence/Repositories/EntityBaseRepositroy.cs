using Microsoft.EntityFrameworkCore;
using Photogram.Domain.Common;
using Photogram.Domain.Entities;
using System.Linq.Expressions;

namespace Photogram.Persistence.Repositories;

public abstract class EntityBaseRepositroy<TEntity,TContext> where TEntity : class,IEntity 
    where TContext : DbContext
{
    protected TContext DbContext;
    private DbSet<TEntity> _dbSet;
    protected EntityBaseRepositroy(TContext dbContext)
    {
        DbContext = dbContext;
        _dbSet = DbContext.Set<TEntity>();
    }
    protected IQueryable<TEntity> Get(bool asNoTracking = false)
    {
        if(asNoTracking)
            _dbSet.AsNoTracking();

        return _dbSet.AsQueryable();
    }
    public ValueTask<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> pradicate,
        bool asNoTracking = false)
    {
        if(asNoTracking)
            _dbSet.AsNoTracking();

        if (pradicate is null)
            return new(_dbSet.AsEnumerable());

        return new(_dbSet.Where(pradicate));
    }
    protected async ValueTask<TEntity?> GetByIdAsync(Guid id, bool asNoTracking = false)
    {
        if (asNoTracking)
            _dbSet.AsNoTracking();

        return await _dbSet.FirstOrDefaultAsync(entity => entity.Id == id);
    }
    protected async ValueTask<TEntity> AddAsync(TEntity entity, bool saveChanges = true, 
        CancellationToken cancellationToken = default)
    {
        await _dbSet.AddAsync(entity, cancellationToken);

        if (saveChanges)
            await DbContext.SaveChangesAsync(cancellationToken);

        return entity;
    }
    protected async  ValueTask<TEntity> UpdateAsync(TEntity entity, bool saveChanges = true,
        CancellationToken cancellationToken = default)
    {
        DbContext.Update(entity);

        if (saveChanges)
            await DbContext.SaveChangesAsync(cancellationToken);

        return entity;
    }
    protected async ValueTask<TEntity> DeleteAsync(TEntity entity, bool saveChanges = true,
        CancellationToken cancellationToken = default)
    {
        DbContext.Remove(entity);

        if (saveChanges)
            await DbContext.SaveChangesAsync(cancellationToken);

        return entity;
    }
}
