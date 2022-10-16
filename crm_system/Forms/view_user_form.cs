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
    public partial class view_user_form : Form
    {
        public view_user_form()
        {
            InitializeComponent();
        }

    

        private void view_user_form_Load(object sender, EventArgs e)
        {
            Int64 id;
            Int64.TryParse(id_label1.Text, out id);
            this.crm_tableTableAdapter.FillBy_ID(user_db.crm_table, id);
            checkAdminRights();
        }

        private void edit_user_button1_Click(object sender, EventArgs e)
        {
            delete_edit_record("Edit Record",true);
           
        }

        private void delete_button1_Click(object sender, EventArgs e)
        {
            delete_edit_record("Delete Record",false);
           
        }

        void delete_edit_record(string text, bool visible)
        {
            new_user_form nuf = new new_user_form();
            nuf.info_panel1.Enabled = visible;
            nuf.id_label1.Text = id_label1.Text;
            nuf.status_label1.Text = text;
            nuf.password_panel1.Visible = false;
            nuf.ShowDialog();

            if (nuf.DialogResult == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        void checkAdminRights()
        {
            string title = crm_system.Properties.Settings.Default.user_title;
            if (title != "CEO")
            {
                edit_user_button1.Visible = false;
                delete_button1.Visible = false;
            }
            else
            {

                edit_user_button1.Visible = true;
                delete_button1.Visible = true; ;
            }
        }
    }
}
