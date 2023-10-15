namespace sales
{
    partial class frm_Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Return));
            this.label2 = new System.Windows.Forms.Label();
            this.rbtn_buy = new System.Windows.Forms.RadioButton();
            this.rbtn_sale = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Dgv_search = new System.Windows.Forms.DataGridView();
            this.txt_madfou3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_totalaftertax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_totaltax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_baky = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_totalorder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_store1 = new System.Windows.Forms.ComboBox();
            this.txt_name1 = new System.Windows.Forms.TextBox();
            this.lbl_name1 = new System.Windows.Forms.Label();
            this.btn_returnAll = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nud_Qty = new System.Windows.Forms.NumericUpDown();
            this.cbx_store2 = new System.Windows.Forms.ComboBox();
            this.rbtn_retunQtyOnly = new System.Windows.Forms.RadioButton();
            this.rbtn_retunitemOnly = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.txt_name2 = new System.Windows.Forms.TextBox();
            this.lbl_name2 = new System.Windows.Forms.Label();
            this.btn_returnitemOnly = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Qty)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(359, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 40);
            this.label2.TabIndex = 52;
            this.label2.Text = "ادارة المرتجعات";
            // 
            // rbtn_buy
            // 
            this.rbtn_buy.AutoSize = true;
            this.rbtn_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_buy.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.rbtn_buy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_buy.Location = new System.Drawing.Point(8, 6);
            this.rbtn_buy.Name = "rbtn_buy";
            this.rbtn_buy.Size = new System.Drawing.Size(147, 32);
            this.rbtn_buy.TabIndex = 2;
            this.rbtn_buy.Text = "مرتجعات مشتريات";
            this.rbtn_buy.UseVisualStyleBackColor = false;
            this.rbtn_buy.CheckedChanged += new System.EventHandler(this.rbtn_buy_CheckedChanged);
            // 
            // rbtn_sale
            // 
            this.rbtn_sale.AutoSize = true;
            this.rbtn_sale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_sale.Checked = true;
            this.rbtn_sale.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.rbtn_sale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_sale.Location = new System.Drawing.Point(160, 6);
            this.rbtn_sale.Name = "rbtn_sale";
            this.rbtn_sale.Size = new System.Drawing.Size(136, 32);
            this.rbtn_sale.TabIndex = 1;
            this.rbtn_sale.TabStop = true;
            this.rbtn_sale.Text = "مرتجعات مبيعات";
            this.rbtn_sale.UseVisualStyleBackColor = false;
            this.rbtn_sale.CheckedChanged += new System.EventHandler(this.rbtn_sale_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_buy);
            this.groupBox1.Controls.Add(this.rbtn_sale);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 49);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(320, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 67;
            this.label1.Text = "تاريخ المرتجع:";
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(432, 48);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_date.Size = new System.Drawing.Size(121, 32);
            this.dtp_date.TabIndex = 66;
            this.dtp_date.Value = new System.DateTime(2022, 12, 19, 0, 0, 0, 0);
            // 
            // txt_id
            // 
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(698, 46);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(161, 32);
            this.txt_id.TabIndex = 70;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(559, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 71;
            this.label3.Text = "بحث برقم الفاتوره:";
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
            this.Dgv_search.Location = new System.Drawing.Point(23, 98);
            this.Dgv_search.Name = "Dgv_search";
            this.Dgv_search.ReadOnly = true;
            this.Dgv_search.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_search.Size = new System.Drawing.Size(872, 291);
            this.Dgv_search.TabIndex = 72;
            // 
            // txt_madfou3
            // 
            this.txt_madfou3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_madfou3.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.txt_madfou3.Location = new System.Drawing.Point(638, 4);
            this.txt_madfou3.Multiline = true;
            this.txt_madfou3.Name = "txt_madfou3";
            this.txt_madfou3.ReadOnly = true;
            this.txt_madfou3.Size = new System.Drawing.Size(120, 32);
            this.txt_madfou3.TabIndex = 73;
            this.txt_madfou3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(764, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 28);
            this.label4.TabIndex = 74;
            this.label4.Text = "المبلغ المدفوع:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_totalaftertax);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_totaltax);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_baky);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_totalorder);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_madfou3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(23, 396);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(881, 87);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            // 
            // txt_totalaftertax
            // 
            this.txt_totalaftertax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_totalaftertax.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.txt_totalaftertax.Location = new System.Drawing.Point(12, 47);
            this.txt_totalaftertax.Multiline = true;
            this.txt_totalaftertax.Name = "txt_totalaftertax";
            this.txt_totalaftertax.ReadOnly = true;
            this.txt_totalaftertax.Size = new System.Drawing.Size(158, 32);
            this.txt_totalaftertax.TabIndex = 81;
            this.txt_totalaftertax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(179, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 28);
            this.label8.TabIndex = 82;
            this.label8.Text = "اجمالي بعد الضرائب:";
            // 
            // txt_totaltax
            // 
            this.txt_totaltax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_totaltax.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.txt_totaltax.Location = new System.Drawing.Point(9, 4);
            this.txt_totaltax.Multiline = true;
            this.txt_totaltax.Name = "txt_totaltax";
            this.txt_totaltax.ReadOnly = true;
            this.txt_totaltax.Size = new System.Drawing.Size(161, 32);
            this.txt_totaltax.TabIndex = 79;
            this.txt_totaltax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(179, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 28);
            this.label7.TabIndex = 80;
            this.label7.Text = "اجمالي الضرائب:";
            // 
            // txt_baky
            // 
            this.txt_baky.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_baky.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.txt_baky.Location = new System.Drawing.Point(366, 42);
            this.txt_baky.Multiline = true;
            this.txt_baky.Name = "txt_baky";
            this.txt_baky.ReadOnly = true;
            this.txt_baky.Size = new System.Drawing.Size(391, 32);
            this.txt_baky.TabIndex = 77;
            this.txt_baky.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(503, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 28);
            this.label6.TabIndex = 78;
            this.label6.Text = "اجمالي الفاتوره:";
            // 
            // txt_totalorder
            // 
            this.txt_totalorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_totalorder.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.txt_totalorder.Location = new System.Drawing.Point(366, 4);
            this.txt_totalorder.Multiline = true;
            this.txt_totalorder.Name = "txt_totalorder";
            this.txt_totalorder.ReadOnly = true;
            this.txt_totalorder.Size = new System.Drawing.Size(132, 32);
            this.txt_totalorder.TabIndex = 75;
            this.txt_totalorder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(764, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 28);
            this.label5.TabIndex = 76;
            this.label5.Text = "المبلغ المتبقي:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cbx_store1);
            this.groupBox3.Controls.Add(this.txt_name1);
            this.groupBox3.Controls.Add(this.lbl_name1);
            this.groupBox3.Controls.Add(this.btn_returnAll);
            this.groupBox3.Location = new System.Drawing.Point(12, 489);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 152);
            this.groupBox3.TabIndex = 73;
            this.groupBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(136, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 28);
            this.label10.TabIndex = 85;
            this.label10.Text = "الي المخزن:";
            // 
            // cbx_store1
            // 
            this.cbx_store1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.cbx_store1.FormattingEnabled = true;
            this.cbx_store1.Location = new System.Drawing.Point(9, 59);
            this.cbx_store1.Name = "cbx_store1";
            this.cbx_store1.Size = new System.Drawing.Size(121, 36);
            this.cbx_store1.TabIndex = 74;
            // 
            // txt_name1
            // 
            this.txt_name1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.txt_name1.Location = new System.Drawing.Point(10, 16);
            this.txt_name1.Multiline = true;
            this.txt_name1.Name = "txt_name1";
            this.txt_name1.Size = new System.Drawing.Size(120, 32);
            this.txt_name1.TabIndex = 83;
            this.txt_name1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_name1
            // 
            this.lbl_name1.AutoSize = true;
            this.lbl_name1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.lbl_name1.ForeColor = System.Drawing.Color.Red;
            this.lbl_name1.Location = new System.Drawing.Point(136, 16);
            this.lbl_name1.Name = "lbl_name1";
            this.lbl_name1.Size = new System.Drawing.Size(92, 28);
            this.lbl_name1.TabIndex = 84;
            this.lbl_name1.Text = "اسم العميل:";
            // 
            // btn_returnAll
            // 
            this.btn_returnAll.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_returnAll.Appearance.Options.UseFont = true;
            this.btn_returnAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_returnAll.ImageOptions.Image")));
            this.btn_returnAll.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_returnAll.Location = new System.Drawing.Point(10, 112);
            this.btn_returnAll.Name = "btn_returnAll";
            this.btn_returnAll.Size = new System.Drawing.Size(223, 34);
            this.btn_returnAll.TabIndex = 16;
            this.btn_returnAll.Text = "ارجاع الفاتوره بالكامل";
            this.btn_returnAll.Click += new System.EventHandler(this.btn_returnAll_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.nud_Qty);
            this.groupBox4.Controls.Add(this.cbx_store2);
            this.groupBox4.Controls.Add(this.rbtn_retunQtyOnly);
            this.groupBox4.Controls.Add(this.rbtn_retunitemOnly);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.txt_name2);
            this.groupBox4.Controls.Add(this.lbl_name2);
            this.groupBox4.Controls.Add(this.btn_returnitemOnly);
            this.groupBox4.Location = new System.Drawing.Point(253, 489);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(639, 152);
            this.groupBox4.TabIndex = 86;
            this.groupBox4.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(531, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 28);
            this.label11.TabIndex = 87;
            this.label11.Text = "الي المخزن:";
            // 
            // nud_Qty
            // 
            this.nud_Qty.DecimalPlaces = 2;
            this.nud_Qty.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.nud_Qty.Location = new System.Drawing.Point(409, 49);
            this.nud_Qty.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nud_Qty.Name = "nud_Qty";
            this.nud_Qty.Size = new System.Drawing.Size(57, 36);
            this.nud_Qty.TabIndex = 90;
            this.nud_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbx_store2
            // 
            this.cbx_store2.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.cbx_store2.FormattingEnabled = true;
            this.cbx_store2.Location = new System.Drawing.Point(10, 108);
            this.cbx_store2.Name = "cbx_store2";
            this.cbx_store2.Size = new System.Drawing.Size(521, 36);
            this.cbx_store2.TabIndex = 86;
            // 
            // rbtn_retunQtyOnly
            // 
            this.rbtn_retunQtyOnly.AutoSize = true;
            this.rbtn_retunQtyOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_retunQtyOnly.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.rbtn_retunQtyOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_retunQtyOnly.Location = new System.Drawing.Point(472, 53);
            this.rbtn_retunQtyOnly.Name = "rbtn_retunQtyOnly";
            this.rbtn_retunQtyOnly.Size = new System.Drawing.Size(160, 32);
            this.rbtn_retunQtyOnly.TabIndex = 88;
            this.rbtn_retunQtyOnly.Text = "ارجاع جزء من المحدد";
            this.rbtn_retunQtyOnly.UseVisualStyleBackColor = false;
            // 
            // rbtn_retunitemOnly
            // 
            this.rbtn_retunitemOnly.AutoSize = true;
            this.rbtn_retunitemOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_retunitemOnly.Checked = true;
            this.rbtn_retunitemOnly.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.rbtn_retunitemOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_retunitemOnly.Location = new System.Drawing.Point(414, 16);
            this.rbtn_retunitemOnly.Name = "rbtn_retunitemOnly";
            this.rbtn_retunitemOnly.Size = new System.Drawing.Size(219, 32);
            this.rbtn_retunitemOnly.TabIndex = 87;
            this.rbtn_retunitemOnly.TabStop = true;
            this.rbtn_retunitemOnly.Text = "ارجاع الكميه المحدده بالكامل";
            this.rbtn_retunitemOnly.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.comboBox2);
            this.groupBox5.Controls.Add(this.textBox8);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.simpleButton2);
            this.groupBox5.Location = new System.Drawing.Point(595, 498);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(639, 248);
            this.groupBox5.TabIndex = 89;
            this.groupBox5.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(136, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 27);
            this.label13.TabIndex = 85;
            this.label13.Text = "الي المخزن :";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(9, 59);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 32);
            this.comboBox2.TabIndex = 74;
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(10, 16);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(120, 32);
            this.textBox8.TabIndex = 83;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(136, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 27);
            this.label14.TabIndex = 84;
            this.label14.Text = "اسم العميل :";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.simpleButton2.Location = new System.Drawing.Point(10, 112);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(223, 34);
            this.simpleButton2.TabIndex = 16;
            this.simpleButton2.Text = "ارجاع الفاتوره بالكامل";
            // 
            // txt_name2
            // 
            this.txt_name2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name2.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.txt_name2.Location = new System.Drawing.Point(10, 16);
            this.txt_name2.Multiline = true;
            this.txt_name2.Name = "txt_name2";
            this.txt_name2.Size = new System.Drawing.Size(159, 32);
            this.txt_name2.TabIndex = 83;
            this.txt_name2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_name2
            // 
            this.lbl_name2.AutoSize = true;
            this.lbl_name2.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.lbl_name2.ForeColor = System.Drawing.Color.Red;
            this.lbl_name2.Location = new System.Drawing.Point(175, 16);
            this.lbl_name2.Name = "lbl_name2";
            this.lbl_name2.Size = new System.Drawing.Size(92, 28);
            this.lbl_name2.TabIndex = 84;
            this.lbl_name2.Text = "اسم العميل:";
            // 
            // btn_returnitemOnly
            // 
            this.btn_returnitemOnly.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_returnitemOnly.Appearance.Options.UseFont = true;
            this.btn_returnitemOnly.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_returnitemOnly.ImageOptions.Image")));
            this.btn_returnitemOnly.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_returnitemOnly.Location = new System.Drawing.Point(10, 61);
            this.btn_returnitemOnly.Name = "btn_returnitemOnly";
            this.btn_returnitemOnly.Size = new System.Drawing.Size(257, 34);
            this.btn_returnitemOnly.TabIndex = 16;
            this.btn_returnitemOnly.Text = "ارجاع الصنف المحدد فقط";
            this.btn_returnitemOnly.Click += new System.EventHandler(this.btn_itemOne_Click);
            // 
            // frm_Return
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(904, 641);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Dgv_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "frm_Return";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة المرتجعات";
            this.Load += new System.EventHandler(this.frm_Return_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Qty)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtn_buy;
        private System.Windows.Forms.RadioButton rbtn_sale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Dgv_search;
        private System.Windows.Forms.TextBox txt_madfou3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_totaltax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_baky;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_totalorder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_totalaftertax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_name1;
        private System.Windows.Forms.Label lbl_name1;
        private DevExpress.XtraEditors.SimpleButton btn_returnAll;
        private System.Windows.Forms.ComboBox cbx_store1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbtn_retunQtyOnly;
        private System.Windows.Forms.RadioButton rbtn_retunitemOnly;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TextBox txt_name2;
        private System.Windows.Forms.Label lbl_name2;
        private DevExpress.XtraEditors.SimpleButton btn_returnitemOnly;
        private System.Windows.Forms.NumericUpDown nud_Qty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbx_store2;
        private System.Windows.Forms.DateTimePicker dtp_date;
    }
}