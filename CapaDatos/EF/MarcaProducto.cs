using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaDatos.EF
{
    public class MarcaProducto : EFBase<Cat_Marcas_Prodcutos>
    {
        public MarcaProducto()
        {
            Contexto = new LaPapeEntidades();
            Contexto.Configuration.ProxyCreationEnabled = false;
        }
    }
}
