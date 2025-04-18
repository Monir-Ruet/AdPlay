using Application.Services;
using Domain.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class HomeController(IHomeService homeService) : ControllerBase
{
    [HttpGet]
    public IActionResult Unique_String()
    {
        return Ok(Guid.NewGuid().ToString());
    }
    
    [HttpGet]
    public IActionResult Get_Payment_Json()
    {
        return Ok(homeService.Get_Payment_Json().Value);
    }
}
