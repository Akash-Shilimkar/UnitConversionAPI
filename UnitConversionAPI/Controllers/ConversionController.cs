using Microsoft.AspNetCore.Mvc;
using UnitConversionAPI.Models;
using UnitConversionAPI.Services;

namespace UnitConversionAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConversionController : ControllerBase
{
    private readonly IConversionService _service;

    public ConversionController(IConversionService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Convert([FromBody] ConversionRequest request)
    {
        var result = _service.Convert(request);

        return Ok(result);
    }
}