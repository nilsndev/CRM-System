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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void continue_button1_Click(object sender, EventArgs e)
        {
            if (!errorLogin())
            {
                crm_system.Properties.Settings.Default.user_name = user_name_textBox1.Text;
                crm_system.Properties.Settings.Default.user_title = titleLabel1.Text;
                crm_system.Properties.Settings.Default.Save();
                MessageBox.Show("Done!");
                DialogResult = DialogResult.OK;
                this.Close();
            }
          
        }

      

        private void user_name_textBox1_TextChanged(object sender, EventArgs e){
            
            crm_tableTableAdapter.FillBy_user_name(user_db.crm_table, this.user_name_textBox1.Text);
        }

        private void exit_button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool errorLogin()
        {

            if (this.user_name_textBox1.Text == "")
            {
                MessageBox.Show("Empty Username!");
                return true;
            }
            if (this.user_name_textBox1.Text != this.user_nameLabel1.Text)
            {
                MessageBox.Show("Wrong Username!");
                return true;
            }
            if (this.password_textBox1.Text != user_passLabel1.Text)
            {
                MessageBox.Show("Wrong Password!");
                return true;
            }
          
            return false;
        }
    }
}
