using Photogram.Domain.Common;

namespace Photogram.Domain.Entities;

public class UserCredetials : SoftDeletedEntity
{
    public string Password { get; set; } = default!;
    public Guid UserId { get; set; }
}