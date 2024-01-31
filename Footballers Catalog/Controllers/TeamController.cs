using Footballers_Catalog.Models;
using Microsoft.AspNetCore.Mvc;

namespace Footballers_Catalog.Controllers
{
    public class TeamController : Controller
    {
        ApplicationContext db;
        public TeamController(ApplicationContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
