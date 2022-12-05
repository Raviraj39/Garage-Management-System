namespace Garage_Management_System
{
    partial class uc_stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_partprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_partqty = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_paetname = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ds_stock = new Garage_Management_System.ds_stock();
            this.db_stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_stockTableAdapter = new Garage_Management_System.ds_stockTableAdapters.db_stockTableAdapter();
            this.tableAdapterManager = new Garage_Management_System.ds_stockTableAdapters.TableAdapterManager();
            this.db_stockDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_stockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(410, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 37);
            this.label4.TabIndex = 111;
            this.label4.Text = "Stock Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(777, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 28);
            this.label2.TabIndex = 110;
            this.label2.Text = "Part Price :";
            // 
            // txt_partprice
            // 
            this.txt_partprice.BackColor = System.Drawing.Color.White;
            this.txt_partprice.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_partprice.ForeColor = System.Drawing.Color.Black;
            this.txt_partprice.Location = new System.Drawing.Point(782, 127);
            this.txt_partprice.Multiline = true;
            this.txt_partprice.Name = "txt_partprice";
            this.txt_partprice.Size = new System.Drawing.Size(300, 45);
            this.txt_partprice.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(412, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 28);
            this.label1.TabIndex = 108;
            this.label1.Text = "Part Quantity :";
            // 
            // txt_partqty
            // 
            this.txt_partqty.BackColor = System.Drawing.Color.White;
            this.txt_partqty.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_partqty.ForeColor = System.Drawing.Color.Black;
            this.txt_partqty.Location = new System.Drawing.Point(417, 127);
            this.txt_partqty.Multiline = true;
            this.txt_partqty.Name = "txt_partqty";
            this.txt_partqty.Size = new System.Drawing.Size(300, 45);
            this.txt_partqty.TabIndex = 107;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(48, 84);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(149, 28);
            this.lbl_name.TabIndex = 106;
            this.lbl_name.Text = "Part Name :";
            // 
            // txt_paetname
            // 
            this.txt_paetname.BackColor = System.Drawing.Color.White;
            this.txt_paetname.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paetname.ForeColor = System.Drawing.Color.Black;
            this.txt_paetname.Location = new System.Drawing.Point(53, 127);
            this.txt_paetname.Multiline = true;
            this.txt_paetname.Name = "txt_paetname";
            this.txt_paetname.Size = new System.Drawing.Size(300, 45);
            this.txt_paetname.TabIndex = 105;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(465, 229);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(185, 50);
            this.btn_update.TabIndex = 113;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.ForeColor = System.Drawing.Color.White;
            this.btn_insert.Location = new System.Drawing.Point(102, 229);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(185, 50);
            this.btn_insert.TabIndex = 112;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(834, 229);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(185, 50);
            this.btn_delete.TabIndex = 114;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.db_stockDataGridView);
            this.panel1.Location = new System.Drawing.Point(53, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 375);
            this.panel1.TabIndex = 115;
            // 
            // ds_stock
            // 
            this.ds_stock.DataSetName = "ds_stock";
            this.ds_stock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_stockBindingSource
            // 
            this.db_stockBindingSource.DataMember = "db_stock";
            this.db_stockBindingSource.DataSource = this.ds_stock;
            // 
            // db_stockTableAdapter
            // 
            this.db_stockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.db_stockTableAdapter = this.db_stockTableAdapter;
            this.tableAdapterManager.UpdateOrder = Garage_Management_System.ds_stockTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // db_stockDataGridView
            // 
            this.db_stockDataGridView.AllowUserToAddRows = false;
            this.db_stockDataGridView.AutoGenerateColumns = false;
            this.db_stockDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.db_stockDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_stockDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.db_stockDataGridView.ColumnHeadersHeight = 40;
            this.db_stockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.db_stockDataGridView.DataSource = this.db_stockBindingSource;
            this.db_stockDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_stockDataGridView.EnableHeadersVisualStyles = false;
            this.db_stockDataGridView.GridColor = System.Drawing.Color.Silver;
            this.db_stockDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_stockDataGridView.Name = "db_stockDataGridView";
            this.db_stockDataGridView.RowHeadersVisible = false;
            this.db_stockDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_stockDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Silver;
            this.db_stockDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_stockDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.db_stockDataGridView.RowTemplate.Height = 35;
            this.db_stockDataGridView.Size = new System.Drawing.Size(1029, 375);
            this.db_stockDataGridView.TabIndex = 0;
            this.db_stockDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.db_stockDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "partname";
            this.dataGridViewTextBoxColumn1.HeaderText = "Part Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "partqut";
            this.dataGridViewTextBoxColumn2.HeaderText = "Part Quantity";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "partprice";
            this.dataGridViewTextBoxColumn3.HeaderText = "Part Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // uc_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_partprice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_partqty);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_paetname);
            this.Name = "uc_stock";
            this.Size = new System.Drawing.Size(1140, 720);
            this.Load += new System.EventHandler(this.uc_stock_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ds_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_stockDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_partprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_partqty;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_paetname;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel1;
        private ds_stock ds_stock;
        private System.Windows.Forms.BindingSource db_stockBindingSource;
        private ds_stockTableAdapters.db_stockTableAdapter db_stockTableAdapter;
        private ds_stockTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        public System.Windows.Forms.DataGridView db_stockDataGridView;

    }
}
