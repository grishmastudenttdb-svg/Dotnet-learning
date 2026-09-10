using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["data1"] = "Viewdata";
            ViewBag.data2 = "View bag";
            TempData["data3"] = "Temp Data";

            TempData["data4"] = null;

            TempData.Keep();

            return View();
        }
        public IActionResult About()
        {
            TempData.Keep();

            return View();
        }
        public IActionResult Contect()
        {
            
            return View();
        }
        //public string Display()
        //{
        //    return "Welcome to programentor";
        //}
        //public int DisplayId(int id)
        //{
        //    return id;
        //}


    }
}


//ViewBag.data1 = "programentor";
//ViewBag.data2 = 8460020237;
//ViewBag.data3 = DateTime.Now.ToShortDateString();

//ViewData["myanme"] = "Adil";
//ViewBag.data6 = "Welcome to My Channel";

//string[] arr = { "Kumar", "pre", "ziya" };
//ViewBag.data4 = arr;

//ViewBag.data5 = new List<string>()
//{
//    "running","cricet","football","hockey"
//};

//ViewData["data1"] = "Programentor";
//ViewData["data2"] = 25;
//ViewData["data3"] = DateTime.Now.ToLongDateString();

//string[] arr = { "Kumar", "Prem", "Grishma", "Yashvi" };

//ViewData["data4"] = arr;

//ViewData["data5"] = new List<string>()
//{
//    "running","cricet","football","hockey"
//};