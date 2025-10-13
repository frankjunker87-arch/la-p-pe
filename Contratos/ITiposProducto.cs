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
    public interface ITiposProducto
    {
        [OperationContract]
        Cat_Tipos_Prodcutos InsertarTipo(Cat_Tipos_Prodcutos tipoProducto);

        [OperationContract]
        IEnumerable<Cat_Tipos_Prodcutos> ListarTipo();

        [OperationContract]
        Cat_Tipos_Prodcutos ModificarTipo(Cat_Tipos_Prodcutos tipoProducto);

        [OperationContract]
        Cat_Tipos_Prodcutos EliminarTipo(Cat_Tipos_Prodcutos tipoProducto);
    }
}
