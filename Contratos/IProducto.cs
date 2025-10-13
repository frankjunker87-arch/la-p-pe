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
    public interface IProducto
    {
        [OperationContract]
        Producto InsertarProducto(Producto producto);

        [OperationContract]
        IEnumerable<Producto> ListarProducto();

        [OperationContract]
        Producto ModificarProducto(Producto producto);

        [OperationContract]
        Producto EliminarProducto(Producto producto);
    }
}
