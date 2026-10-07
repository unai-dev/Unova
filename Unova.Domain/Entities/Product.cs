using Unova.Domain.Entities.Common;

namespace Unova.Domain.Entities;

public class Product : UnovaEntity
{
    #region Properties
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public string EAN { get; set; } = null!;
    public double Price { get; set; }
    #endregion

    #region Related Properties
    public int CategoryID { get; set; }
    public Category? Category { get; set; }

    #endregion
}
