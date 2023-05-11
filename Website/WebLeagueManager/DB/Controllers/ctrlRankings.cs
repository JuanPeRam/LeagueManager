using MySQL;
using System.Data;
using System.Text.RegularExpressions;
using WebLeagueManager.Models;

namespace WebLeagueManager.DB.Controllers
{
    public class ctrlRankings
    {
        public static List<RankingTeam> getRanking(int id)
        {
            List<RankingTeam> ranking = new List<RankingTeam>();
            List<Team> teams = ctrlTeams.ReadTeamsByCompetition(id);
            foreach (Team team in teams)
            {
                RankingTeam rankingtem = new RankingTeam();
                rankingtem.team = team;
                ranking.Add(rankingtem);
            }
            Dictionary<int, RankingTeam> rankingKeys = ranking.ToDictionary(keySelector: m => m.team.Id, elementSelector: m => m);
            List<Result> results = ctrlGames.readResultsByCompetition(id, " AND Played = 1 ");
            foreach (Result result in results)
            {
                RankingTeam homeTeam = rankingKeys[result.Home_Team];
                RankingTeam awayTeam = rankingKeys[result.Away_Team];
                homeTeam.gamesPlayed += 1;
                awayTeam.gamesPlayed += 1;
                homeTeam.goals += result.Home_Goals;
                homeTeam.goalsAgainst += result.Away_Goals;
                awayTeam.goals += result.Away_Goals;
                awayTeam.goalsAgainst += result.Home_Goals;
                if(result.Home_Goals > result.Away_Goals)
                {
                    homeTeam.points += 3;
                    homeTeam.victories += 1;
                    awayTeam.defeats += 1;
                }
                else if (result.Home_Goals < result.Away_Goals)
                {
                    awayTeam.points += 3;
                    homeTeam.defeats += 1;
                    awayTeam.victories += 1;
                }
                else
                {
                    homeTeam.points += 1;
                    awayTeam.points += 1;
                    homeTeam.draws += 1;
                    awayTeam.draws += 1;
                }
            }
            List<RankingTeam> finalRanking = rankingKeys.Values.ToList();
            List<RankingTeam> orderedRanking = new List<RankingTeam>();
            for(int i = 1; i <= finalRanking.Count; i++)
            {
                RankingTeam greaterTeam = null;
                bool first = false;
                foreach(RankingTeam team in finalRanking)
                {
                    if (team.Pos != 0) continue;
                    if (!first)
                    {
                        greaterTeam = team;
                        first = true;
                        continue;
                    }
                    if (greaterTeam.points > team.points) continue;
                    if(team.points > greaterTeam.points)
                    {
                        greaterTeam = team;
                        continue;
                    }
                    if (greaterTeam.goals > team.goals) continue;
                    if(team.goals > greaterTeam.goals)
                    {
                        greaterTeam = team; 
                        continue;
                    }
                    if (greaterTeam.goalsAgainst < team.goalsAgainst) continue;
                    if(greaterTeam.goalsAgainst > team.goalsAgainst)
                    {
                        greaterTeam = team;
                        continue;
                    }

                    
                }
                if (greaterTeam != null)
                {
                    greaterTeam.Pos = i;
                    orderedRanking.Add(greaterTeam);
                }
            }
            return orderedRanking;
        }

        public static List<Ranking> GetRankings(List<Competition> competitions)
        {
            List<Ranking> rankings = new List<Ranking>();
            foreach(Competition comp in competitions)
            {
                Ranking ranking = new Ranking();
                ranking.rankingTeams = getRanking(comp.ID);
                ranking.id_competition = comp.ID;
                ranking.type = comp.Type;
                rankings.Add(ranking);
            }
            return rankings;
        }


    }
}
