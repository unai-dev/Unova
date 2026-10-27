using Microsoft.AspNetCore.Mvc;

using Unova.API.Controllers.Common;
using Unova.App.DTOs.Create;
using Unova.App.DTOs.Detail;
using Unova.App.DTOs.Read;

namespace Unova.API.Controllers;

[Route("api/resources")]
public class ResourceController : UnovaController
{
    private readonly App.Contracts.IResourceService _resourceService;

    public ResourceController(App.Contracts.IResourceService resourceService)
    {
        _resourceService = resourceService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ResourceReadDto>>> Get()
    {
        var resources = await _resourceService.GetAll();

        return Ok(resources);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ResourceReadDto>> GetByID(
        [FromRoute] int ID)
    {
        var resource = await _resourceService.GetByID(ID);

        return Ok(resource);
    }

    [HttpGet("detail/{id:int}")]
    public async Task<ActionResult<ResourceDetailDto>> GetDetail(
        [FromRoute] int ID)
    {
        var resource = await _resourceService.GetDetail(ID);

        return Ok(resource);
    }

    [HttpGet("rsc/{code}")]
    public async Task<ActionResult<string>> GetRsc([FromQuery] string code)
        => Ok(await _resourceService.GetRsc(code));

    [HttpPost]
    public async Task<ActionResult<ResourceReadDto>> Create(
        [FromBody] ResourceCreateDto dto)
    {
        var resource = await _resourceService.Create(dto);

        return CreatedAtAction(
            nameof(GetByID),
            new { ID = resource.ID },
            resource);
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(
        [FromRoute] int ID)
    {
        await _resourceService.Delete(ID);

        return NoContent();
    }
}
