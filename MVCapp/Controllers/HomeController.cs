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
        public string Index()
        {
            //var kontakty = new List<Kontakt> { new Kontakt { Imie = "adam" , Nazwisko="Nowak", Miasto="Katowice", Ulica="Andersa"},
            //new Kontakt { Imie = "Tomasz" , Nazwisko="Gromek", Miasto="Krakow", Ulica="Roweck"},
            //new Kontakt { Imie = "Jacek" , Nazwisko="Limpa", Miasto="Warszawa", Ulica="Pilsudcki"}
            //};
            //ViewBag.Kontakty = kontakty;
            var wynik = RouteTable.Routes.GetVirtualPath(null, new RouteValueDictionary(new { Controller = "mojKontroler", Action = "MojaAkcja", id = "453", parametr = "marcin" }));
            string s = wynik.VirtualPath;
            return s;

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
    }
}