using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjektSklep.Models
{
    public class Kolorystyka
    {
        [Key]
        public int KolorystykaId { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }


        //Relacje
       
    }
}
