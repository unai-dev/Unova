using Microsoft.AspNetCore.Mvc;

using Unova.API.Controllers.Common;
using Unova.App.Contracts;
using Unova.App.DTOs.Create;
using Unova.App.DTOs.Detail;
using Unova.App.DTOs.Read;

namespace Unova.API.Controllers;

[Route("api/addresses")]
public class AddressController : UnovaController
{
    private readonly IAddressService _addressService;

    public AddressController(IAddressService addressService)
    {
        _addressService = addressService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AddressReadDto>>> Get() =>
        Ok(await _addressService.GetAll());

    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<AddressReadDto>> Get([FromRoute] int ID) =>
        Ok(await _addressService.GetByID(ID));

    [HttpGet]
    [Route("detail/{id:int}")]
    public async Task<ActionResult<AddressDetailDto>> GetDetail([FromRoute] int ID) =>
        Ok(await _addressService.GetDetail(ID));

    [HttpPost]
    public async Task<ActionResult<AddressReadDto>> Post([FromBody] AddressCreateDto dto)
    {
        var result = await _addressService.Create(dto);

        return CreatedAtAction(
            nameof(Get),
            new { ID = result.ID },
            result
        );
    }

    [HttpDelete]
    [Route("{id:int}")]
    public async Task<IActionResult> Delete([FromRoute] int ID)
    {
        await _addressService.Delete(ID);
        return NoContent();
    }
}