using System.ServiceModel;

namespace Contratos
{
    [ServiceContract]
    public interface ILaPape : IProducto, IFamiliasProdcuto, IGruposProducto, IMarcasProducto,
        INotas, IPreciosProducto, IProveedores, ITiposProducto, IUnidadesPaquetes
    {

    }
}
