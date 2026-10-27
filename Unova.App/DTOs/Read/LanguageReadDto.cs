using Unova.App.DTOs.Common;

namespace Unova.App.DTOs.Read;

public class LanguageReadDto : UnovaDTO
{
    public required string Iso639Code { get; set; }
    public required string Name { get; set; }
}
