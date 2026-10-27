namespace Unova.App.DTOs.Detail;

public class ResourceDetailDto : ResourceReadDto
{
    #region Related Properties
    public int LanguageID { get; set; }
    public LanguageReadDto? Language { get; set; }
    #endregion
}
