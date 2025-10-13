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
    public interface INotas
    {
        [OperationContract]
        Nota InsertarNota(Nota nota);

        [OperationContract]
        IEnumerable<Nota> ListarNota();

        [OperationContract]
        Nota ModificarNota(Nota nota);

        [OperationContract]
        Nota EliminarNota(Nota nota);
    }
}
