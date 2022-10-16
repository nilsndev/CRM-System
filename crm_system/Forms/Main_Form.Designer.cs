namespace crm_system.Forms
{
    partial class Main_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.side_bar_panel1 = new System.Windows.Forms.Panel();
            this.user_infopanel1 = new System.Windows.Forms.Panel();
            this.user_img_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title_label1 = new System.Windows.Forms.Label();
            this.user_name_label1 = new System.Windows.Forms.Label();
            this.login_button1 = new System.Windows.Forms.Button();
            this.image_comboBox1 = new System.Windows.Forms.ComboBox();
            this.company_button1 = new System.Windows.Forms.Button();
            this.users_button1 = new System.Windows.Forms.Button();
            this.header_panel1 = new System.Windows.Forms.Panel();
            this.minimize_button1 = new System.Windows.Forms.Button();
            this.exit_button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.users_tabPage1 = new System.Windows.Forms.TabPage();
            this.iDLabel1 = new System.Windows.Forms.Label();
            this.add_new_button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.companytabPage2 = new System.Windows.Forms.TabPage();
            this.crm_tableDataGridView = new System.Windows.Forms.DataGridView();
            this.crm_tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.city_label1 = new System.Windows.Forms.Label();
            this.city_name_label2 = new System.Windows.Forms.Label();
            this.contact_label2 = new System.Windows.Forms.Label();
            this.business_label1 = new System.Windows.Forms.Label();
            this.contact_name_label1 = new System.Windows.Forms.Label();
            this.bussiness__name_label1 = new System.Windows.Forms.Label();
            this.company_title_label1 = new System.Windows.Forms.Label();
            this.company_nationality_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.crm_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_db = new crm_system.DS.user_ds();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crm_tableTableAdapter = new crm_system.DS.user_dsTableAdapters.crm_tableTableAdapter();
            this.tableAdapterManager = new crm_system.DS.user_dsTableAdapters.TableAdapterManager();
            this.side_bar_panel1.SuspendLayout();
            this.user_infopanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_img_pictureBox1)).BeginInit();
            this.header_panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.users_tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.companytabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crm_tableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crm_tableBindingNavigator)).BeginInit();
            this.crm_tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.company_nationality_pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crm_tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_db)).BeginInit();
            this.SuspendLayout();
            // 
            // side_bar_panel1
            // 
            this.side_bar_panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.side_bar_panel1.Controls.Add(this.user_infopanel1);
            this.side_bar_panel1.Controls.Add(this.login_button1);
            this.side_bar_panel1.Controls.Add(this.image_comboBox1);
            this.side_bar_panel1.Controls.Add(this.company_button1);
            this.side_bar_panel1.Controls.Add(this.users_button1);
            this.side_bar_panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_bar_panel1.Location = new System.Drawing.Point(0, 0);
            this.side_bar_panel1.Name = "side_bar_panel1";
            this.side_bar_panel1.Size = new System.Drawing.Size(245, 1080);
            this.side_bar_panel1.TabIndex = 0;
            this.side_bar_panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.side_bar_panel1_Paint);
            // 
            // user_infopanel1
            // 
            this.user_infopanel1.Controls.Add(this.user_img_pictureBox1);
            this.user_infopanel1.Controls.Add(this.title_label1);
            this.user_infopanel1.Controls.Add(this.user_name_label1);
            this.user_infopanel1.Location = new System.Drawing.Point(-1, 11);
            this.user_infopanel1.Name = "user_infopanel1";
            this.user_infopanel1.Size = new System.Drawing.Size(245, 100);
            this.user_infopanel1.TabIndex = 7;
            this.user_infopanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.user_infopanel1_Paint);
            // 
            // user_img_pictureBox1
            // 
            this.user_img_pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_img_pictureBox1.Location = new System.Drawing.Point(27, 15);
            this.user_img_pictureBox1.Name = "user_img_pictureBox1";
            this.user_img_pictureBox1.Size = new System.Drawing.Size(71, 56);
            this.user_img_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_img_pictureBox1.TabIndex = 4;
            this.user_img_pictureBox1.TabStop = false;
            // 
            // title_label1
            // 
            this.title_label1.AutoSize = true;
            this.title_label1.Location = new System.Drawing.Point(114, 55);
            this.title_label1.Name = "title_label1";
            this.title_label1.Size = new System.Drawing.Size(10, 13);
            this.title_label1.TabIndex = 6;
            this.title_label1.Text = "-";
            // 
            // user_name_label1
            // 
            this.user_name_label1.AutoSize = true;
            this.user_name_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name_label1.Location = new System.Drawing.Point(114, 16);
            this.user_name_label1.Name = "user_name_label1";
            this.user_name_label1.Size = new System.Drawing.Size(12, 15);
            this.user_name_label1.TabIndex = 5;
            this.user_name_label1.Text = "-";
            // 
            // login_button1
            // 
            this.login_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login_button1.CausesValidation = false;
            this.login_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button1.Image = global::crm_system.Properties.Resources.login_icon;
            this.login_button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login_button1.Location = new System.Drawing.Point(29, 121);
            this.login_button1.Name = "login_button1";
            this.login_button1.Size = new System.Drawing.Size(186, 75);
            this.login_button1.TabIndex = 3;
            this.login_button1.Text = "Login";
            this.login_button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.login_button1.UseVisualStyleBackColor = true;
            this.login_button1.Click += new System.EventHandler(this.login_button1_Click);
            // 
            // image_comboBox1
            // 
            this.image_comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.image_comboBox1.FormattingEnabled = true;
            this.image_comboBox1.Location = new System.Drawing.Point(56, 1046);
            this.image_comboBox1.Name = "image_comboBox1";
            this.image_comboBox1.Size = new System.Drawing.Size(121, 21);
            this.image_comboBox1.TabIndex = 2;
            // 
            // company_button1
            // 
            this.company_button1.BackgroundImage = global::crm_system.Properties.Resources.company_icon;
            this.company_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.company_button1.CausesValidation = false;
            this.company_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.company_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.company_button1.Location = new System.Drawing.Point(29, 307);
            this.company_button1.Name = "company_button1";
            this.company_button1.Size = new System.Drawing.Size(186, 75);
            this.company_button1.TabIndex = 1;
            this.company_button1.Text = "Company";
            this.company_button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.company_button1.UseVisualStyleBackColor = true;
            this.company_button1.Click += new System.EventHandler(this.company_button1_Click);
            // 
            // users_button1
            // 
            this.users_button1.BackgroundImage = global::crm_system.Properties.Resources.user_icon;
            this.users_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.users_button1.CausesValidation = false;
            this.users_button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.users_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.users_button1.Location = new System.Drawing.Point(29, 210);
            this.users_button1.Name = "users_button1";
            this.users_button1.Size = new System.Drawing.Size(186, 75);
            this.users_button1.TabIndex = 0;
            this.users_button1.Text = "Users";
            this.users_button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.users_button1.UseVisualStyleBackColor = true;
            this.users_button1.Click += new System.EventHandler(this.users_button1_Click);
            // 
            // header_panel1
            // 
            this.header_panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.header_panel1.Controls.Add(this.minimize_button1);
            this.header_panel1.Controls.Add(this.exit_button1);
            this.header_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel1.ForeColor = System.Drawing.Color.White;
            this.header_panel1.Location = new System.Drawing.Point(245, 0);
            this.header_panel1.Name = "header_panel1";
            this.header_panel1.Size = new System.Drawing.Size(1675, 91);
            this.header_panel1.TabIndex = 1;
            // 
            // minimize_button1
            // 
            this.minimize_button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_button1.BackColor = System.Drawing.Color.White;
            this.minimize_button1.BackgroundImage = global::crm_system.Properties.Resources.minimize_icon;
            this.minimize_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimize_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_button1.ForeColor = System.Drawing.Color.Black;
            this.minimize_button1.Location = new System.Drawing.Point(1535, 28);
            this.minimize_button1.Name = "minimize_button1";
            this.minimize_button1.Size = new System.Drawing.Size(51, 40);
            this.minimize_button1.TabIndex = 2;
            this.minimize_button1.UseVisualStyleBackColor = false;
            this.minimize_button1.Click += new System.EventHandler(this.minimize_button1_Click);
            // 
            // exit_button1
            // 
            this.exit_button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_button1.BackColor = System.Drawing.Color.White;
            this.exit_button1.BackgroundImage = global::crm_system.Properties.Resources.exit_icon;
            this.exit_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button1.ForeColor = System.Drawing.Color.Black;
            this.exit_button1.Location = new System.Drawing.Point(1603, 28);
            this.exit_button1.Name = "exit_button1";
            this.exit_button1.Size = new System.Drawing.Size(51, 40);
            this.exit_button1.TabIndex = 0;
            this.exit_button1.UseVisualStyleBackColor = false;
            this.exit_button1.Click += new System.EventHandler(this.exit_button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.users_tabPage1);
            this.tabControl1.Controls.Add(this.companytabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(245, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1675, 989);
            this.tabControl1.TabIndex = 3;
            // 
            // users_tabPage1
            // 
            this.users_tabPage1.Controls.Add(this.iDLabel1);
            this.users_tabPage1.Controls.Add(this.add_new_button1);
            this.users_tabPage1.Controls.Add(this.dataGridView1);
            this.users_tabPage1.Location = new System.Drawing.Point(4, 4);
            this.users_tabPage1.Name = "users_tabPage1";
            this.users_tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.users_tabPage1.Size = new System.Drawing.Size(1667, 963);
            this.users_tabPage1.TabIndex = 0;
            this.users_tabPage1.Text = "Users";
            this.users_tabPage1.UseVisualStyleBackColor = true;
            this.users_tabPage1.Click += new System.EventHandler(this.users_tabPage1_Click);
            // 
            // iDLabel1
            // 
            this.iDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.crm_tableBindingSource, "ID", true));
            this.iDLabel1.Location = new System.Drawing.Point(1063, 748);
            this.iDLabel1.Name = "iDLabel1";
            this.iDLabel1.Size = new System.Drawing.Size(100, 23);
            this.iDLabel1.TabIndex = 7;
            this.iDLabel1.Text = "label1";
            // 
            // add_new_button1
            // 
            this.add_new_button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add_new_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_new_button1.Image = global::crm_system.Properties.Resources.add_icon__2_;
            this.add_new_button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.add_new_button1.Location = new System.Drawing.Point(1307, 703);
            this.add_new_button1.Name = "add_new_button1";
            this.add_new_button1.Size = new System.Drawing.Size(119, 101);
            this.add_new_button1.TabIndex = 6;
            this.add_new_button1.Text = "Add New";
            this.add_new_button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add_new_button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.add_new_button1.UseVisualStyleBackColor = true;
            this.add_new_button1.Click += new System.EventHandler(this.add_new_button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.crm_tableBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Lime;
            this.dataGridView1.Location = new System.Drawing.Point(87, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1547, 474);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.crm_tableDataGridView_CellClick);
            // 
            // companytabPage2
            // 
            this.companytabPage2.Controls.Add(this.crm_tableDataGridView);
            this.companytabPage2.Controls.Add(this.crm_tableBindingNavigator);
            this.companytabPage2.Controls.Add(this.city_label1);
            this.companytabPage2.Controls.Add(this.city_name_label2);
            this.companytabPage2.Controls.Add(this.contact_label2);
            this.companytabPage2.Controls.Add(this.business_label1);
            this.companytabPage2.Controls.Add(this.contact_name_label1);
            this.companytabPage2.Controls.Add(this.bussiness__name_label1);
            this.companytabPage2.Controls.Add(this.company_title_label1);
            this.companytabPage2.Controls.Add(this.company_nationality_pictureBox1);
            this.companytabPage2.Location = new System.Drawing.Point(4, 4);
            this.companytabPage2.Name = "companytabPage2";
            this.companytabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.companytabPage2.Size = new System.Drawing.Size(1667, 963);
            this.companytabPage2.TabIndex = 1;
            this.companytabPage2.Text = "Company";
            this.companytabPage2.UseVisualStyleBackColor = true;
            // 
            // crm_tableDataGridView
            // 
            this.crm_tableDataGridView.AllowUserToAddRows = false;
            this.crm_tableDataGridView.AllowUserToDeleteRows = false;
            this.crm_tableDataGridView.AutoGenerateColumns = false;
            this.crm_tableDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.crm_tableDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.crm_tableDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.crm_tableDataGridView.ColumnHeadersHeight = 30;
            this.crm_tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.crm_tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.crm_tableDataGridView.DataSource = this.crm_tableBindingSource;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.crm_tableDataGridView.DefaultCellStyle = dataGridViewCellStyle13;
            this.crm_tableDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crm_tableDataGridView.Location = new System.Drawing.Point(3, 699);
            this.crm_tableDataGridView.Name = "crm_tableDataGridView";
            this.crm_tableDataGridView.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.crm_tableDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.crm_tableDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.crm_tableDataGridView.Size = new System.Drawing.Size(1661, 207);
            this.crm_tableDataGridView.TabIndex = 21;
            // 
            // crm_tableBindingNavigator
            // 
            this.crm_tableBindingNavigator.AddNewItem = null;
            this.crm_tableBindingNavigator.AutoSize = false;
            this.crm_tableBindingNavigator.BindingSource = this.crm_tableBindingSource;
            this.crm_tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.crm_tableBindingNavigator.DeleteItem = null;
            this.crm_tableBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crm_tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.crm_tableBindingNavigator.Location = new System.Drawing.Point(3, 906);
            this.crm_tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.crm_tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.crm_tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.crm_tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.crm_tableBindingNavigator.Name = "crm_tableBindingNavigator";
            this.crm_tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.crm_tableBindingNavigator.Size = new System.Drawing.Size(1661, 54);
            this.crm_tableBindingNavigator.TabIndex = 20;
            this.crm_tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 51);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 51);
            this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 51);
            this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 54);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 51);
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 51);
            this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // city_label1
            // 
            this.city_label1.AutoSize = true;
            this.city_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_label1.Location = new System.Drawing.Point(169, 173);
            this.city_label1.Name = "city_label1";
            this.city_label1.Size = new System.Drawing.Size(127, 18);
            this.city_label1.TabIndex = 18;
            this.city_label1.Text = "Ennetbürgen(NW)";
            // 
            // city_name_label2
            // 
            this.city_name_label2.AutoSize = true;
            this.city_name_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_name_label2.Location = new System.Drawing.Point(112, 173);
            this.city_name_label2.Name = "city_name_label2";
            this.city_name_label2.Size = new System.Drawing.Size(42, 18);
            this.city_name_label2.TabIndex = 17;
            this.city_name_label2.Text = "City:";
            // 
            // contact_label2
            // 
            this.contact_label2.AutoSize = true;
            this.contact_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_label2.Location = new System.Drawing.Point(169, 288);
            this.contact_label2.Name = "contact_label2";
            this.contact_label2.Size = new System.Drawing.Size(82, 18);
            this.contact_label2.TabIndex = 16;
            this.contact_label2.Text = "Nils Näpflin";
            // 
            // business_label1
            // 
            this.business_label1.AutoSize = true;
            this.business_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.business_label1.Location = new System.Drawing.Point(169, 230);
            this.business_label1.Name = "business_label1";
            this.business_label1.Size = new System.Drawing.Size(20, 18);
            this.business_label1.TabIndex = 15;
            this.business_label1.Text = "IT";
            // 
            // contact_name_label1
            // 
            this.contact_name_label1.AutoSize = true;
            this.contact_name_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_name_label1.Location = new System.Drawing.Point(82, 288);
            this.contact_name_label1.Name = "contact_name_label1";
            this.contact_name_label1.Size = new System.Drawing.Size(72, 18);
            this.contact_name_label1.TabIndex = 14;
            this.contact_name_label1.Text = "Contact:";
            // 
            // bussiness__name_label1
            // 
            this.bussiness__name_label1.AutoSize = true;
            this.bussiness__name_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bussiness__name_label1.Location = new System.Drawing.Point(63, 230);
            this.bussiness__name_label1.Name = "bussiness__name_label1";
            this.bussiness__name_label1.Size = new System.Drawing.Size(91, 18);
            this.bussiness__name_label1.TabIndex = 13;
            this.bussiness__name_label1.Text = "Bussiness:";
            // 
            // company_title_label1
            // 
            this.company_title_label1.AutoSize = true;
            this.company_title_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_title_label1.Location = new System.Drawing.Point(192, 59);
            this.company_title_label1.Name = "company_title_label1";
            this.company_title_label1.Size = new System.Drawing.Size(147, 37);
            this.company_title_label1.TabIndex = 12;
            this.company_title_label1.Text = "nilsNdev";
            // 
            // company_nationality_pictureBox1
            // 
            this.company_nationality_pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.company_nationality_pictureBox1.Image = global::crm_system.Properties.Resources.swiss_icon;
            this.company_nationality_pictureBox1.Location = new System.Drawing.Point(62, 26);
            this.company_nationality_pictureBox1.Name = "company_nationality_pictureBox1";
            this.company_nationality_pictureBox1.Size = new System.Drawing.Size(92, 102);
            this.company_nationality_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.company_nationality_pictureBox1.TabIndex = 11;
            this.company_nationality_pictureBox1.TabStop = false;
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "user_name";
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn1.HeaderText = "User Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 500;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 500;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "city";
            this.dataGridViewTextBoxColumn4.HeaderText = "City";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 500;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "user_name";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn2.HeaderText = "User Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Width = 500;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn9.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 500;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "city";
            this.dataGridViewTextBoxColumn10.HeaderText = "City";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 500;
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
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.header_panel1);
            this.Controls.Add(this.side_bar_panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRM System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.side_bar_panel1.ResumeLayout(false);
            this.user_infopanel1.ResumeLayout(false);
            this.user_infopanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_img_pictureBox1)).EndInit();
            this.header_panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.users_tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.companytabPage2.ResumeLayout(false);
            this.companytabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crm_tableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crm_tableBindingNavigator)).EndInit();
            this.crm_tableBindingNavigator.ResumeLayout(false);
            this.crm_tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.company_nationality_pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crm_tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_db)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel side_bar_panel1;
        private System.Windows.Forms.Button exit_button1;
        private System.Windows.Forms.Button users_button1;
        private System.Windows.Forms.Panel header_panel1;
        private System.Windows.Forms.Button minimize_button1;
        private System.Windows.Forms.Button company_button1;
        private DS.user_ds user_db;
        private System.Windows.Forms.BindingSource crm_tableBindingSource;
        private DS.user_dsTableAdapters.crm_tableTableAdapter crm_tableTableAdapter;
        private DS.user_dsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox image_comboBox1;
        private System.Windows.Forms.Button login_button1;
        public System.Windows.Forms.PictureBox user_img_pictureBox1;
        public System.Windows.Forms.Label user_name_label1;
        public System.Windows.Forms.Label title_label1;
        private System.Windows.Forms.Panel user_infopanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage users_tabPage1;
        private System.Windows.Forms.TabPage companytabPage2;
        private System.Windows.Forms.DataGridView crm_tableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingNavigator crm_tableBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label city_label1;
        private System.Windows.Forms.Label city_name_label2;
        private System.Windows.Forms.Label contact_label2;
        private System.Windows.Forms.Label business_label1;
        private System.Windows.Forms.Label contact_name_label1;
        private System.Windows.Forms.Label bussiness__name_label1;
        private System.Windows.Forms.Label company_title_label1;
        private System.Windows.Forms.PictureBox company_nationality_pictureBox1;
        private System.Windows.Forms.Button add_new_button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label iDLabel1;
    }
}