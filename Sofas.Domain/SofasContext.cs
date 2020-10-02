﻿using Microsoft.EntityFrameworkCore;
using System;

namespace Sofas.Domain
{
    public class SofasContext : DbContext
    {
        public SofasContext(DbContextOptions<SofasContext> options): base(options)
        {
             

        }

        public DbSet<Consumibles> consumibles{ get; set; }

        public DbSet<Instrumentos> instrumentos { get; set; }

        public DbSet<Consumibles_Count> consumibles_Counts { get; set; }

        public class Consumibles
        {
            public int id { get; set; }
            public string Producto { get; set; }
           // public string MyProperty { get; set; }
        }
        public class Instrumentos
        {
            public int id { get; set; }
            public string Consumibles { get; set; }
            //public string MyProperty { get; set; }
        }
        public class Instrumentos_Count
        {
            public int id { get; set; }
            public string cantidad { get; set; }
            //public string MyProperty { get; set; }
        }
        public class Consumibles_Count
        {
            public int id { get; set; }
            public string cantidad { get; set; }
            //public string MyProperty { get; set; }
        }

    }
}
