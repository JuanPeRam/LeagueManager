using LeagueManagerJP.Controllers;
using LeagueManagerJP.Forms;
using LeagueManagerJP.Forms.ControlForms;
using LeagueManagerJP.Models;
using System;
using System.Windows.Forms;

namespace LeagueManagerJP
{
    public partial class Login : Form
    {
        User userLog;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            userLog = ctrlUsers.logIn(tb_user.Text, tb_pwd.Text);
            if(userLog == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            else
            {
                if (userLog.Type.Equals("Administrator"))
                {
                    MainPanel menu = new MainPanel(userLog);
                    menu.Show();
                }
                else if (userLog.Type.Equals("Trainer"))
                {
                    String condition = "WHERE ID_Coach = "+userLog.Id;
                    BindingSource bsTeam = ctrlTeams.ReadTeams(condition);
                    Team team = bsTeam.DataSource as Team;
                    if(team != null)
                    {
                        TeamView tv = new TeamView(team);
                        tv.Show();
                    }
                    else
                    {
                        MessageBox.Show("No tienes un equipo asignado, contacta con un administrador para que le asigne su equipo");
                        return;
                    }
                    
                }
                else if (userLog.Type.Equals("Referee"))
                {
                    Matches matches = new Matches(userLog);
                    matches.Show();
                }
                this.Hide();
            }
        }
    }
}
