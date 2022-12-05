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
    public partial class emplooyeesreport : Form
    {
        ReportDocument crypt = new ReportDocument();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\RAVI RAJ\Pictures\Garage Management System\Garage Management System\GMS.mdf;Integrated Security=True");

        public emplooyeesreport()
        {
            InitializeComponent();
        }

        private void emplooyeesreport_Load(object sender, EventArgs e)
        {
            string sqlString = "select * from db_employee";
            SqlDataAdapter da = new SqlDataAdapter(sqlString, con);
            DataSet dataReport = new DataSet();
            da.Fill(dataReport, "db_employee");

            CrystalReport3 myDataReport = new CrystalReport3();
            myDataReport.SetDataSource(dataReport);
            crystalReportViewer1.ReportSource = myDataReport;
        }
    }
}
