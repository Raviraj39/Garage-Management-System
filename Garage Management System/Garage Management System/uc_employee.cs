using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Garage_Management_System
{
    public partial class uc_employee : UserControl
    {
        Connection conn = new Connection();

        public uc_employee()
        {
            InitializeComponent();
        }

        private void uc_employee_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {

            try
            {
                if (txt_ename.Text == "")
                {
                    MessageBox.Show("Please, Enter Employee Name.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ename.Focus();
                }
                else if (txt_eeducation.Text == "")
                {
                    MessageBox.Show("Please, Enter Employee Education Name.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_eeducation.Focus();
                }
                else if (txt_address.Text == "")
                {
                    MessageBox.Show("Please, Enter Employee Address.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_address.Focus();
                }
                else if (cmb_gender.Text == "")
                {
                    MessageBox.Show("Please, Select Employee Gender", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_gender.Focus();
                }
                else
                {
                    SqlConnection con = new SqlConnection(conn.db);

                    con.Open();

                    String str = "Insert Into db_employee (ename,eeducation,eaddress,egender) Values ('" + txt_ename.Text + "','" + txt_eeducation.Text + "','" + txt_address.Text + "','" + cmb_gender.Text + "')";

                    SqlCommand cmd = new SqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    String str1 = "Select max(ename) From db_employee";

                    SqlCommand cmd2 = new SqlCommand(str1, con);

                    SqlDataReader da = cmd2.ExecuteReader();

                    if (da.Read())
                    {
                        MessageBox.Show("Employee Information Inserted Successfully ...!", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        showdata();
                    }
                    else
                    {
                        MessageBox.Show("Employee Information Inserted Unsuccessfully ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showdata()
        {
            try
            {
                SqlConnection con = new SqlConnection(conn.db);

                con.Open();

                String str = "Select * From db_employee";

                SqlCommand cmd = new SqlCommand(str, con);

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                db_employeeDataGridView.DataSource = dt;

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void clear()
        {
            txt_ename.Clear();
            txt_eeducation.Clear();
            txt_address.Clear();
            cmb_gender.Text = "";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_ename.Text == "")
                {
                    MessageBox.Show("Please, Enter Employee Name.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ename.Focus();
                }
                else if (txt_eeducation.Text == "")
                {
                    MessageBox.Show("Please, Enter Employee Education Name.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_eeducation.Focus();
                }
                else if (txt_address.Text == "")
                {
                    MessageBox.Show("Please, Enter Employee Address.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_address.Focus();
                }
                else if (cmb_gender.Text == "")
                {
                    MessageBox.Show("Please, Select Employee Gender", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmb_gender.Focus();
                }
                else
                {
                    SqlConnection con = new SqlConnection(conn.db);

                    con.Open();

                    String str = "Update db_employee Set eeducation = '" + txt_eeducation.Text + "' ,eaddress = '" + txt_address.Text + "',egender = '" + cmb_gender.Text + "' Where ename = '" + txt_ename.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    String str1 = "Select max(ename) From db_employee";

                    SqlCommand cmd2 = new SqlCommand(str1, con);

                    SqlDataReader da = cmd2.ExecuteReader();

                    if (da.Read())
                    {
                        MessageBox.Show("Employee Information Updated Successfully ...!", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        showdata();
                    }
                    else
                    {
                        MessageBox.Show("Employee Information Updated Unsuccessfully ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            try
            {
                   SqlConnection con = new SqlConnection(conn.db);

                    con.Open();

                    String str = "Delete From db_employee Where ename = '" + txt_ename.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    String str1 = "Select max(ename) From db_employee";

                    SqlCommand cmd2 = new SqlCommand(str1, con);

                    SqlDataReader da = cmd2.ExecuteReader();

                    if (da.Read())
                    {
                        MessageBox.Show("Employee Information Deleted Successfully ...!", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        showdata();
                    }
                    else
                    {
                        MessageBox.Show("Employee Information Deleted Unsuccessfully ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
         
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void db_employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_employee);

        }

        private void db_employeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;

            index = e.RowIndex;

            DataGridViewRow dgvr = db_employeeDataGridView.Rows[index];

            txt_ename.Text = dgvr.Cells[0].Value.ToString();
            txt_eeducation.Text = dgvr.Cells[1].Value.ToString();
            txt_address.Text = dgvr.Cells[2].Value.ToString();
            cmb_gender.Text = dgvr.Cells[3].Value.ToString();
        }
    }
}
