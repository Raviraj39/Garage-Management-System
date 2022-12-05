using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;


namespace Garage_Management_System
{
    public partial class billcrystal : Form
    {
        ReportDocument crypt = new ReportDocument();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\RAVI RAJ\Pictures\Garage Management System\Garage Management System\GMS.mdf;Integrated Security=True");
        public billcrystal()
        {
            InitializeComponent();
        }

        private void billcrystal_Load(object sender, EventArgs e)
        {
            string sqlString = "select * from db_billcard";
            SqlDataAdapter da = new SqlDataAdapter(sqlString, con);
            DataSet dataReport = new DataSet();
            da.Fill(dataReport, "db_billcard");

            CrystalReport1 myDataReport = new CrystalReport1();
            myDataReport.SetDataSource(dataReport);
            crystalReportViewer1.ReportSource = myDataReport;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
