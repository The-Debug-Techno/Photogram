using Photogram.Domain.Common;
using System.Runtime.InteropServices;

namespace Photogram.Domain.Entities;

public class User : SoftDeletedEntity
{
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Bio { get; set; } = default!;
    public virtual Follower Follower { get; set; } = new Follower();
    public virtual UserSettings UserSettings { get; set; } = new UserSettings();
    public UserCredetials Credetials { get; set; } = new UserCredetials();
    public ICollection<Post> Posts { get; set; } = new List<Post>();
    public ICollection<Story> Stories { get;set;} = new List<Story>();
}