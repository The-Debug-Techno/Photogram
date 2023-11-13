
using Photogram.Domain.Common;

namespace Photogram.Domain.Entities;

public class Follower : IEntity
{
    public Guid Id { get; set; }

    public Guid FollowingId { get; set; }
    public Guid FollowerId { get; set; }
    public ICollection<User> Followers { get; set; } = new List<User>();
    public ICollection<User> Followings { get; set; } = new List<User>();
}
