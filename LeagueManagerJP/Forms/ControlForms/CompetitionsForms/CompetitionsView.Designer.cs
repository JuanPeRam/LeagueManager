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
            this.dgv_teams = new System.Windows.Forms.DataGridView();
            this.dgv_teamsParticipate = new System.Windows.Forms.DataGridView();
            this.btn_right = new System.Windows.Forms.PictureBox();
            this.btn_left = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_advise = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.dtp_startDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dgv_teams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_teams.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_teams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_teams.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_teams.Location = new System.Drawing.Point(36, 162);
            this.dgv_teams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_teams.Name = "dgv_teams";
            this.dgv_teams.ReadOnly = true;
            this.dgv_teams.RowHeadersVisible = false;
            this.dgv_teams.RowHeadersWidth = 62;
            this.dgv_teams.Size = new System.Drawing.Size(236, 366);
            this.dgv_teams.TabIndex = 3;
            this.dgv_teams.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_teams_CellContentClick);
            // 
            // dgv_teamsParticipate
            // 
            this.dgv_teamsParticipate.AllowUserToAddRows = false;
            this.dgv_teamsParticipate.AllowUserToResizeRows = false;
            this.dgv_teamsParticipate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_teamsParticipate.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_teamsParticipate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_teamsParticipate.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_teamsParticipate.Location = new System.Drawing.Point(429, 162);
            this.dgv_teamsParticipate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_teamsParticipate.Name = "dgv_teamsParticipate";
            this.dgv_teamsParticipate.ReadOnly = true;
            this.dgv_teamsParticipate.RowHeadersVisible = false;
            this.dgv_teamsParticipate.RowHeadersWidth = 62;
            this.dgv_teamsParticipate.Size = new System.Drawing.Size(236, 366);
            this.dgv_teamsParticipate.TabIndex = 4;
            this.dgv_teamsParticipate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_teamsParticipate_CellContentClick);
            // 
            // btn_right
            // 
            this.btn_right.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_right.Image = global::LeagueManagerJP.Properties.Resources.right_arrow67;
            this.btn_right.Location = new System.Drawing.Point(315, 233);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(67, 60);
            this.btn_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_right.TabIndex = 8;
            this.btn_right.TabStop = false;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_left
            // 
            this.btn_left.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_left.Image = global::LeagueManagerJP.Properties.Resources.left_arrow64;
            this.btn_left.Location = new System.Drawing.Point(315, 395);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(67, 60);
            this.btn_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_left.TabIndex = 7;
            this.btn_left.TabStop = false;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(744, 462);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(141, 65);
            this.btn_start.TabIndex = 9;
            this.btn_start.Text = "Comenzar Competición";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_advise
            // 
            this.lbl_advise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_delete.Location = new System.Drawing.Point(744, 318);
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
            this.btn_reset.Location = new System.Drawing.Point(744, 390);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(141, 65);
            this.btn_reset.TabIndex = 13;
            this.btn_reset.Text = "Resetear Competición";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // dtp_startDate
            // 
            this.dtp_startDate.Location = new System.Drawing.Point(710, 233);
            this.dtp_startDate.MinDate = new System.DateTime(2023, 5, 1, 3, 4, 24, 0);
            this.dtp_startDate.Name = "dtp_startDate";
            this.dtp_startDate.Size = new System.Drawing.Size(200, 26);
            this.dtp_startDate.TabIndex = 14;
            this.dtp_startDate.Value = new System.DateTime(2023, 5, 1, 3, 4, 29, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(681, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "Introduzca la fecha de la primera \r\njornada a disputar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CompetitionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_startDate);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lbl_advise);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.dgv_teamsParticipate);
            this.Controls.Add(this.dgv_teams);
            this.Name = "CompetitionsView";
            this.Text = "CompetitionsView";
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
        private System.Windows.Forms.Label label1;
    }
}