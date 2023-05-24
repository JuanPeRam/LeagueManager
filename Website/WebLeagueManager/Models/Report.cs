namespace WebLeagueManager.Models
{
    public class Report
    {
        public Team team { get; set; }
        public Player player { get; set; }
        public int goalsScored { get; set; }
        public int yellowCards { get; set; }
        public int redCards { get; set; }
        public bool Played { get; set; }
    }
}
