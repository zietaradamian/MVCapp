using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCapp.Models
{
    public class Liczniki
    {
        private static int _licznikstatyczny;
        public int LicznikStatyczny
        {
            get {
                return Liczniki._licznikstatyczny;
            }
            set {
                Liczniki._licznikstatyczny = value;
            }
        }
        public int LicznikApplication { get; set; }
        public int LicznikSesji { get; set; }
    }
}