namespace Unova.Domain.Entities.Common;

public abstract class Inventory : UnovaEntity
{
    #region Properties
    public int Total { get; set; }
    public int Active { get; set; }
    public int Inactive { get; set; }
    public string? Observations { get; set; }
    #endregion

    #region Related Properties
    public int UserID { get; set; }
    public User? User { get; set; }
    #endregion
}
