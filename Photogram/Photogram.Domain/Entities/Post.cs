namespace Photogram.Domain.Entities;

public class Post
{
    public string ImagePath { get; set; } = default!;
    public string Description { get; set; } = default!;
    public Guid UserId { get; set; }
    public ICollection<Comment> Posts { get; set;} = new List<Comment>();
}
