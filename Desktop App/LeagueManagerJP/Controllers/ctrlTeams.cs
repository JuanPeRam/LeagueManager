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
            String query = "SELECT t.ID_Team, t.Team_Name, t.Origin, t.Creation_Date, u.ID_User, u.UserName " +
                "FROM teams t " +
                "LEFT JOIN " +
                "(SELECT ID_Team, ID_User, MAX(p.ID_Period) AS last_period " +
                "FROM teamsManager tm  " +
                "LEFT JOIN periods p ON tm.ID_Period = p.ID_Period  " +
                "WHERE p.End_Date IS NULL " +
                "GROUP BY ID_Team, ID_User) AS last_periods ON t.ID_Team = last_periods.ID_Team " +
                "LEFT JOIN teamsManager tm ON last_periods.ID_Team = tm.ID_Team AND last_periods.ID_User = tm.ID_User AND last_periods.last_period = tm.ID_Period " +
                "LEFT JOIN users u ON tm.ID_User = u.ID_User" +
                " " +condition;
            DataTable dt = connMySQL.ObtenerDatosSQL(query);
            ObservableCollection<Team> lstTeams = new ObservableCollection<Team>();
            BindingSource bsTeams = new BindingSource { DataSource = lstTeams };
            foreach (DataRow row in dt.Rows)
            {
                Team team = new Team();
                team.Id = (int)row["ID_Team"];
                team.Name = (string)row["Team_Name"];
                if (!row.IsNull("ID_User"))
                {
                    User trainer = new User();
                    trainer.Id = (int)row["ID_User"];
                    trainer.UserName = (string)row["UserName"];
                    team.Trainer = trainer;
                }
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

        public static User readCurrentTrainer (int id)
        {
            String query = "SELECT tm.ID_User, u.UserName, u.Email " +
                "FROM teamsManager tm " +
                "INNER JOIN users u ON tm.ID_User = u.ID_User " +
                "WHERE ID_Team = " + id + " AND ID_Period IN " +
                "(SELECT ID_Period " +
                "FROM periods  " +
                "WHERE isnull(End_Date))";
            DataTable dt = connMySQL.ObtenerDatosSQL(query);
            if (dt.Rows.Count > 0)
            {
                int id_user = 0;
                User user = new User();
                foreach (DataRow row in dt.Rows)
                {
                    user.Id = (int)row[0];
                    user.UserName = (string)row[1];
                    user.Email = (string)row[2];
                }
                return user;
            }
            else return null;
            
        }
    }
}
