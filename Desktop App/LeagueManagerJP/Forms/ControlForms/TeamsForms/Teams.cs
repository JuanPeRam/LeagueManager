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

namespace LeagueManagerJP.Forms.ControlForms
{
    public partial class Teams : Form
    {
        private Team teamSel;
        public Teams()
        {
            InitializeComponent();
            InitializeTrainers();
            UpdateTable();
            dtp_creation.MaxDate = DateTime.Now;
        }

        private void InitializeTrainers()
        {
            cmb_trainers.DataSource = ctrlUsers.readNonTeamTrainers();
            cmb_trainers.SelectedIndex = -1;
            cmb_trainers.Text = String.Empty;
        }

        private void UpdateTable()
        {
            dgv_teams.DataSource = ctrlTeams.ReadTeams("");
            dgv_teams.Columns[0].Visible = false;
            dgv_teams.Columns[1].HeaderText = "Nombre";
            dgv_teams.Columns[2].HeaderText = "Entrenador";
            dgv_teams.Columns[3].HeaderText = "Procedencia";
            dgv_teams.Columns[4].HeaderText = "Fecha de creación";
        }

        private void dgv_teams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_teams.SelectedRows != null)
            {
                teamSel = (Team)dgv_teams.CurrentRow.DataBoundItem;
                TeamView teamView = new TeamView(teamSel);
                teamView.Show();
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if (tb_name.Text.Length <3)
            {
                MessageBox.Show("El equipo debe tener un nombre de más de 2 caracteres");
                return;
            }
            if(tb_origin.Text.Length <1)
            {
                MessageBox.Show("Debes introducir una procedencia");
                return;
            }
            if(dtp_creation.Value > DateTime.Now)
            {
                MessageBox.Show("Debes introducir una fecha válida");
                return;
            }
            Team team = new Team();
            team.Name = tb_name.Text;
            team.Origin = tb_origin.Text;
            team.CreationDate = dtp_creation.Value;
            if(cmb_trainers.SelectedIndex >-1) team.Trainer = (User)cmb_trainers.SelectedItem;
            ctrlTeams.insertTeam(team);
            UpdateTable();
            InitializeTrainers();
            clearFields();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            tb_name.Text = string.Empty;
            tb_origin.Text = string.Empty;
            cmb_trainers.SelectedIndex = -1;
            dtp_creation.Value = dtp_creation.MaxDate;
        }

    }
}
