using Footballers_Catalog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Footballers_Catalog.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            
            return View(await db.Footballers.ToListAsync());
        }

        public async Task<IActionResult> Create()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(string firstname, string lastname, Sex sex, Country country, string teamname)
        {
            var footballer = new Footballer(firstname, lastname, sex, country, teamname);
            db.Footballers.Add(footballer);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Footballer? footballer = await db.Footballers.FirstOrDefaultAsync(p => p.Id == id);
                if (footballer != null)
                {
                    db.Footballers.Remove(footballer);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Footballer? footballer = await db.Footballers.FirstOrDefaultAsync(p => p.Id == id);
                if (footballer != null) return View(footballer);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, string firstname, string lastname, Sex sex, Country country, string teamname)
        {
            var footballer = new Footballer(id, firstname, lastname, sex, country, teamname);
            db.Footballers.Update(footballer);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}