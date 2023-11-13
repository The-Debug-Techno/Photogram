using Photogram.Domain.Entities;
using System.Linq.Expressions;

namespace Photogram.Persistence.Repositories.UserRepository;

public interface IUserRepository
{
    IQueryable<User> Get(bool asNoTracking = false);
    ValueTask<IEnumerable<User>> Get(Expression<Func<bool>> pradicate, bool asNoTracking = false);
    ValueTask<User> GetByIdAsync(Guid id, bool asNoTracking = false);
    ValueTask<User> AddAsync(User user, bool saveChanges = true, CancellationToken cancellation = default);

    ValueTask<User> UpdateAsync(User user, bool saveChanges = true, CancellationToken cancellation = default);
    ValueTask<User> DeleteAsync(User user, bool saveChanges = true, CancellationToken cancellation = default);
}
