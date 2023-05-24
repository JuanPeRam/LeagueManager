using MySQL;
using System.Data;
using System.Text.RegularExpressions;
using WebLeagueManager.Models;

namespace WebLeagueManager.DB.Controllers
{
    public class ctrlPlayers
    {
        public static List<Player> getPlayersByTeam(int id)
        {
            List<Player> list = new List<Player>();
            String query = "SELECT ID_Player, Number, Player_Name, Age, Position, Nacionality " +
                "FROM players WHERE ID_Player IN " +
                "(SELECT ID_Player " +
                "FROM teamplayers " +
                "WHERE ID_Team = "+id+ " " +
                "AND ID_Period IN (SELECT ID_Period " +
                "FROM periods " +
                "WHERE isnull(End_Date)))";
            DataTable dtPlayers = connMySQL.ObtenerDatosSQL(query);
            foreach(DataRow row in dtPlayers.Rows)
            {
                Player player = new Player();
                player.Id = (int)row["ID_Player"];
                player.Number = (int)row["Number"];
                player.Name = (string)row["Player_Name"];
                player.Age = (int)row["Age"];
                player.Position = (string)row["Position"];
                player.Nacionality = (string)row["Nacionality"];
                list.Add(player);
            }
            return list;
        }

        public static List<Report> getPlayersByGame (int id)
        {
            List <Report> reportList = new List<Report>();
            String query =
                "SELECT p.ID_Player,p.Player_Name,p.Number,p.Position, r.Goals, r.Sanctions, t.Team_Name, t.ID_Team"+
                " FROM players p"+
                " JOIN teamplayers tp ON p.id_player = tp.id_player"+
                " LEFT JOIN games g ON(tp.id_team = g.Home_Team OR tp.id_team = g.Away_Team)"+
                " LEFT JOIN reports r ON p.ID_Player = r.ID_Player AND r.id_game = g.ID_Game"+
                " JOIN teams t ON t.ID_Team = tp.ID_Team"+
                " WHERE g.id_game = "+id+
                " AND tp.ID_Period IN(SELECT ID_Period FROM periods WHERE g.Game_Date > Start_Date AND(End_Date is null OR End_Date > g.Game_Date))"+
                " GROUP BY p.ID_Player " +
                " ORDER BY t.ID_Team ";
            DataTable dtReports = connMySQL.ObtenerDatosSQL(query);
            foreach(DataRow row in dtReports.Rows)
            {
                Report report = new Report();
                Player player = new Player();
                player.Id = (int)row["ID_Player"];
                player.Name = (string)row["Player_Name"];
                player.Number = (int)row["Number"];
                player.Position = (string)row["Position"];
                report.player = player;
                Team team = new Team();
                team.Id = (int)row["ID_Team"];
                team.Name = (string)row["Team_Name"];
                report.team = team;
                if (row["Goals"] is DBNull)
                {
                    report.Played = false;
                }
                else
                {
                    report.Played = true;
                    report.goalsScored = (int)row["Goals"];
                    String sanction = (string)row["Sanctions"];
                    if(sanction == "A")
                    {
                        report.yellowCards = 1;
                    }
                    else if(sanction == "R")
                    {
                        report.redCards = 1;
                    }
                }
                reportList.Add(report);
            }
            return reportList;
        }
    }
}
