using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Capa_Datos
{
    public class ConexionCD
    {
        public SqlConnection ConectarSQLserver()
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder.DataSource = @"DESKTOP-TSV5BTD\MSSQLASDSA";
            stringBuilder.InitialCatalog = "AmericanSoft";
            stringBuilder.UserID ="sa";
            stringBuilder.Password ="123456";

            string cadena = stringBuilder.ConnectionString;
            SqlConnection cnx = new SqlConnection(cadena);
            return cnx;
        }
    }
}
