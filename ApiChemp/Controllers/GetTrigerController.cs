using Microsoft.AspNetCore.Mvc;

namespace ApiChemp.Controllers;
[Controller]
[Route("api/[controller]")]
public class GetTrigerController : Controller
{
    [HttpGet("GetInfoTriger")]
    public IActionResult GetInfoTriger()
    {
        return Ok(Helper.Database.Trigertables.ToList());
    }
}