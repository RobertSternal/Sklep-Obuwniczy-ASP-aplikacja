using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjektSklep.Dane.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T kolorystyka);

        Task<T> UpdateAsync(int id, T newKolorystyka);
        Task DeleteAsync(int id);
    }
}
