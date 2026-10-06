using Unova.Shared.DTOs.Read;

namespace Unova.Shared.DTOs.Detail;

public class LocationDetailDto : LocationReadDto
{
    #region Related Properties
    public List<CopyReadDto> Copies { get; set; } = new List<CopyReadDto>();
    #endregion
}
