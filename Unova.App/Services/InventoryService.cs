namespace Unova.App.Services;

public class InventoryService : IInventoryService
{
    private readonly UnovaDbContext _context;
    private readonly IMapper _mapper;
    private readonly IUserService _userService;

    public InventoryService(UnovaDbContext context, IMapper mapper, IUserService userService)
    {
        _context = context;
        _mapper = mapper;
        _userService = userService;
    }

    public async Task<IEnumerable<InventoryReadDto>> GetAll()
    {
        var inventories = await _context.Inventories
            .AsNoTracking()
            .ToListAsync();
        return _mapper.Map<IEnumerable<InventoryReadDto>>(inventories);
    }
    public async Task<InventoryReadDto> GetByID(int ID)
    {
        var inventory = await _context.Inventories
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.ID == ID)
            ?? throw new NotFoundException($"El inventario con ID {ID} no existe");

        return _mapper.Map<InventoryReadDto>(inventory);
    }

    public async Task<InventoryDetailDto> GetDetail(int ID)
    {
        var inventory = await _context.Inventories
            .Include(x => x.Book)
            .Include(x => x.User)
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.ID == ID)
            ?? throw new NotFoundException($"El inventario con ID {ID} no existe");

        return _mapper.Map<InventoryDetailDto>(inventory);
    }

    public async Task<InventoryReadDto> Create(InventoryCreateDto dto)
    {
        var book = await _context.Books
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.ID == dto.BookID)
            ?? throw new NotFoundException($"El libro con ID {dto.BookID} no existe");

        var currentUser = await _userService.GetMe();

        var inventory = _mapper.Map<Inventory>(dto);

        var totalCopies = book.Copies.Count;
        var copiesWithoutLocation = book.Copies.Count(x => x.LocationID == StaticVariables.COPIES_WITHOUT_LOCATION);
        var copiesWithLocation = book.Copies.Count(x => x.LocationID != StaticVariables.COPIES_WITHOUT_LOCATION);
        var reservedCopies = await _context.Bookings.CountAsync(x => x.Copy!.BookID == dto.BookID && x.Status == EBookingStatus.Active);
        var availableCopies = totalCopies - reservedCopies;

        inventory.TotalCopies = totalCopies;
        inventory.CopiesWithoutLocation = copiesWithoutLocation;
        inventory.CopiesWithLocation = copiesWithLocation;
        inventory.AvailableCopies = availableCopies;
        inventory.ReservedCopies = reservedCopies;
        inventory.UserID = currentUser.ID;

        _context.Inventories.Add(inventory);
        await _context.SaveChangesAsync();

        return _mapper.Map<InventoryReadDto>(inventory);
    }

    public async Task Delete(int ID)
    {
        var inventory = await _context.Inventories
            .FirstOrDefaultAsync(x => x.ID == ID)
            ?? throw new NotFoundException($"El inventario con ID {ID} no existe");

        _context.Inventories.Remove(inventory);
        await _context.SaveChangesAsync();
    }
}
