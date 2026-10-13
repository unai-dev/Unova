using Unova.Shared.DTOs.Common;

namespace Unova.Shared.DTOs.Read;

public class ResourceReadDto : UnovaDTO
{
    #region Properties
    public required string Code { get; set; }
    public required string Text { get; set; }
    public string? Description { get; set; }
    #endregion
}
