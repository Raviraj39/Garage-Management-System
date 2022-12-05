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
    public partial class uc_stock : UserControl
    {
        Connection conn = new Connection();

        public uc_stock()
        {
            InitializeComponent();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {

            try
            {
                if ( txt_paetname.Text == "")
                {
                    MessageBox.Show("Please, Enter Part Name.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_paetname.Focus();
                }
                else if (txt_partqty.Text == "")
                {
                    MessageBox.Show("Please, Enter Part Quantity.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partqty.Focus();
                }
                else if (txt_partprice.Text == "")
                {
                    MessageBox.Show("Please, Enter Part Price", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partprice.Focus();
                }                
                else
                {
                    SqlConnection con = new SqlConnection(conn.db);

                    con.Open();

                    String str = "Insert Into db_stock (partname,partqut,partprice) Values ('" + txt_paetname.Text + "','" + txt_partqty.Text + "','" + txt_partprice.Text + "')";

                    SqlCommand cmd = new SqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    String str1 = "Select max(partname) From db_stock";

                    SqlCommand cmd2 = new SqlCommand(str1, con);

                    SqlDataReader da = cmd2.ExecuteReader();

                    if (da.Read())
                    {
                        MessageBox.Show("Stock Information Inserted Successfully ...!", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        showdata();
                    }
                    else
                    {
                        MessageBox.Show("Stock Information Inserted Unsuccessfully ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                String str = "Select * From db_stock";

                SqlCommand cmd = new SqlCommand(str, con);

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                db_stockDataGridView.DataSource = dt;

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void clear()
        {
            txt_paetname.Clear();
            txt_partprice.Clear();
            txt_partqty.Clear();
        }

        private void db_stockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_stockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ds_stock);

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_paetname.Text == "")
                {
                    MessageBox.Show("Please, Enter Part Name.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_paetname.Focus();
                }
                else if (txt_partqty.Text == "")
                {
                    MessageBox.Show("Please, Enter Part Quantity.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partqty.Focus();
                }
                else if (txt_partprice.Text == "")
                {
                    MessageBox.Show("Please, Enter Part Price", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partprice.Focus();
                }
                else
                {
                    SqlConnection con = new SqlConnection(conn.db);

                    con.Open();

                    String str = "Update db_stock Set partqut = '" + txt_partqty.Text + "',partprice = '" + txt_partprice.Text + "' Where partname = '" + txt_paetname.Text + "' ";

                    SqlCommand cmd = new SqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    String str1 = "Select max(partname) From db_stock";

                    SqlCommand cmd2 = new SqlCommand(str1, con);

                    SqlDataReader da = cmd2.ExecuteReader();

                    if (da.Read())
                    {
                        MessageBox.Show("Stock Information Updated Successfully ...!", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        showdata();
                    }
                    else
                    {
                        MessageBox.Show("Stock Information Updated Unsuccessfully ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                String str = "Delete From db_stock Where partname = '" + txt_paetname.Text + "' ";

                SqlCommand cmd = new SqlCommand(str, con);

                cmd.ExecuteNonQuery();

                String str1 = "Select max(partname) From db_stock";

                SqlCommand cmd2 = new SqlCommand(str1, con);

                SqlDataReader da = cmd2.ExecuteReader();

                if (da.Read())
                {
                    MessageBox.Show("Stock Information Deleted Successfully ...!", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    showdata();
                }
                else
                {
                    MessageBox.Show("Stock Information Deleted Unsuccessfully ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void db_stockDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;

            index = e.RowIndex;

            DataGridViewRow dgvr = db_stockDataGridView.Rows[index];

            txt_paetname.Text = dgvr.Cells[0].Value.ToString();
            txt_partqty.Text = dgvr.Cells[1].Value.ToString();
            txt_partprice.Text = dgvr.Cells[2].Value.ToString();
        }

        private void uc_stock_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 d2 = new Form1();
            d2.Show();
        }
    }
}
