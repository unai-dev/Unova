using Unova.App.DTOs.Common;

namespace Unova.App.DTOs.Read;

public class AddressReadDto : UnovaDTO
{
    #region Properties
    public required string Code { get; set; }
    public required string MainAddress { get; set; }
    public string? SecondAddress { get; set; }
    public required string District { get; set; }
    public required string PostalCode { get; set; }
    public required string City { get; set; }
    public required string Country { get; set; }
    #endregion
}