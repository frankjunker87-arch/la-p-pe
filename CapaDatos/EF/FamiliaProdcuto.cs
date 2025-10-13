using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaDatos.EF
{
    public class FamiliaProdcuto : EFBase<Cat_Familias_Productos>
    {
        public FamiliaProdcuto()
        {
            Contexto = new LaPapeEntidades();
            Contexto.Configuration.ProxyCreationEnabled = false;
        }
    }
}
