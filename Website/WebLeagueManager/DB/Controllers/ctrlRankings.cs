using MySQL;
using System.Data;
using System.Text.RegularExpressions;
using WebLeagueManager.Models;

namespace WebLeagueManager.DB.Controllers
{
    public class ctrlRankings
    {

        public static List<Ranking> GetRankings()
        {
            List<Game> games = ctrlGames.readAllGames("");
            List<Ranking> rankings = new List<Ranking>();
            int id_competition = -1;
            Ranking ranking = null;
            foreach(Game game in games)
            {
                if(game.competition.ID != id_competition)
                {
                    id_competition = game.competition.ID;
                    ranking = new Ranking();
                    ranking.games = new List<Game>();
                    ranking.keyRankingTeams = new Dictionary<int, RankingTeam>();
                    ranking.id_competition = game.competition.ID;
                    ranking.type = game.competition.Type;
                    rankings.Add(ranking);
                }
                if (!ranking.keyRankingTeams.ContainsKey(game.Home_Team.Id))
                {
                    RankingTeam rankingTeam = new RankingTeam();
                    rankingTeam.team = game.Home_Team;
                    ranking.keyRankingTeams.Add(rankingTeam.team.Id, rankingTeam);
                }
                if (!ranking.keyRankingTeams.ContainsKey(game.Away_Team.Id))
                {
                    RankingTeam rankingTeam = new RankingTeam();
                    rankingTeam.team = game.Away_Team;
                    ranking.keyRankingTeams.Add(rankingTeam.team.Id, rankingTeam);
                }
                RankingTeam homeRankingTeam = ranking.keyRankingTeams[game.Home_Team.Id];
                RankingTeam awayRankingTeam = ranking.keyRankingTeams[game.Away_Team.Id];
                if (game.Played)
                {
                    setGameStats(game, homeRankingTeam, awayRankingTeam);
                }
                ranking.games.Add(game);
            }

            foreach(Ranking rank in rankings)
            {
                rank.rankingTeams = new List<RankingTeam>();
                for (int i = 1; i <= rank.keyRankingTeams.Count; i++)
                {
                    RankingTeam greaterTeam = null;
                    bool first = false;
                    foreach (RankingTeam team in rank.keyRankingTeams.Values)
                    {
                        if (team.Pos != 0) continue;
                        if (!first)
                        {
                            greaterTeam = team;
                            first = true;
                            continue;
                        }
                        if (greaterTeam.points > team.points) continue;
                        if (team.points > greaterTeam.points)
                        {
                            greaterTeam = team;
                            continue;
                        }
                        if (greaterTeam.goals > team.goals) continue;
                        if (team.goals > greaterTeam.goals)
                        {
                            greaterTeam = team;
                            continue;
                        }
                        if (greaterTeam.goalsAgainst < team.goalsAgainst) continue;
                        if (greaterTeam.goalsAgainst > team.goalsAgainst)
                        {
                            greaterTeam = team;
                            continue;
                        }


                    }
                    if (greaterTeam != null)
                    {
                        greaterTeam.Pos = i;
                        rank.rankingTeams.Add(greaterTeam);
                    }
                }
            }

            return rankings;
        }

        private static void setGameStats(Game game, RankingTeam homeRankingTeam, RankingTeam awayRankingTeam)
        {
            homeRankingTeam.gamesPlayed++;
            awayRankingTeam.gamesPlayed++;

            homeRankingTeam.goals += game.Home_Goals;
            homeRankingTeam.goalsAgainst += game.Away_Goals;

            awayRankingTeam.goalsAgainst += game.Home_Goals;
            awayRankingTeam.goals += game.Away_Goals;

            if (game.Away_Goals < game.Home_Goals)
            {
                awayRankingTeam.defeats++;
                homeRankingTeam.victories++;
                homeRankingTeam.points += 3;
            }
            else if (game.Away_Goals > game.Home_Goals)
            {
                homeRankingTeam.defeats++;
                awayRankingTeam.victories++;
                awayRankingTeam.points += 3;
            }
            else
            {
                homeRankingTeam.draws++;
                awayRankingTeam.draws++;
                homeRankingTeam.points++;
                awayRankingTeam.points++;
            }


        }


    }
}
