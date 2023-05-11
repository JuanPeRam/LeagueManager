namespace LeagueManagerJP.Forms.ControlForms
{
    partial class Competitions
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
            this.dgv_competitions = new System.Windows.Forms.DataGridView();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_competitions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_competitions
            // 
            this.dgv_competitions.AllowUserToAddRows = false;
            this.dgv_competitions.AllowUserToResizeRows = false;
            this.dgv_competitions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_competitions.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_competitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_competitions.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_competitions.Location = new System.Drawing.Point(13, 28);
            this.dgv_competitions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_competitions.Name = "dgv_competitions";
            this.dgv_competitions.ReadOnly = true;
            this.dgv_competitions.RowHeadersVisible = false;
            this.dgv_competitions.RowHeadersWidth = 62;
            this.dgv_competitions.Size = new System.Drawing.Size(752, 366);
            this.dgv_competitions.TabIndex = 2;
            this.dgv_competitions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_competitions_CellContentClick);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(810, 57);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(121, 26);
            this.tb_name.TabIndex = 4;
            // 
            // cmb_type
            // 
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(806, 156);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(121, 28);
            this.cmb_type.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(810, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(806, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipo de competición";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(810, 323);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(142, 40);
            this.btn_insert.TabIndex = 9;
            this.btn_insert.Text = "Crear Nueva";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // Competitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 593);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.dgv_competitions);
            this.Name = "Competitions";
            this.Text = "Competitions";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_competitions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_competitions;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_insert;
    }
}