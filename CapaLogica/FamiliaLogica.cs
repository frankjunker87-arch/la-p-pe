using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.EF;
using Entidades;

namespace CapaLogica
{
    public class FamiliaLogica
    {
        private FamiliaProdcuto contexto;

        public FamiliaLogica()
        {
            contexto = new FamiliaProdcuto();
        }

        public Cat_Familias_Productos Insertar(Cat_Familias_Productos entidad)
        {
            return contexto.Agregar(entidad);
        }

        public Cat_Familias_Productos Modificar(Cat_Familias_Productos entidad)
        {
            return contexto.Modificar(entidad);
        }

        public Cat_Familias_Productos BuscarPorId(int id)
        {
            return contexto.BuscarUnico(x => x.Id_Familia_Producto.Equals(id));
        }

        public IEnumerable<Cat_Familias_Productos> Listar()
        {
            return contexto.Listar();
        }
    }
}
