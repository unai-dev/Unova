namespace Unova.App.DTOs.Detail;

public class ProductDetailDto : ProductReadDto
{
    #region Related Properties
    public int CategoryID { get; set; }
    public CategoryReadDto? Category { get; set; }
    #endregion
}
