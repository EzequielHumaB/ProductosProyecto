using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProductosProyecto.Entidades;

namespace ProductosProyecto.DAL
{
   public class Contexto
    {
       DbSet<Productos> productos { get; set; }

    }
}
