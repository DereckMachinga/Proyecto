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
    public class EquipoCD
    {
        public void AgregarEquipo(EquipoCE equipoCE)
        {
            ConexionCD conexion = new ConexionCD();
            SqlConnection cnx = conexion.ConectarSQLserver();
            cnx.Open();

            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AGREGAREQUIPO";

            cmd.Parameters.AddWithValue("@serie",equipoCE.Serie);
            cmd.Parameters.AddWithValue("@marca", equipoCE.Marca);
            cmd.Parameters.AddWithValue("@modeloplaca", equipoCE.Modeloplaca);
            cmd.Parameters.AddWithValue("@display", equipoCE.Dislpay);
            cmd.Parameters.AddWithValue("@descripcion", equipoCE.Descripcion);
            cmd.Parameters.AddWithValue("@generacion", equipoCE.Generacion);
            cmd.Parameters.AddWithValue("@proviene", equipoCE.Proviene);
            cmd.Parameters.AddWithValue("@destino", equipoCE.Destino);

            cmd.ExecuteNonQuery();
            cnx.Close();

        }
        public void ActulizarEquipo(EquipoCE equipoCE)
        {
            ConexionCD conexionCD = new ConexionCD();
            SqlConnection cnx = conexionCD.ConectarSQLserver();
            cnx.Open();
            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ACTUALIZAREQUIPO ";

            cmd.Parameters.AddWithValue("@serie", equipoCE.Serie);
            cmd.Parameters.AddWithValue("@marca", equipoCE.Marca);
            cmd.Parameters.AddWithValue("@modeloplaca", equipoCE.Modeloplaca);
            cmd.Parameters.AddWithValue("@display", equipoCE.Dislpay);
            cmd.Parameters.AddWithValue("@descripcion", equipoCE.Descripcion);
            cmd.Parameters.AddWithValue("@generacion", equipoCE.Generacion);
            cmd.Parameters.AddWithValue("@proviene", equipoCE.Proviene);
            cmd.Parameters.AddWithValue("@destino", equipoCE.Destino);

            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public List<EquipoCE> ListarEquipos()
        {
            ConexionCD conexion = new ConexionCD();
            SqlConnection cnx = conexion.ConectarSQLserver();
            cnx.Open();
            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select serie,marca,modeloplaca,display,descripcion,generacion,proviene,destino from equipo";

            SqlDataReader dr = cmd.ExecuteReader();
            List<EquipoCE> listaEquipos = new List<EquipoCE>();

            while (dr.Read())
            {
                EquipoCE equipoCE = new EquipoCE();
                
                equipoCE.Serie = dr["serie"].ToString();
                equipoCE.Marca = dr["marca"].ToString();
                equipoCE.Modeloplaca = dr["modeloplaca"].ToString();
                equipoCE.Dislpay = dr["display"].ToString();
                equipoCE.Descripcion = dr["descripcion"].ToString();
                equipoCE.Generacion = dr["generacion"].ToString();
                equipoCE.Proviene = dr["proviene"].ToString();
                equipoCE.Destino = dr["destino"].ToString();

                listaEquipos.Add(equipoCE);
            }
            cnx.Close();
            return listaEquipos;
        }
        public List<EquipoCE> ListarEquiposPorMarca()
        {
            ConexionCD conexion = new ConexionCD();
            SqlConnection cnx = conexion.ConectarSQLserver();
            cnx.Open();
            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "LISTAREQUIPOSPORMARCA";

            SqlDataReader dr = cmd.ExecuteReader();
            List<EquipoCE> listaEquipos = new List<EquipoCE>();

            while (dr.Read())
            {
                EquipoCE equipoCE = new EquipoCE();
                equipoCE.Serie = dr["serie"].ToString();
                equipoCE.Marca = dr["marca"].ToString();
                equipoCE.Modeloplaca = dr["modeloplaca"].ToString();
                equipoCE.Dislpay = dr["display"].ToString();
                equipoCE.Descripcion = dr["descripcion"].ToString();
                equipoCE.Generacion = dr["generacion"].ToString();
                equipoCE.Proviene = dr["proviene"].ToString();
                equipoCE.Destino = dr["destino"].ToString();

                listaEquipos.Add(equipoCE);
            }
            cnx.Close();
            return listaEquipos;
        }
        public List<EquipoCE> ListarEquiposPorGeneracion()
        {
            ConexionCD conexion = new ConexionCD();
            SqlConnection cnx = conexion.ConectarSQLserver();
            cnx.Open();
            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "LISTAREQUIPOSPORGENERACION";

            SqlDataReader dr = cmd.ExecuteReader();
            List<EquipoCE> listaEquipos = new List<EquipoCE>();

            while (dr.Read())
            {
                EquipoCE equipoCE = new EquipoCE();
                equipoCE.Serie = dr["serie"].ToString();
                equipoCE.Marca = dr["marca"].ToString();
                equipoCE.Modeloplaca = dr["modeloplaca"].ToString();
                equipoCE.Dislpay = dr["display"].ToString();
                equipoCE.Descripcion = dr["descripcion"].ToString();
                equipoCE.Generacion = dr["generacion"].ToString();
                equipoCE.Proviene = dr["proviene"].ToString();
                equipoCE.Destino = dr["destino"].ToString();

                listaEquipos.Add(equipoCE);
            }
            cnx.Close();
            return listaEquipos;
        }
        public List<EquipoCE> ListarEquiposPorDestino()
        {
            ConexionCD conexion = new ConexionCD();
            SqlConnection cnx = conexion.ConectarSQLserver();
            cnx.Open();
            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "LISTAREQUIPOSPORDESTINO";

            SqlDataReader dr = cmd.ExecuteReader();
            List<EquipoCE> listaEquipos = new List<EquipoCE>();

            while (dr.Read())
            {
                EquipoCE equipoCE = new EquipoCE();
                equipoCE.Serie = dr["serie"].ToString();
                equipoCE.Marca = dr["marca"].ToString();
                equipoCE.Modeloplaca = dr["modeloplaca"].ToString();
                equipoCE.Dislpay = dr["display"].ToString();
                equipoCE.Descripcion = dr["descripcion"].ToString();
                equipoCE.Generacion = dr["generacion"].ToString();
                equipoCE.Proviene = dr["proviene"].ToString();
                equipoCE.Destino = dr["destino"].ToString();

                listaEquipos.Add(equipoCE);
            }
            cnx.Close();
            return listaEquipos;
        }
        public List<EquipoCE> ListarEquiposPorProviene()
        {
            ConexionCD conexion = new ConexionCD();
            SqlConnection cnx = conexion.ConectarSQLserver();
            cnx.Open();
            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "LISTAREQUIPOSPORPROVIENE";

            SqlDataReader dr = cmd.ExecuteReader();
            List<EquipoCE> listaEquipos = new List<EquipoCE>();

            while (dr.Read())
            {
                EquipoCE equipoCE = new EquipoCE();
                equipoCE.Serie = dr["serie"].ToString();
                equipoCE.Marca = dr["marca"].ToString();
                equipoCE.Modeloplaca = dr["modeloplaca"].ToString();
                equipoCE.Dislpay = dr["display"].ToString();
                equipoCE.Descripcion = dr["descripcion"].ToString();
                equipoCE.Generacion = dr["generacion"].ToString();
                equipoCE.Proviene = dr["proviene"].ToString();
                equipoCE.Destino = dr["destino"].ToString();

                listaEquipos.Add(equipoCE);
            }
            cnx.Close();
            return listaEquipos;
        }
    }
}
