using MVCapp.DAL;
using MVCapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCapp.Controllers
{
    public class CodeFirstController : Controller
    {
        // GET: CodeFirst
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DodajKontakty(CodeFirst codeFirst)
        {
            if(!ModelState.IsValid)
            {
                return View("Index", codeFirst);
            }
            else
            {
                CodeFirstContext db = new CodeFirstContext();
                db.Kontakty.Add(codeFirst);
                db.SaveChanges();
                return View("Index");
            }
           
        }
    }
}