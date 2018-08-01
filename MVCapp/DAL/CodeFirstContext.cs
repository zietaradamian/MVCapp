﻿using MVCapp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCapp.DAL
{
    public class CodeFirstContext : DbContext

    {

        public CodeFirstContext() : base("CodeFirstConnectionString") { }

        public DbSet<CodeFirst> Kontakty { get; set; }
        public DbSet<Pytanie> Pytania { get; set; }
    }
}