namespace sales
{
    partial class frm_BuyReporter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BuyReporter));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.rbtn_onesupplier = new System.Windows.Forms.RadioButton();
            this.rbtn_allsupplier = new System.Windows.Forms.RadioButton();
            this.cbx_supliers = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.txt_numberOrder = new System.Windows.Forms.TextBox();
            this.checkOrderNumber = new System.Windows.Forms.CheckBox();
            this.Dgv_search = new System.Windows.Forms.DataGridView();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_printAll = new DevExpress.XtraEditors.SimpleButton();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttotaltax = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(388, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 40);
            this.label2.TabIndex = 52;
            this.label2.Text = "تقارير المشتريات في فتره محدده";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.rbtn_onesupplier);
            this.groupBox1.Controls.Add(this.rbtn_allsupplier);
            this.groupBox1.Controls.Add(this.cbx_supliers);
            this.groupBox1.Location = new System.Drawing.Point(19, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 41);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // btn_search
            // 
            this.btn_search.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.ImageOptions.Image")));
            this.btn_search.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_search.Location = new System.Drawing.Point(6, 7);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(76, 34);
            this.btn_search.TabIndex = 14;
            this.btn_search.Text = "بحث";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // rbtn_onesupplier
            // 
            this.rbtn_onesupplier.AutoSize = true;
            this.rbtn_onesupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_onesupplier.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_onesupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_onesupplier.Location = new System.Drawing.Point(215, 9);
            this.rbtn_onesupplier.Name = "rbtn_onesupplier";
            this.rbtn_onesupplier.Size = new System.Drawing.Size(100, 32);
            this.rbtn_onesupplier.TabIndex = 2;
            this.rbtn_onesupplier.Text = "مورد محدد";
            this.rbtn_onesupplier.UseVisualStyleBackColor = false;
            // 
            // rbtn_allsupplier
            // 
            this.rbtn_allsupplier.AutoSize = true;
            this.rbtn_allsupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_allsupplier.Checked = true;
            this.rbtn_allsupplier.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_allsupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_allsupplier.Location = new System.Drawing.Point(321, 9);
            this.rbtn_allsupplier.Name = "rbtn_allsupplier";
            this.rbtn_allsupplier.Size = new System.Drawing.Size(109, 32);
            this.rbtn_allsupplier.TabIndex = 1;
            this.rbtn_allsupplier.TabStop = true;
            this.rbtn_allsupplier.Text = "كل الموردين";
            this.rbtn_allsupplier.UseVisualStyleBackColor = false;
            // 
            // cbx_supliers
            // 
            this.cbx_supliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_supliers.FormattingEnabled = true;
            this.cbx_supliers.Location = new System.Drawing.Point(88, 9);
            this.cbx_supliers.Name = "cbx_supliers";
            this.cbx_supliers.Size = new System.Drawing.Size(121, 32);
            this.cbx_supliers.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtp_to);
            this.groupBox2.Controls.Add(this.dtp_from);
            this.groupBox2.Controls.Add(this.txt_numberOrder);
            this.groupBox2.Controls.Add(this.checkOrderNumber);
            this.groupBox2.Location = new System.Drawing.Point(525, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 41);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(133, 9);
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
            this.label1.Location = new System.Drawing.Point(292, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "من:";
            // 
            // dtp_to
            // 
            this.dtp_to.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_to.Location = new System.Drawing.Point(27, 10);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_to.Size = new System.Drawing.Size(100, 26);
            this.dtp_to.TabIndex = 8;
            this.dtp_to.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // dtp_from
            // 
            this.dtp_from.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_from.Location = new System.Drawing.Point(179, 9);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_from.Size = new System.Drawing.Size(107, 26);
            this.dtp_from.TabIndex = 7;
            this.dtp_from.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // txt_numberOrder
            // 
            this.txt_numberOrder.Location = new System.Drawing.Point(334, 9);
            this.txt_numberOrder.Multiline = true;
            this.txt_numberOrder.Name = "txt_numberOrder";
            this.txt_numberOrder.Size = new System.Drawing.Size(38, 30);
            this.txt_numberOrder.TabIndex = 1;
            this.txt_numberOrder.Text = "1";
            this.txt_numberOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkOrderNumber
            // 
            this.checkOrderNumber.AutoSize = true;
            this.checkOrderNumber.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOrderNumber.Location = new System.Drawing.Point(372, 6);
            this.checkOrderNumber.Name = "checkOrderNumber";
            this.checkOrderNumber.Size = new System.Drawing.Size(111, 32);
            this.checkOrderNumber.TabIndex = 0;
            this.checkOrderNumber.Text = "رقم الفاتوره";
            this.checkOrderNumber.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_search.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_search.Location = new System.Drawing.Point(19, 99);
            this.Dgv_search.Name = "Dgv_search";
            this.Dgv_search.ReadOnly = true;
            this.Dgv_search.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_search.Size = new System.Drawing.Size(1002, 270);
            this.Dgv_search.TabIndex = 56;
            // 
            // btn_print
            // 
            this.btn_print.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Appearance.Options.UseFont = true;
            this.btn_print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_print.ImageOptions.Image")));
            this.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_print.Location = new System.Drawing.Point(13, 384);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(148, 34);
            this.btn_print.TabIndex = 15;
            this.btn_print.Text = "طباعة الفاتوره";
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click_1);
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_delete.Location = new System.Drawing.Point(167, 385);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(138, 34);
            this.btn_delete.TabIndex = 58;
            this.btn_delete.Text = "مسح الفاتوره";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_printAll
            // 
            this.btn_printAll.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printAll.Appearance.Options.UseFont = true;
            this.btn_printAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_printAll.ImageOptions.Image")));
            this.btn_printAll.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_printAll.Location = new System.Drawing.Point(311, 384);
            this.btn_printAll.Name = "btn_printAll";
            this.btn_printAll.Size = new System.Drawing.Size(178, 34);
            this.btn_printAll.TabIndex = 59;
            this.btn_printAll.Text = "طباعة كل الفواتير";
            this.btn_printAll.Click += new System.EventHandler(this.btn_printAll_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(739, 379);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 28);
            this.label14.TabIndex = 61;
            this.label14.Text = "اجمال مبالغ المشتريات:";
            // 
            // txt_total
            // 
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_total.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(908, 375);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(113, 36);
            this.txt_total.TabIndex = 60;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(693, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 28);
            this.label4.TabIndex = 63;
            this.label4.Text = "اجمالي الضرائب علي العمليات:";
            // 
            // txttotaltax
            // 
            this.txttotaltax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotaltax.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotaltax.Location = new System.Drawing.Point(908, 427);
            this.txttotaltax.Name = "txttotaltax";
            this.txttotaltax.Size = new System.Drawing.Size(113, 36);
            this.txttotaltax.TabIndex = 62;
            this.txttotaltax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_BuyReporter
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1032, 482);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttotaltax);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.btn_printAll);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.Dgv_search);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_BuyReporter";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير المشتريات";
            this.Load += new System.EventHandler(this.frm_BuyReporter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.RadioButton rbtn_onesupplier;
        private System.Windows.Forms.RadioButton rbtn_allsupplier;
        private System.Windows.Forms.ComboBox cbx_supliers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_numberOrder;
        private System.Windows.Forms.CheckBox checkOrderNumber;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btn_print;
        private System.Windows.Forms.DataGridView Dgv_search;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_printAll;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttotaltax;
    }
}