using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPapeWPF.ServicioLaPapeWPF;
using System.Collections.ObjectModel;
using System.ServiceModel.Security;
using Entidades;

namespace LaPapeWPF.Modelos
{
    public class GrupoModelo
    {
        public Cat_Grupos_Productos Grupo { get; set; }
        private LaPapeClient servicio;

        public GrupoModelo()
        {
            Grupo = new Cat_Grupos_Productos();
        }

        public Cat_Grupos_Productos Insertar()
        {
            LaPapeClient servicio = new LaPapeClient();
            return servicio.InsertarGrupo(Grupo);
        }

        public ObservableCollection<Cat_Grupos_Productos> Listar()
        {
            servicio = new LaPapeClient();
            if (servicio.ClientCredentials != null)
            {
                servicio.ClientCredentials.UserName.UserName = "Usuario";
                servicio.ClientCredentials.UserName.Password = "secreto";
                servicio.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
            }
            if (servicio == null)
                servicio = new LaPapeClient();
            return servicio.ListarGrupo();
        }
    }
}
