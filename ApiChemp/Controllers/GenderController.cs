using Microsoft.AspNetCore.Mvc;

namespace ApiChemp.Controllers;
[Controller]
[Route("api/[controller]")]
public class GenderController : Controller
{
    [HttpGet("GetGender")]
    public IActionResult GetGender()
    {
        return Ok(Helper.Database.Genders.Select(x => new
        {
            x.Namegender,
            x.Id
        }));
    }
}