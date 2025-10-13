using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.EF;
using Entidades;

namespace CapaLogica
{
    public class ProductoLogica
    {
        private ProductoEF contexto;

        public ProductoLogica()
        {
            contexto = new ProductoEF();
        }

        public Producto Insertar(Producto entidad)
        {
            return contexto.Agregar(entidad);
        }

        public Producto Modificar(Producto entidad)
        {
            return contexto.Modificar(entidad);
        }

        public Producto BuscarPorSKU(string sku)
        {
            return contexto.BuscarUnico(x => x.SKU.Equals(sku));
        }

        public IEnumerable<Producto> Listar()
        {
            return contexto.Listar();
        }
    }
}
