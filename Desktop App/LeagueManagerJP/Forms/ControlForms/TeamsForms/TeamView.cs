using LeagueManagerJP.Controllers;
using LeagueManagerJP.Models;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LeagueManagerJP.Forms.ControlForms
{
    public partial class TeamView : Form
    {
        Team team;
        Player playerSel;
        User trainer;
        Login parent;
        public TeamView(Team team)
        {
            InitializeComponent();
            this.team = team;
            InitializeData();
            if (team.Trainer == null) btn_endContract.Text = "Establecer entrenador";
        }

        public TeamView(Team team, Login parent)
        {
            InitializeComponent();
            this.team = team;
            InitializeData();
            this.parent = parent;
            btn_logout.Visible = true;
        }

        private void InitializeData()
        {
            lbl_date.Text = team.CreationDate.ToString("dd/MM/yyyy");
            lbl_name.Text = team.Name;
            lbl_origin.Text = team.Origin;
            lbl_trainer.Text = (team.Trainer != null ? team.Trainer.UserName : "No Establecido");
            UpdateTable();
        }

        private void UpdateTable()
        {
            dgv_players.DataSource = ctrlPlayers.readPlayersByTeam(team);
            dgv_players.Columns[0].Visible = false;
            dgv_players.Columns[1].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_players.SelectedRows !=  null && (Player)dgv_players.CurrentRow.DataBoundItem!=null)
            {
                playerSel = (Player)dgv_players.CurrentRow.DataBoundItem;
                tb_name.Text = playerSel.Name;
                tb_origin.Text = playerSel.Nacionality;
                tb_positions.Text = playerSel.Position;
                spn_age.Value = playerSel.Age;
                spn_number.Value = playerSel.Number;
            }
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            if (!checkFields()) return;
            if (playerSel != null)
            {
                readFileds(playerSel);
                if (ctrlPlayers.modifyPlayer(playerSel))
                {
                    MessageBox.Show("Datos modificados con éxto");
                    clearFields();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un problema en la inserción de datos");
                }
            }
            else
            {
                Player player = new Player();
                readFileds(player);
                if (ctrlPlayers.insertPlayer(player))
                {
                    MessageBox.Show("Datos introducidos con éxto");
                    clearFields();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un problema en la inserción de datos");
                }
            }
            UpdateTable();
        }

        private void readFileds(Player player)
        {
            player.Name = tb_name.Text;
            player.Nacionality = tb_origin.Text;
            player.Position = tb_positions.Text;
            player.Age = (int)spn_age.Value;
            player.team = team;
            player.Number = (int)spn_number.Value;
        }

        private bool checkFields()
        {
            if(tb_name.Text.Length < 2)
            {
                MessageBox.Show("Introduce un nombre de más de 1 caracter");
                return false;
            }
            if(tb_origin.Text.Length < 2)
            {
                MessageBox.Show("Introduce una nacionalidad de más de 1 caracter");
                return false;
            }
            if(!Regex.IsMatch(tb_positions.Text, @"([A-Za-z]{2}-?)"))
            {
                MessageBox.Show("Debes introducir cada posición separada del caracter '-'");
                return false;
            }
            if (spn_age.Value < 2 || spn_age.Value > 92)
            {
                MessageBox.Show("Introduce una edad válida (Mayor de 2, menor de 92)");
                return false;
            }
            if(spn_number.Value < 1 || spn_number.Value > 99)
            {
                MessageBox.Show("Introduce un dorsal válido (entre 1 y 99)");
                return false;
            }
            return true;
        }

        private void btn_cl_Click(object sender, EventArgs e)
        {
            playerSel = null;
            clearFields();
        }

        private void clearFields()
        {
            spn_age.Value = 0;
            tb_name.Text = String.Empty;
            tb_origin.Text = String.Empty;
            tb_positions.Text = String.Empty;
            spn_number.Value = 0;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(playerSel == null)
            {
                MessageBox.Show("Debes seleccionar un jugador");
                return;
            }
            playerSel.team = team;
            if (ctrlPlayers.deletePlayer(playerSel))
            {
                MessageBox.Show("El jugador "+playerSel.Name+" ha sido dado de baja del "+playerSel.team);
                clearFields();
                playerSel = null;
                UpdateTable();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error en el borrado de datos");
            }
            
        }

        private void btn_endContract_Click(object sender, EventArgs e)
        {
            if(team.Trainer == null)
            {
                cmb_trainers.Visible = true;
                cmb_trainers.DataSource = ctrlUsers.readNonTeamTrainers();
                btn_accept.Visible = true;
                btn_endContract.Visible = false;
            }
            else
            {
                if (MainPanel.showConfirmDialog("El entrenador " + team.Trainer.UserName + " " +
                " dejará de ser entrenador del " + team.Name + ", estás seguro?"))
                {
                    if (ctrlUsers.endTrainerPeriod(team.Trainer))
                    {
                        lbl_trainer.Text = "No Establecido";
                        team.Trainer = null;
                        MessageBox.Show("Entrenador eliminado");
                        if (trainer != null) Application.Exit();
                        btn_endContract.Text = "Establecer Entrenador";
                    }
                }
            }
            
            
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            User trainer = (User)cmb_trainers.SelectedItem;
            if(trainer != null)
            {
                team.Trainer = trainer;
                if (ctrlUsers.startTrainerPeriod(team))
                {
                    btn_accept.Visible = false;
                    cmb_trainers.Visible = false;
                    btn_endContract.Visible = true;
                    btn_endContract.Text = "Finalizar Contrato";
                    MessageBox.Show("Entrenador establecido");
                    lbl_trainer.Text = team.Trainer.UserName;
                }
                else MessageBox.Show("No se ha podido establecer al nuevo entrenador");
            }
            else
            {
                MessageBox.Show("Debes escoger un entrenador");
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }
    }
}
