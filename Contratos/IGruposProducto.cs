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
    public interface IGruposProducto
    {
        [OperationContract]
        Cat_Grupos_Productos InsertarGrupo(Cat_Grupos_Productos grupoProducto);

        [OperationContract]
        IEnumerable<Cat_Grupos_Productos> ListarGrupo();

        [OperationContract]
        Cat_Grupos_Productos ModificarGrupo(Cat_Grupos_Productos grupoProducto);

        [OperationContract]
        Cat_Grupos_Productos EliminarGrupo(Cat_Grupos_Productos grupoProducto);
    }
}
