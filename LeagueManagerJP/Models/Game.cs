using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueManagerJP.Models
{
    public class Game
    {
        public int Id { get; set; }
        public Competition competition { get; set; }
        public User referee { get; set; }
        public Team homeTeam { get; set; }
        public Team awayTeam { get; set; }
        public string matchDay { get; set; }
        public bool isPlayed { get; set; }
        public DateTime GameDate { get; set; } 
    }
}
