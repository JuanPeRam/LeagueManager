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
    public partial class PwdUser : Form
    {
        User userSel;
        Users parent;
        public PwdUser(User user, Users parent)
        {
            InitializeComponent();
            userSel = user;
            this.parent = parent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            if(tb_pwd.Text.Length <= 2)
            {
                MessageBox.Show("Debes introducir al menos 3 caracteres");
                return;
            }
            if(tb_pwd.Text != tb_pwdR.Text )
            {
                MessageBox.Show("Las password deben coincidir");
                return;
            }
            ctrlUsers.InsertUser(userSel,tb_pwd.Text);
            parent.UpdateTable();
            parent.clear();
            this.Close();
            
        }
    }
}
