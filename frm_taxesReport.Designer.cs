namespace sales
{
    partial class frm_taxesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_taxesReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.checksale = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkbuyReturn = new System.Windows.Forms.CheckBox();
            this.checksaleReturn = new System.Windows.Forms.CheckBox();
            this.checkbuy = new System.Windows.Forms.CheckBox();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txttotaltax = new System.Windows.Forms.TextBox();
            this.btn_printsummary = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_printReport = new DevExpress.XtraEditors.SimpleButton();
            this.Dgv_search = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txttotalaftertax = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtp_to);
            this.groupBox2.Controls.Add(this.dtp_from);
            this.groupBox2.Location = new System.Drawing.Point(435, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 58);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(138, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "الي:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(360, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "من:";
            // 
            // dtp_to
            // 
            this.dtp_to.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_to.Location = new System.Drawing.Point(25, 20);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_to.Size = new System.Drawing.Size(107, 26);
            this.dtp_to.TabIndex = 8;
            this.dtp_to.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // dtp_from
            // 
            this.dtp_from.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_from.Location = new System.Drawing.Point(247, 20);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_from.Size = new System.Drawing.Size(107, 26);
            this.dtp_from.TabIndex = 7;
            this.dtp_from.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // checksale
            // 
            this.checksale.AutoSize = true;
            this.checksale.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checksale.Location = new System.Drawing.Point(264, 0);
            this.checksale.Name = "checksale";
            this.checksale.Size = new System.Drawing.Size(129, 32);
            this.checksale.TabIndex = 0;
            this.checksale.Text = "فواتير المبيعات";
            this.checksale.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkbuyReturn);
            this.groupBox1.Controls.Add(this.checksaleReturn);
            this.groupBox1.Controls.Add(this.checkbuy);
            this.groupBox1.Controls.Add(this.checksale);
            this.groupBox1.Location = new System.Drawing.Point(9, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 57);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            // 
            // checkbuyReturn
            // 
            this.checkbuyReturn.AutoSize = true;
            this.checkbuyReturn.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbuyReturn.Location = new System.Drawing.Point(47, 29);
            this.checkbuyReturn.Name = "checkbuyReturn";
            this.checkbuyReturn.Size = new System.Drawing.Size(148, 32);
            this.checkbuyReturn.TabIndex = 3;
            this.checkbuyReturn.Text = "مرتجعات مشتريات";
            this.checkbuyReturn.UseVisualStyleBackColor = true;
            // 
            // checksaleReturn
            // 
            this.checksaleReturn.AutoSize = true;
            this.checksaleReturn.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checksaleReturn.Location = new System.Drawing.Point(58, 0);
            this.checksaleReturn.Name = "checksaleReturn";
            this.checksaleReturn.Size = new System.Drawing.Size(137, 32);
            this.checksaleReturn.TabIndex = 2;
            this.checksaleReturn.Text = "مرتجعات مبيعات";
            this.checksaleReturn.UseVisualStyleBackColor = true;
            // 
            // checkbuy
            // 
            this.checkbuy.AutoSize = true;
            this.checkbuy.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbuy.Location = new System.Drawing.Point(253, 29);
            this.checkbuy.Name = "checkbuy";
            this.checkbuy.Size = new System.Drawing.Size(140, 32);
            this.checkbuy.TabIndex = 1;
            this.checkbuy.Text = "فواتير المشتريات";
            this.checkbuy.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.ImageOptions.Image")));
            this.btn_search.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_search.Location = new System.Drawing.Point(932, 58);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(162, 45);
            this.btn_search.TabIndex = 14;
            this.btn_search.Text = "عرض التقرير";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(388, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 40);
            this.label2.TabIndex = 55;
            this.label2.Text = "الاقرار الضريبي في فتره محددة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(409, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 28);
            this.label4.TabIndex = 71;
            this.label4.Text = "اجمالي الفواتير:";
            // 
            // txttotal
            // 
            this.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotal.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(525, 392);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(82, 30);
            this.txttotal.TabIndex = 70;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(611, 394);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 28);
            this.label14.TabIndex = 69;
            this.label14.Text = "اجمال الضرائب:";
            // 
            // txttotaltax
            // 
            this.txttotaltax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotaltax.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotaltax.Location = new System.Drawing.Point(722, 392);
            this.txttotaltax.Name = "txttotaltax";
            this.txttotaltax.ReadOnly = true;
            this.txttotaltax.Size = new System.Drawing.Size(96, 30);
            this.txttotaltax.TabIndex = 68;
            this.txttotaltax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_printsummary
            // 
            this.btn_printsummary.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printsummary.Appearance.Options.UseFont = true;
            this.btn_printsummary.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_printsummary.ImageOptions.Image")));
            this.btn_printsummary.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_printsummary.Location = new System.Drawing.Point(277, 392);
            this.btn_printsummary.Name = "btn_printsummary";
            this.btn_printsummary.Size = new System.Drawing.Size(129, 34);
            this.btn_printsummary.TabIndex = 67;
            this.btn_printsummary.Text = "طباعة ملخص";
            this.btn_printsummary.Click += new System.EventHandler(this.btn_printsummary_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_delete.Location = new System.Drawing.Point(15, 392);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(132, 34);
            this.btn_delete.TabIndex = 66;
            this.btn_delete.Text = "مسح البيانات";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_printReport
            // 
            this.btn_printReport.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printReport.Appearance.Options.UseFont = true;
            this.btn_printReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_printReport.ImageOptions.Image")));
            this.btn_printReport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_printReport.Location = new System.Drawing.Point(153, 392);
            this.btn_printReport.Name = "btn_printReport";
            this.btn_printReport.Size = new System.Drawing.Size(118, 34);
            this.btn_printReport.TabIndex = 64;
            this.btn_printReport.Text = "طباعة تقرير";
            this.btn_printReport.Click += new System.EventHandler(this.btn_printReport_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_search.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_search.Location = new System.Drawing.Point(15, 116);
            this.Dgv_search.Name = "Dgv_search";
            this.Dgv_search.ReadOnly = true;
            this.Dgv_search.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_search.Size = new System.Drawing.Size(1079, 270);
            this.Dgv_search.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(825, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 28);
            this.label5.TabIndex = 73;
            this.label5.Text = "الاجمالي بعد الضرائب:";
            // 
            // txttotalaftertax
            // 
            this.txttotalaftertax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalaftertax.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalaftertax.Location = new System.Drawing.Point(981, 392);
            this.txttotalaftertax.Name = "txttotalaftertax";
            this.txttotalaftertax.ReadOnly = true;
            this.txttotalaftertax.Size = new System.Drawing.Size(113, 30);
            this.txttotalaftertax.TabIndex = 72;
            this.txttotalaftertax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_taxesReport
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1105, 435);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttotalaftertax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txttotaltax);
            this.Controls.Add(this.btn_printsummary);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_printReport);
            this.Controls.Add(this.Dgv_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = true;
            this.MaximizeBox = false;
            this.Name = "frm_taxesReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة الاقرار الضريبي";
            this.Load += new System.EventHandler(this.frm_taxesReport_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.CheckBox checksale;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkbuyReturn;
        private System.Windows.Forms.CheckBox checksaleReturn;
        private System.Windows.Forms.CheckBox checkbuy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txttotaltax;
        private DevExpress.XtraEditors.SimpleButton btn_printsummary;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_printReport;
        private System.Windows.Forms.DataGridView Dgv_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttotalaftertax;
    }
}