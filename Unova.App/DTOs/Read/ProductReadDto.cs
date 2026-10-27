using Unova.App.DTOs.Common;

namespace Unova.App.DTOs.Read;

public class ProductReadDto : UnovaDTO
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public required string EAN { get; set; }
    public double Price { get; set; }
}
