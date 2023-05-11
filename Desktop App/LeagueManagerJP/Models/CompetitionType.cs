using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueManagerJP.Models
{
    public class CompetitionType
    {
        public static string[] cupRounds = new string[] { "Round of sixty-four", "Round of thirty-two" , "Round of 16" , "Quarter-final", "Semi-final", "Final" };
        public static string getNextRound(int teamsLeft)
        {
            int index = cupRounds.Length-1;
            for(int i=2;i<Math.Pow(2,cupRounds.Length);i=i*2)
            {
                if (i == teamsLeft)
                {
                    return cupRounds[index];
                }
                index--;
            }
            return null;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
