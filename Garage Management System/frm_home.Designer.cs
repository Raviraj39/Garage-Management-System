namespace Garage_Management_System
{
    partial class frm_home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_analytics = new System.Windows.Forms.Button();
            this.btn_billing = new System.Windows.Forms.Button();
            this.btn_employee = new System.Windows.Forms.Button();
            this.btn_stocks = new System.Windows.Forms.Button();
            this.btn_cars = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.uc_analytics1 = new Garage_Management_System.uc_analytics();
            this.uc_billing1 = new Garage_Management_System.uc_billing();
            this.uc_stock1 = new Garage_Management_System.uc_stock();
            this.uc_cars1 = new Garage_Management_System.uc_cars();
            this.uc_employee1 = new Garage_Management_System.uc_employee();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Main_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_analytics);
            this.panel1.Controls.Add(this.btn_billing);
            this.panel1.Controls.Add(this.btn_employee);
            this.panel1.Controls.Add(this.btn_stocks);
            this.panel1.Controls.Add(this.btn_cars);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 737);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(136, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Garage\r\nManagement";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.White;
            this.SidePanel.Location = new System.Drawing.Point(0, 118);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(19, 61);
            this.SidePanel.TabIndex = 1;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(33, 606);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(244, 61);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_analytics
            // 
            this.btn_analytics.BackColor = System.Drawing.Color.Transparent;
            this.btn_analytics.FlatAppearance.BorderSize = 0;
            this.btn_analytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_analytics.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_analytics.ForeColor = System.Drawing.Color.White;
            this.btn_analytics.Location = new System.Drawing.Point(33, 468);
            this.btn_analytics.Name = "btn_analytics";
            this.btn_analytics.Size = new System.Drawing.Size(244, 61);
            this.btn_analytics.TabIndex = 5;
            this.btn_analytics.Text = "Analytics";
            this.btn_analytics.UseVisualStyleBackColor = false;
            this.btn_analytics.Click += new System.EventHandler(this.btn_analytics_Click);
            // 
            // btn_billing
            // 
            this.btn_billing.BackColor = System.Drawing.Color.Transparent;
            this.btn_billing.FlatAppearance.BorderSize = 0;
            this.btn_billing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_billing.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_billing.ForeColor = System.Drawing.Color.White;
            this.btn_billing.Location = new System.Drawing.Point(33, 377);
            this.btn_billing.Name = "btn_billing";
            this.btn_billing.Size = new System.Drawing.Size(244, 61);
            this.btn_billing.TabIndex = 4;
            this.btn_billing.Text = "Billing";
            this.btn_billing.UseVisualStyleBackColor = false;
            this.btn_billing.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_employee
            // 
            this.btn_employee.BackColor = System.Drawing.Color.Transparent;
            this.btn_employee.FlatAppearance.BorderSize = 0;
            this.btn_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employee.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee.ForeColor = System.Drawing.Color.White;
            this.btn_employee.Location = new System.Drawing.Point(33, 289);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(244, 61);
            this.btn_employee.TabIndex = 3;
            this.btn_employee.Text = "Employees";
            this.btn_employee.UseVisualStyleBackColor = false;
            this.btn_employee.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_stocks
            // 
            this.btn_stocks.BackColor = System.Drawing.Color.Transparent;
            this.btn_stocks.FlatAppearance.BorderSize = 0;
            this.btn_stocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stocks.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stocks.ForeColor = System.Drawing.Color.White;
            this.btn_stocks.Location = new System.Drawing.Point(33, 203);
            this.btn_stocks.Name = "btn_stocks";
            this.btn_stocks.Size = new System.Drawing.Size(244, 61);
            this.btn_stocks.TabIndex = 2;
            this.btn_stocks.Text = "Stock";
            this.btn_stocks.UseVisualStyleBackColor = false;
            this.btn_stocks.Click += new System.EventHandler(this.btn_stocks_Click);
            // 
            // btn_cars
            // 
            this.btn_cars.BackColor = System.Drawing.Color.Transparent;
            this.btn_cars.FlatAppearance.BorderSize = 0;
            this.btn_cars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cars.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cars.ForeColor = System.Drawing.Color.White;
            this.btn_cars.Location = new System.Drawing.Point(33, 118);
            this.btn_cars.Name = "btn_cars";
            this.btn_cars.Size = new System.Drawing.Size(244, 61);
            this.btn_cars.TabIndex = 1;
            this.btn_cars.Text = "Cars";
            this.btn_cars.UseVisualStyleBackColor = false;
            this.btn_cars.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(280, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1140, 10);
            this.panel3.TabIndex = 1;
            // 
            // Main_Panel
            // 
            this.Main_Panel.BackColor = System.Drawing.Color.Silver;
            this.Main_Panel.Controls.Add(this.uc_analytics1);
            this.Main_Panel.Controls.Add(this.uc_billing1);
            this.Main_Panel.Controls.Add(this.uc_stock1);
            this.Main_Panel.Controls.Add(this.uc_cars1);
            this.Main_Panel.Controls.Add(this.uc_employee1);
            this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Panel.Location = new System.Drawing.Point(280, 10);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(1140, 727);
            this.Main_Panel.TabIndex = 2;
            // 
            // uc_analytics1
            // 
            this.uc_analytics1.BackColor = System.Drawing.Color.Silver;
            this.uc_analytics1.Location = new System.Drawing.Point(0, 0);
            this.uc_analytics1.Name = "uc_analytics1";
            this.uc_analytics1.Size = new System.Drawing.Size(1140, 727);
            this.uc_analytics1.TabIndex = 4;
            // 
            // uc_billing1
            // 
            this.uc_billing1.BackColor = System.Drawing.Color.Silver;
            this.uc_billing1.Location = new System.Drawing.Point(0, 0);
            this.uc_billing1.Name = "uc_billing1";
            this.uc_billing1.Size = new System.Drawing.Size(1140, 727);
            this.uc_billing1.TabIndex = 3;
            // 
            // uc_stock1
            // 
            this.uc_stock1.BackColor = System.Drawing.Color.Silver;
            this.uc_stock1.Location = new System.Drawing.Point(0, 0);
            this.uc_stock1.Name = "uc_stock1";
            this.uc_stock1.Size = new System.Drawing.Size(1140, 720);
            this.uc_stock1.TabIndex = 2;
            // 
            // uc_cars1
            // 
            this.uc_cars1.BackColor = System.Drawing.Color.Silver;
            this.uc_cars1.Location = new System.Drawing.Point(3, 0);
            this.uc_cars1.Name = "uc_cars1";
            this.uc_cars1.Size = new System.Drawing.Size(1140, 727);
            this.uc_cars1.TabIndex = 1;
            // 
            // uc_employee1
            // 
            this.uc_employee1.BackColor = System.Drawing.Color.Silver;
            this.uc_employee1.Location = new System.Drawing.Point(3, 0);
            this.uc_employee1.Name = "uc_employee1";
            this.uc_employee1.Size = new System.Drawing.Size(1140, 727);
            this.uc_employee1.TabIndex = 0;
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1420, 737);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Main_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_cars;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.Button btn_stocks;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_analytics;
        private System.Windows.Forms.Button btn_billing;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel Main_Panel;
        private uc_employee uc_employee1;
        private uc_cars uc_cars1;
        private uc_stock uc_stock1;
        private uc_billing uc_billing1;
        private uc_analytics uc_analytics1;
    }
}