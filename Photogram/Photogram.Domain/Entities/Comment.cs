using Photogram.Domain.Common;

namespace Photogram.Domain.Entities;

public class Comment : SoftDeletedEntity
{
    public string Description { get; set; } = default!;
    public Guid UserId { get; set; }
    public Guid PostId { get; set; }
    public Guid ParentId { get; set; }
    public ICollection<Comment> Comments { get; set;} = new List<Comment>();
}
