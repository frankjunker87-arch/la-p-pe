using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaDatos.EF
{
    public class ProductoEF : EFBase<Producto>
    {
        LaPapeEntidades contexto = new LaPapeEntidades();

        public ProductoEF()
        {
            contexto = new LaPapeEntidades();
            contexto.Configuration.ProxyCreationEnabled = false;
        }
        public Producto insertarProducto(Producto entidad)
        {
            Producto personaAgregada = contexto.Productos.Add(entidad);
            contexto.SaveChanges();
            return personaAgregada;
        }

        public void modificarProducto(Producto entidad)
        {
            contexto.Set<Producto>().Attach(entidad);
            contexto.Entry(entidad).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void eliminarProducto(Producto entidad)
        {
            contexto.Set<Producto>().Attach(entidad);
            contexto.Set<Producto>().Remove(entidad);
            contexto.SaveChanges();
        }

        public Producto buscarSKUProducto(string sku)
        {
            return contexto.Productos.FirstOrDefault(x => x.SKU.Equals(sku));
        }

        public Producto buscarNombreProducto(string descripcion)
        {
            return contexto.Productos.FirstOrDefault(x => x.Descripcion_Producto.Equals(descripcion));
        }
    }
}
