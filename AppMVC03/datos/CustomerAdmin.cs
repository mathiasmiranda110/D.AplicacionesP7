using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppMVC03.Models;

namespace AppMVC03.datos
{
    public class CustomerAdmin
    {
        public IEnumerable<venta> Consultar()
        {
            using (VENTASEntities contexto = new VENTASEntities())
            {
                return contexto.venta.AsNoTracking().ToList();
            }
        }
        public venta Consultar(int id)
        {
            using (VENTASEntities contexto = new VENTASEntities())
            {
                return contexto.venta.AsNoTracking().FirstOrDefault(c =>
               c.idventa == id);
            }
        }
        public void Guardar(venta modelo)
        {
            using (VENTASEntities contexto = new VENTASEntities())
            {
             
            contexto.venta.Add(modelo);
                contexto.SaveChanges();
            }
        }
        public void Modificar(venta modelo)
        {
            using (VENTASEntities contexto = new VENTASEntities())
            {
                /*contexto.Entry(modelo).State =
               System.Data.Entity.EntityState.Modified;*/
                contexto.SaveChanges();
            }
        }
        public void Eliminar(venta modelo)
        {
            using (VENTASEntities contexto = new VENTASEntities())
            {
                /*contexto.Entry(modelo).State =
               System.Data.Entity.EntityState.Deleted;*/
                contexto.SaveChanges();
            }
        }

    }
}