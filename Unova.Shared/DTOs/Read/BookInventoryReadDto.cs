using Unova.Shared.DTOs.Common;

namespace Unova.Shared.DTOs.Read;

public class BookInventoryReadDto : InventoryReadDto
{
    #region Properties
    public int AvailableCopies { get; set; }
    public int ReservedCopies { get; set; }
    #endregion
}
