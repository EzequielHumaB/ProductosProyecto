using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using ProductosProyecto.Entidades;
using ProductosProyecto.DAL;
using System.Data.Entity;
using System.Linq.Expressions;

namespace ProductosProyecto.BLL
{
   public class ProductosClase
    {
        public static bool guardar(Productos productos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.producto.Add(productos) != null)
                    paso = contexto.SaveChanges() > 0;

            } catch(Exception)
            {
                throw;
            }
            return paso;
        }
      
        public static bool Modificar (Productos productos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(productos).State = System.Data.Entity.EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            } catch(Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
    }
}
