using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCapp.DAL;
using MVCapp.Models;

namespace MVCapp.Controllers
{
    public class AdminController : Controller
    {
        private CodeFirstContext db = new CodeFirstContext();

        // GET: Admin
        public ActionResult Index()
        {
            return View(db.Kontakty.ToList());
        }

        // GET: Admin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodeFirst codeFirst = db.Kontakty.Find(id);
            if (codeFirst == null)
            {
                return HttpNotFound();
            }
            return View(codeFirst);
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KontaktID,Imie,Nazwisko,Email,NowePole")] CodeFirst codeFirst)
        {
            if (ModelState.IsValid)
            {
                db.Kontakty.Add(codeFirst);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(codeFirst);
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodeFirst codeFirst = db.Kontakty.Find(id);
            if (codeFirst == null)
            {
                return HttpNotFound();
            }
            return View(codeFirst);
        }

        // POST: Admin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KontaktID,Imie,Nazwisko,Email,NowePole")] CodeFirst codeFirst)
        {
            if (ModelState.IsValid)
            {
                db.Entry(codeFirst).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(codeFirst);
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CodeFirst codeFirst = db.Kontakty.Find(id);
            if (codeFirst == null)
            {
                return HttpNotFound();
            }
            return View(codeFirst);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CodeFirst codeFirst = db.Kontakty.Find(id);
            db.Kontakty.Remove(codeFirst);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
