using MVCapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCapp.Controllers
{
    public class PracownikController : Controller
    {
        // GET: Pracownik
        public ActionResult Index()
        {
            Pracownik pracownik = new Pracownik()
            {
                PracownikID = 10,
                Imie = "Marcin",
                Nazwisko = "Warwa",
                Miasto = "warszawa",
                Ulica = "Mila 3/12"

            };
            return View(pracownik);
        }
        
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit (int PracownikId,string Imie, string Nazwisko, string Miasto, string Ulica)
        {
            return Content(string.Format("PracownikId {0} Imie: {1} Nazwisko {2} Miasto {3} Ulica {4}",PracownikId,Imie,Nazwisko,Miasto,Ulica));
        }
    }
}