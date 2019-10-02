using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Capa_Entidad;

namespace Capa_Datos
{
    public class UsuarioCD
    {
        public void AgregarUsuario(UsuarioCE usuarioCE)
        {
            ConexionCD conexion = new ConexionCD();
            SqlConnection cnx = conexion.ConectarSQLserver();
            cnx.Open();

            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AGREGARUSUARIO";

            cmd.Parameters.AddWithValue("@nombreusuario",usuarioCE.Nombreusuario);
            cmd.Parameters.AddWithValue("@constraseña", usuarioCE.Contraseña);
            cmd.Parameters.AddWithValue("@nombreusuario", usuarioCE.Idfactura);

            cmd.ExecuteNonQuery();
            cnx.Close();

        }
    }
}
