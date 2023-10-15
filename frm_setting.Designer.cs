namespace sales
{
    partial class frm_setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_setting));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_print = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_phone2 = new System.Windows.Forms.TextBox();
            this.txt_phone1 = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_saveorder = new DevExpress.XtraEditors.SimpleButton();
            this.jab = new System.Windows.Forms.Label();
            this.la = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.btn_choose = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.picturelogo = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnA4buy = new System.Windows.Forms.RadioButton();
            this.rbtn8cmbuy = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnA4sales = new System.Windows.Forms.RadioButton();
            this.rbtn8cmsales = new System.Windows.Forms.RadioButton();
            this.check_buyprint = new System.Windows.Forms.CheckBox();
            this.check_taxes = new System.Windows.Forms.CheckBox();
            this.check_saleprint = new System.Windows.Forms.CheckBox();
            this.nud_buynumber = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbtn_value = new System.Windows.Forms.RadioButton();
            this.rbtn_present = new System.Windows.Forms.RadioButton();
            this.check_descound = new System.Windows.Forms.CheckBox();
            this.nud_salenumber = new System.Windows.Forms.NumericUpDown();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturelogo)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_buynumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_salenumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(21, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(911, 410);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_add);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cbx_print);
            this.tabPage1.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(903, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "اعدادت الطابعات";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_add.Location = new System.Drawing.Point(301, 217);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(291, 41);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "حفظ نوع الطابعه";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(217, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(442, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "اختار طابعه لكي تكون هي الطابعه الرئيسيه للبرنامج";
            // 
            // cbx_print
            // 
            this.cbx_print.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_print.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_print.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_print.FormattingEnabled = true;
            this.cbx_print.Location = new System.Drawing.Point(178, 172);
            this.cbx_print.Name = "cbx_print";
            this.cbx_print.Size = new System.Drawing.Size(519, 33);
            this.cbx_print.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_phone2);
            this.tabPage2.Controls.Add(this.txt_phone1);
            this.tabPage2.Controls.Add(this.txt_description);
            this.tabPage2.Controls.Add(this.txt_address);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txt_name);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btn_saveorder);
            this.tabPage2.Controls.Add(this.jab);
            this.tabPage2.Controls.Add(this.la);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btn_del);
            this.tabPage2.Controls.Add(this.btn_choose);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.picturelogo);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(903, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "اعدادت الفاتوره";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_phone2
            // 
            this.txt_phone2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone2.Location = new System.Drawing.Point(23, 122);
            this.txt_phone2.Name = "txt_phone2";
            this.txt_phone2.Size = new System.Drawing.Size(223, 32);
            this.txt_phone2.TabIndex = 33;
            this.txt_phone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_phone1
            // 
            this.txt_phone1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone1.Location = new System.Drawing.Point(23, 67);
            this.txt_phone1.Name = "txt_phone1";
            this.txt_phone1.Size = new System.Drawing.Size(223, 32);
            this.txt_phone1.TabIndex = 32;
            this.txt_phone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.Location = new System.Drawing.Point(23, 16);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(223, 32);
            this.txt_description.TabIndex = 31;
            this.txt_description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(482, 298);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(293, 32);
            this.txt_address.TabIndex = 30;
            this.txt_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(785, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 29;
            this.label2.Text = "عنوان المحل:";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(482, 247);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(293, 32);
            this.txt_name.TabIndex = 28;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(785, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 28);
            this.label3.TabIndex = 27;
            this.label3.Text = "اسم المحل:";
            // 
            // btn_saveorder
            // 
            this.btn_saveorder.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_saveorder.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_saveorder.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_saveorder.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveorder.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_saveorder.Appearance.Options.UseBackColor = true;
            this.btn_saveorder.Appearance.Options.UseBorderColor = true;
            this.btn_saveorder.Appearance.Options.UseFont = true;
            this.btn_saveorder.Appearance.Options.UseForeColor = true;
            this.btn_saveorder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_saveorder.ImageOptions.Image")));
            this.btn_saveorder.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_saveorder.Location = new System.Drawing.Point(6, 190);
            this.btn_saveorder.Name = "btn_saveorder";
            this.btn_saveorder.Size = new System.Drawing.Size(240, 30);
            this.btn_saveorder.TabIndex = 26;
            this.btn_saveorder.Text = "حفظ بيانات الفاتوره";
            this.btn_saveorder.Click += new System.EventHandler(this.btn_saveorder_Click);
            // 
            // jab
            // 
            this.jab.AutoSize = true;
            this.jab.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.jab.Location = new System.Drawing.Point(252, 126);
            this.jab.Name = "jab";
            this.jab.Size = new System.Drawing.Size(71, 28);
            this.jab.TabIndex = 24;
            this.jab.Text = "تليفون2:";
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.la.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.la.Location = new System.Drawing.Point(251, 67);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(71, 28);
            this.la.TabIndex = 22;
            this.la.Text = "تليفون1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(249, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "جمله في اسفل الفاتوره:";
            // 
            // btn_del
            // 
            this.btn_del.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.btn_del.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.btn_del.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.btn_del.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_del.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_del.Appearance.Options.UseBackColor = true;
            this.btn_del.Appearance.Options.UseBorderColor = true;
            this.btn_del.Appearance.Options.UseFont = true;
            this.btn_del.Appearance.Options.UseForeColor = true;
            this.btn_del.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btn_del.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_del.Location = new System.Drawing.Point(482, 167);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(124, 30);
            this.btn_del.TabIndex = 15;
            this.btn_del.Text = "حذف الصوره";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_choose
            // 
            this.btn_choose.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.btn_choose.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.btn_choose.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(182)))));
            this.btn_choose.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_choose.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_choose.Appearance.Options.UseBackColor = true;
            this.btn_choose.Appearance.Options.UseBorderColor = true;
            this.btn_choose.Appearance.Options.UseFont = true;
            this.btn_choose.Appearance.Options.UseForeColor = true;
            this.btn_choose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btn_choose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_choose.Location = new System.Drawing.Point(651, 167);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(124, 30);
            this.btn_choose.TabIndex = 14;
            this.btn_choose.Text = "اختيار صوره";
            this.btn_choose.Click += new System.EventHandler(this.btn_choose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(785, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "لوجو المحل:";
            // 
            // picturelogo
            // 
            this.picturelogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturelogo.Location = new System.Drawing.Point(482, 16);
            this.picturelogo.Name = "picturelogo";
            this.picturelogo.Size = new System.Drawing.Size(293, 145);
            this.picturelogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturelogo.TabIndex = 0;
            this.picturelogo.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.check_buyprint);
            this.tabPage3.Controls.Add(this.check_taxes);
            this.tabPage3.Controls.Add(this.check_saleprint);
            this.tabPage3.Controls.Add(this.nud_buynumber);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.rbtn_value);
            this.tabPage3.Controls.Add(this.rbtn_present);
            this.tabPage3.Controls.Add(this.check_descound);
            this.tabPage3.Controls.Add(this.nud_salenumber);
            this.tabPage3.Controls.Add(this.simpleButton4);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(903, 366);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "اعدادت عامه";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnA4buy);
            this.groupBox2.Controls.Add(this.rbtn8cmbuy);
            this.groupBox2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 79);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "طباعة فواتير المشتريات";
            // 
            // rbtnA4buy
            // 
            this.rbtnA4buy.AutoSize = true;
            this.rbtnA4buy.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnA4buy.Location = new System.Drawing.Point(24, 29);
            this.rbtnA4buy.Name = "rbtnA4buy";
            this.rbtnA4buy.Size = new System.Drawing.Size(97, 32);
            this.rbtnA4buy.TabIndex = 42;
            this.rbtnA4buy.TabStop = true;
            this.rbtnA4buy.Text = "طباعة A4";
            this.rbtnA4buy.UseVisualStyleBackColor = true;
            // 
            // rbtn8cmbuy
            // 
            this.rbtn8cmbuy.AutoSize = true;
            this.rbtn8cmbuy.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn8cmbuy.Location = new System.Drawing.Point(206, 29);
            this.rbtn8cmbuy.Name = "rbtn8cmbuy";
            this.rbtn8cmbuy.Size = new System.Drawing.Size(175, 32);
            this.rbtn8cmbuy.TabIndex = 41;
            this.rbtn8cmbuy.TabStop = true;
            this.rbtn8cmbuy.Text = "طباعه حراري(8 سنتي)";
            this.rbtn8cmbuy.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnA4sales);
            this.groupBox1.Controls.Add(this.rbtn8cmsales);
            this.groupBox1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(423, 79);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "طباعة فواتير المبيعات";
            // 
            // rbtnA4sales
            // 
            this.rbtnA4sales.AutoSize = true;
            this.rbtnA4sales.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnA4sales.Location = new System.Drawing.Point(24, 29);
            this.rbtnA4sales.Name = "rbtnA4sales";
            this.rbtnA4sales.Size = new System.Drawing.Size(97, 32);
            this.rbtnA4sales.TabIndex = 42;
            this.rbtnA4sales.TabStop = true;
            this.rbtnA4sales.Text = "طباعة A4";
            this.rbtnA4sales.UseVisualStyleBackColor = true;
            // 
            // rbtn8cmsales
            // 
            this.rbtn8cmsales.AutoSize = true;
            this.rbtn8cmsales.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn8cmsales.Location = new System.Drawing.Point(206, 29);
            this.rbtn8cmsales.Name = "rbtn8cmsales";
            this.rbtn8cmsales.Size = new System.Drawing.Size(175, 32);
            this.rbtn8cmsales.TabIndex = 41;
            this.rbtn8cmsales.TabStop = true;
            this.rbtn8cmsales.Text = "طباعه حراري(8 سنتي)";
            this.rbtn8cmsales.UseVisualStyleBackColor = true;
            // 
            // check_buyprint
            // 
            this.check_buyprint.AutoSize = true;
            this.check_buyprint.Location = new System.Drawing.Point(652, 325);
            this.check_buyprint.Name = "check_buyprint";
            this.check_buyprint.Size = new System.Drawing.Size(242, 35);
            this.check_buyprint.TabIndex = 39;
            this.check_buyprint.Text = "تفعيل طباعة فواتير المشتريات";
            this.check_buyprint.UseVisualStyleBackColor = true;
            // 
            // check_taxes
            // 
            this.check_taxes.AutoSize = true;
            this.check_taxes.Location = new System.Drawing.Point(657, 204);
            this.check_taxes.Name = "check_taxes";
            this.check_taxes.Size = new System.Drawing.Size(234, 35);
            this.check_taxes.TabIndex = 38;
            this.check_taxes.Text = "تفعيل ضريبة القيمه المضافه";
            this.check_taxes.UseVisualStyleBackColor = true;
            // 
            // check_saleprint
            // 
            this.check_saleprint.AutoSize = true;
            this.check_saleprint.Location = new System.Drawing.Point(661, 284);
            this.check_saleprint.Name = "check_saleprint";
            this.check_saleprint.Size = new System.Drawing.Size(230, 35);
            this.check_saleprint.TabIndex = 37;
            this.check_saleprint.Text = "تفعيل طباعة فواتير المبيعات";
            this.check_saleprint.UseVisualStyleBackColor = true;
            // 
            // nud_buynumber
            // 
            this.nud_buynumber.DecimalPlaces = 2;
            this.nud_buynumber.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_buynumber.Location = new System.Drawing.Point(531, 147);
            this.nud_buynumber.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nud_buynumber.Name = "nud_buynumber";
            this.nud_buynumber.Size = new System.Drawing.Size(86, 32);
            this.nud_buynumber.TabIndex = 36;
            this.nud_buynumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_buynumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(623, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(274, 31);
            this.label10.TabIndex = 35;
            this.label10.Text = "عدد طباعة نسخة فواتير المبيعات:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(623, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(274, 31);
            this.label9.TabIndex = 34;
            this.label9.Text = "عدد طباعة نسخة فواتير المبيعات:";
            // 
            // rbtn_value
            // 
            this.rbtn_value.AutoSize = true;
            this.rbtn_value.Location = new System.Drawing.Point(537, 38);
            this.rbtn_value.Name = "rbtn_value";
            this.rbtn_value.Size = new System.Drawing.Size(133, 35);
            this.rbtn_value.TabIndex = 33;
            this.rbtn_value.TabStop = true;
            this.rbtn_value.Text = "قيمة من المال";
            this.rbtn_value.UseVisualStyleBackColor = true;
            // 
            // rbtn_present
            // 
            this.rbtn_present.AutoSize = true;
            this.rbtn_present.Location = new System.Drawing.Point(736, 38);
            this.rbtn_present.Name = "rbtn_present";
            this.rbtn_present.Size = new System.Drawing.Size(112, 35);
            this.rbtn_present.TabIndex = 32;
            this.rbtn_present.TabStop = true;
            this.rbtn_present.Text = "نسبة مئويه";
            this.rbtn_present.UseVisualStyleBackColor = true;
            // 
            // check_descound
            // 
            this.check_descound.AutoSize = true;
            this.check_descound.Location = new System.Drawing.Point(514, 245);
            this.check_descound.Name = "check_descound";
            this.check_descound.Size = new System.Drawing.Size(377, 35);
            this.check_descound.TabIndex = 31;
            this.check_descound.Text = "تفعيل امكانية الخصم علي فواتير المبيعات للكاشير";
            this.check_descound.UseVisualStyleBackColor = true;
            // 
            // nud_salenumber
            // 
            this.nud_salenumber.DecimalPlaces = 2;
            this.nud_salenumber.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_salenumber.Location = new System.Drawing.Point(531, 105);
            this.nud_salenumber.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nud_salenumber.Name = "nud_salenumber";
            this.nud_salenumber.Size = new System.Drawing.Size(86, 32);
            this.nud_salenumber.TabIndex = 30;
            this.nud_salenumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_salenumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton4.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton4.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.Appearance.Options.UseBorderColor = true;
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Appearance.Options.UseForeColor = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.simpleButton4.Location = new System.Drawing.Point(96, 276);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(240, 30);
            this.simpleButton4.TabIndex = 29;
            this.simpleButton4.Text = "حفظ الاعدادات";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(344, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(556, 31);
            this.label8.TabIndex = 27;
            this.label8.Text = "هل تريد ان يكون الخصم علي المنتجات نسبه مئويه ام قيمه من المال؟";
            // 
            // frm_setting
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(939, 447);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MaximizeBox = false;
            this.Name = "frm_setting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعدادات البرنامج";
            this.Load += new System.EventHandler(this.frm_setting_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturelogo)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_buynumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_salenumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_print;
        private DevExpress.XtraEditors.SimpleButton btn_del;
        private DevExpress.XtraEditors.SimpleButton btn_choose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picturelogo;
        private DevExpress.XtraEditors.SimpleButton btn_saveorder;
        private System.Windows.Forms.Label jab;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnA4buy;
        private System.Windows.Forms.RadioButton rbtn8cmbuy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnA4sales;
        private System.Windows.Forms.RadioButton rbtn8cmsales;
        private System.Windows.Forms.CheckBox check_buyprint;
        private System.Windows.Forms.CheckBox check_taxes;
        private System.Windows.Forms.CheckBox check_saleprint;
        private System.Windows.Forms.NumericUpDown nud_buynumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbtn_value;
        private System.Windows.Forms.RadioButton rbtn_present;
        private System.Windows.Forms.CheckBox check_descound;
        private System.Windows.Forms.NumericUpDown nud_salenumber;
        private System.Windows.Forms.TextBox txt_phone2;
        private System.Windows.Forms.TextBox txt_phone1;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
    }
}