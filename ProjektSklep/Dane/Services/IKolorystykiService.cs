using ProjektSklep.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjektSklep.Dane.Services
{
    public interface IKolorystykiService
    {
        Task<IEnumerable<Kolorystyka>> GetAllAsync();
        Task<Kolorystyka> GetByIdAsync(int id);
        Task AddAsync(Kolorystyka kolorystyka);

        Task<Kolorystyka> UpdateAsync(int id, Kolorystyka newKolorystyka);
        Task DeleteAsync(int id);



    }
}
