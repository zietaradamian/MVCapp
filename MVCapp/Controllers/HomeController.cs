using MVCapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCapp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Przyklad()
        {

            return View();
        }
        public ActionResult Index()
        {
            //var kontakty = new List<Kontakt> { new Kontakt { Imie = "adam" , Nazwisko="Nowak", Miasto="Katowice", Ulica="Andersa"},
            //new Kontakt { Imie = "Tomasz" , Nazwisko="Gromek", Miasto="Krakow", Ulica="Roweck"},
            //new Kontakt { Imie = "Jacek" , Nazwisko="Limpa", Miasto="Warszawa", Ulica="Pilsudcki"}
            //};
            //ViewBag.Kontakty = kontakty;
            //var wynik = RouteTable.Routes.GetVirtualPath(null, new RouteValueDictionary(new { Controller = "mojKontroler", Action = "MojaAkcja", id = "453", parametr = "marcin" }));
            //string s = wynik.VirtualPath;
            //return s;
            KontaktyModelContainer db = new KontaktyModelContainer();
            var kontakty = db.KontaktySet.FirstOrDefault();

            return View(kontakty);
        }
        public ActionResult Parametry(int par1, int par2, string par3)
        {
            var test = (string.Format("par1: {0}, par2: {1}, par3: {2}", par1, par2, par3) );
            return View();
        }
        public void Parametry2(Ksiazka a)
        {
            Response.Write(string.Format("Tytuł: {0}, Autor: {1}, Cena: {2}", a.Tytul, a.Autor, a.Cena));
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Formularz()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Post(string parametr)
        {
            TempData["Parametr"] = parametr;
            return RedirectToAction("PRG");
        }

        public ActionResult PRG()
        {
            ViewBag.Parametr = TempData["Parametr"];
            return View();
        }
    }
}