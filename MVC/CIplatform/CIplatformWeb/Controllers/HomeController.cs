using CIplatformWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CIplatformWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Forgot_password()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Reset_password()
        {
            return View();
        }
        public IActionResult Platform()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public PartialViewResult GetGridView()
        {
            return PartialView("_Grid_View");
        }
        public PartialViewResult GetListView()
        {
            return PartialView("_List_View");
        }
    }
}