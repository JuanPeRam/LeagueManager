using LeagueManagerJP.Forms.ControlForms;
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

namespace LeagueManagerJP.Forms
{
    public partial class MainPanel : Form
    {
        User userLog;
        Button currentButton;
        Form formSel;
        public MainPanel(User user)
        {
            InitializeComponent();
            userLog = user;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    ResetButton(currentButton);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(80, 50, 99);
                }
            }
        }

        private void ResetButton(Button button)
        {
            if (button != null)
            {
                button.BackColor = Color.FromArgb(50,20,79);
            }
        }

        private void changeFormSel(Form form, object btnSender)
        {
            btn_reset.Visible = true;
            if (formSel != null)
            {
                formSel.Close();
            }
            ActivateButton(btnSender);
            formSel = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelOption.Controls.Add(form);
            panelOption.Tag = form;
            form.BringToFront();
            form.Show();
            lb_Title.Text = form.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            changeFormSel(new Competitions(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeFormSel(new Teams(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            changeFormSel(new Matches(), sender);
        }

        private void btnUsers_Click_1(object sender, EventArgs e)
        {
            changeFormSel(new Users(), sender);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            btn_reset.Visible = false;
            ResetButton(currentButton);
            currentButton = null;
            if (formSel != null)
            {
                formSel.Close();
            }
            lb_Title.Text = "HOME";
        }
    }
}
