using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueManagerJP.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User Trainer { get; set; }

        public string Origin { get; set; }
        public DateTime CreationDate { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
