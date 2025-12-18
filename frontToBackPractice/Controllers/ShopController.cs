using Microsoft.AspNetCore.Mvc;

namespace frontToBackPractice.Controllers;

public class ShopController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}