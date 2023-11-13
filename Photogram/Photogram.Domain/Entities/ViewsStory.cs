using Photogram.Domain.Common;

namespace Photogram.Domain.Entities;

public  class ViewsStory : IEntity
{
    public Guid Id { get; set; }

    public Guid StoryId { get; set; }

    public Guid UserId { get; set; }
}