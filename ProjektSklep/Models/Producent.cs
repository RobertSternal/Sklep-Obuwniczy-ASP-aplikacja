using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjektSklep.Models
{
    public class Producent
    {
        public Producent()
        {
            But = new HashSet<But>();
        }
        [Key]
        public int ProducentId { get; set; }

        public string Logo { get; set; }
        public string NazwaProducenta { get; set; }
        public string Opis { get; set; }


        //Relacje

        //public List<But> Buty { get; set; }
        public ICollection<But> But { get; set; }
    }
}
