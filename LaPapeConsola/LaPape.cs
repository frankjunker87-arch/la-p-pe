using System;
using Contratos;
using System.ServiceModel;
using Entidades;
using LaPapeConsola.ServicioLaPape;

namespace LaPapeConsola
{
    class LaPape
    {
        static void Main(string[] args)
        {
            //ILaPape servicio = new Servicios.LaPapeClient();
            //var grupos = servicio.ListarGrupo();
     
            var binding = new BasicHttpBinding();
            var endPoint = new EndpointAddress(new Uri("http://localhost:8733/Design_Time_Addresses/Servicios/LaPape/"));
            var channel = new ChannelFactory<Contratos.ILaPape>(binding, endPoint);
            Contratos.ILaPape servicio = channel.CreateChannel();

            servicio.InsertarGrupo(new Cat_Grupos_Productos()
                {
                   Descripcion_Grupo_Producto = "LIB0001"

                });

            var grupoProducto = servicio.ListarGrupo();
           
        }
    }
}
