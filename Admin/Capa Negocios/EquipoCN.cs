using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocios
{
    public class EquipoCN
    {
        public void AgregarEquipo(EquipoCE equipoCE)
        {
            EquipoCD equipoCD = new EquipoCD();
            equipoCD.AgregarEquipo(equipoCE);
        }
        public void EditarEquipo(EquipoCE equipoCE)
        {
            EquipoCD equipoCD = new EquipoCD();
            equipoCD.ActulizarEquipo(equipoCE);
        }
        public List<EquipoCE> Listar()
        {
            EquipoCD equipoCD = new EquipoCD();
            return equipoCD.ListarEquipos();
        }
    }
}
