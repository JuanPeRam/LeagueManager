namespace LeagueManagerJP.Forms.ControlForms
{
    partial class Matches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Matches));
            this.dgv_matches = new System.Windows.Forms.DataGridView();
            this.cmb_competitions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Matchday = new System.Windows.Forms.ComboBox();
            this.lbl_ended = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_matches)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_matches
            // 
            this.dgv_matches.AllowUserToAddRows = false;
            this.dgv_matches.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            this.dgv_matches.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_matches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_matches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_matches.BackgroundColor = System.Drawing.Color.White;
            this.dgv_matches.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_matches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_matches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_matches.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_matches.Location = new System.Drawing.Point(129, 85);
            this.dgv_matches.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_matches.Name = "dgv_matches";
            this.dgv_matches.ReadOnly = true;
            this.dgv_matches.RowHeadersVisible = false;
            this.dgv_matches.RowHeadersWidth = 62;
            this.dgv_matches.Size = new System.Drawing.Size(833, 370);
            this.dgv_matches.TabIndex = 1;
            this.dgv_matches.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_matches_CellContentClick);
            // 
            // cmb_competitions
            // 
            this.cmb_competitions.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_competitions.FormattingEnabled = true;
            this.cmb_competitions.Location = new System.Drawing.Point(12, 42);
            this.cmb_competitions.Name = "cmb_competitions";
            this.cmb_competitions.Size = new System.Drawing.Size(179, 29);
            this.cmb_competitions.TabIndex = 2;
            this.cmb_competitions.SelectedIndexChanged += new System.EventHandler(this.cmb_competitions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Competición";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jornada";
            // 
            // cmb_Matchday
            // 
            this.cmb_Matchday.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Matchday.FormattingEnabled = true;
            this.cmb_Matchday.Location = new System.Drawing.Point(222, 42);
            this.cmb_Matchday.Name = "cmb_Matchday";
            this.cmb_Matchday.Size = new System.Drawing.Size(121, 29);
            this.cmb_Matchday.TabIndex = 5;
            this.cmb_Matchday.SelectedIndexChanged += new System.EventHandler(this.cmb_Matchday_SelectedIndexChanged);
            // 
            // lbl_ended
            // 
            this.lbl_ended.AutoSize = true;
            this.lbl_ended.Location = new System.Drawing.Point(520, 46);
            this.lbl_ended.Name = "lbl_ended";
            this.lbl_ended.Size = new System.Drawing.Size(0, 20);
            this.lbl_ended.TabIndex = 6;
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logout.BackColor = System.Drawing.Color.Indigo;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI Black", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_logout.Location = new System.Drawing.Point(833, 28);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(106, 38);
            this.btn_logout.TabIndex = 7;
            this.btn_logout.Text = "Cerrar Sesión";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Visible = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Matches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 510);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.lbl_ended);
            this.Controls.Add(this.cmb_Matchday);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_competitions);
            this.Controls.Add(this.dgv_matches);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Matches";
            this.Text = "Partidos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_matches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_matches;
        private System.Windows.Forms.ComboBox cmb_competitions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Matchday;
        private System.Windows.Forms.Label lbl_ended;
        private System.Windows.Forms.Button btn_logout;
    }
}