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
    public class ButyController : Controller
    {
        private readonly AppDbContext _context;

        public ButyController(AppDbContext context)
        {
            _context = context;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allButy = await _context.Buty.OrderBy(n => n.Nazwa).ToListAsync();
            return View(allButy);
        }

       /* [AllowAnonymous]
        //Get: Buty/Szczegóły
        public async Task<IActionResult> Details(int id)
        {
            var kolorystykaDetails = await _service.GetByIdAsync(id);

            if (kolorystykaDetails == null) return View("NotFound");
            return View(kolorystykaDetails);
        }
       */
    }
}
