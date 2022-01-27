using ProjektSklep.Dane;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjektSklep.Models
{
    public class But
    {
        public But()
        {
            Kolorystyka = new HashSet<Kolorystyka>();
        }

        [Key]
        public int ButId { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public double Cena { get; set; }
        public string Logo { get; set; }

        public KategoriaButa kategoriaButa { get; set; }



        //Relacje
      

        //Producent
        //public int ProducentId { get; set; }
        //[ForeignKey("ProducentId")]
        public Producent Producent { get; set; }

        //public int KolorystykaId { get; set; }
        //[ForeignKey("KolorystykaId")]
        //public Kolorystyka Kolorystyka { get; set; }
        public ICollection<Kolorystyka> Kolorystyka { get; set; }

        public enum KategoriaButa
        {
            Lifestyle = 1,
            Sportowe = 2,
            Zimowe = 3
        }
    }
}
