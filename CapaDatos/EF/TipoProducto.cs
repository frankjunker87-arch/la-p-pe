using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaDatos.EF
{
    public class TipoProducto : EFBase<Cat_Tipos_Prodcutos>
    {
        public TipoProducto()
        {
            Contexto = new LaPapeEntidades();
            Contexto.Configuration.ProxyCreationEnabled = false;
        }
    }
}
