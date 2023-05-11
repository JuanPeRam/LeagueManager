using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL
{
    public class connMySQL
    {
        static MySqlCommand Query = new MySqlCommand();
        static MySqlConnection Conexion;
        static MySqlConnection ConnTransac = new MySqlConnection();

        static string sConn = ";server=leaguemanager.ci8wakk4khz4.eu-west-1.rds.amazonaws.com;user id=viewer;database=LeagueManager;password=pwdViewer18";
        MySqlTransaction tr;

        public static int EjecutarSQL(String sSQL)
        {

            try
            {
                Conexion = new MySqlConnection();
                Conexion.ConnectionString = sConn;
                Conexion.Open();
                Query.CommandText = sSQL;

                Query.Connection = Conexion;
                Query.ExecuteNonQuery();

                Conexion.Close();
                return 1;
            }
            catch (MySqlException e)
            {
                return -1;
            }

        }


        public static DataTable ObtenerDatosSQL(String sSQL)
        {
            MySqlDataReader datosConsulta;
            var dt = new DataTable();

            try
            {
                Conexion = new MySqlConnection();
                Conexion.ConnectionString = sConn;
                Conexion.Open();
                Query.CommandText = sSQL;

                Query.Connection = Conexion;
                datosConsulta = Query.ExecuteReader();

                dt.Load(datosConsulta);
                datosConsulta.Close();

                Conexion.Close();
            }
            catch (MySqlException e)
            {

            }

            return dt;

        }

        //Abre una transacción en MySQL
        //Devuelve 1 si es correcto -1 en caso contrario
        public int AbrirTransaccion()
        {
            try
            {
                ConnTransac.ConnectionString = sConn;
                ConnTransac.Open();

                Query.Connection = ConnTransac;
                tr = ConnTransac.BeginTransaction();
                Query.Transaction = tr;
                return 1;
            }
            catch (MySqlException ex)
            {
                tr.Rollback();
                ConnTransac.Close();
                return -1;
            }
        }

        public int CerrarTransaccionCorrecta()
        {
            try
            {
                tr.Commit();
                return 1;
            }
            catch (MySqlException ex)
            {
                tr.Rollback();
                return -1;
            }
            finally
            {
                ConnTransac.Close();
            }

        }

        public int CerrarTransaccionErronea()
        {
            try
            {
                tr.Rollback();
                ConnTransac.Close();
                return 1;
            }
            catch (MySqlException ex)
            {
                return -1;
            }

        }


        public int EjecutarSQL_EnTransac(String sSQL)
        {
            try
            {
                Query.CommandText = sSQL;
                Query.ExecuteNonQuery();
                return 1;
            }
            catch (MySqlException e)
            {
                tr.Rollback();
                ConnTransac.Close();
                return -1;
            }

        }

        public MySqlDataReader ObtenerDatosSQL_EnTransac(String sSQL)
        {
            MySqlDataReader datosConsulta = null;
            var dt = new DataTable();

            try
            {
                Query.CommandText = sSQL;
                datosConsulta = Query.ExecuteReader();

            }
            catch (MySqlException e)
            {
                tr.Rollback();
                ConnTransac.Close();
            }

            return datosConsulta;

        }




    }
}
