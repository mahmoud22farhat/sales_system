namespace sales
{
    partial class frm_buy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_buy));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_parcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_supplier = new System.Windows.Forms.ComboBox();
            this.btn_supplierbrouse = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_items = new System.Windows.Forms.ComboBox();
            this.btn_items = new DevExpress.XtraEditors.SimpleButton();
            this.btn_deleteitems = new DevExpress.XtraEditors.SimpleButton();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Dgv_buy = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_itemscount = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rbtn_cash = new System.Windows.Forms.RadioButton();
            this.rbtn_agel = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.dtp_agel = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cbx_store = new System.Windows.Forms.ComboBox();
            this.dtp_time = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_buy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(103, 6);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(110, 28);
            this.txt_id.TabIndex = 3;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "رقم الفاتوره:";
            // 
            // txt_parcode
            // 
            this.txt_parcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_parcode.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_parcode.Location = new System.Drawing.Point(103, 67);
            this.txt_parcode.Name = "txt_parcode";
            this.txt_parcode.Size = new System.Drawing.Size(110, 28);
            this.txt_parcode.TabIndex = 24;
            this.txt_parcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_parcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_parcode_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(15, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "رقم الباركود:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(268, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "المورد:";
            // 
            // cbx_supplier
            // 
            this.cbx_supplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_supplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_supplier.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_supplier.FormattingEnabled = true;
            this.cbx_supplier.Location = new System.Drawing.Point(325, 7);
            this.cbx_supplier.Name = "cbx_supplier";
            this.cbx_supplier.Size = new System.Drawing.Size(126, 29);
            this.cbx_supplier.TabIndex = 25;
            // 
            // btn_supplierbrouse
            // 
            this.btn_supplierbrouse.Location = new System.Drawing.Point(457, 6);
            this.btn_supplierbrouse.Name = "btn_supplierbrouse";
            this.btn_supplierbrouse.Size = new System.Drawing.Size(51, 25);
            this.btn_supplierbrouse.TabIndex = 27;
            this.btn_supplierbrouse.Text = "...";
            this.btn_supplierbrouse.Click += new System.EventHandler(this.btn_supplierbrouse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(250, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "اختر منتج:";
            // 
            // cbx_items
            // 
            this.cbx_items.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_items.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_items.Font = new System.Drawing.Font("Droid Arabic Kufi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_items.FormattingEnabled = true;
            this.cbx_items.Location = new System.Drawing.Point(325, 69);
            this.cbx_items.Name = "cbx_items";
            this.cbx_items.Size = new System.Drawing.Size(126, 29);
            this.cbx_items.TabIndex = 28;
            // 
            // btn_items
            // 
            this.btn_items.Appearance.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_items.Appearance.Options.UseFont = true;
            this.btn_items.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_items.ImageOptions.Image")));
            this.btn_items.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_items.Location = new System.Drawing.Point(457, 71);
            this.btn_items.Name = "btn_items";
            this.btn_items.Size = new System.Drawing.Size(51, 27);
            this.btn_items.TabIndex = 30;
            this.btn_items.Click += new System.EventHandler(this.btn_items_Click);
            // 
            // btn_deleteitems
            // 
            this.btn_deleteitems.Appearance.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteitems.Appearance.Options.UseFont = true;
            this.btn_deleteitems.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteitems.ImageOptions.Image")));
            this.btn_deleteitems.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btn_deleteitems.Location = new System.Drawing.Point(558, 71);
            this.btn_deleteitems.Name = "btn_deleteitems";
            this.btn_deleteitems.Size = new System.Drawing.Size(51, 27);
            this.btn_deleteitems.TabIndex = 31;
            this.btn_deleteitems.Click += new System.EventHandler(this.btn_deleteitems_Click);
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(724, 69);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_date.Size = new System.Drawing.Size(134, 26);
            this.dtp_date.TabIndex = 32;
            this.dtp_date.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(521, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 30);
            this.label3.TabIndex = 33;
            this.label3.Text = "f2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(623, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 27);
            this.label4.TabIndex = 34;
            this.label4.Text = "delete";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(219, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "f1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(614, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 27);
            this.label8.TabIndex = 37;
            this.label8.Text = " لدفع وحفظ وطباعة الفاتوره استخدم F12";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(614, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 27);
            this.label9.TabIndex = 38;
            this.label9.Text = "لتعديل الكميه او الخصم استخدم F11     \r\n";
            // 
            // Dgv_buy
            // 
            this.Dgv_buy.AllowUserToAddRows = false;
            this.Dgv_buy.AllowUserToDeleteRows = false;
            this.Dgv_buy.AllowUserToResizeColumns = false;
            this.Dgv_buy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_buy.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_buy.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dgv_buy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_buy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_buy.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_buy.Location = new System.Drawing.Point(3, 102);
            this.Dgv_buy.Name = "Dgv_buy";
            this.Dgv_buy.ReadOnly = true;
            this.Dgv_buy.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.Dgv_buy.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Dgv_buy.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.Dgv_buy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_buy.Size = new System.Drawing.Size(1188, 428);
            this.Dgv_buy.TabIndex = 39;
            this.Dgv_buy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_buy_CellContentClick);
            this.Dgv_buy.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_buy_CellValueChanged);
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
            this.Column3.FillWeight = 25F;
            this.Column3.HeaderText = "الكمية";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 40F;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(12, 536);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 27);
            this.label10.TabIndex = 40;
            this.label10.Text = "اسم المستخدم";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(10, 568);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 27);
            this.label11.TabIndex = 41;
            this.label11.Text = "عدد الاصناف";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_username.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.Black;
            this.lbl_username.Location = new System.Drawing.Point(115, 538);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(28, 20);
            this.lbl_username.TabIndex = 42;
            this.lbl_username.Text = "---";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_username.Click += new System.EventHandler(this.lbl_username_Click);
            // 
            // lbl_itemscount
            // 
            this.lbl_itemscount.AutoSize = true;
            this.lbl_itemscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_itemscount.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemscount.ForeColor = System.Drawing.Color.Black;
            this.lbl_itemscount.Location = new System.Drawing.Point(103, 572);
            this.lbl_itemscount.Name = "lbl_itemscount";
            this.lbl_itemscount.Size = new System.Drawing.Size(28, 20);
            this.lbl_itemscount.TabIndex = 43;
            this.lbl_itemscount.Text = "---";
            this.lbl_itemscount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_total
            // 
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_total.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(1011, 536);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(180, 23);
            this.txt_total.TabIndex = 44;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(895, 536);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 25);
            this.label14.TabIndex = 45;
            this.label14.Text = "اجمالي المطلوب:";
            // 
            // rbtn_cash
            // 
            this.rbtn_cash.AutoSize = true;
            this.rbtn_cash.Checked = true;
            this.rbtn_cash.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_cash.Location = new System.Drawing.Point(236, 536);
            this.rbtn_cash.Name = "rbtn_cash";
            this.rbtn_cash.Size = new System.Drawing.Size(132, 29);
            this.rbtn_cash.TabIndex = 46;
            this.rbtn_cash.TabStop = true;
            this.rbtn_cash.Text = "دفع الفاتوره كاش";
            this.rbtn_cash.UseVisualStyleBackColor = true;
            // 
            // rbtn_agel
            // 
            this.rbtn_agel.AutoSize = true;
            this.rbtn_agel.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_agel.Location = new System.Drawing.Point(236, 562);
            this.rbtn_agel.Name = "rbtn_agel";
            this.rbtn_agel.Size = new System.Drawing.Size(78, 29);
            this.rbtn_agel.TabIndex = 47;
            this.rbtn_agel.Text = "دفع اجل";
            this.rbtn_agel.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(320, 567);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 25);
            this.label15.TabIndex = 48;
            this.label15.Text = "تاريخ الاستحقاق:";
            // 
            // dtp_agel
            // 
            this.dtp_agel.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_agel.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_agel.Location = new System.Drawing.Point(436, 566);
            this.dtp_agel.Name = "dtp_agel";
            this.dtp_agel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_agel.Size = new System.Drawing.Size(117, 26);
            this.dtp_agel.TabIndex = 49;
            this.dtp_agel.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(597, 542);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 25);
            this.label12.TabIndex = 51;
            this.label12.Text = "اختر مخزن:";
            // 
            // cbx_store
            // 
            this.cbx_store.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_store.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_store.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_store.FormattingEnabled = true;
            this.cbx_store.Location = new System.Drawing.Point(674, 540);
            this.cbx_store.Name = "cbx_store";
            this.cbx_store.Size = new System.Drawing.Size(126, 30);
            this.cbx_store.TabIndex = 50;
            // 
            // dtp_time
            // 
            this.dtp_time.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_time.Location = new System.Drawing.Point(1011, 10);
            this.dtp_time.Name = "dtp_time";
            this.dtp_time.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_time.Size = new System.Drawing.Size(120, 26);
            this.dtp_time.TabIndex = 52;
            this.dtp_time.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(998, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 50);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // frm_buy
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1194, 634);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtp_time);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbx_store);
            this.Controls.Add(this.dtp_agel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.rbtn_agel);
            this.Controls.Add(this.rbtn_cash);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.lbl_itemscount);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Dgv_buy);
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
            this.Controls.Add(this.btn_supplierbrouse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx_supplier);
            this.Controls.Add(this.txt_parcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "frm_buy";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة المشتريات";
            this.Load += new System.EventHandler(this.frm_buy_Load);
            this.Click += new System.EventHandler(this.frm_buy_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_buy_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_buy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_parcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btn_supplierbrouse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_items;
        private DevExpress.XtraEditors.SimpleButton btn_items;
        private DevExpress.XtraEditors.SimpleButton btn_deleteitems;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_itemscount;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton rbtn_cash;
        private System.Windows.Forms.RadioButton rbtn_agel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtp_agel;
        public System.Windows.Forms.ComboBox cbx_supplier;
        public System.Windows.Forms.DataGridView Dgv_buy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox cbx_store;
        private System.Windows.Forms.DateTimePicker dtp_time;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}