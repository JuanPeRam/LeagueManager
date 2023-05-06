using LeagueManagerJP.Controllers;
using LeagueManagerJP.Forms.ControlForms.CompetitionsForms;
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
    public partial class Competitions : Form
    {
        private Competition competitionSel;
        public Competitions()
        {
            InitializeComponent();
            fillComboType();
            UpdateTable();
        }

        private void fillComboType()
        {
            cmb_type.DataSource = ctrlCompetitions.readCompetitionsType("");
        }

        public void UpdateTable()
        {
            dgv_competitions.DataSource = ctrlCompetitions.ReadCompetitions("");
            dgv_competitions.Columns[0].Visible = false;
            dgv_competitions.Columns[1].HeaderText = "Nombre";
            dgv_competitions.Columns[2].HeaderText = "Tipo de competición";
            dgv_competitions.Columns[3].HeaderText = "Estado";
        }

        private void dgv_competitions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_competitions.SelectedRows != null)
            {
                competitionSel = (Competition)dgv_competitions.CurrentRow.DataBoundItem;
                CompetitionsView comp = new CompetitionsView(competitionSel,this);
                comp.Show();
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (checkfields())
            {
                competitionSel = new Competition();
                competitionSel.Name = tb_name.Text;
                competitionSel.Type = (CompetitionType)cmb_type.SelectedItem;
                if (ctrlCompetitions.insertCompetition(competitionSel))
                {
                    MessageBox.Show("Competición registrada con éxito");
                }
                else 
                {
                    MessageBox.Show("Ha ocurrido un error en la inserción de datos");
                }
                UpdateTable();
            }
            
        }

        private bool checkfields()
        {
            if(tb_name.Text.Length < 2)
            {
                MessageBox.Show("Debes introduir un nombre de más de 2 caracteres");
                return false;
            }
            if(cmb_type.SelectedIndex == -1)
            {
                MessageBox.Show("Debes elegir un tipo de competición");
                return false;
            }
            return true;
        }
    }
}
