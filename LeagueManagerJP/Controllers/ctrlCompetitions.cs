using LeagueManagerJP.Forms.ControlForms;
using LeagueManagerJP.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySQL;

namespace LeagueManagerJP.Controllers
{
    internal class ctrlCompetitions
    {

        public static BindingSource ReadCompetitions(String condition)
        {
            String query = "SELECT ID_Competition, Competition_Name, ID_Period, Competition_Type FROM competitions "+condition;
            DataTable dt = connMySQL.ObtenerDatosSQL(query);
            ObservableCollection<Competition> lstCompetition = new ObservableCollection<Competition>();
            BindingSource bsCompetitions = new BindingSource { DataSource = lstCompetition };
            foreach (DataRow row in dt.Rows)
            {
                Competition competition = new Competition();
                competition.Id = (int)row["ID_Competition"];
                competition.Name = (string)row["Competition_Name"];
                competition.period = ctrlPeriods.readPeriod((int)row["ID_Period"]);
                competition.Type = readType((int)row["Competition_Type"]);
                bsCompetitions.Add(competition);
            }
            return bsCompetitions;
        }

        public static Competition readCompetition(int id)
        {
            Competition comp = null;
            String condition = "WHERE ID_Competition = " + id;
            BindingSource bsComp = ReadCompetitions(condition);
            foreach (Competition competition in bsComp)
            {
                comp = competition;
            }
            return comp;
        }

        public static BindingSource readCompetitionsType(String condition)
        {
            String query = "SELECT ID_Type,TypeName  FROM competitionstype "+condition ;
            DataTable dt = connMySQL.ObtenerDatosSQL(query);
            ObservableCollection<CompetitionType> lstCompetition = new ObservableCollection<CompetitionType>();
            BindingSource bsCompetitions = new BindingSource { DataSource = lstCompetition };
            foreach (DataRow row in dt.Rows)
            {
                CompetitionType competition = new CompetitionType();
                competition.ID = (int)row["ID_Type"];
                competition.Name = (string)row["TypeName"];
                bsCompetitions.Add(competition);
            }
            return bsCompetitions;
        }

        public static CompetitionType readType(int id)
        {
            BindingSource bsTypes = readCompetitionsType("WHERE ID_Type = "+id);
            CompetitionType type = null;
            foreach(CompetitionType cp in bsTypes)
            {
                type = cp;
            }
            return type;
        }

        public static bool startCompetition (int id)
        {
            String query = "UPDATE periods SET Start_Date = Now() WHERE ID_Period = (SELECT ID_Period from competitions WHERE ID_Competition = "+id+")";
            if (connMySQL.EjecutarSQL(query) == -1) return false;
            else return true;
        }

        public static bool stopCompetition (int id)
        {
            String query = "UPDATE periods SET Start_Date = null WHERE ID_Period = (SELECT ID_Period from competitions WHERE ID_Competition = " + id + ")";
            if (connMySQL.EjecutarSQL(query) == -1) return false;
            else return true;
        }

        public static bool insertCompetition(Competition competition)
        {
            connMySQL con = new connMySQL();
            int res = con.AbrirTransaccion();
            if(res == -1) return false;
            int id_period = ctrlPeriods.insertPeriodinTrans(con,null,true);
            String query = "INSERT INTO competitions VALUES (null,'"+competition.Name+"',"+id_period+","+competition.Type.ID+")";
            if (con.EjecutarSQL_EnTransac(query) == -1) return false;
            res = con.CerrarTransaccionCorrecta();
            if (res == -1) return false;
            return true;
        }

        public static bool deleteCompetition(int id)
        {
            String query = "DELETE FROM competitions WHERE ID_Competition = "+id;
            if (connMySQL.EjecutarSQL(query) == -1) return false;
            else return true;
        }
        public static bool insertParticipant(Competition competition, Team team)
        {
            String query = "INSERT INTO participate VALUES ("+team.Id+","+competition.Id+")";
            if (connMySQL.EjecutarSQL(query) == -1) return false;
            else return true;
        }
        public static bool deleteParticipant(Competition competition, Team team) 
        {
            String query = "DELETE FROM participate WHERE ID_Competition = "+competition.Id+" AND ID_Team = "+team.Id;
            if (connMySQL.EjecutarSQL(query) == -1) return false;
            else return true;
        }

        public static bool deleteParticipants(int id)
        {
            String query = "DELETE FROM participate WHERE ID_Competition = " + id;
            if (connMySQL.EjecutarSQL(query) == -1) return false;
            else return true;
        }

        public static bool endCompetition(Competition comp)
        {
            String query = "UPDATE periods SET End_Date = NOW() WHERE ID_Period = (SELECT ID_Period FROM competitions WHERE ID_Competition = "+comp.Id+")";
            if (connMySQL.EjecutarSQL(query) == -1) return false;
            else return true;
        }
    }
}
