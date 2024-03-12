using Microsoft.AspNetCore.Mvc;

namespace ApiChemp.Controllers;
[Controller]
[Route("api/[controller]")]
public class DoctorsController : Controller
{
    [HttpGet("GetDoctors")]
    public IActionResult GetDoctors()
    {
        return Ok(Helper.Database.Users.Where(x => x.Roleuser == 1).Select(x => new
        {
            x.Id,
            x.Nameuser
        }).ToList());
    }
}