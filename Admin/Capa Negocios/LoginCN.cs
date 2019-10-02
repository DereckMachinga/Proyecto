using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocios
{
    public class LoginCN
    {
        public string loguear(LoginCE inicioSesion)
        {
            LoginCD inicioSesionCD = new LoginCD();
            string verif = inicioSesionCD.Logueo(inicioSesion);
            return verif;
        }
    }
}
