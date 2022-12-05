using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace Garage_Management_System
{
    public partial class Form1 : Form
    {
        ReportDocument crypt = new ReportDocument();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\RAVI RAJ\Pictures\Garage Management System\Garage Management System\GMS.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sqlString = "select * from db_stock";
            SqlDataAdapter da = new SqlDataAdapter(sqlString, con);
            DataSet dataReport = new DataSet();
            da.Fill(dataReport, "db_stock");

            stockreport myDataReport = new stockreport();
            myDataReport.SetDataSource(dataReport);
            crystalReportViewer1.ReportSource = myDataReport;

        }
    }
}
