using Microsoft.AspNetCore.Mvc;
using ProjektSklep.Dane;
using System.Linq;

namespace ProjektSklep.Controllers
{
    public class KolorystykiController : Controller
    {
        private readonly AppDbContext _context;

        public KolorystykiController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Kolorystyki.ToList();
            return View();
        }
    }
}
