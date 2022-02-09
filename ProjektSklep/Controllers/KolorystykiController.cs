using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjektSklep.Dane;
using ProjektSklep.Dane.Services;
using ProjektSklep.Dane.Static;
using ProjektSklep.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklep.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
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

            var allKolorystyki = await _service.GetAllAsync(); ;
            return View(allKolorystyki);
        }

        //Get: Kolorystyki / Create
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create([Bind("Nazwa,Opis")] Kolorystyka kolorystyka)
        {
            if(!ModelState.IsValid)
            {
                return View(kolorystyka);
            }
            await _service.AddAsync(kolorystyka);
            return RedirectToAction(nameof(Index));
        }

        //Get: Kolorystyki/Szczegóły
        public async Task<IActionResult> Details(int id)
        {
            var kolorystykaDetails = await _service.GetByIdAsync(id);

            if (kolorystykaDetails == null) return View("NotFound");
            return View(kolorystykaDetails);
        }


        //Get: Kolorystyki / Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var kolorystykaDetails = await _service.GetByIdAsync(id);

            if (kolorystykaDetails == null) return View("NotFound");
            {
                return View(kolorystykaDetails);
            }
        }


        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("KolorystykaId,Nazwa,Opis")] Kolorystyka kolorystyka)
        {
            if (!ModelState.IsValid)
            {
                return View(kolorystyka);
            }
            await _service.UpdateAsync(id, kolorystyka);
            return RedirectToAction(nameof(Index));
        }


        //Get: Kolorystyki / Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var kolorystykaDetails = await _service.GetByIdAsync(id);

            if (kolorystykaDetails == null) return View("NotFound");
            {
                return View(kolorystykaDetails);
            }
        }


        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kolorystykaDetails = await _service.GetByIdAsync(id);
            if (kolorystykaDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
