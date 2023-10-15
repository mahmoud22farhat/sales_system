namespace sales
{
    partial class frm_customerReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_customerReport));
            this.Dgv_search = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_enter = new DevExpress.XtraEditors.SimpleButton();
            this.rbtn_onecustomer = new System.Windows.Forms.RadioButton();
            this.rbtn_allcustomer = new System.Windows.Forms.RadioButton();
            this.cbx_customer = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_pay = new DevExpress.XtraEditors.SimpleButton();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.Dgv_search.Location = new System.Drawing.Point(12, 140);
            this.Dgv_search.Name = "Dgv_search";
            this.Dgv_search.ReadOnly = true;
            this.Dgv_search.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_search.Size = new System.Drawing.Size(674, 270);
            this.Dgv_search.TabIndex = 63;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(516, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 38);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(516, 32);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_date.Size = new System.Drawing.Size(134, 26);
            this.dtp_date.TabIndex = 61;
            this.dtp_date.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_enter);
            this.groupBox1.Controls.Add(this.rbtn_onecustomer);
            this.groupBox1.Controls.Add(this.rbtn_allcustomer);
            this.groupBox1.Controls.Add(this.cbx_customer);
            this.groupBox1.Location = new System.Drawing.Point(39, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 57);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            // 
            // btn_enter
            // 
            this.btn_enter.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.Appearance.Options.UseFont = true;
            this.btn_enter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_enter.ImageOptions.Image")));
            this.btn_enter.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_enter.Location = new System.Drawing.Point(114, 18);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(122, 34);
            this.btn_enter.TabIndex = 14;
            this.btn_enter.Text = "بحث";
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // rbtn_onecustomer
            // 
            this.rbtn_onecustomer.AutoSize = true;
            this.rbtn_onecustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_onecustomer.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_onecustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_onecustomer.Location = new System.Drawing.Point(382, 19);
            this.rbtn_onecustomer.Name = "rbtn_onecustomer";
            this.rbtn_onecustomer.Size = new System.Drawing.Size(87, 29);
            this.rbtn_onecustomer.TabIndex = 2;
            this.rbtn_onecustomer.Text = "مورد محدد";
            this.rbtn_onecustomer.UseVisualStyleBackColor = false;
            // 
            // rbtn_allcustomer
            // 
            this.rbtn_allcustomer.AutoSize = true;
            this.rbtn_allcustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_allcustomer.Checked = true;
            this.rbtn_allcustomer.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_allcustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_allcustomer.Location = new System.Drawing.Point(512, 22);
            this.rbtn_allcustomer.Name = "rbtn_allcustomer";
            this.rbtn_allcustomer.Size = new System.Drawing.Size(98, 29);
            this.rbtn_allcustomer.TabIndex = 1;
            this.rbtn_allcustomer.TabStop = true;
            this.rbtn_allcustomer.Text = "كل الموردين";
            this.rbtn_allcustomer.UseVisualStyleBackColor = false;
            // 
            // cbx_customer
            // 
            this.cbx_customer.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_customer.FormattingEnabled = true;
            this.cbx_customer.Location = new System.Drawing.Point(245, 18);
            this.cbx_customer.Name = "cbx_customer";
            this.cbx_customer.Size = new System.Drawing.Size(121, 33);
            this.cbx_customer.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_pay);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txt_total);
            this.groupBox2.Location = new System.Drawing.Point(12, 419);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(673, 38);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            // 
            // btn_pay
            // 
            this.btn_pay.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.Appearance.Options.UseFont = true;
            this.btn_pay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_pay.ImageOptions.Image")));
            this.btn_pay.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_pay.Location = new System.Drawing.Point(531, 2);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(142, 34);
            this.btn_pay.TabIndex = 15;
            this.btn_pay.Text = "مسح البيانات";
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(120, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 25);
            this.label14.TabIndex = 57;
            this.label14.Text = "اجمال المبالغ المسدده :";
            // 
            // txt_total
            // 
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_total.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(1, 0);
            this.txt_total.Multiline = true;
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(113, 32);
            this.txt_total.TabIndex = 56;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(194, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 36);
            this.label2.TabIndex = 59;
            this.label2.Text = "المبالغ المتبقه للعملاء";
            // 
            // frm_customerReport
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(687, 458);
            this.Controls.Add(this.Dgv_search);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "frm_customerReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير العملاء";
            this.Load += new System.EventHandler(this.frm_customerReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btn_enter;
        private System.Windows.Forms.RadioButton rbtn_onecustomer;
        private System.Windows.Forms.RadioButton rbtn_allcustomer;
        private System.Windows.Forms.ComboBox cbx_customer;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btn_pay;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label2;
    }
}