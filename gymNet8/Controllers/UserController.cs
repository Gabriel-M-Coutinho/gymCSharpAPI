using gymNet8.dtos;
using gymNet8.models;

using Microsoft.AspNetCore.Mvc;

namespace gymNet8.Controllers;
[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateClient([FromBody] ClientDto clientDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var client = new Client(clientDto.Name,clientDto.Email,clientDto.Email);

        return Ok(client);
    }
    
    
}