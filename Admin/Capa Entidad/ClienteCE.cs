using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class ClienteCE
    {
        private int id;
        private string nombre;
        private string ruc;
        private string telefono;
        private string email;
        private string direccion;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Ruc { get => ruc; set => ruc = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public ClienteCE()
        {

        }

        public ClienteCE(int id, string nombre, string ruc, string telefono, string email, string direccion)
        {
            this.id = id;
            this.nombre = nombre;
            this.ruc = ruc;
            this.telefono = telefono;
            this.email = email;
            this.direccion = direccion;
        }
    }
}
