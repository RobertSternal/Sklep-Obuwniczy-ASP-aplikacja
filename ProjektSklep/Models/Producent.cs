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

        [Display(Name = "Logo" )]
        public string Logo { get; set; }
        [Display(Name = "Nazwa Producenta")]
        public string NazwaProducenta { get; set; }
        [Display(Name = "Opis")]
        public string Opis { get; set; }


        //Relacje

        //public List<But> Buty { get; set; }
        public ICollection<But> But { get; set; }
    }
}
