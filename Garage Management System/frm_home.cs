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
    public partial class frm_home : Form
    {
        public frm_home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_cars.Height;
            SidePanel.Top = btn_cars.Top;
            uc_cars1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_employee.Height;
            SidePanel.Top = btn_employee.Top;
            uc_employee1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_billing.Height;
            SidePanel.Top = btn_billing.Top;
            uc_billing1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_stocks_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_stocks.Height;
            SidePanel.Top = btn_stocks.Top;
            uc_stock1.BringToFront();
        }

        private void btn_analytics_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btn_analytics.Height;
            SidePanel.Top = btn_analytics.Top;
            uc_analytics1.BringToFront();
        }

        private void frm_home_Load(object sender, EventArgs e)
        {
            SidePanel.Height = btn_analytics.Height;
            SidePanel.Top = btn_analytics.Top;
            uc_analytics1.BringToFront();
        }
    }
}
