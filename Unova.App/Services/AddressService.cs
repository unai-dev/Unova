namespace Unova.App.Services;

public class AddressService : IAddressService
{
    #region Fields
    private readonly UnovaDbContext _context;
    private readonly IMapper _mapper;
    #endregion

    #region Constructor
    public AddressService(UnovaDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    #endregion

    #region Methods
    public async Task<IEnumerable<AddressReadDto>> GetAll()
    {
        var addresses = await _context.Addresses
            .AsNoTracking()
            .ToListAsync();
        return _mapper.Map<IEnumerable<AddressReadDto>>(addresses);
    }

    public async Task<AddressReadDto> GetByID(int ID)
    {
        var address = await _context.Addresses
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.ID == ID)
            ?? throw new NotFoundException($"Address with ID {ID} not found");

        return _mapper.Map<AddressReadDto>(address);
    }

    public async Task<AddressDetailDto> GetDetail(int ID)
    {
        var address = await _context.Addresses
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.ID == ID)
            ?? throw new NotFoundException($"Address with ID {ID} not found");

        return _mapper.Map<AddressDetailDto>(address);
    }

    public async Task<AddressReadDto> Create(AddressCreateDto dto)
    {
        var addressExists = await _context.Addresses
            .AnyAsync(x => x.MainAddress.Equals(dto.MainAddress) && x.District == dto.District);

        if (addressExists)
            throw new BadRequestException($"Main Address {dto.MainAddress} already exists in DB");

        var address = _mapper.Map<Address>(dto);

        _context.Addresses.Add(address);
        await _context.SaveChangesAsync();

        return _mapper.Map<AddressReadDto>(address);
    }

    public async Task Delete(int ID)
    {
        var address = await _context.Addresses
            .FirstOrDefaultAsync(x => x.ID == ID)
            ?? throw new NotFoundException($"Address with ID {ID} not found");

        _context.Addresses.Remove(address);
        await _context.SaveChangesAsync();
    }
    #endregion
}