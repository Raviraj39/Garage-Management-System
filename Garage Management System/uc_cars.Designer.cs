namespace Garage_Management_System
{
    partial class uc_cars
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_carmodel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_carbrand = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_carno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_carcolor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ownername = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.db_carsDataGridView = new System.Windows.Forms.DataGridView();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_cars = new Garage_Management_System.ds_cars();
            this.db_carsTableAdapter = new Garage_Management_System.ds_carsTableAdapters.db_carsTableAdapter();
            this.tableAdapterManager = new Garage_Management_System.ds_carsTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_carsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_cars)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(442, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 36);
            this.label4.TabIndex = 116;
            this.label4.Text = "Cars Information";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(323, 338);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(185, 50);
            this.btn_update.TabIndex = 114;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.ForeColor = System.Drawing.Color.White;
            this.btn_insert.Location = new System.Drawing.Point(81, 338);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(185, 50);
            this.btn_insert.TabIndex = 113;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(773, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 110;
            this.label2.Text = "Car Model :";
            // 
            // txt_carmodel
            // 
            this.txt_carmodel.BackColor = System.Drawing.Color.White;
            this.txt_carmodel.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_carmodel.ForeColor = System.Drawing.Color.Black;
            this.txt_carmodel.Location = new System.Drawing.Point(778, 127);
            this.txt_carmodel.Multiline = true;
            this.txt_carmodel.Name = "txt_carmodel";
            this.txt_carmodel.Size = new System.Drawing.Size(303, 45);
            this.txt_carmodel.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(425, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 108;
            this.label1.Text = "Car Brand :";
            // 
            // txt_carbrand
            // 
            this.txt_carbrand.BackColor = System.Drawing.Color.White;
            this.txt_carbrand.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_carbrand.ForeColor = System.Drawing.Color.Black;
            this.txt_carbrand.Location = new System.Drawing.Point(430, 127);
            this.txt_carbrand.Multiline = true;
            this.txt_carbrand.Name = "txt_carbrand";
            this.txt_carbrand.Size = new System.Drawing.Size(303, 45);
            this.txt_carbrand.TabIndex = 107;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(76, 87);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(116, 29);
            this.lbl_name.TabIndex = 106;
            this.lbl_name.Text = "Car No. :";
            // 
            // txt_carno
            // 
            this.txt_carno.BackColor = System.Drawing.Color.White;
            this.txt_carno.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_carno.ForeColor = System.Drawing.Color.Black;
            this.txt_carno.Location = new System.Drawing.Point(81, 127);
            this.txt_carno.Multiline = true;
            this.txt_carno.Name = "txt_carno";
            this.txt_carno.Size = new System.Drawing.Size(303, 45);
            this.txt_carno.TabIndex = 105;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(76, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 118;
            this.label3.Text = "Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(425, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 29);
            this.label5.TabIndex = 120;
            this.label5.Text = "Car Color :";
            // 
            // txt_carcolor
            // 
            this.txt_carcolor.BackColor = System.Drawing.Color.White;
            this.txt_carcolor.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_carcolor.ForeColor = System.Drawing.Color.Black;
            this.txt_carcolor.Location = new System.Drawing.Point(430, 250);
            this.txt_carcolor.Multiline = true;
            this.txt_carcolor.Name = "txt_carcolor";
            this.txt_carcolor.Size = new System.Drawing.Size(303, 45);
            this.txt_carcolor.TabIndex = 119;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(773, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 29);
            this.label6.TabIndex = 122;
            this.label6.Text = "Owner Name :";
            // 
            // txt_ownername
            // 
            this.txt_ownername.BackColor = System.Drawing.Color.White;
            this.txt_ownername.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ownername.ForeColor = System.Drawing.Color.Black;
            this.txt_ownername.Location = new System.Drawing.Point(778, 250);
            this.txt_ownername.Multiline = true;
            this.txt_ownername.Name = "txt_ownername";
            this.txt_ownername.Size = new System.Drawing.Size(303, 45);
            this.txt_ownername.TabIndex = 121;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(581, 338);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(185, 50);
            this.btn_delete.TabIndex = 123;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.db_carsDataGridView);
            this.panel1.Location = new System.Drawing.Point(81, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 306);
            this.panel1.TabIndex = 124;
            // 
            // db_carsDataGridView
            // 
            this.db_carsDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.db_carsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.db_carsDataGridView.AutoGenerateColumns = false;
            this.db_carsDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.db_carsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_carsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.db_carsDataGridView.ColumnHeadersHeight = 40;
            this.db_carsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.db_carsDataGridView.DataSource = this.db_carsBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.db_carsDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.db_carsDataGridView.EnableHeadersVisualStyles = false;
            this.db_carsDataGridView.GridColor = System.Drawing.Color.Silver;
            this.db_carsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_carsDataGridView.Name = "db_carsDataGridView";
            this.db_carsDataGridView.RowHeadersVisible = false;
            this.db_carsDataGridView.RowTemplate.Height = 35;
            this.db_carsDataGridView.Size = new System.Drawing.Size(1000, 303);
            this.db_carsDataGridView.TabIndex = 0;
            this.db_carsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.db_carsDataGridView_CellClick);
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(81, 250);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(303, 45);
            this.dtp_date.TabIndex = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(819, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 50);
            this.button1.TabIndex = 126;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "carno";
            this.dataGridViewTextBoxColumn1.HeaderText = "Car No.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "carbrand";
            this.dataGridViewTextBoxColumn2.HeaderText = "Car Brand";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "carmodel";
            this.dataGridViewTextBoxColumn3.HeaderText = "Car Model";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "carcolor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Car Color";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ownername";
            this.dataGridViewTextBoxColumn6.HeaderText = "Owner Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // db_carsBindingSource
            // 
            this.db_carsBindingSource.DataMember = "db_cars";
            this.db_carsBindingSource.DataSource = this.ds_cars;
            // 
            // ds_cars
            // 
            this.ds_cars.DataSetName = "ds_cars";
            this.ds_cars.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_carsTableAdapter
            // 
            this.db_carsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.db_carsTableAdapter = this.db_carsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Garage_Management_System.ds_carsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uc_cars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ownername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_carcolor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_carmodel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_carbrand);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_carno);
            this.Name = "uc_cars";
            this.Size = new System.Drawing.Size(1140, 779);
            this.Load += new System.EventHandler(this.uc_cars_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_carsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_cars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_carmodel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_carbrand;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_carno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_carcolor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ownername;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private ds_cars ds_cars;
        private System.Windows.Forms.BindingSource db_carsBindingSource;
        private ds_carsTableAdapters.db_carsTableAdapter db_carsTableAdapter;
        private ds_carsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView db_carsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button1;
    }
}
