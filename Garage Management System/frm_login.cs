using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Garage_Management_System
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Username.Text == "admin" && txt_Password.Text == "admin")
                {
                    this.Hide();
                    frm_home fh = new frm_home();
                    fh.ShowDialog();
                }
                else 
                {
                    MessageBox.Show("Your Loggin Detail is Invalied ... !", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshowpassword.Checked)
            {
                txt_Password.UseSystemPasswordChar = true;
            }
            else 
            {
                txt_Password.UseSystemPasswordChar = false;
            }
        }
    }
}
