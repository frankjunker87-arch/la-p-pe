using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaDatos.EF
{
    public class Proveedor : EFBase<Cat_Provedores>
    {
        public Proveedor()
        {
            Contexto = new LaPapeEntidades();
            Contexto.Configuration.ProxyCreationEnabled = false;
        }
    }
}
