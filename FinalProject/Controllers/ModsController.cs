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
            var mods = _context.Mods.ToList(); // THIS is the link to DB
            return View(mods);
        }
    }
}