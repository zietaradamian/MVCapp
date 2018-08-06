using MVCapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCapp.Controllers
{
    public class LicznikController : Controller
    {
        private object licznikStatycznyBlokada = new object();
        // GET: Licznik
        public ActionResult Index()
        {
            var licznik = PobierzLicznik();
            return View(licznik);
        }
        [HttpPost]
        public ActionResult LicznikStatyczny()
        {
            lock(licznikStatycznyBlokada)
            {
                var licznik = PobierzLicznik();
                licznik.LicznikStatyczny++;
            }
            return RedirectToAction("Index");

        }

        private Liczniki PobierzLicznik()
        {
            var licznik = new Liczniki();
            return licznik;
        }
    }
}