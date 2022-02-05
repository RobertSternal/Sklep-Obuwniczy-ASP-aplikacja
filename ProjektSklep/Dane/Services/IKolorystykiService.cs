using ProjektSklep.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjektSklep.Dane.Services
{
    public interface IKolorystykiService
    {
        Task<IEnumerable<Kolorystyka>> GetAll();
        Kolorystyka GetById(int id);
        void Add(Kolorystyka kolorystyka);

        Kolorystyka Update(int id, Kolorystyka newKolorystyka);
        void Delete(int id);



    }
}
