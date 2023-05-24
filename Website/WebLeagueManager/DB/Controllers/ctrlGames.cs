using MySQL;
using System.Data;
using WebLeagueManager.Models;

namespace WebLeagueManager.DB.Controllers
{
    public class ctrlGames
    {

        public static List<Game> readAllGames(String condition)
        {
            String query = "SELECT g.ID_Game,u.UserName, Matchday, Game_Date, Played,g.ID_Competition,c.Competition_Name,TypeName, t1.Team_Name AS Home_Name,t1.ID_Team AS Home_ID,t2.ID_Team AS Away_ID, t2.Team_Name AS Away_Name, " +
            "SUM(CASE WHEN(" +
                "SELECT ID_Team " +
                "FROM teamplayers " +
                "WHERE ID_Player = r.ID_Player " +
                "AND ID_Period IN " +
                    "(SELECT ID_Period " +
                    "FROM periods " +
                    "WHERE Start_Date < g.Game_Date AND (isnull(End_Date) OR End_Date > g.Game_Date))) " +
                "= g.Home_Team THEN r.Goals ELSE 0 END) " +
            "AS Home_Goals," +
            "SUM(CASE WHEN(" +
                "SELECT ID_Team " +
                "FROM teamplayers " +
                "WHERE ID_Player = r.ID_Player " +
                "AND ID_Period IN " +
                    "(SELECT ID_Period " +
                    "FROM periods " +
                    "WHERE Start_Date < g.Game_Date AND (isnull(End_Date) OR End_Date > g.Game_Date))) " +
                "= g.Away_Team THEN r.Goals ELSE 0 END) " +
            "AS Away_Goals " +
            " FROM games g" +
            " LEFT JOIN reports r ON g.ID_Game = r.ID_Game" +
            " JOIN teams t1 ON g.Home_Team = t1.ID_Team " +
            " JOIN teams t2 ON g.Away_Team = t2.ID_Team " +
            " JOIN competitions c ON c.ID_Competition = g.ID_Competition " +
            " LEFT JOIN users u ON g.ID_Referee = u.ID_User "+
            " JOIN competitionstype ct ON c.Competition_Type = ct.ID_Type" +
            " "+condition+" "+
            " GROUP BY g.ID_Game " +
            " ORDER BY g.ID_Competition, Matchday, Game_Date";
            DataTable dtGames = connMySQL.ObtenerDatosSQL(query);
            List<Game> listGames = new List<Game>();
            foreach(DataRow row in  dtGames.Rows)
            {
                Game game = new Game();
                game.Id = (int)row["ID_Game"];
                if (!(row["UserName"] is DBNull))
                {
                    game.Referee = (string)row["UserName"];
                }
                Competition comp = new Competition();
                comp.ID = (int)row["ID_Competition"];
                comp.Name = (string)row["Competition_Name"];
                comp.Type = (string)row["TypeName"];
                game.competition = comp;
                Team homeTeam = new Team();
                homeTeam.Id = (int)row["Home_ID"];
                homeTeam.Name = (string)row["Home_Name"];
                Team awayTeam = new Team();
                awayTeam.Id = (int)row["Away_ID"];
                awayTeam.Name = (string)row["Away_Name"];
                game.Home_Team = homeTeam;
                game.Away_Team = awayTeam;
                game.Played = row["Played"].ToString() == "1";
                if (game.Played)
                {
                    game.Home_Goals = int.Parse(row["Home_Goals"].ToString());
                    game.Away_Goals = int.Parse(row["Away_Goals"].ToString());

                }
                game.Game_Date = (DateTime)row["Game_Date"];
                game.Matchday = (string)row["Matchday"];
                listGames.Add(game);

            }
            return listGames;
        }

        public static Game readGameByID(int id)
        {
            String condition = "WHERE g.ID_Game = " + id;
            List<Game> gameList = readAllGames(condition);
            if(gameList.Count > 0)
            {
                return gameList[0];
            }
            return null;
        }
    }
}
