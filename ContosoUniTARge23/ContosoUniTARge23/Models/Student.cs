using Microsoft.AspNetCore.Mvc;

namespace ContosoUniTARge23.Models
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
