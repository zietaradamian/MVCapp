using MVCapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCapp.Controllers
{
    public class KursController : Controller
    {
        // GET: Kurs
        public ActionResult Index()
        {
            List<Kurs> courses = new List<Kurs>
            {
                new Kurs() { Nazwa="Tworzenie stron WWW" , Opis = "Kurs tworzenia stron www"},
                new Kurs() { Nazwa = "Jakis tam kursik", Opis = "opisu kursiku"},
                new Kurs() { Nazwa= "ASP.NET MVC" , Opis="Nauka ASP"}
            };
            return View(courses);
        }
        [ChildActionOnly]
        public ActionResult PobierzGodzinePartial()
        {
            var czas = DateTime.Now.ToLongTimeString();
            return PartialView("PartialCzas",czas);
        }
        [ChildActionOnly]
        public string PobierzGodzine()
        {
            return DateTime.Now.ToLongTimeString();
            
        }

    }
}