namespace LeagueManagerJP.Forms.ControlForms
{
    partial class Teams
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_teams = new System.Windows.Forms.DataGridView();
            this.cmb_trainers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.dtp_creation = new System.Windows.Forms.DateTimePicker();
            this.tb_origin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teams)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 434);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrenador";
            // 
            // dgv_teams
            // 
            this.dgv_teams.AllowUserToAddRows = false;
            this.dgv_teams.AllowUserToResizeRows = false;
            this.dgv_teams.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_teams.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_teams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_teams.Location = new System.Drawing.Point(13, 26);
            this.dgv_teams.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_teams.Name = "dgv_teams";
            this.dgv_teams.RowHeadersVisible = false;
            this.dgv_teams.RowHeadersWidth = 62;
            this.dgv_teams.Size = new System.Drawing.Size(752, 366);
            this.dgv_teams.TabIndex = 1;
            this.dgv_teams.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_teams_CellContentClick);
            // 
            // cmb_trainers
            // 
            this.cmb_trainers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_trainers.FormattingEnabled = true;
            this.cmb_trainers.Location = new System.Drawing.Point(381, 468);
            this.cmb_trainers.Name = "cmb_trainers";
            this.cmb_trainers.Size = new System.Drawing.Size(144, 28);
            this.cmb_trainers.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(17, 468);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(148, 26);
            this.tb_name.TabIndex = 4;
            // 
            // dtp_creation
            // 
            this.dtp_creation.Location = new System.Drawing.Point(565, 468);
            this.dtp_creation.Name = "dtp_creation";
            this.dtp_creation.Size = new System.Drawing.Size(200, 26);
            this.dtp_creation.TabIndex = 5;
            // 
            // tb_origin
            // 
            this.tb_origin.Location = new System.Drawing.Point(195, 468);
            this.tb_origin.Name = "tb_origin";
            this.tb_origin.Size = new System.Drawing.Size(148, 26);
            this.tb_origin.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Procedencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de creación";
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(808, 47);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(101, 46);
            this.btn_new.TabIndex = 9;
            this.btn_new.Text = "Nuevo";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(808, 135);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(101, 46);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Limpiar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 533);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_origin);
            this.Controls.Add(this.dtp_creation);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_trainers);
            this.Controls.Add(this.dgv_teams);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Teams";
            this.Text = "Teams";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_teams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_teams;
        private System.Windows.Forms.ComboBox cmb_trainers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.DateTimePicker dtp_creation;
        private System.Windows.Forms.TextBox tb_origin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_clear;
    }
}