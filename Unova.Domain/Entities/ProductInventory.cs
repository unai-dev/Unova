using Unova.Domain.Entities.Common;

namespace Unova.Domain.Entities;

public class ProductInventory : Inventory
{
    #region Related Properties
    public int ProductID { get; set; }
    public Product? Product { get; set; }
    #endregion
}
