using Unova.App.DTOs.Common;

namespace Unova.App.DTOs.Read;

public class ResourceReadDto : UnovaDTO
{
    #region Properties
    public required string Code { get; set; }
    public required string Text { get; set; }
    public string? Description { get; set; }
    #endregion
}
