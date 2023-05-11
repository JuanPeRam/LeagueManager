using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebLeagueManager.DB.Controllers;
using WebLeagueManager.Models;

namespace WebLeagueManager.Views.Home
{
    public class TeamModel : PageModel
    {
        public int ID_Team;
        public Team currentTeam;
        public List<Player> lstPlayers = new List<Player>();

        public TeamModel(int id) 
        {
            ID_Team = id;
            lstPlayers = ctrlPlayers.getPlayersByTeam(ID_Team);
            currentTeam = ctrlTeams.readTeam(ID_Team);
        }


    }
}
