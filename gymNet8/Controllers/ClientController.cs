using Microsoft.AspNetCore.Mvc;

namespace gymNet8.Controllers;
[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase
{
 [HttpGet]
    public IActionResult Index()
    {
        return Ok();
    }
}