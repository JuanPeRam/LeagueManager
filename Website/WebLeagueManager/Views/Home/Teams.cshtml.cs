using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebLeagueManager.DB.Controllers;
using WebLeagueManager.Models;

namespace WebLeagueManager.Views.Home
{
    public class TeamsModel : PageModel
    {
        public List<Team> lstTeams = new List<Team>();

        public TeamsModel()
        {
            lstTeams = ctrlTeams.ReadTeams("");
        }
        public void OnGet()
        {
            Console.WriteLine("Get");
        }

        public void OnPost() 
        {
            Console.WriteLine("Post");
        }
    }
}
