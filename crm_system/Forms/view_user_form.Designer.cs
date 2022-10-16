namespace crm_system.Forms
{
    partial class view_user_form
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
            System.Windows.Forms.Label nationalityLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneLabel;
            this.background_panel1 = new System.Windows.Forms.Panel();
            this.title_label1 = new System.Windows.Forms.Label();
            this.crmtableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_db = new crm_system.DS.user_ds();
            this.user_name_label1 = new System.Windows.Forms.Label();
            this.user_img_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.crm_tableTableAdapter = new crm_system.DS.user_dsTableAdapters.crm_tableTableAdapter();
            this.tableAdapterManager = new crm_system.DS.user_dsTableAdapters.TableAdapterManager();
            this.id_label1 = new System.Windows.Forms.Label();
            this.delete_button1 = new System.Windows.Forms.Button();
            this.edit_user_button1 = new System.Windows.Forms.Button();
            this.nationalityLabel1 = new System.Windows.Forms.Label();
            this.cityLabel1 = new System.Windows.Forms.Label();
            this.contact_label2 = new System.Windows.Forms.Label();
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.phoneLabel1 = new System.Windows.Forms.Label();
            nationalityLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            this.background_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crmtableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_db)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_img_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nationalityLabel
            // 
            nationalityLabel.AutoSize = true;
            nationalityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nationalityLabel.Location = new System.Drawing.Point(35, 281);
            nationalityLabel.Name = "nationalityLabel";
            nationalityLabel.Size = new System.Drawing.Size(124, 25);
            nationalityLabel.TabIndex = 6;
            nationalityLabel.Text = "Nationality";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(35, 353);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 25);
            label1.TabIndex = 8;
            label1.Text = "City";
            // 
            // background_panel1
            // 
            this.background_panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.background_panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.background_panel1.Controls.Add(this.title_label1);
            this.background_panel1.Controls.Add(this.user_name_label1);
            this.background_panel1.Controls.Add(this.user_img_pictureBox1);
            this.background_panel1.Location = new System.Drawing.Point(2, 2);
            this.background_panel1.Name = "background_panel1";
            this.background_panel1.Size = new System.Drawing.Size(925, 241);
            this.background_panel1.TabIndex = 3;
            // 
            // title_label1
            // 
            this.title_label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crmtableBindingSource, "title", true));
            this.title_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label1.ForeColor = System.Drawing.Color.White;
            this.title_label1.Location = new System.Drawing.Point(215, 144);
            this.title_label1.Name = "title_label1";
            this.title_label1.Size = new System.Drawing.Size(256, 38);
            this.title_label1.TabIndex = 2;
            this.title_label1.Text = "-";
            this.title_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // crmtableBindingSource
            // 
            this.crmtableBindingSource.DataMember = "crm_table";
            this.crmtableBindingSource.DataSource = this.user_db;
            // 
            // user_db
            // 
            this.user_db.DataSetName = "user_db";
            this.user_db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_name_label1
            // 
            this.user_name_label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crmtableBindingSource, "user_name", true));
            this.user_name_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name_label1.ForeColor = System.Drawing.Color.White;
            this.user_name_label1.Location = new System.Drawing.Point(213, 83);
            this.user_name_label1.Name = "user_name_label1";
            this.user_name_label1.Size = new System.Drawing.Size(339, 38);
            this.user_name_label1.TabIndex = 1;
            this.user_name_label1.Text = "-";
            this.user_name_label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // user_img_pictureBox1
            // 
            this.user_img_pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.user_img_pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.user_img_pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_img_pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.crmtableBindingSource, "user_image", true));
            this.user_img_pictureBox1.Location = new System.Drawing.Point(37, 54);
            this.user_img_pictureBox1.Name = "user_img_pictureBox1";
            this.user_img_pictureBox1.Size = new System.Drawing.Size(150, 128);
            this.user_img_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_img_pictureBox1.TabIndex = 0;
            this.user_img_pictureBox1.TabStop = false;
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
            // id_label1
            // 
            this.id_label1.AutoSize = true;
            this.id_label1.Location = new System.Drawing.Point(1088, 173);
            this.id_label1.Name = "id_label1";
            this.id_label1.Size = new System.Drawing.Size(35, 13);
            this.id_label1.TabIndex = 4;
            this.id_label1.Text = "label1";
            // 
            // delete_button1
            // 
            this.delete_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button1.Image = global::crm_system.Properties.Resources.delete_icon;
            this.delete_button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delete_button1.Location = new System.Drawing.Point(127, 559);
            this.delete_button1.Name = "delete_button1";
            this.delete_button1.Size = new System.Drawing.Size(119, 101);
            this.delete_button1.TabIndex = 6;
            this.delete_button1.Text = "Delete";
            this.delete_button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.delete_button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.delete_button1.UseVisualStyleBackColor = true;
            this.delete_button1.Click += new System.EventHandler(this.delete_button1_Click);
            // 
            // edit_user_button1
            // 
            this.edit_user_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.edit_user_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_user_button1.Image = global::crm_system.Properties.Resources.Edit_Icon;
            this.edit_user_button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.edit_user_button1.Location = new System.Drawing.Point(2, 559);
            this.edit_user_button1.Name = "edit_user_button1";
            this.edit_user_button1.Size = new System.Drawing.Size(119, 101);
            this.edit_user_button1.TabIndex = 5;
            this.edit_user_button1.Text = "Edit";
            this.edit_user_button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.edit_user_button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.edit_user_button1.UseVisualStyleBackColor = true;
            this.edit_user_button1.Click += new System.EventHandler(this.edit_user_button1_Click);
            // 
            // nationalityLabel1
            // 
            this.nationalityLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crmtableBindingSource, "nationality", true));
            this.nationalityLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationalityLabel1.Location = new System.Drawing.Point(37, 315);
            this.nationalityLabel1.Name = "nationalityLabel1";
            this.nationalityLabel1.Size = new System.Drawing.Size(100, 23);
            this.nationalityLabel1.TabIndex = 7;
            this.nationalityLabel1.Text = "label1";
            this.nationalityLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cityLabel1
            // 
            this.cityLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crmtableBindingSource, "city", true));
            this.cityLabel1.Location = new System.Drawing.Point(37, 390);
            this.cityLabel1.Name = "cityLabel1";
            this.cityLabel1.Size = new System.Drawing.Size(100, 23);
            this.cityLabel1.TabIndex = 9;
            this.cityLabel1.Text = "label2";
            // 
            // contact_label2
            // 
            this.contact_label2.AutoSize = true;
            this.contact_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_label2.Location = new System.Drawing.Point(28, 430);
            this.contact_label2.Name = "contact_label2";
            this.contact_label2.Size = new System.Drawing.Size(93, 25);
            this.contact_label2.TabIndex = 10;
            this.contact_label2.Text = "Contact";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(30, 464);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 13);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "E-Mail:";
            // 
            // emailLabel1
            // 
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crmtableBindingSource, "Email", true));
            this.emailLabel1.Location = new System.Drawing.Point(79, 464);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(262, 23);
            this.emailLabel1.TabIndex = 11;
            this.emailLabel1.Text = "label2";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(30, 487);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(47, 13);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "Phone:";
            // 
            // phoneLabel1
            // 
            this.phoneLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crmtableBindingSource, "phone", true));
            this.phoneLabel1.Location = new System.Drawing.Point(79, 487);
            this.phoneLabel1.Name = "phoneLabel1";
            this.phoneLabel1.Size = new System.Drawing.Size(286, 23);
            this.phoneLabel1.TabIndex = 12;
            this.phoneLabel1.Text = "label2";
            // 
            // view_user_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 680);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneLabel1);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailLabel1);
            this.Controls.Add(this.contact_label2);
            this.Controls.Add(this.cityLabel1);
            this.Controls.Add(label1);
            this.Controls.Add(nationalityLabel);
            this.Controls.Add(this.nationalityLabel1);
            this.Controls.Add(this.delete_button1);
            this.Controls.Add(this.edit_user_button1);
            this.Controls.Add(this.background_panel1);
            this.Controls.Add(this.id_label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "view_user_form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View User";
            this.Load += new System.EventHandler(this.view_user_form_Load);
            this.background_panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crmtableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_db)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_img_pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel background_panel1;
        private DS.user_ds user_db;
        private System.Windows.Forms.BindingSource crmtableBindingSource;
        private DS.user_dsTableAdapters.crm_tableTableAdapter crm_tableTableAdapter;
        public System.Windows.Forms.Label title_label1;
        public System.Windows.Forms.Label user_name_label1;
        public System.Windows.Forms.PictureBox user_img_pictureBox1;
        private DS.user_dsTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.Label id_label1;
        private System.Windows.Forms.Button edit_user_button1;
        private System.Windows.Forms.Button delete_button1;
        private System.Windows.Forms.Label nationalityLabel1;
        private System.Windows.Forms.Label cityLabel1;
        private System.Windows.Forms.Label contact_label2;
        private System.Windows.Forms.Label emailLabel1;
        private System.Windows.Forms.Label phoneLabel1;
    }
}