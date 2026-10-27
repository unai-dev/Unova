namespace Unova.App.DTOs.Create;

public class LocationCreateDto
{
    #region Properties

    [Required]
    [StringLength(55)]
    public string Code { get; set; } = string.Empty;

    [Required]
    [StringLength(5)]
    public string Aisle { get; set; } = string.Empty;
    [Required]
    [StringLength(5)]
    public string Shelf { get; set; } = string.Empty;
    [Required]
    [StringLength(5)]
    public string Column { get; set; } = string.Empty;
    public int Limit { get; set; }
    #endregion

    #region Related properties
    #endregion
}
