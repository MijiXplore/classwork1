using Microsoft.AspNetCore.Mvc;

namespace classwork.Controllers
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
