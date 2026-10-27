namespace Unova.App.DTOs.Detail;

public class CategoryDetailDto : CategoryReadDto
{
    #region Related Properties
    public List<BookReadDto> Books { get; set; } = new List<BookReadDto>();
    #endregion
}
