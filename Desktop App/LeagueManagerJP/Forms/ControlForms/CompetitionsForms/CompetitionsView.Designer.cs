namespace LeagueManagerJP.Forms.ControlForms.CompetitionsForms
{
    partial class CompetitionsView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompetitionsView));
            this.dgv_teams = new System.Windows.Forms.DataGridView();
            this.dgv_teamsParticipate = new System.Windows.Forms.DataGridView();
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_advise = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.dtp_startDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_date = new System.Windows.Forms.Label();
            this.btn_right = new System.Windows.Forms.PictureBox();
            this.btn_left = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teamsParticipate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_left)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_teams
            // 
            this.dgv_teams.AllowUserToAddRows = false;
            this.dgv_teams.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_teams.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_teams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_teams.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_teams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_teams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_teams.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_teams.Location = new System.Drawing.Point(13, 162);
            this.dgv_teams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_teams.Name = "dgv_teams";
            this.dgv_teams.ReadOnly = true;
            this.dgv_teams.RowHeadersVisible = false;
            this.dgv_teams.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_teams.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_teams.Size = new System.Drawing.Size(236, 366);
            this.dgv_teams.TabIndex = 3;
            this.dgv_teams.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_teams_CellContentClick);
            // 
            // dgv_teamsParticipate
            // 
            this.dgv_teamsParticipate.AllowUserToAddRows = false;
            this.dgv_teamsParticipate.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_teamsParticipate.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_teamsParticipate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_teamsParticipate.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_teamsParticipate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_teamsParticipate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_teamsParticipate.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_teamsParticipate.Location = new System.Drawing.Point(406, 162);
            this.dgv_teamsParticipate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_teamsParticipate.Name = "dgv_teamsParticipate";
            this.dgv_teamsParticipate.ReadOnly = true;
            this.dgv_teamsParticipate.RowHeadersVisible = false;
            this.dgv_teamsParticipate.RowHeadersWidth = 62;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_teamsParticipate.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_teamsParticipate.Size = new System.Drawing.Size(236, 366);
            this.dgv_teamsParticipate.TabIndex = 4;
            this.dgv_teamsParticipate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_teamsParticipate_CellContentClick);
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(721, 462);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(141, 65);
            this.btn_start.TabIndex = 9;
            this.btn_start.Text = "Comenzar Competición";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_advise
            // 
            this.lbl_advise.BackColor = System.Drawing.Color.Transparent;
            this.lbl_advise.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_advise.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_advise.Location = new System.Drawing.Point(32, 65);
            this.lbl_advise.Name = "lbl_advise";
            this.lbl_advise.Size = new System.Drawing.Size(853, 67);
            this.lbl_advise.TabIndex = 10;
            this.lbl_advise.Text = "Selecciona un equipo de la tabla izquierda y pulsa en la flecha derecha para anad" +
    "irlo a la tabla de equipos participantes de la competición.";
            this.lbl_advise.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(721, 318);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(141, 65);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Borrar Competición";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Enabled = false;
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(721, 390);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(141, 65);
            this.btn_reset.TabIndex = 13;
            this.btn_reset.Text = "Resetear Competición";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // dtp_startDate
            // 
            this.dtp_startDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_startDate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_startDate.Location = new System.Drawing.Point(687, 233);
            this.dtp_startDate.MinDate = new System.DateTime(2023, 5, 1, 3, 4, 24, 0);
            this.dtp_startDate.Name = "dtp_startDate";
            this.dtp_startDate.Size = new System.Drawing.Size(200, 29);
            this.dtp_startDate.TabIndex = 14;
            this.dtp_startDate.Value = new System.DateTime(2023, 5, 1, 3, 4, 29, 0);
            // 
            // lbl_date
            // 
            this.lbl_date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_date.Location = new System.Drawing.Point(652, 162);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(240, 42);
            this.lbl_date.TabIndex = 15;
            this.lbl_date.Text = "Introduzca la fecha de la primera \r\njornada a disputar";
            this.lbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_right
            // 
            this.btn_right.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_right.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_right.Image = global::LeagueManagerJP.Properties.Resources.right_arrow67;
            this.btn_right.Location = new System.Drawing.Point(292, 233);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(67, 60);
            this.btn_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_right.TabIndex = 8;
            this.btn_right.TabStop = false;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            this.btn_right.MouseEnter += new System.EventHandler(this.btn_right_MouseEnter);
            this.btn_right.MouseLeave += new System.EventHandler(this.btn_right_MouseLeave);
            // 
            // btn_left
            // 
            this.btn_left.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_left.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_left.Image = global::LeagueManagerJP.Properties.Resources.left_arrow64;
            this.btn_left.Location = new System.Drawing.Point(292, 395);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(67, 60);
            this.btn_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_left.TabIndex = 7;
            this.btn_left.TabStop = false;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            this.btn_left.MouseEnter += new System.EventHandler(this.btn_left_MouseEnter);
            this.btn_left.MouseLeave += new System.EventHandler(this.btn_left_MouseLeave);
            // 
            // CompetitionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LeagueManagerJP.Properties.Resources.bg_sm;
            this.ClientSize = new System.Drawing.Size(922, 588);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.dtp_startDate);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lbl_advise);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.dgv_teamsParticipate);
            this.Controls.Add(this.dgv_teams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompetitionsView";
            this.Text = "Vista de competición";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teamsParticipate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_left)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_teams;
        private System.Windows.Forms.DataGridView dgv_teamsParticipate;
        private System.Windows.Forms.PictureBox btn_left;
        private System.Windows.Forms.PictureBox btn_right;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_advise;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.DateTimePicker dtp_startDate;
        private System.Windows.Forms.Label lbl_date;
    }
}