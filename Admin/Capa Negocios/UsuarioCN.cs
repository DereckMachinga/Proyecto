using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocios
{
    public class UsuarioCN
    {
        public void AgregarUsuario(UsuarioCE usuarioCE)
        {
            UsuarioCD usuarioCD = new UsuarioCD();
            usuarioCD.AgregarUsuario(usuarioCE);

        }
    }
}
