namespace Unova.App.DTOs.Detail;

public class BookInventoryDetailDto : BookInventoryReadDto
{
    #region Related Properties
    public int UserID { get; set; }
    public UserReadDto? User { get; set; }

    public int BookID { get; set; }
    public BookReadDto? Book { get; set; }
    #endregion
}
