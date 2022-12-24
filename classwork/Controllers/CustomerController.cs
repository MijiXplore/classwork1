using Microsoft.AspNetCore.Mvc;

namespace WebApplication8.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult CustomerIndex(string name)
        {
            ViewBag.name = name;
            return View();
        }
    }
}
