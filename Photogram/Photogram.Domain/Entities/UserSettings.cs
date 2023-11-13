using Photogram.Domain.Common;

namespace Photogram.Domain.Entities;

public class UserSettings : SoftDeletedEntity
{
    public bool IsDarkMode { get; set; }
    public bool IsPrivate { get; set; }
    public Guid UserId { get; set; }
}
