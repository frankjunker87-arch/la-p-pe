using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.EF;
using Entidades;

namespace CapaLogica
{
    public class MarcaLogica
    {
        private MarcaProducto contexto;

        public MarcaLogica()
        {
            contexto = new MarcaProducto();
        }

        public Cat_Marcas_Prodcutos Insertar(Cat_Marcas_Prodcutos entidad)
        {
            return contexto.Agregar(entidad);
        }

        public Cat_Marcas_Prodcutos Modificar(Cat_Marcas_Prodcutos entidad)
        {
            return contexto.Modificar(entidad);
        }

        public Cat_Marcas_Prodcutos BuscarPorId(int id)
        {
            return contexto.BuscarUnico(x => x.Id_Marca_Prodcuto.Equals(id));
        }

        public IEnumerable<Cat_Marcas_Prodcutos> Listar()
        {
            return contexto.Listar();
        }
    }
}
