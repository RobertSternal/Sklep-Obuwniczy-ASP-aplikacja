using Microsoft.AspNetCore.Mvc;
using ProjektSklep.Dane;
using ProjektSklep.Dane.Services;
using ProjektSklep.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklep.Controllers
{
    public class KolorystykiController : Controller
    {
        private readonly IKolorystykiService _service;

        public KolorystykiController(IKolorystykiService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            //var data = _context.Kolorystyki.ToList();

            var allKolorystyki = await _service.GetAll(); ;
            return View(allKolorystyki);
        }

        //Get: Kolorystyki / Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Nazwa,Opis")]Kolorystyka kolorystyka)
        {
            if(ModelState.IsValid)
            {
                return View(kolorystyka);
            }
            _service.Add(kolorystyka);
            return RedirectToAction(nameof(Index));
        }
    }
}
