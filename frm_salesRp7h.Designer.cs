namespace sales
{
    partial class frm_salesRp7h
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_salesRp7h));
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_search = new System.Windows.Forms.DataGridView();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_printOrederall = new DevExpress.XtraEditors.SimpleButton();
            this.cbx_user = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_oneuser = new System.Windows.Forms.RadioButton();
            this.rbtn_alluser = new System.Windows.Forms.RadioButton();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_numberOrder = new System.Windows.Forms.TextBox();
            this.checkOrderNumber = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_totalRp7h = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(886, 18);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_date.Size = new System.Drawing.Size(134, 26);
            this.dtp_date.TabIndex = 80;
            this.dtp_date.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(397, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 36);
            this.label2.TabIndex = 74;
            this.label2.Text = "تقارير ارباح المبيعات في فتره محدده";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_search.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_search.Location = new System.Drawing.Point(40, 125);
            this.Dgv_search.Name = "Dgv_search";
            this.Dgv_search.ReadOnly = true;
            this.Dgv_search.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_search.Size = new System.Drawing.Size(1002, 289);
            this.Dgv_search.TabIndex = 77;
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_delete.Location = new System.Drawing.Point(6, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(244, 30);
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
            this.btn_printOrederall.Location = new System.Drawing.Point(256, 3);
            this.btn_printOrederall.Name = "btn_printOrederall";
            this.btn_printOrederall.Size = new System.Drawing.Size(171, 30);
            this.btn_printOrederall.TabIndex = 71;
            this.btn_printOrederall.Text = "طباعة تقرير مفصل";
            this.btn_printOrederall.Click += new System.EventHandler(this.btn_printOrederall_Click);
            // 
            // cbx_user
            // 
            this.cbx_user.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.cbx_user.FormattingEnabled = true;
            this.cbx_user.Location = new System.Drawing.Point(448, 4);
            this.cbx_user.Name = "cbx_user";
            this.cbx_user.Size = new System.Drawing.Size(121, 33);
            this.cbx_user.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.btn_printOrederall);
            this.groupBox1.Controls.Add(this.rbtn_oneuser);
            this.groupBox1.Controls.Add(this.rbtn_alluser);
            this.groupBox1.Controls.Add(this.cbx_user);
            this.groupBox1.Location = new System.Drawing.Point(40, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 40);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            // 
            // rbtn_oneuser
            // 
            this.rbtn_oneuser.AutoSize = true;
            this.rbtn_oneuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_oneuser.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.rbtn_oneuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_oneuser.Location = new System.Drawing.Point(575, 5);
            this.rbtn_oneuser.Name = "rbtn_oneuser";
            this.rbtn_oneuser.Size = new System.Drawing.Size(108, 29);
            this.rbtn_oneuser.TabIndex = 2;
            this.rbtn_oneuser.Text = "مستخدم محدد";
            this.rbtn_oneuser.UseVisualStyleBackColor = false;
            // 
            // rbtn_alluser
            // 
            this.rbtn_alluser.AutoSize = true;
            this.rbtn_alluser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_alluser.Checked = true;
            this.rbtn_alluser.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.rbtn_alluser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_alluser.Location = new System.Drawing.Point(682, 5);
            this.rbtn_alluser.Name = "rbtn_alluser";
            this.rbtn_alluser.Size = new System.Drawing.Size(118, 29);
            this.rbtn_alluser.TabIndex = 1;
            this.rbtn_alluser.TabStop = true;
            this.rbtn_alluser.Text = "كل المستخدمين";
            this.rbtn_alluser.UseVisualStyleBackColor = false;
            // 
            // btn_search
            // 
            this.btn_search.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.ImageOptions.Image")));
            this.btn_search.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_search.Location = new System.Drawing.Point(6, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(178, 29);
            this.btn_search.TabIndex = 15;
            this.btn_search.Text = "بحث";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(499, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "من :";
            // 
            // dtp_to
            // 
            this.dtp_to.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_to.Location = new System.Drawing.Point(215, 5);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_to.Size = new System.Drawing.Size(100, 32);
            this.dtp_to.TabIndex = 8;
            this.dtp_to.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // dtp_from
            // 
            this.dtp_from.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_from.Location = new System.Drawing.Point(386, 5);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_from.Size = new System.Drawing.Size(107, 32);
            this.dtp_from.TabIndex = 7;
            this.dtp_from.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
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
            this.groupBox2.Location = new System.Drawing.Point(37, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(696, 39);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(334, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "الي :";
            // 
            // txt_numberOrder
            // 
            this.txt_numberOrder.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.txt_numberOrder.Location = new System.Drawing.Point(538, 2);
            this.txt_numberOrder.Name = "txt_numberOrder";
            this.txt_numberOrder.Size = new System.Drawing.Size(49, 32);
            this.txt_numberOrder.TabIndex = 1;
            this.txt_numberOrder.Text = "1";
            this.txt_numberOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkOrderNumber
            // 
            this.checkOrderNumber.AutoSize = true;
            this.checkOrderNumber.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.checkOrderNumber.Location = new System.Drawing.Point(592, 2);
            this.checkOrderNumber.Name = "checkOrderNumber";
            this.checkOrderNumber.Size = new System.Drawing.Size(100, 29);
            this.checkOrderNumber.TabIndex = 0;
            this.checkOrderNumber.Text = "رقم الفاتوره";
            this.checkOrderNumber.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(125, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 25);
            this.label14.TabIndex = 79;
            this.label14.Text = "اجمال مبالغ المبيعات :";
            // 
            // txt_total
            // 
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_total.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.txt_total.Location = new System.Drawing.Point(6, 12);
            this.txt_total.Multiline = true;
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(113, 32);
            this.txt_total.TabIndex = 78;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_totalRp7h);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_total);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(45, 425);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(997, 53);
            this.groupBox3.TabIndex = 77;
            this.groupBox3.TabStop = false;
            // 
            // txt_totalRp7h
            // 
            this.txt_totalRp7h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_totalRp7h.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.txt_totalRp7h.Location = new System.Drawing.Point(630, 5);
            this.txt_totalRp7h.Multiline = true;
            this.txt_totalRp7h.Name = "txt_totalRp7h";
            this.txt_totalRp7h.Size = new System.Drawing.Size(113, 32);
            this.txt_totalRp7h.TabIndex = 80;
            this.txt_totalRp7h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(749, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 25);
            this.label4.TabIndex = 81;
            this.label4.Text = "اجمالي ارباح المبيعات في الفتره المحدده :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(880, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 38);
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // frm_salesRp7h
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1042, 490);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dgv_search);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_salesRp7h";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير ارباح المبيعات";
            this.Load += new System.EventHandler(this.frm_salesRp7h_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_search;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_printOrederall;
        private System.Windows.Forms.ComboBox cbx_user;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_oneuser;
        private System.Windows.Forms.RadioButton rbtn_alluser;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_numberOrder;
        private System.Windows.Forms.CheckBox checkOrderNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_totalRp7h;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}