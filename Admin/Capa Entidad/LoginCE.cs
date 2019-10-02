using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class LoginCE
    {
        private String usuario;
        private String contraseña;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

        public LoginCE()
        {

        }
        public LoginCE(string usuario, string contraseña)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
        }
    }
}
