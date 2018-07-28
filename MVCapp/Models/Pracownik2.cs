using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCapp.Models
{
    public class Pracownik2
    {
        [ScaffoldColumn(false)]
        public int PracownikID { get; set; }

        [Display(Name = "Wprowadź imie: ")]
        [Required(ErrorMessage = "Musisz wprowadzić imie !")]
        [StringLength(30)]
        public string Imie { get; set; }
        [Display(Name = "Wiek pracownika: ")]
        [Required(ErrorMessage = "Musisz wprowadzić wiek !")]
        [Range(18,70)]
        public int Wiek { get; set; }
        [Display(Name = "Email pracownika: ")]
        [Required(ErrorMessage = "Musisz wprowadzić email !")]
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
       
        public string NumerTelefonu { get; set; }
        [Display(Name = "Pytanie do szefa: ")]
        [DataType(DataType.MultilineText)]
        public string Pytanie { get; set; }
    }
}