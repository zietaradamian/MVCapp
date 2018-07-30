using MVCapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCapp.Controllers
{
    public class DateController : Controller
    {
        // GET: Date
        public ActionResult Index()
        {
            var date = new Date()
            {
                DateTime = new DateTime(2016,1,30),
                Bool = true,
                String = "Asp MVC",
                Decimal = 123123.12m,
                Int = 250
                
            };
            return View(date);
        }
    }
}