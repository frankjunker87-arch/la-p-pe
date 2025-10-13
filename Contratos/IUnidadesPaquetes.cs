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
    public interface IUnidadesPaquetes
    {
        [OperationContract]
        Productos_Unidades_Paquetes InsertarUnidadPaquete(Productos_Unidades_Paquetes unidadPaqueteProducto);

        [OperationContract]
        IEnumerable<Productos_Unidades_Paquetes> ListarUnidadPaquete();

        [OperationContract]
        Productos_Unidades_Paquetes ModificarUnidadPaquete(Productos_Unidades_Paquetes unidadPaqueteProducto);

        [OperationContract]
        Productos_Unidades_Paquetes EliminarUnidadPaquete(Productos_Unidades_Paquetes unidadPaqueteProducto);
    }
}
