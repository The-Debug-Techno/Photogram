using Photogram.Domain.Common;

namespace Photogram.Domain.Entities;

public class User : IEntity
{
    public Guid Id => throw new NotImplementedException();
    public string Email { get; set; } = default!;
    public UserCredetials Credetials { get; set; } = default!;
}