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
            this.btn_players = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnTeams = new System.Windows.Forms.Button();
            this.btnCompetitions = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lb_Title = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.panelOption = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(79)))));
            this.panelMenu.Controls.Add(this.btn_players);
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
            // btn_players
            // 
            this.btn_players.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_players.FlatAppearance.BorderSize = 0;
            this.btn_players.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_players.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_players.ForeColor = System.Drawing.Color.Silver;
            this.btn_players.Image = global::LeagueManagerJP.Properties.Resources.players3;
            this.btn_players.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_players.Location = new System.Drawing.Point(0, 399);
            this.btn_players.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_players.Name = "btn_players";
            this.btn_players.Size = new System.Drawing.Size(330, 92);
            this.btn_players.TabIndex = 7;
            this.btn_players.Text = "Jugadores";
            this.btn_players.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_players.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_players.UseVisualStyleBackColor = true;
            this.btn_players.Click += new System.EventHandler(this.btn_players_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.button3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnTeams.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnCompetitions.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "League Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.lb_Title);
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(330, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 123);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(902, -8);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(54, 55);
            this.button2.TabIndex = 4;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(957, 0);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(54, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "O";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1017, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_close.Size = new System.Drawing.Size(54, 55);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "x";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lb_Title
            // 
            this.lb_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Title.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.Location = new System.Drawing.Point(54, 0);
            this.lb_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(1017, 123);
            this.lb_Title.TabIndex = 0;
            this.lb_Title.Text = "HOME";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_Title_MouseDown);
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
            // panelOption
            // 
            this.panelOption.AutoSize = true;
            this.panelOption.Controls.Add(this.pictureBox1);
            this.panelOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOption.Location = new System.Drawing.Point(330, 123);
            this.panelOption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(1071, 735);
            this.panelOption.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LeagueManagerJP.Properties.Resources.Logo_2_LM;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1071, 735);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 858);
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
            this.panelOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_players;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_close;
    }
}