using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueManagerJP.Models
{
    public class Player
    {
        public int Id { get; set; }
        public Team team { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public string Nacionality { get; set; }
        public int Number { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
