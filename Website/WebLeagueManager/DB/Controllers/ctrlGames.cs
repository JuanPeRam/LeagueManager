using MySQL;
using System.Data;
using WebLeagueManager.Models;

namespace WebLeagueManager.DB.Controllers
{
    public class ctrlGames
    {
        public static List<Result> readResultsByCompetition (int id, string condition)
        {
            List<Result> results = new List<Result>();
            DataTable dtGames = readGamesByCompetition(id,condition);
            foreach (DataRow row in dtGames.Rows)
            {
                Result result = new Result();
                result.Home_Team = (int)row["Home_Team"];
                result.Away_Team = (int)row["Away_Team"];
                result.Home_Goals = int.Parse(row["home_goals"].ToString());
                result.Away_Goals = int.Parse(row["away_goals"].ToString());
                results.Add(result);

            }
            return results;
        }

        public static DataTable readGamesByCompetition(int id, string condition)
        {
            String query = "SELECT g.ID_Game,g.ID_Referee, Matchday, Game_Date, Played, g.Home_Team, g.Away_Team, " +
            "SUM(CASE WHEN(SELECT ID_Team FROM teamplayers WHERE ID_Player = r.ID_Player) = g.Home_Team THEN r.Goals ELSE 0 END) AS home_goals," +
            "SUM(CASE WHEN(SELECT ID_Team FROM teamplayers WHERE ID_Player = r.ID_Player) = g.Away_Team THEN r.Goals ELSE 0 END) AS away_goals" +
            " FROM games g" +
            " INNER JOIN reports r ON g.ID_Game = r.ID_Game" +
            " WHERE g.ID_Competition = " + id + " " + condition + " " +
            " GROUP BY r.ID_Game";
            DataTable dtGames = connMySQL.ObtenerDatosSQL(query);
            return dtGames;
        }
    }
}
