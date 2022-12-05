namespace Garage_Management_System
{
    partial class uc_analytics
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_cars = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_spare = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_employee = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_frinance = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.db_finance = new Garage_Management_System.db_finance();
            this.db_billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_billTableAdapter = new Garage_Management_System.db_financeTableAdapters.db_billTableAdapter();
            this.tableAdapterManager = new Garage_Management_System.db_financeTableAdapters.TableAdapterManager();
            this.db_billDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_finance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_billDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(17, 170);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbl_cars);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(72, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 170);
            this.panel1.TabIndex = 0;
            // 
            // lbl_cars
            // 
            this.lbl_cars.AutoSize = true;
            this.lbl_cars.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cars.Location = new System.Drawing.Point(139, 80);
            this.lbl_cars.Name = "lbl_cars";
            this.lbl_cars.Size = new System.Drawing.Size(27, 32);
            this.lbl_cars.TabIndex = 6;
            this.lbl_cars.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cars";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Garage_Management_System.Properties.Resources.icons8_car_120px;
            this.pictureBox1.Location = new System.Drawing.Point(33, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lbl_spare);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(415, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 170);
            this.panel3.TabIndex = 1;
            // 
            // lbl_spare
            // 
            this.lbl_spare.AutoSize = true;
            this.lbl_spare.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spare.Location = new System.Drawing.Point(132, 80);
            this.lbl_spare.Name = "lbl_spare";
            this.lbl_spare.Size = new System.Drawing.Size(27, 32);
            this.lbl_spare.TabIndex = 6;
            this.lbl_spare.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Spare";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Garage_Management_System.Properties.Resources.icons8_services_120px;
            this.pictureBox2.Location = new System.Drawing.Point(36, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(17, 170);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lbl_employee);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(755, 51);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 170);
            this.panel5.TabIndex = 2;
            // 
            // lbl_employee
            // 
            this.lbl_employee.AutoSize = true;
            this.lbl_employee.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee.Location = new System.Drawing.Point(137, 80);
            this.lbl_employee.Name = "lbl_employee";
            this.lbl_employee.Size = new System.Drawing.Size(27, 32);
            this.lbl_employee.TabIndex = 6;
            this.lbl_employee.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employees";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Garage_Management_System.Properties.Resources.icons8_user_120px;
            this.pictureBox3.Location = new System.Drawing.Point(33, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(79, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(17, 170);
            this.panel6.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.lbl_frinance);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.pictureBox4);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(415, 284);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 170);
            this.panel7.TabIndex = 3;
            // 
            // lbl_frinance
            // 
            this.lbl_frinance.AutoSize = true;
            this.lbl_frinance.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_frinance.Location = new System.Drawing.Point(132, 88);
            this.lbl_frinance.Name = "lbl_frinance";
            this.lbl_frinance.Size = new System.Drawing.Size(27, 32);
            this.lbl_frinance.TabIndex = 5;
            this.lbl_frinance.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Finance";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Garage_Management_System.Properties.Resources.icons8_money_bag_120px;
            this.pictureBox4.Location = new System.Drawing.Point(36, 52);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(79, 68);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(17, 170);
            this.panel8.TabIndex = 1;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_refresh.FlatAppearance.BorderSize = 2;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.Purple;
            this.btn_refresh.Location = new System.Drawing.Point(415, 545);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(300, 63);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // db_finance
            // 
            this.db_finance.DataSetName = "db_finance";
            this.db_finance.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_billBindingSource
            // 
            this.db_billBindingSource.DataMember = "db_bill";
            this.db_billBindingSource.DataSource = this.db_finance;
            // 
            // db_billTableAdapter
            // 
            this.db_billTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.db_billTableAdapter = this.db_billTableAdapter;
            this.tableAdapterManager.UpdateOrder = Garage_Management_System.db_financeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // db_billDataGridView
            // 
            this.db_billDataGridView.AutoGenerateColumns = false;
            this.db_billDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_billDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.db_billDataGridView.DataSource = this.db_billBindingSource;
            this.db_billDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.db_billDataGridView.Location = new System.Drawing.Point(0, 717);
            this.db_billDataGridView.Name = "db_billDataGridView";
            this.db_billDataGridView.RowTemplate.Height = 24;
            this.db_billDataGridView.Size = new System.Drawing.Size(1140, 10);
            this.db_billDataGridView.TabIndex = 6;
            this.db_billDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "billno";
            this.dataGridViewTextBoxColumn1.HeaderText = "billno";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "partname";
            this.dataGridViewTextBoxColumn2.HeaderText = "partname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "partprice";
            this.dataGridViewTextBoxColumn3.HeaderText = "partprice";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "partqty";
            this.dataGridViewTextBoxColumn4.HeaderText = "partqty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "totalprice";
            this.dataGridViewTextBoxColumn5.HeaderText = "totalprice";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "grandtotal";
            this.dataGridViewTextBoxColumn6.HeaderText = "grandtotal";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // uc_analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.db_billDataGridView);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "uc_analytics";
            this.Size = new System.Drawing.Size(1140, 727);
            this.Load += new System.EventHandler(this.uc_analytics_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_finance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_billDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbl_cars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_spare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_employee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_frinance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_refresh;
        private db_finance db_finance;
        private System.Windows.Forms.BindingSource db_billBindingSource;
        private db_financeTableAdapters.db_billTableAdapter db_billTableAdapter;
        private db_financeTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView db_billDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

    }
}
