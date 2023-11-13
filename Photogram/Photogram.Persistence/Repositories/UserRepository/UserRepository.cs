using Photogram.Domain.Entities;
using Photogram.Persistence.DataContext;
using System.Linq.Expressions;

namespace Photogram.Persistence.Repositories.UserRepository;

public class UserRepository : EntityBaseRepositroy<User, AppDbContext>, IUserRepository
{
    public UserRepository(AppDbContext dbContext) : base(dbContext)
    {
    }

    public IQueryable<User> Get(bool asNoTracking = false) => base.Get(asNoTracking);

    public ValueTask<IEnumerable<User>> Get(Expression<Func<User, bool>> pradicate,
        bool asNoTracking = false) => base.Get(pradicate, asNoTracking);

    public ValueTask<User?> GetByIdAsync(Guid id, bool asNoTracking = false) =>
        base.GetByIdAsync(id, asNoTracking);
    
    public ValueTask<User> AddAsync(User user, bool saveChanges = true,
        CancellationToken cancellation = default) => 
        base.AddAsync(user, saveChanges, cancellation);
   
    public ValueTask<User> UpdateAsync(User user, bool saveChanges = true,
        CancellationToken cancellation = default) => 
        base.UpdateAsync(user, saveChanges, cancellation);
    
    public ValueTask<User> DeleteAsync(User user, bool saveChanges = true,
        CancellationToken cancellation = default) => 
        base.DeleteAsync(user, saveChanges, cancellation); 
}
