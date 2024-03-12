using Microsoft.AspNetCore.Mvc;

namespace ApiChemp.Controllers;
[Controller]
[Route("api/[controller]")]
public class FullInfoPatientController : Controller
{
    [HttpGet("GetFullInfo")]
    public IActionResult GetFullInfo(string patient)
    {
        return Ok(Helper.Database.Fullinfopatients.Where(x => x.Id == Convert.ToInt32(patient)));
    }
}