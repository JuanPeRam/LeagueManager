namespace WebLeagueManager.Models
{
    public class Game
    {
        public int Id { get; set; } 
        public Team Home_Team { get; set; }
        public Team Away_Team { get; set; }
        public int Home_Goals { get; set; }
        public int Away_Goals { get; set; }
        public DateTime Game_Date { get; set; }
        public string Matchday { get; set; }
        public bool Played { get; set; }
        public string Referee { get; set; }
        public Competition competition { get; set; }

    }
}
