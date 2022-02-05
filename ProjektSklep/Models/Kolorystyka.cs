using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjektSklep.Models
{
    public class Kolorystyka
    {
        [Key]
        public int KolorystykaId { get; set; }


        [Display(Name = "Nazwa Kolorystyki")]
        [Required(ErrorMessage = "Podaj Nazwe")]
        [StringLength(50,MinimumLength = 3,ErrorMessage = "Nazwa musi zawierać przynajmniej 3 i nie więcej niż 50 znaków")]
        public string Nazwa { get; set; }

        [Display(Name = "Opis")]
        [Required(ErrorMessage = "Podaj Opis")]
        public string Opis { get; set; }


        //Relacje
       
    }
}
