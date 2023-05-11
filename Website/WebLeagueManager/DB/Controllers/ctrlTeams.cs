using Microsoft.AspNetCore.Mvc.ModelBinding;
using MySQL;
using Org.BouncyCastle.Bcpg;
using System.Collections.ObjectModel;
using System.Data;
using WebLeagueManager.Models;

namespace WebLeagueManager.DB.Controllers
{
    public class ctrlTeams
    {
        public static List<Team> ReadTeams(string condition)
        {
            string query = "SELECT ID_Team, Team_Name, Origin, Creation_Date FROM teams " + condition;
            DataTable dt = connMySQL.ObtenerDatosSQL(query);
            List<Team> teams = new List<Team>();
            foreach (DataRow row in dt.Rows)
            {
                Team team = new Team();
                team.Id = (int)row["ID_Team"];
                team.Name = (string)row["Team_Name"];
                team.Origin = (string)row["Origin"];
                team.CreationDate = (DateTime)row["Creation_Date"];
                teams.Add(team);
            }
            return teams;
        }

        public static List<Team> ReadTeamsByCompetition(int id)
        {
            String condition = "WHERE ID_Team IN (SELECT ID_Team FROM participate WHERE ID_Competition = "+id+")";
            return ReadTeams(condition);
        }

        public static Team readTeam(int id)
        {
            Team team = new Team();
            String query = "SELECT Team_Name, Origin, Creation_Date FROM teams WHERE ID_Team = "+id;
            DataTable dtTeam = connMySQL.ObtenerDatosSQL(query);
            foreach(DataRow row in dtTeam.Rows)
            {
                team.Id = id;
                team.Name = (string)row["Team_Name"];
                team.Origin = (string)row["Origin"];
                team.CreationDate = (DateTime)row["Creation_Date"];
            }
            return team;
        }
    }
}
