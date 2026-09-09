using Microsoft.AspNetCore.Mvc;

namespace RouterWithoutMVC.Properties.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
