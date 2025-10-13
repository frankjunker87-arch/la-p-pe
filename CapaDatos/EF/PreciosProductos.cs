using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaDatos.EF
{
    public class PreciosProductos : EFBase<Precios_Prodcutos>
    {
        public PreciosProductos()
        {
            Contexto = new LaPapeEntidades();
            Contexto.Configuration.ProxyCreationEnabled = false;
        }
    }
}
