using MySQL;
using System.Data;
using WebLeagueManager.Models;

namespace WebLeagueManager.DB.Controllers
{
    public class ctrlCompetitions
    {
        public static List<Competition> GetCompetitions()
        {
            string query = "SELECT ID_Competition, Competition_Name, TypeName" +
                " FROM competitions c " +
                "INNER JOIN competitionstype cp ON cp.ID_Type = c.Competition_Type " +
                "WHERE ID_Period NOT IN (SELECT ID_Period FROM periods WHERE isnull(Start_Date))";
            DataTable dtCompetitions = connMySQL.ObtenerDatosSQL(query);
            List<Competition> competitions = new List<Competition>();
            foreach(DataRow row in dtCompetitions.Rows)
            {
                Competition competition = new Competition();
                competition.ID = (int)row["ID_Competition"];
                competition.Name = (string)row["Competition_Name"];
                competition.Type = (string)row["TypeName"];
                competitions.Add(competition);
            }
            return competitions;
        }
    }
}
