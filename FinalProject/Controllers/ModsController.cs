using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;
using System.Linq;

namespace FinalProject.Controllers
{
    public class ModsController : Controller
    {
        private readonly AppDbContext _context;

        public ModsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var mods = _context.Mods.ToList(); 
            return View(mods);
        }
        public IActionResult Details(int id)
        {
            var mod = _context.Mods.FirstOrDefault(m => m.Id == id);

            if (mod == null)
                return NotFound();

            return View(mod);
        }
    }
}