using Microsoft.AspNetCore.Mvc;

using Unova.API.Controllers.Common;
using Unova.App.Contracts;
using Unova.Shared.DTOs.Create;
using Unova.Shared.DTOs.Detail;
using Unova.Shared.DTOs.Read;

namespace Unova.API.Controllers;

[Route("api/products")]
public class ProductController : UnovaController
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductReadDto>>> Get() =>
        Ok(await _productService.GetAll());

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ProductReadDto>> GetById([FromRoute] int id) =>
        Ok(await _productService.GetByID(id));

    [HttpGet("detail/{id:int}")]
    public async Task<ActionResult<ProductDetailDto>> GetDetail([FromRoute] int id) =>
        Ok(await _productService.GetDetail(id));

    [HttpPost]
    public async Task<ActionResult<ProductReadDto>> Post([FromBody] ProductCreateDto dto)
    {
        var result = await _productService.Create(dto);
        return CreatedAtAction(nameof(GetById), new { id = result.ID }, result);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        await _productService.Delete(id);
        return NoContent();
    }
}
