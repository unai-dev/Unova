using Unova.Shared.DTOs.Read;

namespace Unova.Shared.DTOs.Detail;

public class ProductDetailDto : ProductReadDto
{
    #region Related Properties
    public int CategoryID { get; set; }
    public CategoryReadDto? Category { get; set; }
    #endregion
}
