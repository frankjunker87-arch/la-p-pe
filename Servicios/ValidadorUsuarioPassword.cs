using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel;
using System.IdentityModel.Selectors;
using System.ServiceModel;

namespace Servicios
{
    class ValidadorUsuarioPassword : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (userName == null || password == null)
            {
                throw new ArgumentNullException();
            }
            if (!(userName == "Un Usuario" && password == "secreto"))
            {
                throw new FaultException("Nombre de usuario o password incorrecto");
            }
        }
    }
}
