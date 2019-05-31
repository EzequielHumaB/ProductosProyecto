using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProductosProyecto.DAL;

namespace ProductosProyecto.Entidades
{
   public class Productos
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int ProductoID { get; set; }
        public string Descripcion { get; set; }
        public int existencia { get; set; }
        public float costo { get; set; }
        public float ValorInventario { get; set; }



        public Productos()
        {
            ProductoID = 0;
            Descripcion = string.Empty;
            existencia = 0;
            costo = 0.0f;
            ValorInventario = 0.0f;
        }

    }
}
