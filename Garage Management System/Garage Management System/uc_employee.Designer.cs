namespace Garage_Management_System
{
    partial class uc_employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_ename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_eeducation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ds_employee = new Garage_Management_System.ds_employee();
            this.db_employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_employeeTableAdapter = new Garage_Management_System.ds_employeeTableAdapters.db_employeeTableAdapter();
            this.tableAdapterManager = new Garage_Management_System.ds_employeeTableAdapters.TableAdapterManager();
            this.db_employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_employeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(73, 105);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(98, 28);
            this.lbl_name.TabIndex = 92;
            this.lbl_name.Text = "Name :";
            // 
            // txt_ename
            // 
            this.txt_ename.BackColor = System.Drawing.Color.White;
            this.txt_ename.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ename.ForeColor = System.Drawing.Color.Black;
            this.txt_ename.Location = new System.Drawing.Point(78, 148);
            this.txt_ename.Multiline = true;
            this.txt_ename.Name = "txt_ename";
            this.txt_ename.Size = new System.Drawing.Size(288, 45);
            this.txt_ename.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(404, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 94;
            this.label1.Text = "Education :";
            // 
            // txt_eeducation
            // 
            this.txt_eeducation.BackColor = System.Drawing.Color.White;
            this.txt_eeducation.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_eeducation.ForeColor = System.Drawing.Color.Black;
            this.txt_eeducation.Location = new System.Drawing.Point(409, 148);
            this.txt_eeducation.Multiline = true;
            this.txt_eeducation.Name = "txt_eeducation";
            this.txt_eeducation.Size = new System.Drawing.Size(288, 45);
            this.txt_eeducation.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(738, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 96;
            this.label2.Text = "Address :";
            // 
            // txt_address
            // 
            this.txt_address.BackColor = System.Drawing.Color.White;
            this.txt_address.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.ForeColor = System.Drawing.Color.Black;
            this.txt_address.Location = new System.Drawing.Point(743, 148);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(288, 45);
            this.txt_address.TabIndex = 95;
            // 
            // cmb_gender
            // 
            this.cmb_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmb_gender.Location = new System.Drawing.Point(78, 268);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(288, 44);
            this.cmb_gender.TabIndex = 97;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 28);
            this.label3.TabIndex = 99;
            this.label3.Text = "Gender :";
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.ForeColor = System.Drawing.Color.White;
            this.btn_insert.Location = new System.Drawing.Point(409, 262);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(185, 50);
            this.btn_insert.TabIndex = 101;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(620, 262);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(185, 50);
            this.btn_update.TabIndex = 102;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(384, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 37);
            this.label4.TabIndex = 104;
            this.label4.Text = "Employee Information";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(831, 262);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(185, 50);
            this.btn_delete.TabIndex = 105;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.db_employeeDataGridView);
            this.panel1.Location = new System.Drawing.Point(78, 354);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(953, 345);
            this.panel1.TabIndex = 106;
            // 
            // ds_employee
            // 
            this.ds_employee.DataSetName = "ds_employee";
            this.ds_employee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_employeeBindingSource
            // 
            this.db_employeeBindingSource.DataMember = "db_employee";
            this.db_employeeBindingSource.DataSource = this.ds_employee;
            // 
            // db_employeeTableAdapter
            // 
            this.db_employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.db_employeeTableAdapter = this.db_employeeTableAdapter;
            this.tableAdapterManager.UpdateOrder = Garage_Management_System.ds_employeeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // db_employeeDataGridView
            // 
            this.db_employeeDataGridView.AllowUserToAddRows = false;
            this.db_employeeDataGridView.AutoGenerateColumns = false;
            this.db_employeeDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.db_employeeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_employeeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.db_employeeDataGridView.ColumnHeadersHeight = 40;
            this.db_employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.db_employeeDataGridView.DataSource = this.db_employeeBindingSource;
            this.db_employeeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_employeeDataGridView.EnableHeadersVisualStyles = false;
            this.db_employeeDataGridView.GridColor = System.Drawing.Color.Silver;
            this.db_employeeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_employeeDataGridView.Name = "db_employeeDataGridView";
            this.db_employeeDataGridView.RowHeadersVisible = false;
            this.db_employeeDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_employeeDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Silver;
            this.db_employeeDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_employeeDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.db_employeeDataGridView.RowTemplate.Height = 35;
            this.db_employeeDataGridView.Size = new System.Drawing.Size(953, 345);
            this.db_employeeDataGridView.TabIndex = 0;
            this.db_employeeDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.db_employeeDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ename";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "eeducation";
            this.dataGridViewTextBoxColumn2.HeaderText = "Education";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "eaddress";
            this.dataGridViewTextBoxColumn3.HeaderText = "Address";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "egender";
            this.dataGridViewTextBoxColumn4.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // uc_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_gender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_eeducation);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_ename);
            this.Name = "uc_employee";
            this.Size = new System.Drawing.Size(1140, 727);
            this.Load += new System.EventHandler(this.uc_employee_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_employeeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_ename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_eeducation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.ComboBox cmb_gender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel1;
        private ds_employee ds_employee;
        private System.Windows.Forms.BindingSource db_employeeBindingSource;
        private ds_employeeTableAdapters.db_employeeTableAdapter db_employeeTableAdapter;
        private ds_employeeTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.DataGridView db_employeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
