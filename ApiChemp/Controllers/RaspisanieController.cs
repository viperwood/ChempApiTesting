using ApiChemp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiChemp.Controllers;
[Controller]
[Route("api/[controller]")]
public class RaspisanieController : Controller
{
    [HttpGet("GetRaspisanie")]
    public IActionResult GetRaspisanie(int page, int tipe)
    {
        if (tipe == 0)
        {
            return Ok(Helper.Database.Raspisanies.Where(x => x.Datapriema.Day == page && x.Datapriema.Month == DateTime.Now.Month && x.Datapriema.Year == DateTime.Now.Year).Select(x => new
            {
                x.Id,
                x.Datapriema,
                x.Napravlenie,
                x.Doctorid,
                x.Title
            }).ToList());
        }
        else
        {
            List<Raspisanie> raspisanies = new List<Raspisanie>();
            for (int i = 1+((page-1)*7); i < 8+((page-1)*7); i++)
            {
                if (Helper.Database.Raspisanies.Where(x => x.Datapriema.Day == i && x.Datapriema.Month == DateTime.Now.Month && x.Datapriema.Year == DateTime.Now.Year).ToList().Count == 1)
                {
                    raspisanies.Add(Helper.Database.Raspisanies.Where(x => x.Datapriema.Day == i && x.Datapriema.Month == DateTime.Now.Month && x.Datapriema.Year == DateTime.Now.Year).ToList()[0]);   
                }
            }
            return Ok(raspisanies.Select(x => new
            {
                x.Id,
                x.Datapriema,
                x.Napravlenie,
                x.Doctorid,
                x.Title
            }).ToList());   
        }
    }
}