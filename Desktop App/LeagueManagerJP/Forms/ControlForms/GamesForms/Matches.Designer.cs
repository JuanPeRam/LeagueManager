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
            this.dgv_matches = new System.Windows.Forms.DataGridView();
            this.cmb_competitions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Matchday = new System.Windows.Forms.ComboBox();
            this.lbl_ended = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_matches)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_matches
            // 
            this.dgv_matches.AllowUserToAddRows = false;
            this.dgv_matches.AllowUserToResizeRows = false;
            this.dgv_matches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_matches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_matches.BackgroundColor = System.Drawing.Color.White;
            this.dgv_matches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.cmb_competitions.FormattingEnabled = true;
            this.cmb_competitions.Location = new System.Drawing.Point(12, 42);
            this.cmb_competitions.Name = "cmb_competitions";
            this.cmb_competitions.Size = new System.Drawing.Size(179, 28);
            this.cmb_competitions.TabIndex = 2;
            this.cmb_competitions.SelectedIndexChanged += new System.EventHandler(this.cmb_competitions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Competición";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jornada";
            // 
            // cmb_Matchday
            // 
            this.cmb_Matchday.FormattingEnabled = true;
            this.cmb_Matchday.Location = new System.Drawing.Point(222, 42);
            this.cmb_Matchday.Name = "cmb_Matchday";
            this.cmb_Matchday.Size = new System.Drawing.Size(121, 28);
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
            // Matches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 510);
            this.Controls.Add(this.lbl_ended);
            this.Controls.Add(this.cmb_Matchday);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_competitions);
            this.Controls.Add(this.dgv_matches);
            this.Name = "Matches";
            this.Text = "Matches";
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
    }
}