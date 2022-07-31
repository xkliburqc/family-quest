// Licensed under the MIT license.

using Microsoft.AspNetCore.Mvc;

namespace FamilyQuest.Identity.Api.Controllers;

/// <summary>
/// Api health monitoring controller.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    /// <summary>
    /// Run a series of health check then return a corresponding http code.
    /// Note: Currently the method returns 200 OK always.
    /// </summary>
    /// <returns>Return http code 200 OK.</returns>
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Ok.");
    }
}
