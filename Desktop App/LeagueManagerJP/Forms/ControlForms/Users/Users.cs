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
using System.Text.RegularExpressions;

namespace LeagueManagerJP.Forms.ControlForms
{
    public partial class Users : Form
    {

        User userSel;
        public Users()
        {
            InitializeComponent();
            UpdateTable();
        }

        public void UpdateTable()
        {
            dgv_users.DataSource = ctrlUsers.readUsers(null);
            dgv_users.Columns[0].Visible = false;
            dgv_users.Columns[1].HeaderText = "Nombre";
            dgv_users.Columns[2].HeaderText = "Email";
            dgv_users.Columns[3].HeaderText = "Tipo";
            dgv_users.BorderStyle = BorderStyle.None;
            dgv_users.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_users.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_users.DefaultCellStyle.SelectionBackColor = Color.FromArgb(96, 60, 118);
            dgv_users.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv_users.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv_users.EnableHeadersVisualStyles = false;
            dgv_users.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_users.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif",10);
            dgv_users.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dgv_users.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_users.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_users.ColumnHeadersDefaultCellStyle.Padding = new Padding(2);
        }

        private void dgv_users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_users.SelectedRows != null)
            {
                userSel = (User)dgv_users.CurrentRow.DataBoundItem;
                setType();
                tb_name.Text = userSel.UserName;
                tb_email.Text = userSel.Email;
                unableTypes();
            }
        }

        private void setType()
        {
            switch(userSel.Type)
            {
                case "Administrator":
                    rb_admin.Checked = true;
                    break;
                case "Trainer":
                    rb_trainer.Checked = true;
                    break;
                case "Referee":
                    rb_ref.Checked = true;  
                    break;
            }
        }

        private void unableTypes()
        {
            rb_admin.Enabled = false;
            rb_trainer.Enabled = false;
            rb_ref.Enabled = false;
        }

        private void enableTypes()
        {
            rb_admin.Enabled = true;
            rb_trainer.Enabled = true;
            rb_ref.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            userSel = null;
            tb_email.Text = String.Empty;
            tb_name.Text = String.Empty;
            clearType();
            enableTypes();
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

        private void btn_modify_Click(object sender, EventArgs e)
        {
                if(tb_name.Text.Length == 0)
                {
                    MessageBox.Show("Debes introducir un nombre de usuario correcto");
                    return;
                }
                if(!checkEmail())
                {
                    MessageBox.Show("Debes introducir un email correcto");
                    return;
                }
                if(!rb_admin.Checked && !rb_ref.Checked && !rb_trainer.Checked)
                {
                    MessageBox.Show("Debes seleccionar un tipo de usuario");
                    return;
                }
                if(userSel != null)
                {
                userSel.Email = tb_email.Text;
                userSel.UserName = tb_name.Text;
                if(userSel.Type == "Administrator" && !rb_admin.Checked)
                {
                    MessageBox.Show("No se puede cambiar el rol de administrador a un usuario");
                    return;
                }
                selectType(userSel);
                ctrlUsers.ModifyUser(userSel);
                }
                else
                {
                    User user = new User();
                    user.Email = tb_email.Text;
                    user.UserName = tb_name.Text;
                    selectType(user);
                    PwdUser newUser = new PwdUser(user, this);
                    newUser.Show();
                }
            UpdateTable();
            clear();
        }

        private void selectType(User user)
        {
            string type = "";
            if(rb_trainer.Checked)
            {
                type = "Trainer";
            }
            else if (rb_admin.Checked)
            {
                type = "Administrator";
            }
            else
            {
                type = "Referee";
            }
            user.Type = type;
        }

        private bool checkEmail()
        {
            Regex emailregex = new Regex("(?<user>[^@]+)@(?<host>.+)");
            String mail = tb_email.Text;
            Match m = emailregex.Match(mail);
            if(!m.Success)
            {
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(userSel == null)
            {
                MessageBox.Show("Debes seleccionar un usuario");
                return;
            }
            else
            {
                if(userSel.UserName == "Admin")
                {
                    MessageBox.Show("No puedes eliminar al usuario principal");
                    return;
                }
                if (MainPanel.showConfirmDialog("Estás seguro de que quieres eliminar al usuario "+userSel.UserName+"?"))
                {
                    ctrlUsers.DeleteUser(userSel.Id);
                    UpdateTable();
                    clear();
                }
            }
        }
    }
}
