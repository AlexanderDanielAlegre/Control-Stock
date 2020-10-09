using Microsoft.EntityFrameworkCore;
using Sofas.Domain.Models;
using System;

namespace Sofas.Domain
{
    public class SofasContext : DbContext
    {
        public SofasContext(DbContextOptions<SofasContext> options): base(options)
        {
            //Database.OpenConnection();

        }

        public DbSet<Consumibles> consumibles{ get; set; }

        public DbSet<Instrumentos> instrumentos { get; set; }

        public DbSet<Consumibles_Count> consumibles_Counts { get; set; }

        public DbSet<ToDo> toDos { get; set; }
        //public class Instrumentos
        //{
        //    public int id { get; set; }
        //    public string Consumibles { get; set; }
        //    //public string MyProperty { get; set; }
        //}
        //public class Instrumentos_Count
        //{
        //    public int id { get; set; }
        //    public string cantidad { get; set; }
        //    //public string MyProperty { get; set; }
        //}
        //public class Consumibles_Count
        //{
        //    public int id { get; set; }
        //    public string cantidad { get; set; }
        //    //public string MyProperty { get; set; }
        //}
        //public class ToDo
        //{
        //    public int id { get; set; }
        //    public string descripcion { get; set; }
        //    public bool completado { get; set; }
        //}
    }
}
