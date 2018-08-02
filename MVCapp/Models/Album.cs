using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCapp.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string Tytul { get; set; }
        public string Autor { get; set; }
        public double Cena { get; set; }
    }
}