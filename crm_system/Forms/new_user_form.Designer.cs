namespace crm_system.Forms
{
    partial class new_user_form
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
            System.Windows.Forms.Label iDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(new_user_form));
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label nationalityLabel;
            System.Windows.Forms.Label cityLabel1;
            System.Windows.Forms.Label user_nameLabel;
            System.Windows.Forms.Label emailLabel1;
            System.Windows.Forms.Label phoneLabel1;
            System.Windows.Forms.Label birth_dateLabel;
            System.Windows.Forms.Label salaryLabel1;
            System.Windows.Forms.Label adressLabel1;
            System.Windows.Forms.Label repeat_pass_label1;
            System.Windows.Forms.Label user_passLabel;
            System.Windows.Forms.Label businessLabel;
            System.Windows.Forms.Label titleLabel;
            this.id_label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.status_label1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.info_panel1 = new System.Windows.Forms.Panel();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.crm_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_db = new crm_system.DS.user_ds();
            this.businessTextBox = new System.Windows.Forms.TextBox();
            this.password_panel1 = new System.Windows.Forms.Panel();
            this.repeat_pass_textBox1 = new System.Windows.Forms.TextBox();
            this.user_passTextBox = new System.Windows.Forms.TextBox();
            this.user_nameTextBox = new System.Windows.Forms.TextBox();
            this.select_img_button1 = new System.Windows.Forms.Button();
            this.nationalityTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.birth_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.crm_tableTableAdapter = new crm_system.DS.user_dsTableAdapters.crm_tableTableAdapter();
            this.tableAdapterManager = new crm_system.DS.user_dsTableAdapters.TableAdapterManager();
            this.user_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.save_button1 = new System.Windows.Forms.Button();
            this.close_new_user_button1 = new System.Windows.Forms.Button();
            iDLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            nationalityLabel = new System.Windows.Forms.Label();
            cityLabel1 = new System.Windows.Forms.Label();
            user_nameLabel = new System.Windows.Forms.Label();
            emailLabel1 = new System.Windows.Forms.Label();
            phoneLabel1 = new System.Windows.Forms.Label();
            birth_dateLabel = new System.Windows.Forms.Label();
            salaryLabel1 = new System.Windows.Forms.Label();
            adressLabel1 = new System.Windows.Forms.Label();
            repeat_pass_label1 = new System.Windows.Forms.Label();
            user_passLabel = new System.Windows.Forms.Label();
            businessLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            this.info_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crm_tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_db)).BeginInit();
            this.password_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            resources.ApplyResources(iDLabel, "iDLabel");
            iDLabel.Name = "iDLabel";
            // 
            // salaryLabel
            // 
            resources.ApplyResources(salaryLabel, "salaryLabel");
            salaryLabel.Name = "salaryLabel";
            // 
            // adressLabel
            // 
            resources.ApplyResources(adressLabel, "adressLabel");
            adressLabel.Name = "adressLabel";
            // 
            // phoneLabel
            // 
            resources.ApplyResources(phoneLabel, "phoneLabel");
            phoneLabel.Name = "phoneLabel";
            // 
            // emailLabel
            // 
            resources.ApplyResources(emailLabel, "emailLabel");
            emailLabel.Name = "emailLabel";
            // 
            // cityLabel
            // 
            resources.ApplyResources(cityLabel, "cityLabel");
            cityLabel.Name = "cityLabel";
            // 
            // nationalityLabel
            // 
            resources.ApplyResources(nationalityLabel, "nationalityLabel");
            nationalityLabel.Name = "nationalityLabel";
            // 
            // cityLabel1
            // 
            resources.ApplyResources(cityLabel1, "cityLabel1");
            cityLabel1.Name = "cityLabel1";
            // 
            // user_nameLabel
            // 
            resources.ApplyResources(user_nameLabel, "user_nameLabel");
            user_nameLabel.Name = "user_nameLabel";
            // 
            // emailLabel1
            // 
            resources.ApplyResources(emailLabel1, "emailLabel1");
            emailLabel1.Name = "emailLabel1";
            // 
            // phoneLabel1
            // 
            resources.ApplyResources(phoneLabel1, "phoneLabel1");
            phoneLabel1.Name = "phoneLabel1";
            // 
            // birth_dateLabel
            // 
            resources.ApplyResources(birth_dateLabel, "birth_dateLabel");
            birth_dateLabel.Name = "birth_dateLabel";
            // 
            // salaryLabel1
            // 
            resources.ApplyResources(salaryLabel1, "salaryLabel1");
            salaryLabel1.Name = "salaryLabel1";
            // 
            // adressLabel1
            // 
            resources.ApplyResources(adressLabel1, "adressLabel1");
            adressLabel1.Name = "adressLabel1";
            // 
            // repeat_pass_label1
            // 
            resources.ApplyResources(repeat_pass_label1, "repeat_pass_label1");
            repeat_pass_label1.Name = "repeat_pass_label1";
            // 
            // user_passLabel
            // 
            resources.ApplyResources(user_passLabel, "user_passLabel");
            user_passLabel.Name = "user_passLabel";
            // 
            // businessLabel
            // 
            resources.ApplyResources(businessLabel, "businessLabel");
            businessLabel.Name = "businessLabel";
            // 
            // titleLabel
            // 
            resources.ApplyResources(titleLabel, "titleLabel");
            titleLabel.Name = "titleLabel";
            // 
            // id_label1
            // 
            resources.ApplyResources(this.id_label1, "id_label1");
            this.id_label1.Name = "id_label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // status_label1
            // 
            resources.ApplyResources(this.status_label1, "status_label1");
            this.status_label1.Name = "status_label1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // info_panel1
            // 
            resources.ApplyResources(this.info_panel1, "info_panel1");
            this.info_panel1.BackColor = System.Drawing.Color.White;
            this.info_panel1.Controls.Add(titleLabel);
            this.info_panel1.Controls.Add(this.titleTextBox);
            this.info_panel1.Controls.Add(businessLabel);
            this.info_panel1.Controls.Add(this.businessTextBox);
            this.info_panel1.Controls.Add(this.password_panel1);
            this.info_panel1.Controls.Add(this.user_nameTextBox);
            this.info_panel1.Controls.Add(this.user_pictureBox1);
            this.info_panel1.Controls.Add(this.select_img_button1);
            this.info_panel1.Controls.Add(this.nationalityTextBox);
            this.info_panel1.Controls.Add(nationalityLabel);
            this.info_panel1.Controls.Add(this.cityTextBox);
            this.info_panel1.Controls.Add(cityLabel1);
            this.info_panel1.Controls.Add(this.emailTextBox);
            this.info_panel1.Controls.Add(user_nameLabel);
            this.info_panel1.Controls.Add(emailLabel1);
            this.info_panel1.Controls.Add(this.phoneTextBox);
            this.info_panel1.Controls.Add(phoneLabel1);
            this.info_panel1.Controls.Add(this.birth_dateDateTimePicker);
            this.info_panel1.Controls.Add(birth_dateLabel);
            this.info_panel1.Controls.Add(this.adressTextBox);
            this.info_panel1.Controls.Add(salaryLabel1);
            this.info_panel1.Controls.Add(adressLabel1);
            this.info_panel1.Controls.Add(this.salaryTextBox);
            this.info_panel1.Name = "info_panel1";
            // 
            // titleTextBox
            // 
            resources.ApplyResources(this.titleTextBox, "titleTextBox");
            this.titleTextBox.BackColor = System.Drawing.Color.Azure;
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crm_tableBindingSource, "title", true));
            this.titleTextBox.Name = "titleTextBox";
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
            // businessTextBox
            // 
            resources.ApplyResources(this.businessTextBox, "businessTextBox");
            this.businessTextBox.BackColor = System.Drawing.Color.Azure;
            this.businessTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crm_tableBindingSource, "business", true));
            this.businessTextBox.Name = "businessTextBox";
            // 
            // password_panel1
            // 
            resources.ApplyResources(this.password_panel1, "password_panel1");
            this.password_panel1.BackColor = System.Drawing.Color.White;
            this.password_panel1.Controls.Add(repeat_pass_label1);
            this.password_panel1.Controls.Add(this.repeat_pass_textBox1);
            this.password_panel1.Controls.Add(user_passLabel);
            this.password_panel1.Controls.Add(this.user_passTextBox);
            this.password_panel1.Name = "password_panel1";
            // 
            // repeat_pass_textBox1
            // 
            resources.ApplyResources(this.repeat_pass_textBox1, "repeat_pass_textBox1");
            this.repeat_pass_textBox1.BackColor = System.Drawing.Color.Azure;
            this.repeat_pass_textBox1.Name = "repeat_pass_textBox1";
            this.repeat_pass_textBox1.UseSystemPasswordChar = true;
            // 
            // user_passTextBox
            // 
            resources.ApplyResources(this.user_passTextBox, "user_passTextBox");
            this.user_passTextBox.BackColor = System.Drawing.Color.Azure;
            this.user_passTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crm_tableBindingSource, "user_pass", true));
            this.user_passTextBox.Name = "user_passTextBox";
            this.user_passTextBox.UseSystemPasswordChar = true;
            // 
            // user_nameTextBox
            // 
            resources.ApplyResources(this.user_nameTextBox, "user_nameTextBox");
            this.user_nameTextBox.BackColor = System.Drawing.Color.Azure;
            this.user_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crm_tableBindingSource, "user_name", true));
            this.user_nameTextBox.Name = "user_nameTextBox";
            // 
            // select_img_button1
            // 
            resources.ApplyResources(this.select_img_button1, "select_img_button1");
            this.select_img_button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.select_img_button1.ForeColor = System.Drawing.Color.White;
            this.select_img_button1.Name = "select_img_button1";
            this.select_img_button1.UseVisualStyleBackColor = false;
            this.select_img_button1.Click += new System.EventHandler(this.select_img_button1_Click);
            // 
            // nationalityTextBox
            // 
            resources.ApplyResources(this.nationalityTextBox, "nationalityTextBox");
            this.nationalityTextBox.BackColor = System.Drawing.Color.Azure;
            this.nationalityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crm_tableBindingSource, "nationality", true));
            this.nationalityTextBox.Name = "nationalityTextBox";
            // 
            // cityTextBox
            // 
            resources.ApplyResources(this.cityTextBox, "cityTextBox");
            this.cityTextBox.BackColor = System.Drawing.Color.Azure;
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crm_tableBindingSource, "city", true));
            this.cityTextBox.Name = "cityTextBox";
            // 
            // emailTextBox
            // 
            resources.ApplyResources(this.emailTextBox, "emailTextBox");
            this.emailTextBox.BackColor = System.Drawing.Color.Azure;
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crm_tableBindingSource, "Email", true));
            this.emailTextBox.Name = "emailTextBox";
            // 
            // phoneTextBox
            // 
            resources.ApplyResources(this.phoneTextBox, "phoneTextBox");
            this.phoneTextBox.BackColor = System.Drawing.Color.Azure;
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crm_tableBindingSource, "phone", true));
            this.phoneTextBox.Name = "phoneTextBox";
            // 
            // birth_dateDateTimePicker
            // 
            resources.ApplyResources(this.birth_dateDateTimePicker, "birth_dateDateTimePicker");
            this.birth_dateDateTimePicker.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.birth_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.crm_tableBindingSource, "birth_date", true));
            this.birth_dateDateTimePicker.Name = "birth_dateDateTimePicker";
            // 
            // adressTextBox
            // 
            resources.ApplyResources(this.adressTextBox, "adressTextBox");
            this.adressTextBox.BackColor = System.Drawing.Color.Azure;
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crm_tableBindingSource, "adress", true));
            this.adressTextBox.Name = "adressTextBox";
            // 
            // salaryTextBox
            // 
            resources.ApplyResources(this.salaryTextBox, "salaryTextBox");
            this.salaryTextBox.BackColor = System.Drawing.Color.Azure;
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crm_tableBindingSource, "salary", true));
            this.salaryTextBox.Name = "salaryTextBox";
            // 
            // crm_tableTableAdapter
            // 
            this.crm_tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.crm_tableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = crm_system.DS.user_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // user_pictureBox1
            // 
            resources.ApplyResources(this.user_pictureBox1, "user_pictureBox1");
            this.user_pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.crm_tableBindingSource, "user_image", true));
            this.user_pictureBox1.Name = "user_pictureBox1";
            this.user_pictureBox1.TabStop = false;
            // 
            // save_button1
            // 
            resources.ApplyResources(this.save_button1, "save_button1");
            this.save_button1.Image = global::crm_system.Properties.Resources.save_icon;
            this.save_button1.Name = "save_button1";
            this.save_button1.UseVisualStyleBackColor = true;
            this.save_button1.Click += new System.EventHandler(this.save_button1_Click);
            // 
            // close_new_user_button1
            // 
            resources.ApplyResources(this.close_new_user_button1, "close_new_user_button1");
            this.close_new_user_button1.Image = global::crm_system.Properties.Resources.cancel_icon;
            this.close_new_user_button1.Name = "close_new_user_button1";
            this.close_new_user_button1.UseVisualStyleBackColor = true;
            this.close_new_user_button1.Click += new System.EventHandler(this.close_new_user_button1_Click);
            // 
            // new_user_form
            // 
            resources.ApplyResources(this, "$this");
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.info_panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status_label1);
            this.Controls.Add(this.id_label1);
            this.Controls.Add(this.save_button1);
            this.Controls.Add(this.close_new_user_button1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(adressLabel);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(cityLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "new_user_form";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.new_user_form_Load);
            this.info_panel1.ResumeLayout(false);
            this.info_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crm_tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_db)).EndInit();
            this.password_panel1.ResumeLayout(false);
            this.password_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button save_button1;
        private System.Windows.Forms.Button close_new_user_button1;
        private DS.user_ds user_db;
        private System.Windows.Forms.BindingSource crm_tableBindingSource;
        private DS.user_dsTableAdapters.crm_tableTableAdapter crm_tableTableAdapter;
        private DS.user_dsTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.Label id_label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label status_label1;
        private System.Windows.Forms.TextBox user_nameTextBox;
        private System.Windows.Forms.PictureBox user_pictureBox1;
        private System.Windows.Forms.Button select_img_button1;
        private System.Windows.Forms.TextBox nationalityTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.DateTimePicker birth_dateDateTimePicker;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        public System.Windows.Forms.Panel info_panel1;
        private System.Windows.Forms.TextBox repeat_pass_textBox1;
        private System.Windows.Forms.TextBox user_passTextBox;
        public System.Windows.Forms.Panel password_panel1;
        private System.Windows.Forms.TextBox businessTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
    }
}