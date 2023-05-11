namespace WebLeagueManager.Models
{
    public class RankingTeam
    {
        public int Pos { get; set; }
        public Team team { get; set; }
        public int goals;
        public int points;
        public int goalsAgainst;
        public int gamesPlayed;
        public int victories;
        public int draws;
        public int defeats;
        public RankingTeam()
        {
            goals = 0;
            points = 0;
            goalsAgainst = 0;
            gamesPlayed = 0;
            victories = 0;
            draws = 0;
            defeats = 0;
            Pos = 0;
        }
    }
}
