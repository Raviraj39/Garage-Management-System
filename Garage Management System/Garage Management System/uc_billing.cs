using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Garage_Management_System
{
    public partial class uc_billing : UserControl
    {
        Connection conn = new Connection();

        double totalprice;

        public uc_billing()
        {
            InitializeComponent();
        }

        public static string GetUniqueKey(int maxSize) 
        {
            char[] chars = new char[62];

            chars = "1234567890".ToCharArray();

            byte[] data = new byte[1];

            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();

            crypto.GetNonZeroBytes(data);

            data = new byte[maxSize];

            crypto.GetNonZeroBytes(data);

            StringBuilder result = new StringBuilder(maxSize);

            foreach (byte b in data) 
            {
                result.Append(chars[b % (chars.Length)]);
            }

            return result.ToString();
        }

        public void autobillno() 
        {
            txt_billno.Text = "" + GetUniqueKey(6);
        }

        private void uc_billing_Load(object sender, EventArgs e)
        {
            autobillno(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_billno.Text == "")
                {
                    MessageBox.Show("Please, Enter Bill No.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_billno.Focus();
                }
                else if (txt_grand_total.Text == "")
                {
                    MessageBox.Show("Please, Enter Grand Total.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_grand_total.Focus();
                }
                else
                {
                    SqlConnection con = new SqlConnection(conn.db);

                    con.Open();

                    String str = "Insert Into db_bill (billno,grandtotal) Values ('" + txt_billno.Text + "','" + txt_grand_total.Text + "')";

                    SqlCommand cmd = new SqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    String str1 = "Select max(billno) From db_bill";

                    SqlCommand cmd2 = new SqlCommand(str1, con);

                    SqlDataReader da = cmd2.ExecuteReader();

                    if (da.Read())
                    {
                        MessageBox.Show("Bill Saved Successfull...!", "Thank You...!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                        billcalculation();
                        autobillno();
                        showdata();
                        clearall();
                    }
                    else
                    {
                        MessageBox.Show(" Unsuccessfully ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            billcalculation();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_billno.Text == "")
                {
                    MessageBox.Show("Please, Enter Bill No.","Try Again",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txt_billno.Focus();
                }
                else if (txt_partname.Text == "")
                {
                    MessageBox.Show("Please, Enter Part Name.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partname.Focus();
                }
                else if (txt_partprice.Text == "")
                {
                    MessageBox.Show("Please, Enter Part Price.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partprice.Focus();
                }
                else if (txt_partquantity.Text == "")
                {
                    MessageBox.Show("Please, Enter Part Quantity.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_partquantity.Focus();
                }
                else if (txt_totalprice.Text == "")
                {
                    MessageBox.Show("Please, Enter Total Price.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_totalprice.Focus();
                }
                else
                {
                    SqlConnection con = new SqlConnection(conn.db);

                    con.Open();

                    String str = "Insert Into db_billcard (billno,partname,partprice,partqty,totalprice) Values ('" + txt_billno.Text + "','" + txt_partname.Text + "','" + txt_partprice.Text + "','" + txt_partquantity.Text + "','" + txt_totalprice.Text + "')";

                    SqlCommand cmd = new SqlCommand(str, con);

                    cmd.ExecuteNonQuery();

                    String str1 = "Select max(billno) From db_billcard";

                    SqlCommand cmd2 = new SqlCommand(str1, con);

                    SqlDataReader da = cmd2.ExecuteReader();

                    if (da.Read())
                    {
                        clear();
                        showdata();
                        billcalculation();
                    }
                    else
                    {
                        MessageBox.Show(" Unsuccessfully ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
          
                }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void billcalculation()
        {
            int A = 0, B = 0;

            for (A = 0; A < db_billcardDataGridView.Rows.Count; ++A) 
            {
                B += Convert.ToInt32(db_billcardDataGridView.Rows[A].Cells[4].Value);
            }

            txt_grand_total.Text = B.ToString();
        }

        private void showdata()
        {
            try
            {
                SqlConnection con = new SqlConnection(conn.db);

                con.Open();

                String str = "Select * From db_billcard Where billno = '" + txt_billno.Text + "'";

                SqlCommand cmd = new SqlCommand(str, con);

                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                db_billcardDataGridView.DataSource = dt;

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear()
        {
            txt_partname.Clear();
            txt_partprice.Clear();
            txt_partquantity.Clear();
            txt_totalprice.Clear();
            txt_partname.Focus();
        }


        private void clearall()
        {
            txt_partname.Clear();
            txt_partprice.Clear();
            txt_partquantity.Clear();
            txt_totalprice.Clear();
            txt_grand_total.Clear();
            txt_partname.Focus();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                
            SqlConnection con = new SqlConnection(conn.db);

            con.Open();

            String str = "Delete From db_billcard Where billno = '" + txt_billno.Text + "'";

            SqlCommand cmd = new SqlCommand(str, con);

            cmd.ExecuteNonQuery();

            String str1 = "Select max(billno) From db_billcard";

            SqlCommand cmd2 = new SqlCommand(str1, con);

            SqlDataReader da = cmd2.ExecuteReader();

            if (da.Read())
            {
                clear();
                showdata();
                billcalculation();
            }
            else
            {
                MessageBox.Show(" Unsuccessfully ...!", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void db_billcardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_billcardBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_billcard);

        }

        private void txt_partquantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_partquantity.Text == "") 
                {
                    txt_totalprice.Clear();
                }
                else if (txt_partname.Text == "")
                {
                    MessageBox.Show("Please, Enter Part Name.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_partname.Focus();
                }
                else 
                {                   

                    totalprice = double.Parse(txt_partprice.Text) * double.Parse(txt_partquantity.Text);

                    txt_totalprice.Text = totalprice.ToString();
                    
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void db_billcardDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_partname_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (txt_partname.Text == "")
                {
                    txt_partprice.Clear();
                    txt_partquantity.Clear();
                }
                else 
                {
                    SqlConnection con = new SqlConnection(conn.db);

                    con.Open();

                    String str = "Select partprice from db_stock Where partname = '" + txt_partname.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read()) 
                    {
                        txt_partprice.Text = dr.GetValue(0).ToString();

                    }
                    con.Close();
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
