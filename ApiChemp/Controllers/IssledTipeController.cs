using Microsoft.AspNetCore.Mvc;

namespace ApiChemp.Controllers;
[Controller]
[Route("api/[controller]")]
public class IssledTipeController : Controller
{
    [HttpGet("GetIssledTipe")]
    public IActionResult GetIssledTipe()
    {
        return Ok(Helper.Database.Issledtipes.Select(x => new
        {
            x.Id,
            x.Nameissled
        }));
    }
}