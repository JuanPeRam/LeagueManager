namespace WebLeagueManager.Models
{
    public class Ranking
    {
        public List<RankingTeam> rankingTeams { get; set; }
        public int id_competition { get; set; }
        public string type { get; set; }
    }
}
