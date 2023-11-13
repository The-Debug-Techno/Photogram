using Photogram.Domain.Common;

namespace Photogram.Domain.Entities;

public class Message : SoftDeletedEntity
{
    public Guid FirstUserId { get; set; }
    public Guid SecondUserId { get; set; }
    public string ImagePath { get; set; } = default!;
    public string Content { get; set; } = default!;
}
