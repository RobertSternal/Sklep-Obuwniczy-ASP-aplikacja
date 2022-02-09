using Microsoft.EntityFrameworkCore;
using ProjektSklep.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklep.Dane.Services
{
    public class KolorystykiService : IKolorystykiService
    {

        private readonly AppDbContext _context;
        
        public KolorystykiService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Kolorystyka kolorystyka)
        {
            await _context.Kolorystyki.AddAsync(kolorystyka);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Kolorystyki.FirstOrDefaultAsync(n => n.KolorystykaId == id);
            _context.Kolorystyki.Remove(result);
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Kolorystyka>> GetAllAsync()
        {
            var result = await _context.Kolorystyki.ToListAsync();
            return result;
        }

        public async Task<Kolorystyka> GetByIdAsync(int id)
        {
            var result = await _context.Kolorystyki.FirstOrDefaultAsync(n => n.KolorystykaId == id);   
            return result;
        }

        public async Task<Kolorystyka> UpdateAsync(int id, Kolorystyka newKolorystyka)
        {
            _context.Update(newKolorystyka);
            await _context.SaveChangesAsync();
            return newKolorystyka;
        }
    }
}
