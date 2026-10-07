using Microsoft.AspNetCore.Mvc;

using Unova.API.Controllers.Common;
using Unova.App.Contracts;
using Unova.Shared.DTOs.Create;
using Unova.Shared.DTOs.Detail;
using Unova.Shared.DTOs.Read;

namespace Unova.API.Controllers;

[Route("api/inventories")]
public class BookInventoryController : UnovaController
{
    private readonly IBookInventoryService _inventoryService;

    public BookInventoryController(IBookInventoryService inventoryService)
    {
        _inventoryService = inventoryService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<BookInventoryReadDto>>> Get()
    {
        var inventories = await _inventoryService.GetAll();

        return Ok(inventories);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<BookInventoryReadDto>> GetByID(
        [FromRoute] int ID)
    {
        var inventory = await _inventoryService.GetByID(ID);

        return Ok(inventory);
    }

    [HttpGet("detail/{id:int}")]
    public async Task<ActionResult<BookInventoryDetailDto>> GetDetail(
        [FromRoute] int ID)
    {
        var inventory = await _inventoryService.GetDetail(ID);

        return Ok(inventory);
    }

    [HttpPost]
    public async Task<ActionResult<BookInventoryReadDto>> Create(
        [FromBody] BookInventoryCreateDto dto)
    {
        var inventory = await _inventoryService.Create(dto);

        return CreatedAtAction(
            nameof(GetByID),
            new { ID = inventory.ID },
            inventory);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(
        [FromRoute] int ID)
    {
        await _inventoryService.Delete(ID);

        return NoContent();
    }
}
