using Unova.Domain.Entities.Common;

namespace Unova.Domain.Entities;

public class Inventory : UnovaEntity
{
    #region Properties
    public int TotalCopies { get; set; }
    public int CopiesWithLocation { get; set; }
    public int CopiesWithoutLocation { get; set; }
    public int ReservedCopies { get; set; }
    public int AvailableCopies { get; set; }
    public string? Observations { get; set; }
    #endregion

    #region Related Properties
    public int BookID { get; set; }
    public Book? Book { get; set; }

    public int UserID { get; set; }
    public User? User { get; set; }
    #endregion
}
