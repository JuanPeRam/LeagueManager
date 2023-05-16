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

namespace LeagueManagerJP.Forms.ControlForms.PlayersForms
{
    public partial class Players : Form
    {
        Player playerSel;
        public Players()
        {
            InitializeComponent();
            InitializeTable();
            InitializeCombo();
        }

        private void InitializeCombo()
        {
            cmb_teams.DataSource = ctrlTeams.ReadTeams("");
            Team team = new Team();
            team.Name = "Sin equipo";
            ((BindingSource)cmb_teams.DataSource).Add(team);
        }

        private void setComboSel(Team team)
        {
            for(int i = 0; i < cmb_teams.Items.Count; i++)
            {
                if(team.Id == ((Team)cmb_teams.Items[i]).Id)
                {
                    cmb_teams.SelectedIndex = i;
                }
            }
        }

        private void setComboNonTeam()
        {
            for (int i = 0; i < cmb_teams.Items.Count; i++)
            {
                if ("Sin equipo" == ((Team)cmb_teams.Items[i]).Name)
                {
                    cmb_teams.SelectedIndex = i;
                }
            }
        }
        private void InitializeTable()
        {
            dgv_players.DataSource = ctrlPlayers.readNonTeamPlayers();
            dgv_players.Columns[0].Visible = false;
            dgv_players.Columns[1].HeaderText = "Equipo";
            dgv_players.Columns[2].HeaderText = "Nombre";
            dgv_players.Columns[3].HeaderText = "Edad";
            dgv_players.Columns[4].HeaderText = "Posición";
            dgv_players.Columns[5].HeaderText = "Nacionalidad";
            dgv_players.Columns[6].HeaderText = "Dorsal";
        }

        public void UpdateTable(Team team)
        {
            if (team == null)
            {
                dgv_players.DataSource = ctrlPlayers.readNonTeamPlayers();
                setComboNonTeam();
            }
            else
            {
                dgv_players.DataSource = ctrlPlayers.readPlayersByTeam(team);
                setComboSel(team);
            }
        }

        private void dgv_players_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_players.SelectedRows != null)
            {
                playerSel = (Player)dgv_players.CurrentRow.DataBoundItem;
                PlayersView playerview = new PlayersView(playerSel,this);
                playerview.Show();
            }
        }

        private void cmb_teams_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_teams.SelectedIndex != -1)
            {
                Team selectedTeam = (Team)cmb_teams.SelectedItem;
                if(selectedTeam.Name == "Sin equipo")
                {
                    dgv_players.DataSource = ctrlPlayers.readNonTeamPlayers();
                    return;
                }
                dgv_players.DataSource = ctrlPlayers.readPlayersByTeam(selectedTeam);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayersView psview = new PlayersView(this);
            psview.Show();
        }
    }
}
