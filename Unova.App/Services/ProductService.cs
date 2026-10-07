namespace Unova.App.Services;

public class ProductService : IProductService
{
    private readonly IMapper _mapper;
    private readonly UnovaDbContext _context;

    public ProductService(IMapper mapper, UnovaDbContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<IEnumerable<ProductReadDto>> GetAll()
    {
        var products = await _context.Products
            .AsNoTracking()
            .ToListAsync();

        return _mapper.Map<IEnumerable<ProductReadDto>>(products);
    }

    public async Task<ProductReadDto> GetByID(int ID)
    {
        var product = await _context.Products
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.ID == ID)
            ?? throw new NotFoundException($"El producto con ID {ID} no existe");

        return _mapper.Map<ProductReadDto>(product);
    }

    public async Task<ProductDetailDto> GetDetail(int ID)
    {
        var product = await _context.Products
            .Include(x => x.Category)
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.ID == ID)
            ?? throw new NotFoundException($"El producto con ID {ID} no existe");

        return _mapper.Map<ProductDetailDto>(product);
    }

    public async Task<ProductReadDto> Create(ProductCreateDto dto)
    {
        var productExists = await _context.Products.AnyAsync(x => x.EAN == dto.EAN);
        if (productExists)
            throw new BadRequestException($"El producto con EAN {dto.EAN} ya figura en nuestra base de datos");

        var categoryExists = await _context.Categories.AnyAsync(x => x.ID == dto.CategoryID);
        if (!categoryExists)
            throw new NotFoundException($"La categoria con ID {dto.CategoryID} no existe");

        var product = _mapper.Map<Product>(dto);

        _context.Products.Add(product);
        await _context.SaveChangesAsync();

        return _mapper.Map<ProductReadDto>(product);
    }

    public async Task Delete(int ID)
    {
        var product = await _context.Products
            .FirstOrDefaultAsync(x => x.ID == ID)
            ?? throw new NotFoundException($"El producto con ID {ID} no existe");

        _context.Products.Remove(product);
        await _context.SaveChangesAsync();
    }
}
