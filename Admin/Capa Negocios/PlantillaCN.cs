using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Negocios;
using Capa_Datos;

namespace Capa_Negocios
{
    public class PlantillaCN
    {
        PlantillaCD PlantillaCD = new PlantillaCD();
        public bool Login(string usuario, string clave)
        {
            return PlantillaCD.Login(usuario, clave);
        }

    }
}
