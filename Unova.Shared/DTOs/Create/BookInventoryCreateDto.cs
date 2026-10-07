namespace Unova.Shared.DTOs.Create;

public class BookInventoryCreateDto
{
    #region Properties
    public string? Observations { get; set; }
    #endregion

    #region Related Properties
    public int BookID { get; set; }
    #endregion
}
