using Photogram.Domain.Common;

namespace Photogram.Domain.Entities;

public class Like : IEntity
{
    public Guid Id { get; set; }

    public Guid PostId { get; set; }

    public Guid UserId { get; set; }
}