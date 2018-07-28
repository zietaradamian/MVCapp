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
        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit ([Bind(Exclude ="PracownikId")] Pracownik pracownik)
        {
            return View();
        }
       
    }
}