using Unova.App.DTOs.Common;

namespace Unova.App.DTOs.Read;

public class UserReadDto : UnovaDTO
{
    public required string UserName { get; set; }
    public required string Email { get; set; }
    public required string CIF { get; set; }
}
