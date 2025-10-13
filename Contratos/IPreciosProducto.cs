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
    public interface IPreciosProducto
    {
        [OperationContract]
        Precios_Prodcutos InsertarPrecio(Precios_Prodcutos precioProducto);

        [OperationContract]
        IEnumerable<Precios_Prodcutos> ListarPrecio();

        [OperationContract]
        Precios_Prodcutos ModificarPrecio(Precios_Prodcutos precioProducto);

        [OperationContract]
        Precios_Prodcutos EliminarPrecio(Precios_Prodcutos precioProducto);
    }
}
