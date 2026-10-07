using Unova.Shared.DTOs.Read;

namespace Unova.Shared.DTOs.Detail;

public class UserDetailDto : UserReadDto
{
    #region Related Properties
    public int LanguageID { get; set; }
    public LanguageReadDto? Language { get; set; }
    public List<BookingReadDto> Bookings { get; set; } = new List<BookingReadDto>();
    public List<BookInventoryReadDto> BookInventories { get; set; } = new List<BookInventoryReadDto>();
    #endregion
}
