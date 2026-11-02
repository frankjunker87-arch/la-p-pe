using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.EF;
using Entidades;

namespace CapaLogica
{
    public class TipoLogica
    {
        private TipoProducto contexto;

        public TipoLogica()
        {
            contexto = new TipoProducto();
        }

        public Cat_Tipos_Prodcutos Insertar(Cat_Tipos_Prodcutos entidad)
        {
            return contexto.Agregar(entidad);
        }

        public Cat_Tipos_Prodcutos Modificar(Cat_Tipos_Prodcutos entidad)
        {
            return contexto.Modificar(entidad);
        }

        public Cat_Tipos_Prodcutos BuscarPorId(int id)
        {
            return contexto.BuscarUnico(x => x.Id_Tipo_Prodcuto.Equals(id));
        }

        public IEnumerable<Cat_Tipos_Prodcutos> Listar()
        {
            return contexto.Listar();
        }
    }
}
