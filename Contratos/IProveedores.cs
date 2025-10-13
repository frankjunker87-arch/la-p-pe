using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.ServiceModel;

namespace Contratos
{
    [ServiceContract]
    public interface IProveedores
    {
        [OperationContract]
        Cat_Provedores InsertarProveedor(Cat_Provedores proveedor);

        [OperationContract]
        IEnumerable<Cat_Provedores> ListarProveedor();

        [OperationContract]
        Cat_Provedores ModificarProveedor(Cat_Provedores proveedor);

        [OperationContract]
        Cat_Provedores EliminarProveedor(Cat_Provedores proveedor);
    }
}
