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
    public interface IMarcasProducto
    {
        [OperationContract]
        Cat_Marcas_Prodcutos InsertarMarca(Cat_Marcas_Prodcutos marcaProducto);

        [OperationContract]
        IEnumerable<Cat_Marcas_Prodcutos> ListarMarca();

        [OperationContract]
        Cat_Marcas_Prodcutos ModificarMarca(Cat_Marcas_Prodcutos marcaProducto);

        [OperationContract]
        Cat_Marcas_Prodcutos EliminarMarca(Cat_Marcas_Prodcutos marcaProducto);
    }
}
