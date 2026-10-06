using Unova.Shared.DTOs.Common;

namespace Unova.Shared.DTOs.Read;

public class InventoryReadDto : UnovaDTO
{
    #region Properties
    public int TotalCopies { get; set; }
    public int ReservedCopies { get; set; }
    public int AvailableCopies { get; set; }
    public string? Observations { get; set; }
    #endregion
}
