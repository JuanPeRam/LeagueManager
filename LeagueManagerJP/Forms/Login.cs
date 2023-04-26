using LeagueManagerJP.Controllers;
using LeagueManagerJP.Forms;
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
                this.Hide();
            }
        }
    }
}
