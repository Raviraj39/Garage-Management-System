namespace Garage_Management_System
{
    partial class uc_billing
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
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_partprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_partname = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_billno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_totalprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_partquantity = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.db_billcardDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_billcardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_billcard = new Garage_Management_System.db_billcard();
            this.btn_savebill = new System.Windows.Forms.Button();
            this.db_billcardTableAdapter = new Garage_Management_System.db_billcardTableAdapters.db_billcardTableAdapter();
            this.tableAdapterManager = new Garage_Management_System.db_billcardTableAdapters.TableAdapterManager();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_grand_total = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_billcardDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_billcardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_billcard)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Location = new System.Drawing.Point(581, 231);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(155, 50);
            this.btn_remove.TabIndex = 123;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.ForeColor = System.Drawing.Color.White;
            this.btn_insert.Location = new System.Drawing.Point(402, 231);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(155, 50);
            this.btn_insert.TabIndex = 122;
            this.btn_insert.Text = "Add";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(416, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 36);
            this.label4.TabIndex = 121;
            this.label4.Text = "Billing Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(762, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 29);
            this.label2.TabIndex = 120;
            this.label2.Text = "Part Price :";
            // 
            // txt_partprice
            // 
            this.txt_partprice.BackColor = System.Drawing.Color.White;
            this.txt_partprice.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_partprice.ForeColor = System.Drawing.Color.Black;
            this.txt_partprice.Location = new System.Drawing.Point(767, 135);
            this.txt_partprice.Multiline = true;
            this.txt_partprice.Name = "txt_partprice";
            this.txt_partprice.Size = new System.Drawing.Size(314, 45);
            this.txt_partprice.TabIndex = 119;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(406, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 118;
            this.label1.Text = "Part Name :";
            // 
            // txt_partname
            // 
            this.txt_partname.BackColor = System.Drawing.Color.White;
            this.txt_partname.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_partname.ForeColor = System.Drawing.Color.Black;
            this.txt_partname.Location = new System.Drawing.Point(411, 135);
            this.txt_partname.Multiline = true;
            this.txt_partname.Name = "txt_partname";
            this.txt_partname.Size = new System.Drawing.Size(314, 45);
            this.txt_partname.TabIndex = 117;
            this.txt_partname.TextChanged += new System.EventHandler(this.txt_partname_TextChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(46, 93);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(113, 29);
            this.lbl_name.TabIndex = 116;
            this.lbl_name.Text = "Bill No. :";
            // 
            // txt_billno
            // 
            this.txt_billno.BackColor = System.Drawing.Color.White;
            this.txt_billno.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_billno.ForeColor = System.Drawing.Color.Black;
            this.txt_billno.Location = new System.Drawing.Point(51, 135);
            this.txt_billno.Multiline = true;
            this.txt_billno.Name = "txt_billno";
            this.txt_billno.Size = new System.Drawing.Size(314, 45);
            this.txt_billno.TabIndex = 115;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(762, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 130;
            this.label3.Text = "Total Price :";
            // 
            // txt_totalprice
            // 
            this.txt_totalprice.BackColor = System.Drawing.Color.White;
            this.txt_totalprice.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalprice.ForeColor = System.Drawing.Color.Black;
            this.txt_totalprice.Location = new System.Drawing.Point(767, 246);
            this.txt_totalprice.Multiline = true;
            this.txt_totalprice.Name = "txt_totalprice";
            this.txt_totalprice.Size = new System.Drawing.Size(314, 45);
            this.txt_totalprice.TabIndex = 129;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 29);
            this.label6.TabIndex = 126;
            this.label6.Text = "Part Quantity :";
            // 
            // txt_partquantity
            // 
            this.txt_partquantity.BackColor = System.Drawing.Color.White;
            this.txt_partquantity.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_partquantity.ForeColor = System.Drawing.Color.Black;
            this.txt_partquantity.Location = new System.Drawing.Point(51, 246);
            this.txt_partquantity.Multiline = true;
            this.txt_partquantity.Name = "txt_partquantity";
            this.txt_partquantity.Size = new System.Drawing.Size(314, 45);
            this.txt_partquantity.TabIndex = 125;
            this.txt_partquantity.TextChanged += new System.EventHandler(this.txt_partquantity_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.db_billcardDataGridView);
            this.panel1.Location = new System.Drawing.Point(51, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 325);
            this.panel1.TabIndex = 131;
            // 
            // db_billcardDataGridView
            // 
            this.db_billcardDataGridView.AllowUserToAddRows = false;
            this.db_billcardDataGridView.AutoGenerateColumns = false;
            this.db_billcardDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.db_billcardDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.db_billcardDataGridView.ColumnHeadersHeight = 40;
            this.db_billcardDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.db_billcardDataGridView.DataSource = this.db_billcardBindingSource;
            this.db_billcardDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_billcardDataGridView.EnableHeadersVisualStyles = false;
            this.db_billcardDataGridView.GridColor = System.Drawing.Color.Silver;
            this.db_billcardDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_billcardDataGridView.Name = "db_billcardDataGridView";
            this.db_billcardDataGridView.RowHeadersVisible = false;
            this.db_billcardDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.db_billcardDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Silver;
            this.db_billcardDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_billcardDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.db_billcardDataGridView.RowTemplate.Height = 35;
            this.db_billcardDataGridView.Size = new System.Drawing.Size(1030, 325);
            this.db_billcardDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "billno";
            this.dataGridViewTextBoxColumn1.HeaderText = "Bill No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "partname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Part Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "partprice";
            this.dataGridViewTextBoxColumn3.HeaderText = "Part Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "partqty";
            this.dataGridViewTextBoxColumn4.HeaderText = "Part Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "totalprice";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // db_billcardBindingSource
            // 
            this.db_billcardBindingSource.DataMember = "db_billcard";
            this.db_billcardBindingSource.DataSource = this.db_billcard;
            // 
            // db_billcard
            // 
            this.db_billcard.DataSetName = "db_billcard";
            this.db_billcard.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_savebill
            // 
            this.btn_savebill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_savebill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_savebill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_savebill.ForeColor = System.Drawing.Color.White;
            this.btn_savebill.Location = new System.Drawing.Point(51, 657);
            this.btn_savebill.Name = "btn_savebill";
            this.btn_savebill.Size = new System.Drawing.Size(214, 50);
            this.btn_savebill.TabIndex = 133;
            this.btn_savebill.Text = "Save Bill";
            this.btn_savebill.UseVisualStyleBackColor = false;
            this.btn_savebill.Click += new System.EventHandler(this.button2_Click);
            // 
            // db_billcardTableAdapter
            // 
            this.db_billcardTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.db_billcardTableAdapter = this.db_billcardTableAdapter;
            this.tableAdapterManager.UpdateOrder = Garage_Management_System.db_billcardTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(592, 669);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 29);
            this.label5.TabIndex = 135;
            this.label5.Text = "Grand Total :";
            // 
            // txt_grand_total
            // 
            this.txt_grand_total.BackColor = System.Drawing.Color.White;
            this.txt_grand_total.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grand_total.ForeColor = System.Drawing.Color.Black;
            this.txt_grand_total.Location = new System.Drawing.Point(776, 656);
            this.txt_grand_total.Multiline = true;
            this.txt_grand_total.Name = "txt_grand_total";
            this.txt_grand_total.Size = new System.Drawing.Size(305, 45);
            this.txt_grand_total.TabIndex = 134;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(342, 658);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 50);
            this.button1.TabIndex = 136;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uc_billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_grand_total);
            this.Controls.Add(this.btn_savebill);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_totalprice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_partquantity);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_partprice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_partname);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_billno);
            this.Name = "uc_billing";
            this.Size = new System.Drawing.Size(1140, 727);
            this.Load += new System.EventHandler(this.uc_billing_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_billcardDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_billcardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_billcard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_partprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_partname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_billno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_totalprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_partquantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_savebill;
        private db_billcard db_billcard;
        private System.Windows.Forms.BindingSource db_billcardBindingSource;
        private db_billcardTableAdapters.db_billcardTableAdapter db_billcardTableAdapter;
        private db_billcardTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.DataGridView db_billcardDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_grand_total;
        private System.Windows.Forms.Button button1;
    }
}
