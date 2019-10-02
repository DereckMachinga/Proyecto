using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using System.Data.SqlClient;
using System.Data;

namespace Capa_Datos
{
    public class LoginCD
    {
        public string Logueo (LoginCE loginCE)
        {
            Conexion conexion = new Conexion();
            SqlConnection cnx = conexion.ConectarSql();
            cnx.Open();
            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select dbo.VerificarLogin(@usuario, @clave)as verif ";
            cmd.Parameters.AddWithValue("@usuario", loginCE.Usuario);
            cmd.Parameters.AddWithValue("@contraseña", loginCE.Contraseña);

            SqlDataReader dr = cmd.ExecuteReader();
            string verif;
            dr.Read();
            verif = dr["verif"].ToString();
            cnx.Close();
            return verif;
        }

        
    }
}
