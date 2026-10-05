namespace Unova.Shared.DTOs.Create;

public class InventoryCreateDto
{
    #region Properties
    public string? Observations { get; set; }
    #endregion

    #region Related Properties
    public int BookID { get; set; }
    #endregion
}
