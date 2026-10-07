namespace Unova.App.Services;

public class InventoryService : IBookInventoryService
{
    #region Fields
    private readonly UnovaDbContext _context;
    private readonly IMapper _mapper;
    private readonly IUserService _userService;
    #endregion

    #region Constructor
    public InventoryService(UnovaDbContext context, IMapper mapper, IUserService userService)
    {
        _context = context;
        _mapper = mapper;
        _userService = userService;
    }
    #endregion

    #region Methods
    public async Task<IEnumerable<BookInventoryReadDto>> GetAll()
    {
        var inventories = await _context.BookInventories
            .AsNoTracking()
            .ToListAsync();
        return _mapper.Map<IEnumerable<BookInventoryReadDto>>(inventories);
    }
    public async Task<BookInventoryReadDto> GetByID(int ID)
    {
        var inventory = await _context.BookInventories
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.ID == ID)
            ?? throw new NotFoundException($"El inventario con ID {ID} no existe");

        return _mapper.Map<BookInventoryReadDto>(inventory);
    }

    public async Task<BookInventoryDetailDto> GetDetail(int ID)
    {
        var inventory = await _context.BookInventories
            .Include(x => x.Book)
            .Include(x => x.User)
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.ID == ID)
            ?? throw new NotFoundException($"El inventario con ID {ID} no existe");

        return _mapper.Map<BookInventoryDetailDto>(inventory);
    }

    public async Task<BookInventoryReadDto> Create(BookInventoryCreateDto dto)
    {
        var book = await _context.Books
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.ID == dto.BookID)
            ?? throw new NotFoundException($"El libro con ID {dto.BookID} no existe");

        var currentUser = await _userService.GetMe();
        var inventory = _mapper.Map<BookInventory>(dto);

        var totalCopies = book.Copies.Count();
        var inactiveCopies = book.Copies.Count(x => !x.IsActive);
        var activeCopies = totalCopies - inactiveCopies;
        var reservedCopies = await _context.Bookings
            .CountAsync(x => x.Copy!.BookID == dto.BookID
            && x.Status == EBookingStatus.Active);
        var availableCopies = totalCopies - reservedCopies;

        inventory.Total = totalCopies;
        inventory.Inactive = inactiveCopies;
        inventory.Active = activeCopies;
        inventory.AvailableCopies = availableCopies;
        inventory.ReservedCopies = reservedCopies;
        inventory.UserID = currentUser.ID;

        _context.BookInventories.Add(inventory);
        await _context.SaveChangesAsync();

        return _mapper.Map<BookInventoryReadDto>(inventory);
    }

    public async Task Delete(int ID)
    {
        var inventory = await _context.BookInventories
            .FirstOrDefaultAsync(x => x.ID == ID)
            ?? throw new NotFoundException($"El inventario con ID {ID} no existe");

        _context.BookInventories.Remove(inventory);
        await _context.SaveChangesAsync();
    }
    #endregion
}