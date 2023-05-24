using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using WebLeagueManager.DB.Controllers;
using WebLeagueManager.Models;

namespace WebLeagueManager.Views.Home
{
    public class GamesModel : PageModel
    {
        public List<Game> lstGames = new List<Game>();
        public List<Competition> lstCompetitions = new List<Competition>();
        public GamesModel() 
        {
            lstGames = ctrlGames.readAllGames("");
            lstCompetitions = ctrlCompetitions.GetCompetitions();
        }

        public string getGames()
        {
            string Json = JsonConvert.SerializeObject(lstGames);
            return Json;
        }
    }
}
