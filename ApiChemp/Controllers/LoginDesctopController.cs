using Microsoft.AspNetCore.Mvc;

namespace ApiChemp.Controllers;
[Controller]
[Route("api/[controller]")]
public class LoginDesctopController : Controller
{
    [HttpGet("GetLoginDoctor")]
    public IActionResult GetLoginDoctor(string login)
    {
        return Ok(Helper.Database.Users.Where(x => x.Emailuser == login && x.Roleuser == 1).Select(x => x.Nameuser));
    }
}