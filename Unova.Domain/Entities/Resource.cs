using Unova.Domain.Entities.Common;

namespace Unova.Domain.Entities;

public class Resource : UnovaEntity
{
    #region Properties
    public string Code { get; set; } = null!;
    public string Text { get; set; } = null!;
    public string? Description { get; set; }
    #endregion

    #region
    public int LanguageID { get; set; }
    public Language? Language { get; set; }
    #endregion
}
