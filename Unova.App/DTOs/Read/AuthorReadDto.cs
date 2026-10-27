using Unova.App.DTOs.Common;

namespace Unova.App.DTOs.Read;

public class AuthorReadDto : UnovaDTO
{
    public required string Code { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string FullName => $"{FirstName} {LastName}";
}
