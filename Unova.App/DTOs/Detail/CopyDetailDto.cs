namespace Unova.App.DTOs.Detail;

public class CopyDetailDto : CopyReadDto
{
    #region Related Properties
    public int CopyID { get; set; }
    public CopyReadDto? Book { get; set; }
    public int LocationID { get; set; }
    public LocationReadDto? Location { get; set; }
    #endregion
}
