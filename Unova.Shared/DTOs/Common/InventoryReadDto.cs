namespace Unova.Shared.DTOs.Common;

public class InventoryReadDto : UnovaDTO
{
    #region Properties
    public int Total { get; set; }
    public int Active { get; set; }
    public int Inactive { get; set; }
    public string? Observations { get; set; }
    #endregion
}
