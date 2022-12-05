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
    public partial class uc_analytics : UserControl
    {
        Connection conn = new Connection();

        public uc_analytics()
        {
            InitializeComponent();
        }

        private void uc_analytics_Load(object sender, EventArgs e)
        {

            totalfinance();
            finance();
            totalcars();
            totalspare();
            totalemployee();
           
        }

        private void totalfinance()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\RAVI RAJ\Pictures\Garage Management System\Garage Management System\GMS.mdf;Integrated Security=True");

            con.Open();

            String str = "Select * From db_bill";

            SqlCommand cmd = new SqlCommand(str, con);

            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            db_billDataGridView.DataSource = dt;

            con.Close();

        }

        private void finance()
        {
            totalfinance();

            int A = 0, B = 0;

            for (A = 0; A < db_billDataGridView.Rows.Count; ++A)
            {
                B += Convert.ToInt32(db_billDataGridView.Rows[A].Cells[5].Value);
            }

            lbl_frinance.Text = B.ToString();
        }

        private void totalemployee()
        {
            SqlConnection con = new SqlConnection(conn.db);

            con.Open();

            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "Select Count (ename) From db_employee";

            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();

            lbl_employee.Text = rows_count.ToString();
            
        }

        private void totalspare()
        {
            SqlConnection con = new SqlConnection(conn.db);

            con.Open();

            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "Select Count (partname) From db_stock";

            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();

            lbl_spare.Text = rows_count.ToString(); 
        }

        private void totalcars()
        {
            SqlConnection con = new SqlConnection(conn.db);

            con.Open();

            SqlCommand cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "Select Count (carno) From db_cars";

            Int32 rows_count = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();

            lbl_cars.Text = rows_count.ToString();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            totalfinance();
            finance();
            totalcars();
            totalspare();
            totalemployee();
        }

        private void db_billBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.db_billBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_finance);

        }
    }
}
