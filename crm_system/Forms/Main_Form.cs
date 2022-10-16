using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace crm_system.Forms
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void exit_button1_Click(object sender, EventArgs e)
        {
            crm_system.Properties.Settings.Default.user_name = "";
            crm_system.Properties.Settings.Default.user_title = "";
            crm_system.Properties.Settings.Default.Save();
          Application.Exit();
        }

        private void minimize_button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void users_button1_Click(object sender, EventArgs e){
            this.tabControl1.SelectedIndex = 0;
        }

      
        private void Main_Form_Load(object sender, EventArgs e)
        {
          
            // TODO: Diese Codezeile lädt Daten in die Tabelle "user_db.crm_table". Sie können sie bei Bedarf verschieben oder entfernen.
            this.crm_tableTableAdapter.Fill(this.user_db.crm_table);

            login_button1_Click(sender, e);
        
        }

        private void company_button1_Click(object sender, EventArgs e){
            this.tabControl1.SelectedIndex = 1;
        }

        private void login_button1_Click(object sender, EventArgs e)
        {
            crm_system.Forms.Login login = new Login();
        
            login.ShowDialog();

            if(login.DialogResult == DialogResult.OK)
            {
                user_img_pictureBox1.Image = login.user_imagePictureBox.Image;
                user_name_label1.Text = login.user_nameLabel1.Text;
                title_label1.Text = login.titleLabel1.Text;
                
            }
        }
      
        private void side_bar_panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void user_infopanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_new_button1_Click(object sender, EventArgs e){
           
                new_user_form nuf = new new_user_form();
                nuf.info_panel1.Enabled = true;
                nuf.id_label1.Text = iDLabel1.Text;
                nuf.status_label1.Text = "Add Record";
                nuf.password_panel1.Visible = true;
                nuf.ShowDialog();

                if (nuf.DialogResult == DialogResult.OK)
                {
                    this.crm_tableTableAdapter.Fill(this.user_db.crm_table);
                }

        }
        private void crm_tableDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            view_user_form vuf = new view_user_form();

            vuf.id_label1.Text = iDLabel1.Text;
            vuf.ShowDialog();

            if (vuf.DialogResult == DialogResult.OK)
            {
                this.crm_tableTableAdapter.Fill(this.user_db.crm_table);
            }
        }

        private void users_tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
