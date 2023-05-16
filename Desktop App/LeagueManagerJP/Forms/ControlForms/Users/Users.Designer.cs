namespace LeagueManagerJP.Forms.ControlForms
{
    partial class Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.dgv_users = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.rb_admin = new System.Windows.Forms.RadioButton();
            this.rb_trainer = new System.Windows.Forms.RadioButton();
            this.rb_ref = new System.Windows.Forms.RadioButton();
            this.gb_type = new System.Windows.Forms.GroupBox();
            this.btn_modify = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.gb_type.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_users
            // 
            this.dgv_users.AllowUserToAddRows = false;
            this.dgv_users.AllowUserToResizeRows = false;
            this.dgv_users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_users.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_users.Location = new System.Drawing.Point(333, 62);
            this.dgv_users.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.ReadOnly = true;
            this.dgv_users.RowHeadersVisible = false;
            this.dgv_users.RowHeadersWidth = 62;
            this.dgv_users.Size = new System.Drawing.Size(717, 449);
            this.dgv_users.TabIndex = 0;
            this.dgv_users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_users_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(24, 108);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(289, 29);
            this.tb_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(24, 228);
            this.tb_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(289, 29);
            this.tb_email.TabIndex = 4;
            // 
            // rb_admin
            // 
            this.rb_admin.AutoSize = true;
            this.rb_admin.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_admin.Location = new System.Drawing.Point(9, 29);
            this.rb_admin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_admin.Name = "rb_admin";
            this.rb_admin.Size = new System.Drawing.Size(135, 25);
            this.rb_admin.TabIndex = 5;
            this.rb_admin.TabStop = true;
            this.rb_admin.Text = "Administrador";
            this.rb_admin.UseVisualStyleBackColor = true;
            // 
            // rb_trainer
            // 
            this.rb_trainer.AutoSize = true;
            this.rb_trainer.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_trainer.Location = new System.Drawing.Point(9, 65);
            this.rb_trainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_trainer.Name = "rb_trainer";
            this.rb_trainer.Size = new System.Drawing.Size(112, 25);
            this.rb_trainer.TabIndex = 6;
            this.rb_trainer.TabStop = true;
            this.rb_trainer.Text = "Entrenador";
            this.rb_trainer.UseVisualStyleBackColor = true;
            // 
            // rb_ref
            // 
            this.rb_ref.AutoSize = true;
            this.rb_ref.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_ref.Location = new System.Drawing.Point(9, 100);
            this.rb_ref.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_ref.Name = "rb_ref";
            this.rb_ref.Size = new System.Drawing.Size(84, 25);
            this.rb_ref.TabIndex = 7;
            this.rb_ref.TabStop = true;
            this.rb_ref.Text = "Árbitro";
            this.rb_ref.UseVisualStyleBackColor = true;
            // 
            // gb_type
            // 
            this.gb_type.Controls.Add(this.rb_admin);
            this.gb_type.Controls.Add(this.rb_ref);
            this.gb_type.Controls.Add(this.rb_trainer);
            this.gb_type.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gb_type.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_type.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gb_type.Location = new System.Drawing.Point(24, 311);
            this.gb_type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_type.Name = "gb_type";
            this.gb_type.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gb_type.Size = new System.Drawing.Size(291, 146);
            this.gb_type.TabIndex = 8;
            this.gb_type.TabStop = false;
            this.gb_type.Text = "Tipo";
            // 
            // btn_modify
            // 
            this.btn_modify.FlatAppearance.BorderSize = 0;
            this.btn_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modify.Image = global::LeagueManagerJP.Properties.Resources.check;
            this.btn_modify.Location = new System.Drawing.Point(56, 467);
            this.btn_modify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(62, 48);
            this.btn_modify.TabIndex = 9;
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Image = global::LeagueManagerJP.Properties.Resources.borrar;
            this.btn_remove.Location = new System.Drawing.Point(136, 469);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(64, 43);
            this.btn_remove.TabIndex = 10;
            this.btn_remove.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Image = global::LeagueManagerJP.Properties.Resources.limpiar;
            this.btn_clear.Location = new System.Drawing.Point(210, 464);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(57, 52);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Image = global::LeagueManagerJP.Properties.Resources.borrar;
            this.btn_delete.Location = new System.Drawing.Point(141, 467);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(62, 48);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_cl
            // 
            this.btn_cl.FlatAppearance.BorderSize = 0;
            this.btn_cl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cl.Image = global::LeagueManagerJP.Properties.Resources.limpiar;
            this.btn_cl.Location = new System.Drawing.Point(214, 467);
            this.btn_cl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_cl.Name = "btn_cl";
            this.btn_cl.Size = new System.Drawing.Size(62, 48);
            this.btn_cl.TabIndex = 11;
            this.btn_cl.UseVisualStyleBackColor = true;
            this.btn_cl.Click += new System.EventHandler(this.button3_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btn_cl);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.gb_type);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_users);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Users";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.gb_type.ResumeLayout(false);
            this.gb_type.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_users;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.RadioButton rb_admin;
        private System.Windows.Forms.RadioButton rb_trainer;
        private System.Windows.Forms.RadioButton rb_ref;
        private System.Windows.Forms.GroupBox gb_type;
        private System.Windows.Forms.Button btn_modify;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cl;
    }
}