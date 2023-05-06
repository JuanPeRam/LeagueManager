using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeagueManagerJP.Models
{
    public class Report
    {
        public Player player { get; set; }
        public Game match { get; set; }
        public int goals { get; set; }
        public string sanctions { get; set; }
    }
}
