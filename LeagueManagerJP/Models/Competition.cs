using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueManagerJP.Models
{
    public class Competition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CompetitionType Type { get; set; }
        public Period period { get; set; }

        public override String ToString()
        {
            return Name;
        }
    }
}
