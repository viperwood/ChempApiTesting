using Microsoft.AspNetCore.Mvc;

namespace ApiChemp.Controllers;

public class RaspisanieController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}