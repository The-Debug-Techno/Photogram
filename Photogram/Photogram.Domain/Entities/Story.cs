using Photogram.Domain.Common;

namespace Photogram.Domain.Entities;

public class Story : SoftDeletedEntity
{
    public string ImagePath { get; set; } = default!;

    public string Description { get; set; } = default!;

    public int DurationInMinutes { get; set; } = 1;

    public Guid UserId { get; set; }

    public ICollection<ViewsStory> Stories { get; set; } = new List<ViewsStory>();

    public ICollection<Like> Likes { get; set; } = new List<Like>();
}
