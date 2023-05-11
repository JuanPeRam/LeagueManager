using LeagueManagerJP.Controllers;
using LeagueManagerJP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueManagerJP.Forms.ControlForms.CompetitionsForms
{
    public partial class CompetitionsView : Form
    {
        private Team teamSel;
        private Competition competition;
        private Competitions parent;
        public CompetitionsView(Competition competition, Competitions parent)
        {
            InitializeComponent();
            this.competition = competition;
            this.parent = parent;
            InitializeTables();
            if (competition.period != null && competition.period.StartDate != DateTime.MinValue)
            {
                UnableButtons();
            }
        }

        private void UnableButtons()
        {
            btn_left.Enabled = false;
            btn_right.Enabled = false;
            btn_start.Enabled = false;
            dgv_teams.Enabled = false;
            dgv_teamsParticipate.Enabled = false;
            btn_delete.Enabled = true;
            btn_reset.Enabled = true;
        }

        private void EnableButtons()
        {
            btn_left.Enabled = !false;
            btn_right.Enabled = !false;
            btn_start.Enabled = !false;
            dgv_teams.Enabled = !false;
            dgv_teamsParticipate.Enabled = !false;
            btn_delete.Enabled = !true;
            btn_reset.Enabled = !true;
        }

        private void InitializeTables()
        {
            String condition = "WHERE ID_Team NOT IN (SELECT IFNULL(ID_Team,0) FROM participate WHERE ID_Competition = "+competition.Id+")";
            dgv_teams.DataSource = ctrlTeams.ReadTeams(condition);
            condition = "WHERE ID_Team IN (SELECT IFNULL(ID_Team,0) FROM participate WHERE ID_Competition = " + competition.Id + ")";
            dgv_teamsParticipate.DataSource = ctrlTeams.ReadTeams(condition);
            dgv_teams.Columns[0].Visible = false;
            dgv_teams.Columns[1].HeaderText =  "Equipos que no participan";
            dgv_teams.Columns[2].Visible = false;
            dgv_teams.Columns[3].Visible = false;
            dgv_teams.Columns[4].Visible = false;
            dgv_teamsParticipate.Columns[0].Visible = false;
            dgv_teamsParticipate.Columns[1].HeaderText = "Equipos que participan";
            dgv_teamsParticipate.Columns[2].Visible = false;
            dgv_teamsParticipate.Columns[3].Visible = false;
            dgv_teamsParticipate.Columns[4].Visible = false;

            dtp_startDate.Value = DateTime.Now;
            dtp_startDate.MinDate = DateTime.Now;
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            if (teamSel == null) return;
            foreach (DataGridViewRow row in dgv_teamsParticipate.Rows)
            {
                if (((Team)row.DataBoundItem).Id == teamSel.Id)
                {
                    return;
                }
            }
            ctrlCompetitions.insertParticipant(competition, teamSel);
            foreach (DataGridViewRow row in dgv_teams.Rows)
            {
                if (((Team)row.DataBoundItem).Id == teamSel.Id)
                {
                    dgv_teams.Rows.Remove(row);
                }
            }
            InitializeTables();
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            if(teamSel == null) return;
            foreach(DataGridViewRow row in dgv_teams.Rows)
            {
                if(((Team)row.DataBoundItem).Id == teamSel.Id)
                {
                    return;
                }
            }
            ctrlCompetitions.deleteParticipant(competition, teamSel);
            foreach(DataGridViewRow row in dgv_teamsParticipate.Rows)
            {
                if (((Team)row.DataBoundItem).Id == teamSel.Id)
                {
                    dgv_teamsParticipate.Rows.Remove(row);
                }
            }
            InitializeTables();

        }

        private void dgv_teamsParticipate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_teams.CurrentRow !=null) dgv_teams.CurrentRow.Selected = false;
            if (dgv_teamsParticipate.SelectedRows != null)
            {
                teamSel = (Team)dgv_teamsParticipate.CurrentRow.DataBoundItem;
            }
        }

        private void dgv_teams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_teamsParticipate.CurrentRow != null) dgv_teamsParticipate.CurrentRow.Selected = false;
            if (dgv_teams.SelectedRows != null)
            {
                teamSel = (Team)dgv_teams.CurrentRow.DataBoundItem;
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (checkFields() && MainPanel.showConfirmDialog("Estás seguro de que deseas comenzar la competición?"))
            {
                List<Game> games = generateGames();
                if (games != null)
                {
                    
                    if (ctrlGames.insertGames(games))
                    {
                        ctrlCompetitions.startCompetition(competition.Id);
                        parent.UpdateTable();
                        UnableButtons();
                        MessageBox.Show("Calendario generado con éxito");
                    }
                }
            }
        }

        private bool checkFields()
        {
            if (dtp_startDate.Value <= DateTime.Now)
            {
                MessageBox.Show("Debes introducir una fecha superior a la de hoy");
                return false;
            }
            return true;
        }

        private List<Game> generateGames()
        {
            List<Team> teams = new List<Team>();
            List<Game> games = new List<Game>();
            foreach(DataGridViewRow row in dgv_teamsParticipate.Rows)
            {
                teams.Add((Team)row.DataBoundItem);
            }
            if(competition.Type.Name == "League")
            {
                bool isEven = (teams.Count % 2 == 0);

                if (!isEven)
                {
                    Team teamGhost = new Team();
                    teamGhost.Name = "G";
                    teams.Add(teamGhost);
                }
                List<Team> teamsShuffled = ShuffleTeamsList(teams);
                generateMatches(games, teamsShuffled);
                printGames(games, teamsShuffled);
            }
            else if(competition.Type.Name == "Tournament")
            {
                List<Team> teamsShuffled = ShuffleTeamsList(teams);
                int numberOfTeams = teamsShuffled.Count;
                DateTime selectedDate = dtp_startDate.Value;
                if (isPow2(numberOfTeams))
                {
                    String round = CompetitionType.getNextRound(numberOfTeams);
                    int eliminationRounds = numberOfTeams / 2;
                    DateTime date = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, 9, 0, 0);
                    for (int i = 0; i < numberOfTeams; i += 2)
                    {
                        DateTime dateR = date.AddHours(i);
                        Team team1 = teamsShuffled[i];
                        Team team2 = teamsShuffled[i + 1];
                        Game game = new Game();
                        game.homeTeam = team1;
                        game.awayTeam = team2;
                        game.matchDay = round;
                        game.isPlayed = false;
                        game.competition = competition;
                        game.GameDate = dateR;
                        games.Add(game);
                    }
                }
                else
                {
                    MessageBox.Show("No es posible crear un torneo con ese número de equipos.");
                    return null;
                }
            }
            return games;
            
            
        }

        private bool isPow2(int n)
        {
            if (n == 0)
                return false;

            return (int)(Math.Ceiling(
                       (Math.Log(n) / Math.Log(2))))
                == (int)(Math.Floor(
                    ((Math.Log(n) / Math.Log(2)))));
        }
        private void generateMatches(List<Game> games, List<Team> teams)
        {
            int totalRounds = teams.Count - 1;
            DateTime selectedDate = dtp_startDate.Value;
            for (int i = 0; i < totalRounds; i++)
            {
                DateTime date = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, 9, 0, 0);
                DateTime dateAux = date.AddDays(i * 7);
                for (int j = 0; j < teams.Count / 2; j++)
                {
                    DateTime dateR = dateAux.AddHours(j);
                    Game game = new Game();
                    game.homeTeam = teams[j];
                    game.awayTeam = teams[teams.Count - j - 1];
                    game.matchDay = "Matchday " + (i + 1);
                    game.competition = competition;
                    game.isPlayed = false;
                    game.GameDate = dateR;
                    games.Add(game);
                }

                // Rotate the teams in the list for the next round
                teams.Insert(1, teams[teams.Count - 1]);
                teams.RemoveAt(teams.Count - 1);
            }

        }

        private void printGames(List<Game> games, List<Team> teams)
        {
            foreach (Game game in games)
            {
                Console.WriteLine(game.homeTeam.Name + " vs " + game.awayTeam.Name + " (" + game.matchDay + ")");
            }
        }

        private List<Team> ShuffleTeamsList (List<Team> teams)
        {
            Random rand = new Random();
            var shuffled = teams.OrderBy(_ => rand.Next()).ToList();
            return shuffled;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            ctrlGames.deleteGames(competition.Id);
            ctrlCompetitions.deleteParticipants(competition.Id);
            ctrlCompetitions.deleteCompetition(competition.Id);
            parent.UpdateTable();
            this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ctrlCompetitions.stopCompetition(competition.Id);
            ctrlGames.deleteGames(competition.Id);
            parent.UpdateTable() ;
            EnableButtons();
        }

    }
}
