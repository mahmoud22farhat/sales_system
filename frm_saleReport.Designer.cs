namespace sales
{
    partial class frm_saleReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_saleReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_orderprint = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.txt_numberOrder = new System.Windows.Forms.TextBox();
            this.checkOrderNumber = new System.Windows.Forms.CheckBox();
            this.rbtn_oneuser = new System.Windows.Forms.RadioButton();
            this.rbtn_alluser = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_printOrederall = new DevExpress.XtraEditors.SimpleButton();
            this.cbx_user = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_search = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_totaltax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pricetax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_userrep7h = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(17, 418);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 31);
            this.label14.TabIndex = 70;
            this.label14.Text = "اجمالي مبلغ المبيعات:";
            // 
            // txt_total
            // 
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_total.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(189, 417);
            this.txt_total.Multiline = true;
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(113, 32);
            this.txt_total.TabIndex = 69;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_orderprint
            // 
            this.btn_orderprint.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F);
            this.btn_orderprint.Appearance.Options.UseFont = true;
            this.btn_orderprint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_orderprint.ImageOptions.Image")));
            this.btn_orderprint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_orderprint.Location = new System.Drawing.Point(5, 469);
            this.btn_orderprint.Name = "btn_orderprint";
            this.btn_orderprint.Size = new System.Drawing.Size(213, 34);
            this.btn_orderprint.TabIndex = 62;
            this.btn_orderprint.Text = "طباعة الفاتوره المحدده";
            this.btn_orderprint.Click += new System.EventHandler(this.btn_orderprint_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(419, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "الي :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtp_to);
            this.groupBox2.Controls.Add(this.dtp_from);
            this.groupBox2.Controls.Add(this.txt_numberOrder);
            this.groupBox2.Controls.Add(this.checkOrderNumber);
            this.groupBox2.Location = new System.Drawing.Point(2, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(905, 39);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            // 
            // btn_search
            // 
            this.btn_search.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.ImageOptions.Image")));
            this.btn_search.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_search.Location = new System.Drawing.Point(54, 1);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(178, 29);
            this.btn_search.TabIndex = 15;
            this.btn_search.Text = "بحث";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(614, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "من :";
            // 
            // dtp_to
            // 
            this.dtp_to.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_to.Location = new System.Drawing.Point(307, 1);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_to.Size = new System.Drawing.Size(106, 32);
            this.dtp_to.TabIndex = 8;
            this.dtp_to.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // dtp_from
            // 
            this.dtp_from.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_from.Location = new System.Drawing.Point(501, 1);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_from.Size = new System.Drawing.Size(107, 32);
            this.dtp_from.TabIndex = 7;
            this.dtp_from.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // txt_numberOrder
            // 
            this.txt_numberOrder.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numberOrder.Location = new System.Drawing.Point(664, 3);
            this.txt_numberOrder.Name = "txt_numberOrder";
            this.txt_numberOrder.Size = new System.Drawing.Size(45, 32);
            this.txt_numberOrder.TabIndex = 1;
            this.txt_numberOrder.Text = "1";
            this.txt_numberOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkOrderNumber
            // 
            this.checkOrderNumber.AutoSize = true;
            this.checkOrderNumber.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOrderNumber.Location = new System.Drawing.Point(715, 3);
            this.checkOrderNumber.Name = "checkOrderNumber";
            this.checkOrderNumber.Size = new System.Drawing.Size(111, 32);
            this.checkOrderNumber.TabIndex = 0;
            this.checkOrderNumber.Text = "رقم الفاتوره";
            this.checkOrderNumber.UseVisualStyleBackColor = true;
            // 
            // rbtn_oneuser
            // 
            this.rbtn_oneuser.AutoSize = true;
            this.rbtn_oneuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_oneuser.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_oneuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_oneuser.Location = new System.Drawing.Point(628, 3);
            this.rbtn_oneuser.Name = "rbtn_oneuser";
            this.rbtn_oneuser.Size = new System.Drawing.Size(127, 32);
            this.rbtn_oneuser.TabIndex = 2;
            this.rbtn_oneuser.Text = "مستخدم محدد";
            this.rbtn_oneuser.UseVisualStyleBackColor = false;
            // 
            // rbtn_alluser
            // 
            this.rbtn_alluser.AutoSize = true;
            this.rbtn_alluser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_alluser.Checked = true;
            this.rbtn_alluser.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_alluser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_alluser.Location = new System.Drawing.Point(761, 2);
            this.rbtn_alluser.Name = "rbtn_alluser";
            this.rbtn_alluser.Size = new System.Drawing.Size(135, 32);
            this.rbtn_alluser.TabIndex = 1;
            this.rbtn_alluser.TabStop = true;
            this.rbtn_alluser.Text = "كل المستخدمين";
            this.rbtn_alluser.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_printOrederall);
            this.groupBox1.Controls.Add(this.rbtn_oneuser);
            this.groupBox1.Controls.Add(this.rbtn_alluser);
            this.groupBox1.Controls.Add(this.cbx_user);
            this.groupBox1.Location = new System.Drawing.Point(5, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(902, 40);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F);
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_delete.Location = new System.Drawing.Point(39, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(262, 30);
            this.btn_delete.TabIndex = 71;
            this.btn_delete.Text = "مسح البيانات في هذه الفتره";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_printOrederall
            // 
            this.btn_printOrederall.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printOrederall.Appearance.Options.UseFont = true;
            this.btn_printOrederall.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_printOrederall.ImageOptions.Image")));
            this.btn_printOrederall.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_printOrederall.Location = new System.Drawing.Point(307, 4);
            this.btn_printOrederall.Name = "btn_printOrederall";
            this.btn_printOrederall.Size = new System.Drawing.Size(188, 30);
            this.btn_printOrederall.TabIndex = 71;
            this.btn_printOrederall.Text = "طباعة تقرير مفصل";
            this.btn_printOrederall.Click += new System.EventHandler(this.btn_printOrederall_Click);
            // 
            // cbx_user
            // 
            this.cbx_user.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_user.FormattingEnabled = true;
            this.cbx_user.Location = new System.Drawing.Point(501, 3);
            this.cbx_user.Name = "cbx_user";
            this.cbx_user.Size = new System.Drawing.Size(121, 36);
            this.cbx_user.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(364, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 40);
            this.label2.TabIndex = 63;
            this.label2.Text = "تقارير المبيعات في فتره محدده";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_search.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_search.Location = new System.Drawing.Point(5, 156);
            this.Dgv_search.Name = "Dgv_search";
            this.Dgv_search.ReadOnly = true;
            this.Dgv_search.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_search.Size = new System.Drawing.Size(938, 256);
            this.Dgv_search.TabIndex = 66;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(746, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 38);
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(752, 12);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_date.Size = new System.Drawing.Size(134, 26);
            this.dtp_date.TabIndex = 71;
            this.dtp_date.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(344, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 31);
            this.label4.TabIndex = 74;
            this.label4.Text = "اجمالي الضريبة:";
            // 
            // txt_totaltax
            // 
            this.txt_totaltax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_totaltax.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totaltax.Location = new System.Drawing.Point(474, 418);
            this.txt_totaltax.Multiline = true;
            this.txt_totaltax.Name = "txt_totaltax";
            this.txt_totaltax.Size = new System.Drawing.Size(113, 32);
            this.txt_totaltax.TabIndex = 73;
            this.txt_totaltax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(635, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 31);
            this.label5.TabIndex = 76;
            this.label5.Text = "اجمالي البيع بعد الضريبة:";
            // 
            // txt_pricetax
            // 
            this.txt_pricetax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pricetax.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pricetax.Location = new System.Drawing.Point(830, 418);
            this.txt_pricetax.Multiline = true;
            this.txt_pricetax.Name = "txt_pricetax";
            this.txt_pricetax.Size = new System.Drawing.Size(113, 32);
            this.txt_pricetax.TabIndex = 75;
            this.txt_pricetax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(231, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 31);
            this.label6.TabIndex = 78;
            this.label6.Text = "اجمالي نسبة الربح للبائع المحدد:";
            // 
            // txt_userrep7h
            // 
            this.txt_userrep7h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_userrep7h.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userrep7h.Location = new System.Drawing.Point(474, 468);
            this.txt_userrep7h.Multiline = true;
            this.txt_userrep7h.Name = "txt_userrep7h";
            this.txt_userrep7h.Size = new System.Drawing.Size(113, 32);
            this.txt_userrep7h.TabIndex = 77;
            this.txt_userrep7h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(593, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 31);
            this.label7.TabIndex = 79;
            this.label7.Text = "%";
            // 
            // frm_saleReport
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(946, 517);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_userrep7h);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_pricetax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_totaltax);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.btn_orderprint);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dgv_search);
            this.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "frm_saleReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة تقارير ارباح المبيعات";
            this.Load += new System.EventHandler(this.frm_saleReport_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_total;
        private DevExpress.XtraEditors.SimpleButton btn_orderprint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.TextBox txt_numberOrder;
        private System.Windows.Forms.CheckBox checkOrderNumber;
        private System.Windows.Forms.RadioButton rbtn_oneuser;
        private System.Windows.Forms.RadioButton rbtn_alluser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbx_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_search;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_printOrederall;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_totaltax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pricetax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_userrep7h;
        private System.Windows.Forms.Label label7;
    }
}