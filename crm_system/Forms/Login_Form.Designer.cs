namespace crm_system.Forms
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label user_nameLabel;
            System.Windows.Forms.Label user_passLabel;
            System.Windows.Forms.Label titleLabel;
            this.user_name_textBox1 = new System.Windows.Forms.TextBox();
            this.user_name_title_label1 = new System.Windows.Forms.Label();
            this.continue_button1 = new System.Windows.Forms.Button();
            this.user_pass_title_label1 = new System.Windows.Forms.Label();
            this.password_textBox1 = new System.Windows.Forms.TextBox();
            this.user_nameLabel1 = new System.Windows.Forms.Label();
            this.crm_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_db = new crm_system.DS.user_ds();
            this.user_passLabel1 = new System.Windows.Forms.Label();
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.crm_tableTableAdapter = new crm_system.DS.user_dsTableAdapters.crm_tableTableAdapter();
            this.tableAdapterManager = new crm_system.DS.user_dsTableAdapters.TableAdapterManager();
            this.user_name_back_panel1 = new System.Windows.Forms.Panel();
            this.seperator_panel1 = new System.Windows.Forms.Panel();
            this.user_name_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.seperator_panel2 = new System.Windows.Forms.Panel();
            this.pass_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit_button1 = new System.Windows.Forms.Button();
            this.user_imagePictureBox = new System.Windows.Forms.PictureBox();
            this.sign_in_label1 = new System.Windows.Forms.Label();
            user_nameLabel = new System.Windows.Forms.Label();
            user_passLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.crm_tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_db)).BeginInit();
            this.user_name_back_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_name_pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pass_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // user_nameLabel
            // 
            user_nameLabel.AutoSize = true;
            user_nameLabel.Location = new System.Drawing.Point(558, 96);
            user_nameLabel.Name = "user_nameLabel";
            user_nameLabel.Size = new System.Drawing.Size(59, 13);
            user_nameLabel.TabIndex = 7;
            user_nameLabel.Text = "user name:";
            // 
            // user_passLabel
            // 
            user_passLabel.AutoSize = true;
            user_passLabel.Location = new System.Drawing.Point(558, 119);
            user_passLabel.Name = "user_passLabel";
            user_passLabel.Size = new System.Drawing.Size(55, 13);
            user_passLabel.TabIndex = 9;
            user_passLabel.Text = "user pass:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(587, 142);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(26, 13);
            titleLabel.TabIndex = 12;
            titleLabel.Text = "title:";
            // 
            // user_name_textBox1
            // 
            this.user_name_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user_name_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name_textBox1.Location = new System.Drawing.Point(63, 18);
            this.user_name_textBox1.Name = "user_name_textBox1";
            this.user_name_textBox1.Size = new System.Drawing.Size(237, 24);
            this.user_name_textBox1.TabIndex = 0;
            this.user_name_textBox1.TextChanged += new System.EventHandler(this.user_name_textBox1_TextChanged);
            // 
            // user_name_title_label1
            // 
            this.user_name_title_label1.AutoSize = true;
            this.user_name_title_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name_title_label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_name_title_label1.Location = new System.Drawing.Point(77, 291);
            this.user_name_title_label1.Name = "user_name_title_label1";
            this.user_name_title_label1.Size = new System.Drawing.Size(93, 18);
            this.user_name_title_label1.TabIndex = 1;
            this.user_name_title_label1.Text = "User Name";
            // 
            // continue_button1
            // 
            this.continue_button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.continue_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continue_button1.ForeColor = System.Drawing.Color.White;
            this.continue_button1.Location = new System.Drawing.Point(95, 486);
            this.continue_button1.Name = "continue_button1";
            this.continue_button1.Size = new System.Drawing.Size(302, 85);
            this.continue_button1.TabIndex = 2;
            this.continue_button1.Text = "LOGIN";
            this.continue_button1.UseVisualStyleBackColor = false;
            this.continue_button1.Click += new System.EventHandler(this.continue_button1_Click);
            // 
            // user_pass_title_label1
            // 
            this.user_pass_title_label1.AutoSize = true;
            this.user_pass_title_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_pass_title_label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_pass_title_label1.Location = new System.Drawing.Point(77, 381);
            this.user_pass_title_label1.Name = "user_pass_title_label1";
            this.user_pass_title_label1.Size = new System.Drawing.Size(83, 18);
            this.user_pass_title_label1.TabIndex = 4;
            this.user_pass_title_label1.Text = "Password";
            // 
            // password_textBox1
            // 
            this.password_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textBox1.Location = new System.Drawing.Point(63, 18);
            this.password_textBox1.Name = "password_textBox1";
            this.password_textBox1.Size = new System.Drawing.Size(237, 24);
            this.password_textBox1.TabIndex = 3;
            this.password_textBox1.UseSystemPasswordChar = true;
            // 
            // user_nameLabel1
            // 
            this.user_nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crm_tableBindingSource, "user_name", true));
            this.user_nameLabel1.Location = new System.Drawing.Point(619, 96);
            this.user_nameLabel1.Name = "user_nameLabel1";
            this.user_nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.user_nameLabel1.TabIndex = 8;
            this.user_nameLabel1.Text = "label1";
            // 
            // crm_tableBindingSource
            // 
            this.crm_tableBindingSource.DataMember = "crm_table";
            this.crm_tableBindingSource.DataSource = this.user_db;
            // 
            // user_db
            // 
            this.user_db.DataSetName = "user_db";
            this.user_db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_passLabel1
            // 
            this.user_passLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crm_tableBindingSource, "user_pass", true));
            this.user_passLabel1.Location = new System.Drawing.Point(619, 119);
            this.user_passLabel1.Name = "user_passLabel1";
            this.user_passLabel1.Size = new System.Drawing.Size(100, 23);
            this.user_passLabel1.TabIndex = 10;
            this.user_passLabel1.Text = "label1";
            // 
            // titleLabel1
            // 
            this.titleLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crm_tableBindingSource, "title", true));
            this.titleLabel1.Location = new System.Drawing.Point(619, 142);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(100, 23);
            this.titleLabel1.TabIndex = 13;
            this.titleLabel1.Text = "label1";
            // 
            // crm_tableTableAdapter
            // 
            this.crm_tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.crm_tableTableAdapter = this.crm_tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = crm_system.DS.user_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // user_name_back_panel1
            // 
            this.user_name_back_panel1.BackColor = System.Drawing.Color.White;
            this.user_name_back_panel1.Controls.Add(this.seperator_panel1);
            this.user_name_back_panel1.Controls.Add(this.user_name_pictureBox1);
            this.user_name_back_panel1.Controls.Add(this.user_name_textBox1);
            this.user_name_back_panel1.Location = new System.Drawing.Point(80, 312);
            this.user_name_back_panel1.Name = "user_name_back_panel1";
            this.user_name_back_panel1.Size = new System.Drawing.Size(336, 56);
            this.user_name_back_panel1.TabIndex = 16;
            // 
            // seperator_panel1
            // 
            this.seperator_panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.seperator_panel1.Location = new System.Drawing.Point(54, 15);
            this.seperator_panel1.Name = "seperator_panel1";
            this.seperator_panel1.Size = new System.Drawing.Size(2, 30);
            this.seperator_panel1.TabIndex = 18;
            // 
            // user_name_pictureBox1
            // 
            this.user_name_pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.user_name_pictureBox1.Image = global::crm_system.Properties.Resources.user_icon;
            this.user_name_pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.user_name_pictureBox1.Name = "user_name_pictureBox1";
            this.user_name_pictureBox1.Size = new System.Drawing.Size(34, 31);
            this.user_name_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_name_pictureBox1.TabIndex = 17;
            this.user_name_pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.seperator_panel2);
            this.panel1.Controls.Add(this.password_textBox1);
            this.panel1.Controls.Add(this.pass_pictureBox1);
            this.panel1.Location = new System.Drawing.Point(80, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 56);
            this.panel1.TabIndex = 17;
            // 
            // seperator_panel2
            // 
            this.seperator_panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.seperator_panel2.Location = new System.Drawing.Point(54, 14);
            this.seperator_panel2.Name = "seperator_panel2";
            this.seperator_panel2.Size = new System.Drawing.Size(2, 30);
            this.seperator_panel2.TabIndex = 19;
            // 
            // pass_pictureBox1
            // 
            this.pass_pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pass_pictureBox1.Image = global::crm_system.Properties.Resources.password_icon;
            this.pass_pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pass_pictureBox1.Name = "pass_pictureBox1";
            this.pass_pictureBox1.Size = new System.Drawing.Size(34, 31);
            this.pass_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pass_pictureBox1.TabIndex = 17;
            this.pass_pictureBox1.TabStop = false;
            // 
            // user_pictureBox1
            // 
            this.user_pictureBox1.Image = global::crm_system.Properties.Resources.user_inmg;
            this.user_pictureBox1.Location = new System.Drawing.Point(172, 121);
            this.user_pictureBox1.Name = "user_pictureBox1";
            this.user_pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.user_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_pictureBox1.TabIndex = 15;
            this.user_pictureBox1.TabStop = false;
            // 
            // exit_button1
            // 
            this.exit_button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_button1.BackColor = System.Drawing.Color.White;
            this.exit_button1.BackgroundImage = global::crm_system.Properties.Resources.exit_icon;
            this.exit_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button1.ForeColor = System.Drawing.Color.Black;
            this.exit_button1.Location = new System.Drawing.Point(473, 9);
            this.exit_button1.Name = "exit_button1";
            this.exit_button1.Size = new System.Drawing.Size(51, 40);
            this.exit_button1.TabIndex = 14;
            this.exit_button1.UseVisualStyleBackColor = false;
            this.exit_button1.Click += new System.EventHandler(this.exit_button1_Click);
            // 
            // user_imagePictureBox
            // 
            this.user_imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.crm_tableBindingSource, "user_image", true));
            this.user_imagePictureBox.Location = new System.Drawing.Point(561, 187);
            this.user_imagePictureBox.Name = "user_imagePictureBox";
            this.user_imagePictureBox.Size = new System.Drawing.Size(100, 97);
            this.user_imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_imagePictureBox.TabIndex = 12;
            this.user_imagePictureBox.TabStop = false;
            // 
            // sign_in_label1
            // 
            this.sign_in_label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.sign_in_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_in_label1.ForeColor = System.Drawing.Color.White;
            this.sign_in_label1.Location = new System.Drawing.Point(92, 9);
            this.sign_in_label1.Name = "sign_in_label1";
            this.sign_in_label1.Size = new System.Drawing.Size(305, 85);
            this.sign_in_label1.TabIndex = 18;
            this.sign_in_label1.Text = "SINGN IN";
            this.sign_in_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 583);
            this.Controls.Add(this.sign_in_label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.user_name_title_label1);
            this.Controls.Add(this.user_pass_title_label1);
            this.Controls.Add(this.user_name_back_panel1);
            this.Controls.Add(this.user_pictureBox1);
            this.Controls.Add(this.exit_button1);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleLabel1);
            this.Controls.Add(this.user_imagePictureBox);
            this.Controls.Add(user_passLabel);
            this.Controls.Add(this.user_passLabel1);
            this.Controls.Add(user_nameLabel);
            this.Controls.Add(this.user_nameLabel1);
            this.Controls.Add(this.continue_button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crm_tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_db)).EndInit();
            this.user_name_back_panel1.ResumeLayout(false);
            this.user_name_back_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_name_pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pass_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_name_textBox1;
        private System.Windows.Forms.Label user_name_title_label1;
        private System.Windows.Forms.Button continue_button1;
        private System.Windows.Forms.Label user_pass_title_label1;
        private System.Windows.Forms.TextBox password_textBox1;
        private DS.user_ds user_db;
        private System.Windows.Forms.BindingSource crm_tableBindingSource;
        private DS.user_dsTableAdapters.crm_tableTableAdapter crm_tableTableAdapter;
        private DS.user_dsTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.PictureBox user_imagePictureBox;
        public System.Windows.Forms.Label titleLabel1;
        public System.Windows.Forms.Label user_nameLabel1;
        public System.Windows.Forms.Label user_passLabel1;
        private System.Windows.Forms.Button exit_button1;
        private System.Windows.Forms.PictureBox user_pictureBox1;
        private System.Windows.Forms.Panel user_name_back_panel1;
        private System.Windows.Forms.PictureBox user_name_pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pass_pictureBox1;
        private System.Windows.Forms.Panel seperator_panel1;
        private System.Windows.Forms.Panel seperator_panel2;
        private System.Windows.Forms.Label sign_in_label1;
    }
}