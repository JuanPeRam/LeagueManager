using LeagueManagerJP.Controllers;
using LeagueManagerJP.Forms.ControlForms.GamesForms;
using LeagueManagerJP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueManagerJP.Forms.ControlForms
{
    public partial class Matches : Form
    {

        public Competition competition;
        User referee;
        Login parent;
        public Matches()
        {
            InitializeComponent();
            InitializeCombo();
        }

        public Matches(User referee, Login parent)
        {
            InitializeComponent();
            InitializeCombo();
            this.referee = referee;
            btn_logout.Visible = true;
            this.parent = parent;
        }

        private void InitializeCombo()
        {
            cmb_competitions.DataSource = ctrlCompetitions.ReadCompetitions("WHERE c.ID_Period IN (SELECT ID_Period FROM periods WHERE !isnull(Start_Date))");
        }

        private void cmb_competitions_SelectedIndexChanged(object sender, EventArgs e)
        {
            competition = (Competition)cmb_competitions.SelectedItem;
            UpdateTable(competition,"");
            cmb_Matchday.DataSource = ctrlGames.readMatchdays(competition);
            cmb_Matchday.SelectedIndex = -1;
            cmb_Matchday.Text = "";
        }

        public void UpdateTable(Competition competition,String condition)
        {
            dgv_matches.DataSource = ctrlGames.readGames(competition, condition);
            if (ctrlGames.areAllGamesPlayed(competition))
            {
                if (competition.Type.Name == "League")
                {
                    ctrlCompetitions.endCompetition(competition);
                    lbl_ended.Text = "Liga Finalizada";
                }
                else
                {
                    checkCup();
                }
            }
            else lbl_ended.Text = String.Empty;
            
            dgv_matches.Columns[0].Visible = false;
            dgv_matches.Columns[1].Visible = false;
            dgv_matches.Columns[2].Visible = false;

            dgv_matches.Columns[5].HeaderText = "Jornada";
            dgv_matches.Columns[3].HeaderText = "Local";
            dgv_matches.Columns[4].HeaderText = "Visitante";
            dgv_matches.Columns[6].HeaderText = "Jugado";
            dgv_matches.Columns[7].HeaderText = "Fecha";
        }

        private void checkCup()
        {
            string lastround = "";
            int matchesRound = 0;
            foreach (Game game in dgv_matches.DataSource as BindingSource)
            {
                if (lastround != game.matchDay)
                {
                    matchesRound = 1;
                    lastround = game.matchDay;
                }
                else
                {
                    matchesRound++;
                }
            }
            if(lastround == "Final")
            {
                ctrlCompetitions.endCompetition(competition);
                lbl_ended.Text = "Copa Finalizada";
            }
            else
            {
                List<Game> gamesOfLastRound = new List<Game>();
                foreach (Game game in dgv_matches.DataSource as BindingSource)
                {
                    if(game.matchDay == lastround)
                    {
                        gamesOfLastRound.Add(game);
                    }
                }
                List<Game> newGames = new List<Game>();
                for (int i = 0; i < matchesRound / 2; i++)
                {
                    Game game1 = gamesOfLastRound[0];
                    gamesOfLastRound.RemoveAt(0);
                    Game game2 = gamesOfLastRound[0];
                    gamesOfLastRound.RemoveAt(0);
                    Game game = new Game();
                    game.competition = competition;
                    game.matchDay = CompetitionType.getNextRound(matchesRound);
                    game.isPlayed = false;
                    game.homeTeam = ctrlGames.getWinner(game1);
                    game.awayTeam = ctrlGames.getWinner(game2);
                    game.GameDate = game1.GameDate.AddDays(7);
                    newGames.Add(game);
                }
                ctrlGames.insertGames(newGames);
                dgv_matches.DataSource = ctrlGames.readGames(competition, "");
            }

        }

        private void cmb_Matchday_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_Matchday.SelectedIndex != -1)
            {
                string cond = " AND Matchday = '"+cmb_Matchday.SelectedItem.ToString()+"'";
                UpdateTable(competition,cond);
            }
        }

        private void dgv_matches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_matches.SelectedRows != null)
            {
                Game game = (Game)dgv_matches.CurrentRow.DataBoundItem;
                if(game.isPlayed)
                {
                    MessageBox.Show("Este partido ya ha sido disputado");
                    return;
                }
                MatchesView mv = null;
                if (referee != null)
                {
                    mv = new MatchesView(game, referee,this);

                }
                else
                {
                    mv = new MatchesView(game,this);
                }
                mv.Show();
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }
    }
}
