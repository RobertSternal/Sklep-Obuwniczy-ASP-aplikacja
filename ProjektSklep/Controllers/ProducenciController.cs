using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjektSklep.Dane;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklep.Controllers
{
    public class ProducenciController : Controller
    {
        private readonly AppDbContext _context;

        public ProducenciController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Producenci.ToListAsync();
            return View();
        }
    }
}
