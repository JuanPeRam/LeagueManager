using MySQL;
using System.Data;
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
    }
}
