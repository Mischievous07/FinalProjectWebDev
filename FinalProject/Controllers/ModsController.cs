using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;

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
    }
}