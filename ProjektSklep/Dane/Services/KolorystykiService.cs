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

        public void Add(Kolorystyka kolorystyka)
        {
            _context.Kolorystyki.Add(kolorystyka);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Kolorystyka>> GetAll()
        {
            var result = await _context.Kolorystyki.ToListAsync();
            return result;
        }

        public Kolorystyka GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Kolorystyka Update(int id, Kolorystyka newKolorystyka)
        {
            throw new System.NotImplementedException();
        }
    }
}
