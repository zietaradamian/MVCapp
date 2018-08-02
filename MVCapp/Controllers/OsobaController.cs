using MVCapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCapp.Controllers
{
    public class OsobaController : Controller
    {
        // GET: Osoba
        public ActionResult Index(string szukaj = null)
        {
            IEnumerable<Osoba> listaOsob;
            if (szukaj != null)
            {
                listaOsob = Osoba.PobierzListeOsob().Where(p => p.Imie.Contains(szukaj) || p.Nazwisko.Contains(szukaj) || szukaj == p.Imie + " " + p.Nazwisko).ToArray();
            }
            else
                listaOsob = Osoba.PobierzListeOsob().ToArray();

            if (Request.IsAjaxRequest())
                return PartialView("_ListaOsob", listaOsob);       
                    
            return View(listaOsob);
        }
        public ActionResult OsobaPropozycje(string term)
        {
            var listaOsob = Osoba.PobierzListeOsob().Where(p => p.Imie.Contains(term) || p.Nazwisko.Contains(term))
                .Take(4).Select(p=> new { label = p.Imie + " " + p.Nazwisko });
            return Json(listaOsob, JsonRequestBehavior.AllowGet);
        }
    }
}