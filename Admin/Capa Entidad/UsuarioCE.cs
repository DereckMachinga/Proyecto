using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class UsuarioCE
    {
        private int id;
        private string nombreusuario;
        private byte contraseña;
        private int idfactura;

        public int Id { get => id; set => id = value; }
        public string Nombreusuario { get => nombreusuario; set => nombreusuario = value; }
        public byte Contraseña { get => contraseña; set => contraseña = value; }
        public int Idfactura { get => idfactura; set => idfactura = value; }

        public UsuarioCE()
        {

        }
        public UsuarioCE(int id, string nombreusuario, byte contraseña, int idfactura)
        {
            this.id = id;
            this.nombreusuario = nombreusuario;
            this.contraseña = contraseña;
            this.idfactura = idfactura;
        }

    }
}
