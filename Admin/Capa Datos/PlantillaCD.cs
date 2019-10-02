using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data.SqlClient;
using System.Data;
using Capa_Entidad.Cach;

namespace Capa_Datos
{
    public class PlantillaCD
    {
        public bool Login(string usuario, string clave)
        {
            ConexionCD cnx = new ConexionCD();
            SqlConnection con = cnx.ConectarSQLserver();
            con.Open();
            SqlCommand cos = con.CreateCommand();
            cos.CommandType = CommandType.Text;
            cos.CommandText = "select * from Usuario where nombreusuario=@nombreusuario and contraseña = @contraseña";
            cos.Parameters.AddWithValue("nombreusuario", usuario);
            cos.Parameters.AddWithValue("contraseña", clave);
            SqlDataReader rd = cos.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {

                    LoginCach.codigo = rd.GetInt32(0);
                    LoginCach.nombreYapellido = rd.GetString(1);
                   

                }
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}

