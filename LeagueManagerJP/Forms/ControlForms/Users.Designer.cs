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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.gb_type.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_users
            // 
            this.dgv_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_users.Location = new System.Drawing.Point(465, 62);
            this.dgv_users.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.RowHeadersWidth = 62;
            this.dgv_users.Size = new System.Drawing.Size(717, 449);
            this.dgv_users.TabIndex = 0;
            this.dgv_users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_users_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(24, 108);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(289, 26);
            this.tb_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(24, 228);
            this.tb_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(289, 26);
            this.tb_email.TabIndex = 4;
            // 
            // rb_admin
            // 
            this.rb_admin.AutoSize = true;
            this.rb_admin.Location = new System.Drawing.Point(9, 29);
            this.rb_admin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_admin.Name = "rb_admin";
            this.rb_admin.Size = new System.Drawing.Size(132, 24);
            this.rb_admin.TabIndex = 5;
            this.rb_admin.TabStop = true;
            this.rb_admin.Text = "Administrador";
            this.rb_admin.UseVisualStyleBackColor = true;
            // 
            // rb_trainer
            // 
            this.rb_trainer.AutoSize = true;
            this.rb_trainer.Location = new System.Drawing.Point(9, 65);
            this.rb_trainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_trainer.Name = "rb_trainer";
            this.rb_trainer.Size = new System.Drawing.Size(114, 24);
            this.rb_trainer.TabIndex = 6;
            this.rb_trainer.TabStop = true;
            this.rb_trainer.Text = "Entrenador";
            this.rb_trainer.UseVisualStyleBackColor = true;
            // 
            // rb_ref
            // 
            this.rb_ref.AutoSize = true;
            this.rb_ref.Location = new System.Drawing.Point(9, 100);
            this.rb_ref.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rb_ref.Name = "rb_ref";
            this.rb_ref.Size = new System.Drawing.Size(81, 24);
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
            this.btn_modify.Location = new System.Drawing.Point(44, 490);
            this.btn_modify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Size = new System.Drawing.Size(62, 48);
            this.btn_modify.TabIndex = 9;
            this.btn_modify.UseVisualStyleBackColor = true;
            // 
            // btn_remove
            // 
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Image = global::LeagueManagerJP.Properties.Resources.borrar;
            this.btn_remove.Location = new System.Drawing.Point(124, 492);
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
            this.btn_clear.Location = new System.Drawing.Point(198, 487);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(57, 52);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::LeagueManagerJP.Properties.Resources.borrar;
            this.button2.Location = new System.Drawing.Point(129, 490);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 48);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::LeagueManagerJP.Properties.Resources.limpiar;
            this.button3.Location = new System.Drawing.Point(202, 490);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 48);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_modify);
            this.Controls.Add(this.gb_type);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_users);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Users";
            this.Text = "Users";
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}