using Microsoft.AspNetCore.Mvc;

using Unova.API.Controllers.Common;
using Unova.App.Contracts;
using Unova.Shared.DTOs.Create;
using Unova.Shared.DTOs.Detail;
using Unova.Shared.DTOs.Read;

namespace Unova.API.Controllers;

[Route("api/inventories")]
public class InventoryController : UnovaController
{
    private readonly IInventoryService _inventoryService;

    public InventoryController(IInventoryService inventoryService)
    {
        _inventoryService = inventoryService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<InventoryReadDto>>> Get()
    {
        var inventories = await _inventoryService.GetAll();

        return Ok(inventories);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<InventoryReadDto>> GetByID(
        [FromRoute] int ID)
    {
        var inventory = await _inventoryService.GetByID(ID);

        return Ok(inventory);
    }

    [HttpGet("detail/{id:int}")]
    public async Task<ActionResult<InventoryDetailDto>> GetDetail(
        [FromRoute] int ID)
    {
        var inventory = await _inventoryService.GetDetail(ID);

        return Ok(inventory);
    }

    [HttpPost]
    public async Task<ActionResult<InventoryReadDto>> Create(
        [FromBody] InventoryCreateDto dto)
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
