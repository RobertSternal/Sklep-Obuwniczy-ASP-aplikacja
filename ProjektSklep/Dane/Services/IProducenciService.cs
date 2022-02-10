using ProjektSklep.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjektSklep.Dane.Services
{
    public interface IProducenciService
    {
        Task<IEnumerable<Producent>> GetAllAsync();
        Task<Producent> GetByIdAsync(int id);
        Task AddAsync(Producent producent);

        Task<Producent> UpdateAsync(int id, Producent newProducent);
        Task DeleteAsync(int id);



    }
}
