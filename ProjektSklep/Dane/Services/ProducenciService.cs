using Microsoft.EntityFrameworkCore;
using ProjektSklep.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektSklep.Dane.Services
{
    public class ProducenciService : IProducenciService
    {

        private readonly AppDbContext _context;
        
        public ProducenciService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Producent producent)
        {
            await _context.Producenci.AddAsync(producent);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Producenci.FirstOrDefaultAsync(n => n.ProducentId == id);
            _context.Producenci.Remove(result);
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Producent>> GetAllAsync()
        {
            var result = await _context.Producenci.ToListAsync();
            return result;
        }

        public async Task<Producent> GetByIdAsync(int id)
        {
            var result = await _context.Producenci.FirstOrDefaultAsync(n => n.ProducentId == id);   
            return result;
        }

        public async Task<Producent> UpdateAsync(int id, Producent newProducent)
        {
            _context.Update(newProducent);
            await _context.SaveChangesAsync();
            return newProducent;
        }
    }
}
