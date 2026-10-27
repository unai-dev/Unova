namespace Unova.App.DTOs.Detail;

public class AuthorDetailDto : AuthorReadDto
{
    #region Related Properties
    public List<BookReadDto> Books { get; set; } = new List<BookReadDto>();
    #endregion
}
