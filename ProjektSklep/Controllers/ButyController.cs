using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjektSklep.Dane;
using System.Linq;
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
            var allButy = await _context.Buty.OrderBy(n => n.Nazwa).ToListAsync();
            return View(allButy);
        }
    }
}
