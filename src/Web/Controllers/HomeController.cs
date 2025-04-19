using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class HomeController(IHomeService homeService) : ControllerBase
{
    [HttpGet]
    public IActionResult UniqueString()
    {
        return Ok(Guid.NewGuid().ToString());
    }
    
    [HttpGet]
    public IActionResult GetPaymentJson()
    {
        return Ok(homeService.GetPaymentJson().Value);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCheckOutUrl()
    {
        return Ok(await homeService.CreateCheckOutUrl());
    }
}
