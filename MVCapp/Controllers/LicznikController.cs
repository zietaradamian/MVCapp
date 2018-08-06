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

     

        [HttpPost]
        public ActionResult LicznikApplication()
        {
            HttpContext.Application.Lock();
                var licznik = PobierzLicznik();
                licznik.LicznikApplication++;
                UstawLicznik(licznik);
            HttpContext.Application.UnLock();
           
            return RedirectToAction("Index");

        }
        [HttpPost]
        public ActionResult LicznikSesji()
        {
         
            var licznik = PobierzLicznik();
            licznik.LicznikSesji++;
            UstawLicznik(licznik);
            

            return RedirectToAction("Index");

        }
        [HttpPost]
        public ActionResult LicznikCiasteczka()
        {

            var licznik = PobierzLicznik();
            licznik.LicznikCiasteczka++;
            UstawLicznik(licznik);


            return RedirectToAction("Index");

        }

        private void UstawLicznik(Liczniki licznik)
        {
            HttpContext.Application["Licznik"] = licznik.LicznikApplication;
            Session["licznik"] = licznik.LicznikSesji;
            HttpCookie ciasteczko = new HttpCookie("licznik", licznik.LicznikCiasteczka.ToString());
            ciasteczko.Expires = DateTime.Now.AddDays(5);
            Response.SetCookie(ciasteczko);
        }

        private Liczniki PobierzLicznik()
        {
            var licznik = new Liczniki();

            //Application
            if (HttpContext.Application["Licznik"] != null)
            {
                licznik.LicznikApplication = (int)HttpContext.Application["licznik"];
            }
            else
                licznik.LicznikApplication = 0;
            

            //Sesja

            if (Session["licznik"] != null)
                licznik.LicznikSesji = (int)Session["licznik"];
            else
                licznik.LicznikSesji = 0;

            //Ciasteczka

            if (Request.Cookies["licznik"] != null)
                licznik.LicznikCiasteczka = int.Parse(Request.Cookies["licznik"].Value);
            else
                licznik.LicznikCiasteczka = 0;


            return licznik;
        }
    }
}