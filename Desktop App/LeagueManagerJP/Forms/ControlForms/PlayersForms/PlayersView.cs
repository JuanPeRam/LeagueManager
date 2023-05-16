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

namespace LeagueManagerJP.Forms.ControlForms.PlayersForms
{
    public partial class PlayersView : Form
    {
        private Player player;
        private Players parent;
        private Team nullTeam;
        public PlayersView(Player player, Players parent)
        {
            Initialize(parent);
            this.player = player;
            fillFields();
        }

        private void Initialize(Players parent)
        {
            InitializeComponent();
            InitializeCombo();
            this.parent = parent;
        }

        public PlayersView(Players parent)
        {
            Initialize(parent);
        }

        private void InitializeCombo()
        {
            cmb_teams.DataSource = ctrlTeams.ReadTeams("");
            Team team = new Team();
            team.Name = "Sin equipo";
            nullTeam = team;
            ((BindingSource)cmb_teams.DataSource).Add(team);
            cmb_teams.SelectedItem = team;
        }

        private void btn_cl_Click(object sender, EventArgs e)
        {
            if(player == null)
            {
                tb_nacionality.Text = string.Empty;
                tb_name.Text = string.Empty;
                tb_pos.Text = string.Empty;
                cmb_teams.SelectedItem = nullTeam;
                spn_age.Value = 18;
                spn_number.Value = 0;
            }
            else
            {
                fillFields();
            }
        }

        private void fillFields()
        {
            tb_nacionality.Text = player.Nacionality;
            tb_name.Text = player.Name;
            tb_pos.Text = player.Position;
            if (player.team != null)
            {
                for (int i = 0; i < cmb_teams.Items.Count; i++)
                {
                    Team teamAux = (Team)cmb_teams.Items[i];
                    if (teamAux.Name != "Sin equipo" && teamAux.Id == player.team.Id)
                    {
                        cmb_teams.SelectedIndex = i;
                        continue;
                    }
                }
            }
            spn_age.Value = player.Age;
            spn_number.Value = player.Number;
        }

        private void btn_modify_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                if (player == null)
                {
                    player = new Player();
                    fillPlayer(player);
                    if (ctrlPlayers.insertPlayer(player))
                    {
                        if (((Team)cmb_teams.SelectedItem).Id != nullTeam.Id)
                        {
                            player.team = (Team)cmb_teams.SelectedItem;
                            if (ctrlPlayers.signPlayer(player))
                            {
                                MessageBox.Show("Jugador añdido con éxito");
                            }
                            else MessageBox.Show("No se ha podido añadir al jugador");
                        }
                        else MessageBox.Show("Jugador añdido con éxito");
                    }
                    else MessageBox.Show("No se ha podido añadir al jugador");
                    parent.UpdateTable(player.team);
                    
                }
                else
                {
                    fillPlayer(player);
                    ctrlPlayers.modifyPlayer(player);
                    if(((Team)cmb_teams.SelectedItem).Id != nullTeam.Id)
                    {
                        Team teamSel = (Team)cmb_teams.SelectedItem;
                        if(player.team == null)
                        {
                            player.team = teamSel;
                            if (ctrlPlayers.signPlayer(player))
                            {
                                MessageBox.Show("Jugador modificado con éxito");
                                parent.UpdateTable(player.team);
                            }
                            else MessageBox.Show("No se ha podido añadir al jugador");
                            return;
                        }
                        if(player.team.Id !=  teamSel.Id)
                        {
                            if (ctrlPlayers.deletePlayer(player))
                            {
                                player.team = teamSel;
                                if (ctrlPlayers.signPlayer(player))
                                {
                                    MessageBox.Show("Jugador mdificado con éxito");
                                }
                                else MessageBox.Show("No se ha podido añadir al jugador al nuevo equipo");
                            }
                            else MessageBox.Show("No se ha podido elminiar al jugador de su equipo actual");
                        }
                        else MessageBox.Show("Jugador mdificado con éxito");
                    }
                    else
                    {
                        if(player.team != null)
                        {
                            if (ctrlPlayers.deletePlayer(player))
                            {
                                player.team = null;
                                MessageBox.Show("Jugador mdificado con éxito");
                            }
                            else MessageBox.Show("No se ha podido elminiar al jugador de su equipo actual");
                            

                        }
                        else MessageBox.Show("Jugador mdificado con éxito");
                    }
                    parent.UpdateTable(player.team);
                }

            }
        }

        private void fillPlayer(Player playerAux)
        {
            playerAux.Name = tb_name.Text;
            playerAux.Position = tb_pos.Text;
            playerAux.Nacionality = tb_nacionality.Text;
            playerAux.Age = (int)spn_age.Value;
            playerAux.Number = (int)spn_number.Value;
        }

        private bool checkFields()
        {
            if (tb_name.Text.Length < 2)
            {
                MessageBox.Show("Introduce un nombre de más de 1 caracter");
                return false;
            }
            if (tb_nacionality.Text.Length < 2)
            {
                MessageBox.Show("Introduce una nacionalidad de más de 1 caracter");
                return false;
            }
            if (!Regex.IsMatch(tb_pos.Text, @"([A-Za-z]{2}-?)"))
            {
                MessageBox.Show("Debes introducir cada posición separada del caracter '-'");
                return false;
            }
            if (spn_age.Value < 2 || spn_age.Value > 92)
            {
                MessageBox.Show("Introduce una edad válida (Mayor de 2, menor de 92)");
                return false;
            }
            if (spn_number.Value < 1 || spn_number.Value > 99)
            {
                MessageBox.Show("Introduce un dorsal válido (entre 1 y 99)");
                return false;
            }
            return true;
        }
    }
}
