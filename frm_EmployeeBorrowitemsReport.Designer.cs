namespace sales
{
    partial class frm_EmployeeBorrowitemsReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EmployeeBorrowitemsReport));
            this.Dgv_search = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_allEmp = new System.Windows.Forms.RadioButton();
            this.rbtn_oneEmp = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.cbx_employee = new System.Windows.Forms.ComboBox();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_search
            // 
            this.Dgv_search.AllowUserToAddRows = false;
            this.Dgv_search.AllowUserToDeleteRows = false;
            this.Dgv_search.AllowUserToResizeColumns = false;
            this.Dgv_search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_search.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_search.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_search.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_search.Location = new System.Drawing.Point(5, 91);
            this.Dgv_search.Name = "Dgv_search";
            this.Dgv_search.ReadOnly = true;
            this.Dgv_search.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_search.Size = new System.Drawing.Size(939, 256);
            this.Dgv_search.TabIndex = 41;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_allEmp);
            this.groupBox1.Controls.Add(this.rbtn_oneEmp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtp_to);
            this.groupBox1.Controls.Add(this.cbx_employee);
            this.groupBox1.Controls.Add(this.dtp_from);
            this.groupBox1.Location = new System.Drawing.Point(7, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 49);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // rbtn_allEmp
            // 
            this.rbtn_allEmp.AutoSize = true;
            this.rbtn_allEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_allEmp.Checked = true;
            this.rbtn_allEmp.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_allEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_allEmp.Location = new System.Drawing.Point(634, 8);
            this.rbtn_allEmp.Name = "rbtn_allEmp";
            this.rbtn_allEmp.Size = new System.Drawing.Size(105, 29);
            this.rbtn_allEmp.TabIndex = 12;
            this.rbtn_allEmp.TabStop = true;
            this.rbtn_allEmp.Text = "كل الموظفين";
            this.rbtn_allEmp.UseVisualStyleBackColor = false;
            // 
            // rbtn_oneEmp
            // 
            this.rbtn_oneEmp.AutoSize = true;
            this.rbtn_oneEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_oneEmp.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_oneEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_oneEmp.Location = new System.Drawing.Point(511, 7);
            this.rbtn_oneEmp.Name = "rbtn_oneEmp";
            this.rbtn_oneEmp.Size = new System.Drawing.Size(99, 29);
            this.rbtn_oneEmp.TabIndex = 13;
            this.rbtn_oneEmp.Text = "موظف محدد";
            this.rbtn_oneEmp.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(125, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "الي :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(316, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "من :";
            // 
            // dtp_to
            // 
            this.dtp_to.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_to.Location = new System.Drawing.Point(2, 8);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_to.Size = new System.Drawing.Size(117, 32);
            this.dtp_to.TabIndex = 8;
            this.dtp_to.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // cbx_employee
            // 
            this.cbx_employee.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_employee.FormattingEnabled = true;
            this.cbx_employee.Location = new System.Drawing.Point(381, 5);
            this.cbx_employee.Name = "cbx_employee";
            this.cbx_employee.Size = new System.Drawing.Size(121, 33);
            this.cbx_employee.TabIndex = 11;
            // 
            // dtp_from
            // 
            this.dtp_from.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_from.Location = new System.Drawing.Point(193, 8);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_from.Size = new System.Drawing.Size(117, 32);
            this.dtp_from.TabIndex = 7;
            this.dtp_from.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_delete.Location = new System.Drawing.Point(5, 353);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(105, 36);
            this.btn_delete.TabIndex = 43;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(624, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "عدد المنتجات المسحوبه:";
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(776, 353);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(167, 32);
            this.txt_total.TabIndex = 42;
            // 
            // btn_search
            // 
            this.btn_search.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.ImageOptions.Image")));
            this.btn_search.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_search.Location = new System.Drawing.Point(801, 45);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(142, 31);
            this.btn_search.TabIndex = 40;
            this.btn_search.Text = "بحث";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(301, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 31);
            this.label2.TabIndex = 39;
            this.label2.Text = "اجمالي مسحوبات الموظفين في فترة";
            // 
            // frm_EmployeeBorrowitemsReport
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(953, 392);
            this.Controls.Add(this.Dgv_search);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frm_EmployeeBorrowitemsReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير مسحوبات الموظفين";
            this.Load += new System.EventHandler(this.frm_EmployeeBorrowitemsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_total;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtn_allEmp;
        private System.Windows.Forms.RadioButton rbtn_oneEmp;
        private System.Windows.Forms.ComboBox cbx_employee;
    }
}