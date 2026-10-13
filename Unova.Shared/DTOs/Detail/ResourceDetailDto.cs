using Unova.Shared.DTOs.Read;

namespace Unova.Shared.DTOs.Detail;

public class ResourceDetailDto : ResourceReadDto
{
    #region Related Properties
    public int LanguageID { get; set; }
    public LanguageReadDto? Language { get; set; }
    #endregion
}
