using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCapp.Models
{
    public class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public static IEnumerable<Osoba> PobierzListeOsob()
        {
            var osoby = new List<Osoba>
            {
                new Osoba() { Imie="Andrzej", Nazwisko="Maien"},
                new Osoba() { Imie="Arek", Nazwisko="Nowak"},
                new Osoba() { Imie="Amadeusz", Nazwisko="Maien"},
                new Osoba() { Imie="Rysiu", Nazwisko="krowka"},
                new Osoba() { Imie="Andrzej", Nazwisko="Maien"},
                new Osoba() { Imie="Andrzej", Nazwisko="Maien"},
                new Osoba() { Imie="Andrzej", Nazwisko="eryk"},
                new Osoba() { Imie="WArrr", Nazwisko="Maien"},
                new Osoba() { Imie="Andrzej", Nazwisko="Maien"},
                new Osoba() { Imie="Warsza", Nazwisko="Wigra"},
                new Osoba() { Imie="Aleksandy", Nazwisko="Maien"},
                new Osoba() { Imie="Andrzej", Nazwisko="Maien"},
            };

            return osoby;
        }
    }   
}