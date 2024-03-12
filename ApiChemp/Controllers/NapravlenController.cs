using Microsoft.AspNetCore.Mvc;

namespace ApiChemp.Controllers;
[Controller]
[Route("api/[controller]")]
public class NapravlenController : Controller
{
    [HttpGet("GetNaprav")]
    public IActionResult GetNaprav()
    {
        return Ok(Helper.Database.Napravlenia.Select(x => new
        {
            x.Id,
            x.Namenaprav
        }));
    }
}