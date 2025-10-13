using System.Collections.Generic;
using Entidades;
using System.ServiceModel;

namespace Contratos
{
    [ServiceContract]
    public interface IFamiliasProdcuto
    {
        [OperationContract]
        Cat_Familias_Productos InsertarFamilia(Cat_Familias_Productos familiaProducto);

        [OperationContract]
        IEnumerable<Cat_Familias_Productos> ListarFamilia();

        [OperationContract]
        Cat_Familias_Productos ModificarFamilia(Cat_Familias_Productos familiaProducto);

        [OperationContract]
        Cat_Familias_Productos BorrarFamilia(Cat_Familias_Productos familiaProducto);
    }
}
