using Microsoft.AspNetCore.Mvc;

namespace ApiChemp.Controllers;

public class NapravlenController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}