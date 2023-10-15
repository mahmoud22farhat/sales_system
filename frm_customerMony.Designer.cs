namespace sales
{
    partial class frm_customerMony
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_customerMony));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_pay = new DevExpress.XtraEditors.SimpleButton();
            this.nud_price = new System.Windows.Forms.NumericUpDown();
            this.rbtn_paypart = new System.Windows.Forms.RadioButton();
            this.rbtn_payall = new System.Windows.Forms.RadioButton();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.cbx_customer = new System.Windows.Forms.ComboBox();
            this.Dgv_search = new System.Windows.Forms.DataGridView();
            this.rbtn_onecust = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_enter = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_allcust = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 38);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // btn_pay
            // 
            this.btn_pay.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.Appearance.Options.UseFont = true;
            this.btn_pay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_pay.ImageOptions.Image")));
            this.btn_pay.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_pay.Location = new System.Drawing.Point(0, 0);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(127, 34);
            this.btn_pay.TabIndex = 15;
            this.btn_pay.Text = "تسديد المحدد";
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // nud_price
            // 
            this.nud_price.DecimalPlaces = 2;
            this.nud_price.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_price.Location = new System.Drawing.Point(139, 0);
            this.nud_price.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nud_price.Name = "nud_price";
            this.nud_price.Size = new System.Drawing.Size(115, 32);
            this.nud_price.TabIndex = 5;
            this.nud_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbtn_paypart
            // 
            this.rbtn_paypart.AutoSize = true;
            this.rbtn_paypart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.rbtn_paypart.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_paypart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_paypart.Location = new System.Drawing.Point(260, 0);
            this.rbtn_paypart.Name = "rbtn_paypart";
            this.rbtn_paypart.Size = new System.Drawing.Size(112, 29);
            this.rbtn_paypart.TabIndex = 4;
            this.rbtn_paypart.Text = "تسديد جزء منه";
            this.rbtn_paypart.UseVisualStyleBackColor = false;
            // 
            // rbtn_payall
            // 
            this.rbtn_payall.AutoSize = true;
            this.rbtn_payall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.rbtn_payall.Checked = true;
            this.rbtn_payall.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_payall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_payall.Location = new System.Drawing.Point(390, 3);
            this.rbtn_payall.Name = "rbtn_payall";
            this.rbtn_payall.Size = new System.Drawing.Size(133, 29);
            this.rbtn_payall.TabIndex = 3;
            this.rbtn_payall.TabStop = true;
            this.rbtn_payall.Text = "تسديد المبلغ كامل";
            this.rbtn_payall.UseVisualStyleBackColor = false;
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(25, 10);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_date.Size = new System.Drawing.Size(134, 26);
            this.dtp_date.TabIndex = 53;
            this.dtp_date.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // cbx_customer
            // 
            this.cbx_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_customer.FormattingEnabled = true;
            this.cbx_customer.Location = new System.Drawing.Point(416, 24);
            this.cbx_customer.Name = "cbx_customer";
            this.cbx_customer.Size = new System.Drawing.Size(121, 32);
            this.cbx_customer.TabIndex = 0;
            // 
            // Dgv_search
            // 
            this.Dgv_search.AllowUserToAddRows = false;
            this.Dgv_search.AllowUserToDeleteRows = false;
            this.Dgv_search.AllowUserToResizeColumns = false;
            this.Dgv_search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.Dgv_search.Location = new System.Drawing.Point(37, 119);
            this.Dgv_search.Name = "Dgv_search";
            this.Dgv_search.ReadOnly = true;
            this.Dgv_search.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_search.Size = new System.Drawing.Size(794, 262);
            this.Dgv_search.TabIndex = 57;
            // 
            // rbtn_onecust
            // 
            this.rbtn_onecust.AutoSize = true;
            this.rbtn_onecust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_onecust.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_onecust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_onecust.Location = new System.Drawing.Point(553, 25);
            this.rbtn_onecust.Name = "rbtn_onecust";
            this.rbtn_onecust.Size = new System.Drawing.Size(91, 29);
            this.rbtn_onecust.TabIndex = 2;
            this.rbtn_onecust.Text = "عميل محدد";
            this.rbtn_onecust.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_pay);
            this.groupBox2.Controls.Add(this.nud_price);
            this.groupBox2.Controls.Add(this.rbtn_paypart);
            this.groupBox2.Controls.Add(this.rbtn_payall);
            this.groupBox2.Location = new System.Drawing.Point(37, 401);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 44);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            // 
            // txt_total
            // 
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_total.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(636, 401);
            this.txt_total.Multiline = true;
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(180, 32);
            this.txt_total.TabIndex = 54;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.simpleButton1.Location = new System.Drawing.Point(19, 18);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(200, 35);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "طباعة تقرير مفصل";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.Appearance.Options.UseFont = true;
            this.btn_enter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_enter.ImageOptions.Image")));
            this.btn_enter.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_enter.Location = new System.Drawing.Point(225, 19);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(174, 34);
            this.btn_enter.TabIndex = 14;
            this.btn_enter.Text = "بحث";
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.btn_enter);
            this.groupBox1.Controls.Add(this.rbtn_onecust);
            this.groupBox1.Controls.Add(this.rbtn_allcust);
            this.groupBox1.Controls.Add(this.cbx_customer);
            this.groupBox1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 353);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // rbtn_allcust
            // 
            this.rbtn_allcust.AutoSize = true;
            this.rbtn_allcust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_allcust.Checked = true;
            this.rbtn_allcust.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_allcust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_allcust.Location = new System.Drawing.Point(683, 28);
            this.rbtn_allcust.Name = "rbtn_allcust";
            this.rbtn_allcust.Size = new System.Drawing.Size(89, 29);
            this.rbtn_allcust.TabIndex = 1;
            this.rbtn_allcust.TabStop = true;
            this.rbtn_allcust.Text = "كل العملاء";
            this.rbtn_allcust.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(319, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 36);
            this.label2.TabIndex = 51;
            this.label2.Text = "المبالغ المتبقه علي العملاء -أجل";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(545, 407);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 25);
            this.label14.TabIndex = 55;
            this.label14.Text = "اجمالي المبالغ :";
            // 
            // frm_customerMony
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.Dgv_search);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frm_customerMony";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المبالغ المتبقه علي العملاء -أجل";
            this.Load += new System.EventHandler(this.frm_customerMony_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btn_pay;
        private System.Windows.Forms.NumericUpDown nud_price;
        private System.Windows.Forms.RadioButton rbtn_paypart;
        private System.Windows.Forms.RadioButton rbtn_payall;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.ComboBox cbx_customer;
        private System.Windows.Forms.DataGridView Dgv_search;
        private System.Windows.Forms.RadioButton rbtn_onecust;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_total;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_enter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_allcust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
    }
}