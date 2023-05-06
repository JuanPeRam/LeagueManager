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
    internal class ctrlTeams
    {
        public static BindingSource ReadTeams(String condition)
        {
            String query = "SELECT ID_Team, Team_Name, Origin, Creation_Date FROM teams "+condition;
            DataTable dt = connMySQL.ObtenerDatosSQL(query);
            ObservableCollection<Team> lstTeams = new ObservableCollection<Team>();
            BindingSource bsTeams = new BindingSource { DataSource = lstTeams };
            foreach (DataRow row in dt.Rows)
            {
                Team team = new Team();
                team.Id = (int)row["ID_Team"];
                team.Name = (string)row["Team_Name"];
                team.Trainer = readCurrentTrainer(team.Id);
                team.Origin = (string)row["Origin"];
                team.CreationDate = (DateTime)row["Creation_Date"];
                bsTeams.Add(team);
            }
            return bsTeams;
        }

        public static void insertTeam(Team team)
        {
            String query;
            if (team.Trainer == null)
            {
                query = "INSERT INTO teams VALUES (null,'"+team.Name+"','"+team.Origin+"','"+ team.CreationDate.ToString("yyyy-MM-dd") + "')";
                if (connMySQL.EjecutarSQL(query) == -1)
                {
                    MessageBox.Show("Ha ocurrido un error al insertar los datos");
                }
                else
                {
                    MessageBox.Show("Equipo registrado con éxito");
                }
                return;
            }
            else
            {
                query = "INSERT INTO teams VALUES (null,'"+ team.Name + "','"+team.Origin+"','" + team.CreationDate.ToString("yyyy-MM-dd") + "')";
                connMySQL con = new connMySQL();
                if (con.AbrirTransaccion() == -1)
                {
                    MessageBox.Show("Ha ocurrido un error al abrir la transacción");
                    return;
                }
                if (con.EjecutarSQL_EnTransac(query) == -1)
                {
                    MessageBox.Show("Ha ocurrido un error al insertar los datos");
                    return;
                }
                query = "SELECT MAX(ID_Team) FROM teams";
                MySqlDataReader reader = con.ObtenerDatosSQL_EnTransac(query);
                while (reader.Read())
                {
                    team.Id = reader.GetInt32(0);
                }
                reader.Close();
                int id_period = ctrlPeriods.insertPeriodinTrans(con, null,false);
                query = "INSERT INTO teamsManager VALUES ("+team.Trainer.Id+","+team.Id+","+id_period+")";
                if(con.EjecutarSQL_EnTransac(query) == -1)
                {
                    MessageBox.Show("Ha ocurrido un error al insertar los datos");
                    return;
                }
                if(con.CerrarTransaccionCorrecta() == -1)
                {
                    MessageBox.Show("Ha ocurrido un error al insertar los datos");
                    return;
                }
                else
                {
                    MessageBox.Show("Equipo insertado correctamente");
                    return;
                }

            }
        }

        public static Team readTeam(int id)
        {
            Team team = null;
            String condition = "WHERE ID_Team = "+id;
            BindingSource bsTeams = ReadTeams(condition);
            foreach (Team teamAux in  bsTeams)
            {
                team = teamAux;
            }
            return team;
        }

        public static String readTeamName(int id)
        {
            String query = "SELECT Team_Name FROM teams WHERE ID_Team = " + id;
            DataTable dt = connMySQL.ObtenerDatosSQL(query);
            if (dt.Rows.Count > 0)
            {
                String name = "";
                foreach (DataRow row in dt.Rows)
                {
                    name = (string)row[0];
                }
                return name;
            }
            else return null;
        }

        public static User readCurrentTrainer (int id)
        {
            String query = "SELECT ID_User FROM teamsManager WHERE ID_Team = " + id + " AND ID_Period IN (SELECT ID_Period FROM periods  WHERE isnull(End_Date))";
            DataTable dt = connMySQL.ObtenerDatosSQL(query);
            if (dt.Rows.Count > 0)
            {
                int id_user = 0;
                foreach (DataRow row in dt.Rows)
                {
                    id_user = (int)row[0];
                }
                User user = ctrlUsers.readUser(id_user);
                return user;
            }
            else return null;
            
        }
    }
}
