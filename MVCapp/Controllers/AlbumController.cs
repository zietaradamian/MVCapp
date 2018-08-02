using MVCapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCapp.Controllers
{
    public class AlbumController : Controller
    {
        // GET: Album
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Album album)
        {
            //return Content(string.Format("Tytuł: {0} , Autor: {1}, Cena: {2}",album.Tytul,album.Autor,album.Cena));
            return Json(album);
        }
    }
}