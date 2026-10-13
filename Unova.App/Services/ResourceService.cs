namespace Unova.App.Services;

public class ResourceService : IResourceService
{
    private readonly UnovaDbContext _context;
    private readonly IMapper _mapper;
    private readonly IUserService _userService;

    public ResourceService(UnovaDbContext context, IMapper mapper, IUserService userService)
    {
        _context = context;
        _mapper = mapper;
        _userService = userService;
    }

    public async Task<IEnumerable<ResourceReadDto>> GetAll()
    {
        var resources = await _context.Resources
                        .AsNoTracking()
                        .ToListAsync();
        return _mapper.Map<IEnumerable<ResourceReadDto>>(resources);
    }

    public async Task<ResourceReadDto> GetByID(int ID)
    {
        var resource = await _context.Resources
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.ID == ID)
            ?? throw new NotFoundException($"Resource with ID {ID} not found.");

        return _mapper.Map<ResourceReadDto>(resource);
    }

    public async Task<ResourceDetailDto> GetDetail(int ID)
    {
        var resource = await _context.Resources
            .Include(x => x.Language)
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.ID == ID)
            ?? throw new NotFoundException($"Resource with ID {ID} not found.");

        return _mapper.Map<ResourceDetailDto>(resource);
    }

    public async Task<ResourceReadDto> Create(ResourceCreateDto dto)
    {
        var resourceExists = await _context.Resources
            .AnyAsync(x => x.Code == dto.Code && x.LanguageID == dto.LanguageID);

        if (resourceExists)
            throw new BadRequestException($"Resource with code '{dto.Code}' already exists for the specified language.");

        var resource = _mapper.Map<Resource>(dto);

        _context.Resources.Add(resource);
        await _context.SaveChangesAsync();

        return _mapper.Map<ResourceReadDto>(resource);
    }

    public async Task Delete(int ID)
    {
        var resource = await _context.Resources
            .FirstOrDefaultAsync(x => x.ID == ID)
            ?? throw new NotFoundException($"Resource with ID {ID} not found.");

        _context.Resources.Remove(resource);
        await _context.SaveChangesAsync();
    }
}
