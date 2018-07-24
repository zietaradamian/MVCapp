using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCapp.Controllers
{
    [RoutePrefix("AtrybutPrefix")]
    public class SklepController : Controller
    {
        // GET: Sklep

        [Route("atrybut/routing/{parametr}/trasa")]
        public string Index(string parametr)
        {
            return "Definiowanie tras- Atrybuty";
        }
        [Route("{parametr:int}")]
        public string Test(string parametr)
        {
            return parametr;
        }
    }
}