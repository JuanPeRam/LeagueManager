using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json.Nodes;
using WebLeagueManager.DB.Controllers;
using WebLeagueManager.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WebLeagueManager.Views.Home
{
    public class RankingsModel : PageModel
    {
        public List<RankingTeam> rankingTeams = new List<RankingTeam>();
        public List<Competition> competitions = new List<Competition>();
        public List<Ranking> rankings = new List<Ranking>();

        public RankingsModel() 
        {
            competitions = ctrlCompetitions.GetCompetitions();

            rankings = ctrlRankings.GetRankings();

            if(rankings.Count > 0 ) rankingTeams = rankings[1].rankingTeams;
        }

        public string getRankings()
        {
            string Json = JsonConvert.SerializeObject(rankings);
            return Json;
        }

    }
}
