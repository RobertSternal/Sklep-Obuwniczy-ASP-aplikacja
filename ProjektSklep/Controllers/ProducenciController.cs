using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjektSklep.Dane;
using ProjektSklep.Dane.Static;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklep.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class ProducenciController : Controller
    {
        private readonly AppDbContext _context;

        public ProducenciController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allProducenci = await _context.Producenci.ToListAsync();
            return View(allProducenci);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
