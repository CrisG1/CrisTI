using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace Codigo
{
   public class Conexion
    {
        static SqlConnection cnx;
        static string cadena = "server=localhost;database=Club; trusted_connection=true;";
        public static void conectar()
        {
            cnx = new SqlConnection(cadena);
            cnx.Open();
        }
        public static void desconectar()
        {
            cnx.Close();
            cnx = null;
        }
        public static int EjecutaConsulta(string consulta)
        {
            int filasAfectadas = 0;
            conectar();
            SqlCommand cmd = new SqlCommand(consulta, cnx);
            filasAfectadas = cmd.ExecuteNonQuery();
            desconectar();
            return filasAfectadas;
        }
        public static DataTable EjecutaSeleccion(string consulta)
        {
            DataTable dt = new DataTable();
            conectar();
            SqlDataAdapter da = new SqlDataAdapter(consulta, cnx);
            da.Fill(dt);
            desconectar();
            return dt;
        }
        public static object EjecutaEscalar(string consulta)
        {
            DataTable dt = new DataTable();
            conectar();
            SqlDataAdapter da = new SqlDataAdapter(consulta, cnx);
            da.Fill(dt);
            desconectar();
            return dt.Rows[0].ItemArray[0];
        }
    }
}
