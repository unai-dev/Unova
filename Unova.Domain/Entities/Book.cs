using Unova.Domain.Entities.Common;

namespace Unova.Domain.Entities;

public class Book : UnovaEntity
{
    #region Properties
    public string Title { get; set; } = null!;
    public string ISBN { get; set; } = null!;
    public int Stock { get; set; }
    public string? Synopsis { get; set; }
    public DateTime PublicationAt { get; set; }
    #endregion

    #region Related Properties
    public int AuthorID { get; set; }
    public Author? Author { get; set; }

    public int CategoryID { get; set; }
    public Category? Category { get; set; }

    public List<Copy> Copies { get; set; } = new List<Copy>();
    public List<Inventory> Inventories { get; set; } = new List<Inventory>();
    #endregion
}