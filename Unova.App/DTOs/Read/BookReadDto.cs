using Unova.App.DTOs.Common;

namespace Unova.App.DTOs.Read;

public class BookReadDto : UnovaDTO
{
    public required string Title { get; set; }
    public required string ISBN { get; set; }
    public int Stock { get; set; }
    public string? Synopsis { get; set; }
    public DateTime PublicationAt { get; set; }
}
