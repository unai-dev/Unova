using Unova.Domain.Entities.Common;

namespace Unova.Domain.Entities;

public class BookInventory : Inventory
{
    #region Properties
    public int AvailableCopies { get; set; }
    public int ReservedCopies { get; set; }
    #endregion

    #region Related Properties
    public int BookID { get; set; }
    public Book? Book { get; set; }
    #endregion
}
