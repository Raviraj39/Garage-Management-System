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
    public partial class uc_cars : UserControl
    {
        Connection conn = new Connection();

        public uc_cars()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_carno.Text == "")
                {
                    MessageBox.Show("Please, Enter Car No.","Try Again",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txt_carno.Focus();
                }
                else if (txt_carbrand.Text == "")
                {
                    MessageBox.Show("Please, Enter Car Brand.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carbrand.Focus();
                }
                else if (txt_carmodel.Text == "")
                {
                    MessageBox.Show("Please, Enter Car Model.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carmodel.Focus();
                }
                else if (txt_carcolor.Text == "")
                {
                    MessageBox.Show("Please, Enter Car Color.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carcolor.Focus();
                }
                else if (txt_ownername.Text == "")
                {
                    MessageBox.Show("Please, Enter Car Owner Name.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ownername.Focus();
                }
                else 
                {

                    SqlConnection con = new SqlConnection(conn.db);

                    con.Open();

                    String str = "Insert Into db_cars (carno,carbrand,carmodel,date,carcolor,ownername) Values ('" + txt_carno.Text + "','" + txt_carbrand.Text + "','" + txt_carmodel.Text + "','" + dtp_date.Text + "','" + txt_carcolor.Text + "','" + txt_ownername.Text + "')";

                    SqlCommand cmd = new SqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    String str1 = "Select max(carno) From db_cars";

                    SqlCommand cmd2 = new SqlCommand(str1, con);

                    SqlDataReader da = cmd2.ExecuteReader();

                    if (da.Read())
                    {
                        MessageBox.Show("Car Information Inserted Successfully ...!","Thank You",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        clear();
                        showdata();
                    }
                    else 
                    {
                        MessageBox.Show("Car Information Inserted Unsuccessfully ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void clear() 
        {
            txt_ownername.Clear();
            txt_carno.Clear();
            txt_carmodel.Clear();
            txt_carcolor.Clear();
            txt_carbrand.Clear();
            dtp_date.Text = "";
        }

        private void uc_cars_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void showdata()
        {
            try
            {
                SqlConnection con = new SqlConnection(conn.db);

                con.Open();

                String str = "Select * From db_cars";

                SqlCommand cmd = new SqlCommand(str, con);

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                db_carsDataGridView.DataSource = dt;

                con.Close();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_carno.Text == "")
                {
                    MessageBox.Show("Please, Enter Car No.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carno.Focus();
                }
                else if (txt_carbrand.Text == "")
                {
                    MessageBox.Show("Please, Enter Car Brand.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carbrand.Focus();
                }
                else if (txt_carmodel.Text == "")
                {
                    MessageBox.Show("Please, Enter Car Model.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carmodel.Focus();
                }
                else if (txt_carcolor.Text == "")
                {
                    MessageBox.Show("Please, Enter Car Color.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_carcolor.Focus();
                }
                else if (txt_ownername.Text == "")
                {
                    MessageBox.Show("Please, Enter Car Owner Name.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ownername.Focus();
                }
                else
                {

                    SqlConnection con = new SqlConnection(conn.db);

                    con.Open();

                    String str = "Update db_cars Set carbrand = '" + txt_carbrand.Text + "', carmodel = '" + txt_carmodel.Text + "', date = '" + dtp_date.Text + "', carcolor = '" + txt_carcolor.Text + "',ownername = '" + txt_ownername.Text + "' Where carno = '" + txt_carno.Text + "' ";

                    SqlCommand cmd = new SqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    String str1 = "Select max(carno) From db_cars";

                    SqlCommand cmd2 = new SqlCommand(str1, con);

                    SqlDataReader da = cmd2.ExecuteReader();

                    if (da.Read())
                    {
                        MessageBox.Show("Car Information Updated Successfully ...!", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        showdata();
                    }
                    else
                    {
                        MessageBox.Show("Car Information Updated Unsuccessfully ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                String str = "Delete From db_cars Where carno = '" + txt_carno.Text + "' ";

                SqlCommand cmd = new SqlCommand(str, con);

                cmd.ExecuteNonQuery();

                String str1 = "Select max(carno) From db_cars";

                SqlCommand cmd2 = new SqlCommand(str1, con);

                SqlDataReader da = cmd2.ExecuteReader();

                if (da.Read())
                {
                    MessageBox.Show("Car Information Deleted Successfully ...!", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    showdata();
                }
                else
                {
                    MessageBox.Show("Car Information Deleted Unsuccessfully ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void db_carsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_carsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_cars);

        }

        private void db_carsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int index;

                index = e.RowIndex;

                DataGridViewRow dgvr = db_carsDataGridView.Rows[index];

                txt_carno.Text = dgvr.Cells[0].Value.ToString();
                txt_carbrand.Text = dgvr.Cells[1].Value.ToString();
                txt_carmodel.Text = dgvr.Cells[2].Value.ToString();
                dtp_date.Text = dgvr.Cells[3].Value.ToString();
                txt_carcolor.Text = dgvr.Cells[4].Value.ToString();
                txt_ownername.Text = dgvr.Cells[5].Value.ToString();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
