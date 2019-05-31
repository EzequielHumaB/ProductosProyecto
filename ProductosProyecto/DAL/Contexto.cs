using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProductosProyecto.Entidades;
using ProductosProyecto.BLL;

namespace ProductosProyecto.DAL
{
   public class Contexto : DbContext
    {
        public DbSet<Productos> producto { get; set; }
        

        public Contexto() : base("ConStr")
        { }

    }
}
