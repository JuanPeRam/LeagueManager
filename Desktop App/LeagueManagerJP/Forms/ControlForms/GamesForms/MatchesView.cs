using LeagueManagerJP.Controllers;
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

namespace LeagueManagerJP.Forms.ControlForms.GamesForms
{
    public partial class MatchesView : Form
    {
        Game game;
        Matches parent;
        public MatchesView(Game game, Matches parent)
        {
            InitializeComponent();
            InitializeData(game, parent);
            UpdateTables();
            InitializeCombo();
        }

        public MatchesView(Game game, User user, Matches parent)
        {
            InitializeComponent();
            InitializeData(game,parent);
            UpdateTables();
            InitializeCombo();
            SetReferee(user);
            cmb_referees.Enabled = false; 
        }

        private void SetReferee(User user)
        {
            foreach(User us in cmb_referees.Items)
            {
                if(us.Id == user.Id)
                {
                    cmb_referees.SelectedItem = us;
                }
            }
        }

        private void InitializeCombo()
        {
            cmb_referees.DataSource = ctrlUsers.readUsers(" AND UserType = (SELECT ID_UserType FROM userstype WHERE NameType = 'Referee')");
        }

        private void InitializeData(Game game, Matches parent)
        {
            
            game.homeTeam.Trainer = ctrlTeams.readCurrentTrainer(game.homeTeam.Id);
            game.awayTeam.Trainer = ctrlTeams.readCurrentTrainer(game.awayTeam.Id);
            lbl_homeTeam.Text = game.homeTeam.Name;
            lbl_awayTeam.Text = game.awayTeam.Name;
            lbl_homeTrainer.Text = game.homeTeam.Trainer!=null ? game.homeTeam.Trainer.UserName:"";
            lbl_awayTrainer.Text = game.awayTeam.Trainer!=null ? game.awayTeam.Trainer.UserName:"";
            this.game = game;
            this.parent = parent;
        }

        private void UpdateTables()
        {
            List<Player> homePlayers = readPlayers(game.homeTeam);
            List<Player> awayPlayers = readPlayers(game.awayTeam);
            fillTable(homePlayers, dgv_homeTeam);
            fillTable(awayPlayers, dgv_AwayTeam);
        }

        private void fillTable(List<Player> players, DataGridView dgv)
        {
            DataTable dtPlayers  = new DataTable();

            dtPlayers.Columns.Add("Jugador", typeof(Player));
            dtPlayers.Columns.Add("Goles", typeof(int));
            dtPlayers.Columns.Add("Sanciones", typeof(string));
            dtPlayers.Columns.Add("Jugó", typeof(bool));

            foreach(Player player in players)
            {
                dtPlayers.Rows.Add(player,0,"",false);
            }

            dtPlayers.Columns[0].ReadOnly = true;

            dgv.DataSource = dtPlayers;
        }

        private List<Player> readPlayers(Team team)
        {
            List<Player> players = new List<Player>();
            BindingSource bsPlayers = ctrlPlayers.readPlayersByTeam(team);
            foreach (Player player in bsPlayers)
            {
                if (player != null)
                {
                    players.Add(player);
                }
            }
            return players;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MainPanel.showConfirmDialog("Una vez cierres el acta del partido no podrás cambiar los datos,Estás seguro de que quieres continuar?"))
            {
                List<Report> reports = new List<Report>();
                if (!fillReports(reports, dgv_homeTeam) || !fillReports(reports, dgv_AwayTeam))
                {
                    MessageBox.Show("Al menos 1 jugador de cada equipo debe haber jugado el partido");
                    return;
                }
                if(game.competition.Type.Name == "Tournament")
                {
                    if (checkDraw(reports))
                    {
                        MessageBox.Show("No puede haber un empate en una ronda eliminatoria");
                        return;
                    }
                }
                if(ctrlReports.InsertReports(reports))
                {
                    ctrlGames.closeGame(game.Id);
                    User referee = getCurrentItem();
                    if (referee != null)
                    {
                        ctrlGames.setReferee(game.Id, referee);
                    }
                    parent.UpdateTable(parent.competition, "");
                    this.Close();
                }

            }
        }

        private bool checkDraw(List<Report> reports)
        {
            int home_goals = 0;
            int away_goals = 0;
            bool start = true;
            Team homeTeam = null;
            foreach (Report report in reports)
            {
                if (start)
                {
                    homeTeam = report.player.team;
                    home_goals += report.goals;
                    start = false;
                    continue;
                }
                if (report.player.team.Id == homeTeam.Id)
                {
                    home_goals += report.goals;
                }
                else away_goals += report.goals;
            }
            if (home_goals == away_goals)
            {
                return true;
            }
            return false;
        }

        private User getCurrentItem()
        {
            if(cmb_referees.SelectedIndex != -1)
            {
                return cmb_referees.SelectedItem as User;
            }
            return null;
        }

        private bool fillReports(List<Report> reports, DataGridView dgv)
        {
            int count = 0;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if ((bool)row.Cells[3].Value)
                {
                    count++;
                    Player p = (Player)row.Cells[0].Value;
                    int goals = (int)row.Cells[1].Value;
                    string sanction = (string)row.Cells[2].Value;
                    Report report = new Report();
                    report.player = p;
                    report.goals = goals;
                    report.sanctions = sanction;
                    report.match = game;
                    reports.Add(report);
                }
            }
            return count > 0;
        }
    }
}
