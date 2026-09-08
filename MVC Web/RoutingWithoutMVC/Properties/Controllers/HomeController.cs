using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.Properties.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
