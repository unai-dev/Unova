namespace Unova.App.DTOs.Auth;

public class ClaimDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
}
