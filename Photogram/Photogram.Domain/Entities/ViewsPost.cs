using Photogram.Domain.Common;

namespace Photogram.Domain.Entities;

public class ViewsPost : IEntity
{
    public Guid Id { get; set; }

    public Guid PostId { get; set; }
}