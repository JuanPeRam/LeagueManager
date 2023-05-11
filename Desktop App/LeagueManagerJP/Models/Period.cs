using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueManagerJP.Models
{
    public class Period
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public override string ToString()
        {
            if (StartDate == DateTime.MinValue)
            {
                return "No comenzado";
            }
            else if (EndDate == DateTime.MinValue)
            {
                return "En proceso";
            }
            else
            {
                return "Finalizado";
            }
        }
    }
}
