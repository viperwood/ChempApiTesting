using Microsoft.AspNetCore.Mvc;

namespace ApiChemp.Controllers;
[Controller]
[Route("api/[controller]")]
public class LoginuserController : Controller
{
    [HttpGet("GetRoleUser")]
    public IActionResult GetRoleUser(string login)
    {
        return Ok(Helper.Database.Users.Where(x => x.Emailuser == login).Select(x => x.Roleuser));
    }
}