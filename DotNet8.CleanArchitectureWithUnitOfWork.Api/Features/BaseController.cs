﻿namespace DotNet8.CleanArchitectureWithUnitOfWork.Api.Features;

[Route("api/[controller]")]
[ApiController]
public class BaseController : ControllerBase
{
    protected IActionResult Content(object obj)
    {
        return Ok(JsonConvert.SerializeObject(obj));
    }

    protected IActionResult InternalServerError(Exception ex)
    {
        return StatusCode(500, ex.Message);
    }
}
