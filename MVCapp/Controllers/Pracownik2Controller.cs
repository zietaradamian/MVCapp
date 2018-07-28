using MVCapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCapp.Controllers
{
    public class Pracownik2Controller : Controller
    {
        // GET: Pracownik2
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Pracownik2 pracownik2)
        {
            if(!ModelState.IsValid)
            {
                return View("Index", pracownik2);
            }
            else
            {
                //kod do wprowadzania do bazy danych
                return View("Index");
            }
            
        }
    }
}