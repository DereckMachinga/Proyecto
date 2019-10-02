using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class EquipoCE
    {
        private int id;
        private string serie;
        private string marca;
        private string modeloplaca;
        private string dislpay;
        private string descripcion;
        private string generacion;
        private string proviene;
        private string destino;

        
        public int Id { get => id; set => id = value; }
        public string Serie { get => serie; set => serie = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modeloplaca { get => modeloplaca; set => modeloplaca = value; }
        public string Dislpay { get => dislpay; set => dislpay = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Generacion { get => generacion; set => generacion = value; }
        public string Proviene { get => proviene; set => proviene = value; }
        public string Destino { get => destino; set => destino = value; }

        public EquipoCE()
        {

        }
        public EquipoCE(int id, string serie, string marca, string modeloplaca, string dislpay, 
            string descripcion, string generacion, string proviene, string destino)
        {
            this.Id = id;
            this.Serie = serie;
            this.Marca = marca;
            this.Modeloplaca = modeloplaca;
            this.Dislpay = dislpay;
            this.Descripcion = descripcion;
            this.Generacion = generacion;
            this.Proviene = proviene;
            this.Destino = destino;
        }
    }
}
