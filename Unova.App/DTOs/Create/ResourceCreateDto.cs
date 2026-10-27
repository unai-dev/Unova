namespace Unova.App.DTOs.Create;

public class ResourceCreateDto
{
    #region Properties
    public string Code { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public string? Description { get; set; }
    #endregion

    #region Related Properties
    public int LanguageID { get; set; }
    #endregion
}
