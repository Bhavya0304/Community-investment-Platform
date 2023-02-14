using CIplatformWeb.Data;
using CIplatformWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIplatformWeb.Controllers
{
    public class userController : Controller
    {
        private readonly ApplicationDbContext _db;
        public userController(ApplicationDbContext db)
        {
           _db = db;   
        }
        public IActionResult Index()
        {
            IEnumerable<user> objUserList = _db.user;
            return View(objUserList);
        }
    }
}
