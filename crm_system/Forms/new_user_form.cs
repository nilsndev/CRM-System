using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using crm_system.DS;

namespace crm_system.Forms
{
    public partial class new_user_form : Form
    {
        public new_user_form()
        {
            InitializeComponent();
        }

        private void close_new_user_button1_Click(object sender, EventArgs e)
        {
            crm_tableBindingSource.CancelEdit();

            user_db.crm_table.RejectChanges();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void save_button1_Click(object sender, EventArgs e)
        {
            if (optionsCorrect())
            {
                if (user_pictureBox1.Image == null)
                {
                    user_pictureBox1.Image = crm_system.Properties.Resources.no_image;
                }
                updateUser();
            }
        }

        private void new_user_form_Load(object sender, EventArgs e){
            long id;
            Int64.TryParse(id_label1.Text, out id);
            this.crm_tableTableAdapter.FillBy_ID(user_db.crm_table,id);

            if (status_label1.Text == "Add Record")
                this.crm_tableBindingSource.AddNew();

            if (status_label1.Text == "Delete Record")
                this.crm_tableBindingSource.RemoveCurrent();
        }

        private void select_img_button1_Click(object sender, EventArgs e){
            try{
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName != "openFileDialog1"){
                    user_pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            
        }
        void updateUser(){
            crm_tableBindingSource.EndEdit();
            if (crm_tableTableAdapter.Update(user_db.crm_table) > 0){
                MessageBox.Show("Saved!");
            }
            else{
                MessageBox.Show("Nothing Saved!");
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        bool optionsCorrect()
        {
            if (info_panel1.Enabled)
            {
                if (user_nameTextBox.Text == "")
                {
                    MessageBox.Show("Empty Name");
                    return false;
                }
                if (password_panel1.Visible)
                {

                    if (repeat_pass_textBox1.Text != user_passTextBox.Text||user_passTextBox.Text == "")
                    {
                        MessageBox.Show("Wrong Password");
                        return false;
                    }
                   

                }
            }
                return true;
            
        }
      
    }
}
