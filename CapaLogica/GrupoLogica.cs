using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.EF;
using Entidades;

namespace CapaLogica
{
    public class GrupoLogica
    {
        private GrupoProducto contexto;

        public GrupoLogica()
        {
            contexto = new GrupoProducto();
        }

        public Cat_Grupos_Productos Insertar(Cat_Grupos_Productos entidad)
        {
            return contexto.Agregar(entidad);
        }

        public Cat_Grupos_Productos Modificar(Cat_Grupos_Productos entidad)
        {
            return contexto.Modificar(entidad);
        }

        public Cat_Grupos_Productos BuscarPorSKU(string id)
        {
            return contexto.BuscarUnico(x => x.Id_Grupo_Producto.Equals(id));
        }

        public IEnumerable<Cat_Grupos_Productos> Listar()
        {
            return contexto.Listar();
        }
    }
}
