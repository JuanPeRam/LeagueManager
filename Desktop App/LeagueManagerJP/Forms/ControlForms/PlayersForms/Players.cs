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

        private void dgv_players_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
