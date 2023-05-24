using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;
using WebLeagueManager.DB.Controllers;
using WebLeagueManager.Models;

namespace WebLeagueManager.Views.Home
{
    public class GameModel : PageModel
    {
        public Game game;
        public String date;
        public List<Report> reportList = new List<Report>();
        public List<Report> homePlayers = new List<Report>();
        public List<Report> awayPlayers = new List<Report>();
        public List<Report> homeNotPlayed = new List<Report>();
        public List<Report> awayNotPlayed = new List<Report>();
        public GameModel(int id) 
        {
            game = ctrlGames.readGameByID(id);
            reportList = ctrlPlayers.getPlayersByGame(id);
            foreach(Report report in reportList)
            {
                if(report.team.Id == game.Home_Team.Id)
                {
                    if (report.Played)
                    {
                        homePlayers.Add(report);
                    }
                    else homeNotPlayed.Add(report);
                }
                else
                {
                    if (report.Played)
                    {
                        awayPlayers.Add(report);
                    }
                    else awayNotPlayed.Add(report);
                }
            }
            setDate();
        }

        private void setDate()
        {
            CultureInfo spanishCulture = new CultureInfo("es-ES");
            /*DateTimeFormatInfo spanishFormat = spanishCulture.DateTimeFormat;
            string day = spanishFormat.GetDayName(game.Game_Date.DayOfWeek);*/
            date = game.Game_Date.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm", spanishCulture);
            
        }
    }
}
