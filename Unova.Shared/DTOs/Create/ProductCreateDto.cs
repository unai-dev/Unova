namespace Unova.Shared.DTOs.Create;

public class ProductCreateDto
{
    #region Properties
    [Required]
    [StringLength(255)]
    public string Name { get; set; } = string.Empty;

    [StringLength(2000)]
    public string? Description { get; set; }

    [Required]
    [StringLength(13)]
    public string EAN { get; set; } = string.Empty;

    [Range(0.01, double.MaxValue)]
    public double Price { get; set; }
    #endregion

    #region Related Properties
    public int CategoryID { get; set; }
    #endregion
}
