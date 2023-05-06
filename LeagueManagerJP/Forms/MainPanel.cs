using LeagueManagerJP.Forms.ControlForms;
using LeagueManagerJP.Forms.ControlForms.PlayersForms;
using LeagueManagerJP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            setControlFunctions();
        }

        private void setControlFunctions()
        {
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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

        public static bool showConfirmDialog(String message) 
        {
            return MessageBox.Show(message, "Message", MessageBoxButtons.YesNo) == DialogResult.Yes;    
        }

        private void btn_players_Click(object sender, EventArgs e)
        {
            changeFormSel(new Players(), sender);
        }

        private void lb_Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                button1.Text = "o";
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                button1.Text = "O";
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
