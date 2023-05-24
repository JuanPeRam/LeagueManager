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
    public partial class Users : Form
    {

        User userSel;
        public Users()
        {
            InitializeComponent();
            InitializeTable();
        }

        private void InitializeTable()
        {
            dgv_users.DataSource = ctrlUsers.readUsers(null);
            dgv_users.Columns[0].Visible = false;
        }

        private void dgv_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_users.SelectedRows != null)
            {
                userSel = (User)dgv_users.CurrentRow.DataBoundItem;
                setType();
                tb_name.Text = userSel.UserName;
                tb_email.Text = userSel.Email;
            }
        }

        private void setType()
        {
            switch(userSel.Type)
            {
                case "Administrator":
                    rb_admin.Checked = true;
                    break;
                case "Tranier":
                    rb_trainer.Checked = true;
                    break;
                case "Referee":
                    rb_trainer.Checked = true;  
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userSel = null;
            tb_email.Text = String.Empty;
            tb_name.Text = String.Empty;
            clearType();
        }

        private void clearType()
        {
            foreach(Control control in gb_type.Controls)
            {
                if(control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }
            }
        }
    }
}
