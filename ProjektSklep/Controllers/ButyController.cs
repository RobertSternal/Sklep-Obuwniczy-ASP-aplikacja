using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjektSklep.Dane;
using System.Threading.Tasks;

namespace ProjektSklep.Controllers
{
    public class ButyController : Controller
    {
        private readonly AppDbContext _context;

        public ButyController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Buty.ToListAsync();
            return View();
        }
    }
}
