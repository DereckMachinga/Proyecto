using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class ClienteCD
    {
        public List<ClienteCE> ListarClientes()
        {
            ConexionCD conexion = new ConexionCD();
            SqlConnection cnx = conexion.ConectarSQLserver();
            cnx.Open();
            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Clientes";

            SqlDataReader dr = cmd.ExecuteReader();
            List<ClienteCE> listaClientes = new List<ClienteCE>();

            while (dr.Read())
            {
                ClienteCE clienteCE = new ClienteCE();
                clienteCE.Nombre = dr["nombre"].ToString();
                clienteCE.Ruc = dr["ruc"].ToString();
                clienteCE.Telefono = dr["display"].ToString();
                clienteCE.Email = dr["descripcion"].ToString();
                clienteCE.Direccion = dr["direccion"].ToString();

                listaClientes.Add(clienteCE);
            }
            cnx.Close();
            return listaClientes;
        }
        public void AgregarCliente(ClienteCE clienteCE)
        {
            ConexionCD conexion = new ConexionCD();
            SqlConnection cnx = conexion.ConectarSQLserver();
            cnx.Open();
            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AGREGARCLIENTE";

            cmd.Parameters.AddWithValue("@nombre",clienteCE.Nombre);
            cmd.Parameters.AddWithValue("@ruc", clienteCE.Ruc);
            cmd.Parameters.AddWithValue("@telefono", clienteCE.Telefono);
            cmd.Parameters.AddWithValue("@email", clienteCE.Email);
            cmd.Parameters.AddWithValue("@direccion", clienteCE.Direccion);

            cmd.ExecuteNonQuery();
            cnx.Close();


        }
        public void ActualizarCliente (ClienteCE clienteCE)
        {
            ConexionCD conexion = new ConexionCD();
            SqlConnection cnx = conexion.ConectarSQLserver();
            cnx.Open();
            SqlCommand cmd = cnx.CreateCommand();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ACTULIZARCLLIENTE";


            cmd.Parameters.AddWithValue("nombre",clienteCE.Nombre);
            cmd.Parameters.AddWithValue("ruc",clienteCE.Ruc);
            cmd.Parameters.AddWithValue("telefono",clienteCE.Telefono);
            cmd.Parameters.AddWithValue("email",clienteCE.Email);
            cmd.Parameters.AddWithValue("direccion",clienteCE.Direccion);
            cmd.Parameters.AddWithValue("id",clienteCE.Id);

            cmd.ExecuteNonQuery();
            cnx.Close();

        }
    }
}
