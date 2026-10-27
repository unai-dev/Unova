namespace Unova.App.DTOs.Create;

public class AuthorCreateDto
{
    #region Properties

    [Required]
    [StringLength(55)]
    public string Code { get; set; } = string.Empty;

    [Required]
    [StringLength(55)]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    [StringLength(55)]
    public string LastName { get; set; } = string.Empty;
    #endregion
}
