using LeagueManagerJP.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySQL;

namespace LeagueManagerJP.Controllers
{
    public class ctrlPeriods
    {

        public static string noEndDate = "ID_Period IN (SELECT ID_Period FROM periods WHERE isnull(End_Date))";
        public static Period readPeriod(int id)
        {
            String query = "SELECT Start_Date, End_Date FROM periods WHERE ID_Period = " + id;
            Period period = null;
            DataTable dtPeriod = connMySQL.ObtenerDatosSQL(query);
            if(dtPeriod.Rows.Count > 0)
            {
                period = new Period();
                period.Id = id;
                foreach (DataRow row in dtPeriod.Rows)
                {
                    var startDate = row[0] == DBNull.Value ?
                                        null :
                                   (DateTime?)Convert.ToDateTime(row[0]);
                    var endDate = row[1] == DBNull.Value ?
                                        null :
                                   (DateTime?)Convert.ToDateTime(row[1]);
                    period.StartDate = startDate == null ? DateTime.MinValue:startDate.Value;
                    period.EndDate = endDate == null ? DateTime.MinValue : endDate.Value;
                }
            }
            
            return period;
        }

        public static int insertPeriodinTrans(connMySQL con, String startDate, bool empty)
        {
            String query;
            if(empty)
            {
                query = "INSERT INTO periods VALUES ()";
            }
            else
            {
                if(startDate == null)
                {
                    query = "INSERT INTO periods (Start_Date) VALUES (Now())";
                }
                else query = "INSERT INTO periods (Start_Date) VALUES ('"+startDate+"')";
            }
            
            if (con.EjecutarSQL_EnTransac(query) == -1) return 0;
            query = "SELECT MAX(ID_Period) FROM periods";
            int id_period = 0;
            MySqlDataReader reader = con.ObtenerDatosSQL_EnTransac(query);
            while (reader.Read())
            {
                id_period = reader.GetInt32(0);
            }
            reader.Close();
            return id_period;
        }

        public static bool endPeriod(int id)
        {
            String query = "UPDATE periods SET End_Date = Now() WHERE ID_Period = " + id;
            if (connMySQL.EjecutarSQL(query) == -1) return false;
            else return true;
        }
    }
}
