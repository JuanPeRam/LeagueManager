namespace LeagueManagerJP.Forms
{
    partial class MainPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnTeams = new System.Windows.Forms.Button();
            this.btnCompetitions = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lb_Title = new System.Windows.Forms.Label();
            this.panelOption = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(79)))));
            this.panelMenu.Controls.Add(this.btnUsers);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.btnTeams);
            this.panelMenu.Controls.Add(this.btnCompetitions);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(330, 858);
            this.panelMenu.TabIndex = 0;
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.Silver;
            this.btnUsers.Image = global::LeagueManagerJP.Properties.Resources.user;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 766);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(330, 92);
            this.btnUsers.TabIndex = 6;
            this.btnUsers.Text = "Usuarios";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click_1);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Image = global::LeagueManagerJP.Properties.Resources.marcador;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 307);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(330, 92);
            this.button3.TabIndex = 4;
            this.button3.Text = "Partidos";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTeams
            // 
            this.btnTeams.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeams.FlatAppearance.BorderSize = 0;
            this.btnTeams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeams.ForeColor = System.Drawing.Color.Silver;
            this.btnTeams.Image = global::LeagueManagerJP.Properties.Resources.equipos;
            this.btnTeams.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeams.Location = new System.Drawing.Point(0, 215);
            this.btnTeams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTeams.Name = "btnTeams";
            this.btnTeams.Size = new System.Drawing.Size(330, 92);
            this.btnTeams.TabIndex = 3;
            this.btnTeams.Text = "Equipos";
            this.btnTeams.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeams.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeams.UseVisualStyleBackColor = true;
            this.btnTeams.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCompetitions
            // 
            this.btnCompetitions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompetitions.FlatAppearance.BorderSize = 0;
            this.btnCompetitions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompetitions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompetitions.ForeColor = System.Drawing.Color.Silver;
            this.btnCompetitions.Image = global::LeagueManagerJP.Properties.Resources.trofeo;
            this.btnCompetitions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompetitions.Location = new System.Drawing.Point(0, 123);
            this.btnCompetitions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompetitions.Name = "btnCompetitions";
            this.btnCompetitions.Size = new System.Drawing.Size(330, 92);
            this.btnCompetitions.TabIndex = 2;
            this.btnCompetitions.Text = "Competiciones";
            this.btnCompetitions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompetitions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompetitions.UseVisualStyleBackColor = true;
            this.btnCompetitions.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(10)))), ((int)(((byte)(40)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(330, 123);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "League Manager";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.lb_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(330, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 123);
            this.panel1.TabIndex = 1;
            // 
            // btn_reset
            // 
            this.btn_reset.AutoSize = true;
            this.btn_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_reset.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.ForeColor = System.Drawing.Color.Transparent;
            this.btn_reset.Image = global::LeagueManagerJP.Properties.Resources.square_cross;
            this.btn_reset.Location = new System.Drawing.Point(0, 0);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(54, 123);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Visible = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(543, 40);
            this.lb_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(112, 37);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "HOME";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelOption
            // 
            this.panelOption.AutoSize = true;
            this.panelOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOption.Location = new System.Drawing.Point(330, 123);
            this.panelOption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(1204, 735);
            this.panelOption.TabIndex = 2;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 858);
            this.Controls.Add(this.panelOption);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainPanel";
            this.Text = "MainMenu";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnTeams;
        private System.Windows.Forms.Button btnCompetitions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Panel panelOption;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btn_reset;
    }
}