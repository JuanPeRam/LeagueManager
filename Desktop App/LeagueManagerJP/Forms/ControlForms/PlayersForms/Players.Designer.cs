namespace LeagueManagerJP.Forms.ControlForms.PlayersForms
{
    partial class Players
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Players));
            this.dgv_players = new System.Windows.Forms.DataGridView();
            this.cmb_teams = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_players)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_players
            // 
            this.dgv_players.AllowUserToAddRows = false;
            this.dgv_players.AllowUserToDeleteRows = false;
            this.dgv_players.AllowUserToOrderColumns = true;
            this.dgv_players.AllowUserToResizeColumns = false;
            this.dgv_players.AllowUserToResizeRows = false;
            this.dgv_players.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_players.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_players.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_players.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_players.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_players.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_players.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_players.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_players.Location = new System.Drawing.Point(24, 117);
            this.dgv_players.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_players.Name = "dgv_players";
            this.dgv_players.ReadOnly = true;
            this.dgv_players.RowHeadersVisible = false;
            this.dgv_players.RowHeadersWidth = 62;
            this.dgv_players.Size = new System.Drawing.Size(752, 291);
            this.dgv_players.TabIndex = 3;
            this.dgv_players.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_players_CellContentClick);
            // 
            // cmb_teams
            // 
            this.cmb_teams.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_teams.FormattingEnabled = true;
            this.cmb_teams.Location = new System.Drawing.Point(24, 64);
            this.cmb_teams.Name = "cmb_teams";
            this.cmb_teams.Size = new System.Drawing.Size(121, 29);
            this.cmb_teams.TabIndex = 4;
            this.cmb_teams.SelectedIndexChanged += new System.EventHandler(this.cmb_teams_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equipo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(645, 64);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(97, 42);
            this.btn_new.TabIndex = 5;
            this.btn_new.Text = "Nuevo";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.button1_Click);
            // 
            // Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_teams);
            this.Controls.Add(this.dgv_players);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Players";
            this.Text = "Jugadores";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_players)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_players;
        private System.Windows.Forms.ComboBox cmb_teams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_new;
    }
}