namespace WebLeagueManager.Models
{
    public class Ranking
    {
        public List<RankingTeam> rankingTeams { get; set; }
        public Dictionary<int,RankingTeam> keyRankingTeams { get; set; }
        public List<Game> games { get; set; }
        public int id_competition { get; set; }
        public string type { get; set; }
    }
}
