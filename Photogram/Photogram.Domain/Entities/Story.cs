using Photogram.Domain.Common;

namespace Photogram.Domain.Entities;

public class Story : SoftDeletedEntity
{
    public string ImagePath { get; set; } = default!;
    public string Description { get; set; } = default!;
    public int DurationInMinutes { get; set; } = 1;
    public Guid UserId { get; set; }
}
