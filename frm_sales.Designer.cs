namespace sales
{
    partial class frm_sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sales));
            this.rbtncust_agel = new System.Windows.Forms.RadioButton();
            this.rbtnCust_cash = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.lbl_itemscount = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Dgv_sale = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.btn_deleteitems = new DevExpress.XtraEditors.SimpleButton();
            this.btn_items = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_items = new System.Windows.Forms.ComboBox();
            this.btn_customerbrouse = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_customer = new System.Windows.Forms.ComboBox();
            this.txt_parcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_customer = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Dtp_reminder = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtp_time = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_sale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtncust_agel
            // 
            this.rbtncust_agel.AutoSize = true;
            this.rbtncust_agel.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.rbtncust_agel.Location = new System.Drawing.Point(352, 3);
            this.rbtncust_agel.Name = "rbtncust_agel";
            this.rbtncust_agel.Size = new System.Drawing.Size(84, 29);
            this.rbtncust_agel.TabIndex = 75;
            this.rbtncust_agel.Text = "عميل اجل";
            this.rbtncust_agel.UseVisualStyleBackColor = true;
            this.rbtncust_agel.CheckedChanged += new System.EventHandler(this.rbtncust_agel_CheckedChanged);
            // 
            // rbtnCust_cash
            // 
            this.rbtnCust_cash.AutoSize = true;
            this.rbtnCust_cash.Checked = true;
            this.rbtnCust_cash.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.rbtnCust_cash.Location = new System.Drawing.Point(239, 4);
            this.rbtnCust_cash.Name = "rbtnCust_cash";
            this.rbtnCust_cash.Size = new System.Drawing.Size(93, 29);
            this.rbtnCust_cash.TabIndex = 74;
            this.rbtnCust_cash.TabStop = true;
            this.rbtnCust_cash.Text = "عميل نقدي";
            this.rbtnCust_cash.UseVisualStyleBackColor = true;
            this.rbtnCust_cash.CheckedChanged += new System.EventHandler(this.rbtnCust_cash_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(853, 538);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 28);
            this.label14.TabIndex = 73;
            this.label14.Text = "اجمالي المطلوب:";
            // 
            // txt_total
            // 
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_total.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.txt_total.Location = new System.Drawing.Point(983, 527);
            this.txt_total.Multiline = true;
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(180, 52);
            this.txt_total.TabIndex = 72;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_itemscount
            // 
            this.lbl_itemscount.AutoSize = true;
            this.lbl_itemscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_itemscount.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemscount.ForeColor = System.Drawing.Color.Black;
            this.lbl_itemscount.Location = new System.Drawing.Point(340, 527);
            this.lbl_itemscount.Name = "lbl_itemscount";
            this.lbl_itemscount.Size = new System.Drawing.Size(32, 30);
            this.lbl_itemscount.TabIndex = 71;
            this.lbl_itemscount.Text = "---";
            this.lbl_itemscount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_username.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.Black;
            this.lbl_username.Location = new System.Drawing.Point(130, 527);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(32, 30);
            this.lbl_username.TabIndex = 70;
            this.lbl_username.Text = "---";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(239, 527);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 30);
            this.label11.TabIndex = 69;
            this.label11.Text = "عدد الاصناف";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(12, 527);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 30);
            this.label10.TabIndex = 68;
            this.label10.Text = "اسم المستخدم";
            // 
            // Dgv_sale
            // 
            this.Dgv_sale.AllowUserToAddRows = false;
            this.Dgv_sale.AllowUserToDeleteRows = false;
            this.Dgv_sale.AllowUserToResizeColumns = false;
            this.Dgv_sale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_sale.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_sale.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dgv_sale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_sale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_sale.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_sale.Location = new System.Drawing.Point(3, 109);
            this.Dgv_sale.Name = "Dgv_sale";
            this.Dgv_sale.ReadOnly = true;
            this.Dgv_sale.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.Dgv_sale.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Dgv_sale.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.Dgv_sale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_sale.Size = new System.Drawing.Size(1160, 412);
            this.Dgv_sale.TabIndex = 67;
            this.Dgv_sale.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_sale_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "رقم المنتج";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 70F;
            this.Column2.HeaderText = "اسم المنتج";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 40F;
            this.Column7.HeaderText = "الوحدة";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 40F;
            this.Column3.HeaderText = "الكمية";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 60F;
            this.Column4.HeaderText = "السعر شامل الضريبة";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 40F;
            this.Column5.HeaderText = "الخصم";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.FillWeight = 60F;
            this.Column6.HeaderText = "الاجمالي";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label9.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(858, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(287, 30);
            this.label9.TabIndex = 66;
            this.label9.Text = "لتعديل الكميه او الخصم استخدم F11     \r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(858, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(296, 30);
            this.label8.TabIndex = 65;
            this.label8.Text = " لدفع وحفظ وطباعة الفاتوره استخدم F12";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(204, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 20);
            this.label7.TabIndex = 64;
            this.label7.Text = "f1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(611, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 27);
            this.label4.TabIndex = 63;
            this.label4.Text = "delete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(506, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 27);
            this.label3.TabIndex = 62;
            this.label3.Text = "f2";
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(688, 68);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_date.Size = new System.Drawing.Size(134, 32);
            this.dtp_date.TabIndex = 61;
            this.dtp_date.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // btn_deleteitems
            // 
            this.btn_deleteitems.Appearance.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteitems.Appearance.Options.UseFont = true;
            this.btn_deleteitems.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteitems.ImageOptions.Image")));
            this.btn_deleteitems.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_deleteitems.Location = new System.Drawing.Point(555, 68);
            this.btn_deleteitems.Name = "btn_deleteitems";
            this.btn_deleteitems.Size = new System.Drawing.Size(51, 27);
            this.btn_deleteitems.TabIndex = 60;
            this.btn_deleteitems.Click += new System.EventHandler(this.btn_deleteitems_Click);
            // 
            // btn_items
            // 
            this.btn_items.Appearance.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_items.Appearance.Options.UseFont = true;
            this.btn_items.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_items.ImageOptions.Image")));
            this.btn_items.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_items.Location = new System.Drawing.Point(449, 69);
            this.btn_items.Name = "btn_items";
            this.btn_items.Size = new System.Drawing.Size(51, 27);
            this.btn_items.TabIndex = 59;
            this.btn_items.Click += new System.EventHandler(this.btn_items_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(242, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 58;
            this.label2.Text = "اختر منتج:";
            // 
            // cbx_items
            // 
            this.cbx_items.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_items.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_items.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_items.FormattingEnabled = true;
            this.cbx_items.Location = new System.Drawing.Point(317, 68);
            this.cbx_items.Name = "cbx_items";
            this.cbx_items.Size = new System.Drawing.Size(126, 30);
            this.cbx_items.TabIndex = 57;
            // 
            // btn_customerbrouse
            // 
            this.btn_customerbrouse.Location = new System.Drawing.Point(743, 3);
            this.btn_customerbrouse.Name = "btn_customerbrouse";
            this.btn_customerbrouse.Size = new System.Drawing.Size(51, 31);
            this.btn_customerbrouse.TabIndex = 56;
            this.btn_customerbrouse.Text = "...";
            this.btn_customerbrouse.Click += new System.EventHandler(this.btn_customerbrouse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(550, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 55;
            this.label5.Text = "العميل:";
            // 
            // cbx_customer
            // 
            this.cbx_customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_customer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_customer.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_customer.FormattingEnabled = true;
            this.cbx_customer.Location = new System.Drawing.Point(611, 4);
            this.cbx_customer.Name = "cbx_customer";
            this.cbx_customer.Size = new System.Drawing.Size(126, 30);
            this.cbx_customer.TabIndex = 54;
            // 
            // txt_parcode
            // 
            this.txt_parcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_parcode.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_parcode.Location = new System.Drawing.Point(88, 70);
            this.txt_parcode.Name = "txt_parcode";
            this.txt_parcode.Size = new System.Drawing.Size(110, 30);
            this.txt_parcode.TabIndex = 53;
            this.txt_parcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_parcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_parcode_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(5, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 52;
            this.label6.Text = "رقم الباركود:";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(88, 6);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(110, 30);
            this.txt_id.TabIndex = 51;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "رقم الفاتوره:";
            // 
            // txt_customer
            // 
            this.txt_customer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_customer.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer.Location = new System.Drawing.Point(446, 28);
            this.txt_customer.Name = "txt_customer";
            this.txt_customer.Size = new System.Drawing.Size(110, 30);
            this.txt_customer.TabIndex = 78;
            this.txt_customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(356, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 25);
            this.label12.TabIndex = 79;
            this.label12.Text = "عميل نقدي:";
            // 
            // Dtp_reminder
            // 
            this.Dtp_reminder.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.Dtp_reminder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_reminder.Location = new System.Drawing.Point(940, 6);
            this.Dtp_reminder.Name = "Dtp_reminder";
            this.Dtp_reminder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Dtp_reminder.Size = new System.Drawing.Size(117, 32);
            this.Dtp_reminder.TabIndex = 80;
            this.Dtp_reminder.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(828, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 25);
            this.label13.TabIndex = 81;
            this.label13.Text = "تاريخ الاستحقاق:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(472, 529);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 50);
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // dtp_time
            // 
            this.dtp_time.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_time.Location = new System.Drawing.Point(485, 533);
            this.dtp_time.Name = "dtp_time";
            this.dtp_time.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_time.Size = new System.Drawing.Size(120, 26);
            this.dtp_time.TabIndex = 82;
            this.dtp_time.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // frm_sales
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1175, 586);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtp_time);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Dtp_reminder);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_customer);
            this.Controls.Add(this.rbtncust_agel);
            this.Controls.Add(this.rbtnCust_cash);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lbl_itemscount);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Dgv_sale);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.btn_deleteitems);
            this.Controls.Add(this.btn_items);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_items);
            this.Controls.Add(this.btn_customerbrouse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx_customer);
            this.Controls.Add(this.txt_parcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm_sales";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة المبيعات (باركود)";
            this.Load += new System.EventHandler(this.frm_sales_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_sales_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_sale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtncust_agel;
        private System.Windows.Forms.RadioButton rbtnCust_cash;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label lbl_itemscount;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private DevExpress.XtraEditors.SimpleButton btn_deleteitems;
        private DevExpress.XtraEditors.SimpleButton btn_items;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_items;
        private DevExpress.XtraEditors.SimpleButton btn_customerbrouse;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbx_customer;
        private System.Windows.Forms.TextBox txt_parcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_customer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker Dtp_reminder;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtp_time;
        public System.Windows.Forms.DataGridView Dgv_sale;
    }
}