using Microsoft.AspNetCore.Mvc;

namespace ApiChemp.Controllers;

public class DoctorsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}