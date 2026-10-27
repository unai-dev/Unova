using Unova.App.DTOs.Common;

namespace Unova.App.DTOs.Read;

public class BookingReadDto : UnovaDTO
{
    public DateTime StartTime { get; set; }
    public DateTime PickupDeadline { get; set; }
    public int Status { get; set; }
}
