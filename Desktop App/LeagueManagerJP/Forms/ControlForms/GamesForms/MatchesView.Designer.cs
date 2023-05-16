namespace LeagueManagerJP.Forms.ControlForms.GamesForms
{
    partial class MatchesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchesView));
            this.dgv_homeTeam = new System.Windows.Forms.DataGridView();
            this.dgv_AwayTeam = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmb_referees = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_homeTeam = new System.Windows.Forms.Label();
            this.lbl_awayTeam = new System.Windows.Forms.Label();
            this.lbl_homeTrainer = new System.Windows.Forms.Label();
            this.lbl_awayTrainer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_homeTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AwayTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_homeTeam
            // 
            this.dgv_homeTeam.AllowUserToAddRows = false;
            this.dgv_homeTeam.AllowUserToResizeRows = false;
            this.dgv_homeTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_homeTeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_homeTeam.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(26)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_homeTeam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_homeTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(19)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_homeTeam.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_homeTeam.Location = new System.Drawing.Point(13, 157);
            this.dgv_homeTeam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_homeTeam.Name = "dgv_homeTeam";
            this.dgv_homeTeam.RowHeadersVisible = false;
            this.dgv_homeTeam.RowHeadersWidth = 62;
            this.dgv_homeTeam.Size = new System.Drawing.Size(416, 335);
            this.dgv_homeTeam.TabIndex = 1;
            // 
            // dgv_AwayTeam
            // 
            this.dgv_AwayTeam.AllowUserToAddRows = false;
            this.dgv_AwayTeam.AllowUserToResizeRows = false;
            this.dgv_AwayTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_AwayTeam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AwayTeam.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(26)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_AwayTeam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_AwayTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(19)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_AwayTeam.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_AwayTeam.Location = new System.Drawing.Point(579, 157);
            this.dgv_AwayTeam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_AwayTeam.Name = "dgv_AwayTeam";
            this.dgv_AwayTeam.RowHeadersVisible = false;
            this.dgv_AwayTeam.RowHeadersWidth = 62;
            this.dgv_AwayTeam.Size = new System.Drawing.Size(416, 335);
            this.dgv_AwayTeam.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(880, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rellena ambas tablas con los datos de cada jugador en el partido. Las sanciones s" +
    "e deben escribir con la letra A para amarillas \r\ny R para rojas. Marca la casill" +
    "a si el jugador disputó el partido.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(27)))), ((int)(((byte)(101)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(442, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cerrar Acta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_referees
            // 
            this.cmb_referees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_referees.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_referees.FormattingEnabled = true;
            this.cmb_referees.Location = new System.Drawing.Point(442, 103);
            this.cmb_referees.Name = "cmb_referees";
            this.cmb_referees.Size = new System.Drawing.Size(121, 29);
            this.cmb_referees.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(468, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Árbitro";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "Equipo Local";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(579, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Equipo Visitante";
            // 
            // lbl_homeTeam
            // 
            this.lbl_homeTeam.AutoSize = true;
            this.lbl_homeTeam.BackColor = System.Drawing.Color.Transparent;
            this.lbl_homeTeam.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_homeTeam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_homeTeam.Location = new System.Drawing.Point(17, 112);
            this.lbl_homeTeam.Name = "lbl_homeTeam";
            this.lbl_homeTeam.Size = new System.Drawing.Size(71, 28);
            this.lbl_homeTeam.TabIndex = 9;
            this.lbl_homeTeam.Text = "label5";
            // 
            // lbl_awayTeam
            // 
            this.lbl_awayTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_awayTeam.AutoSize = true;
            this.lbl_awayTeam.BackColor = System.Drawing.Color.Transparent;
            this.lbl_awayTeam.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_awayTeam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_awayTeam.Location = new System.Drawing.Point(583, 112);
            this.lbl_awayTeam.Name = "lbl_awayTeam";
            this.lbl_awayTeam.Size = new System.Drawing.Size(71, 28);
            this.lbl_awayTeam.TabIndex = 10;
            this.lbl_awayTeam.Text = "label6";
            // 
            // lbl_homeTrainer
            // 
            this.lbl_homeTrainer.AutoSize = true;
            this.lbl_homeTrainer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_homeTrainer.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_homeTrainer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_homeTrainer.Location = new System.Drawing.Point(345, 119);
            this.lbl_homeTrainer.Name = "lbl_homeTrainer";
            this.lbl_homeTrainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_homeTrainer.Size = new System.Drawing.Size(58, 21);
            this.lbl_homeTrainer.TabIndex = 11;
            this.lbl_homeTrainer.Text = "label5";
            // 
            // lbl_awayTrainer
            // 
            this.lbl_awayTrainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_awayTrainer.AutoSize = true;
            this.lbl_awayTrainer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_awayTrainer.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_awayTrainer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_awayTrainer.Location = new System.Drawing.Point(937, 119);
            this.lbl_awayTrainer.Name = "lbl_awayTrainer";
            this.lbl_awayTrainer.Size = new System.Drawing.Size(58, 21);
            this.lbl_awayTrainer.TabIndex = 12;
            this.lbl_awayTrainer.Text = "label6";
            // 
            // MatchesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LeagueManagerJP.Properties.Resources.bg_sm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 506);
            this.Controls.Add(this.lbl_awayTrainer);
            this.Controls.Add(this.lbl_homeTrainer);
            this.Controls.Add(this.lbl_awayTeam);
            this.Controls.Add(this.lbl_homeTeam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_referees);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_AwayTeam);
            this.Controls.Add(this.dgv_homeTeam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MatchesView";
            this.Text = "Acta del partido";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_homeTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AwayTeam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_homeTeam;
        private System.Windows.Forms.DataGridView dgv_AwayTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmb_referees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_homeTeam;
        private System.Windows.Forms.Label lbl_awayTeam;
        private System.Windows.Forms.Label lbl_homeTrainer;
        private System.Windows.Forms.Label lbl_awayTrainer;
    }
}