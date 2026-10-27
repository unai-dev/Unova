using Unova.App.DTOs.Common;

namespace Unova.App.DTOs.Read;

public class BookInventoryReadDto : InventoryReadDto
{
    #region Properties
    public int AvailableCopies { get; set; }
    public int ReservedCopies { get; set; }
    #endregion
}
