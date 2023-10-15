namespace sales
{
    partial class frm_stocktransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_stocktransfer));
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_stockfrom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_stockto = new System.Windows.Forms.ComboBox();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_price = new System.Windows.Forms.NumericUpDown();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Money2 = new System.Windows.Forms.Label();
            this.lbl_Money1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(46, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "تحويل من خزنه :";
            // 
            // cbx_stockfrom
            // 
            this.cbx_stockfrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_stockfrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_stockfrom.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_stockfrom.FormattingEnabled = true;
            this.cbx_stockfrom.Location = new System.Drawing.Point(180, 11);
            this.cbx_stockfrom.Name = "cbx_stockfrom";
            this.cbx_stockfrom.Size = new System.Drawing.Size(172, 33);
            this.cbx_stockfrom.TabIndex = 14;
            this.cbx_stockfrom.SelectionChangeCommitted += new System.EventHandler(this.cbx_stockfrom_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(47, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "تحويل الي خزنه :";
            // 
            // cbx_stockto
            // 
            this.cbx_stockto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_stockto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_stockto.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_stockto.FormattingEnabled = true;
            this.cbx_stockto.Location = new System.Drawing.Point(180, 109);
            this.cbx_stockto.Name = "cbx_stockto";
            this.cbx_stockto.Size = new System.Drawing.Size(172, 33);
            this.cbx_stockto.TabIndex = 16;
            this.cbx_stockto.SelectionChangeCommitted += new System.EventHandler(this.cbx_stockto_SelectionChangeCommitted);
            // 
            // txt_reason
            // 
            this.txt_reason.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reason.Location = new System.Drawing.Point(180, 326);
            this.txt_reason.Multiline = true;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(172, 67);
            this.txt_reason.TabIndex = 29;
            this.txt_reason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(56, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "سبب التحويل :";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(180, 291);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(172, 29);
            this.txt_name.TabIndex = 27;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(-3, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "اسم المسؤل عن التحويل :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(60, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "تاريخ التحويل :";
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(180, 253);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_date.Size = new System.Drawing.Size(172, 32);
            this.dtp_date.TabIndex = 24;
            this.dtp_date.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(40, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "المبلغ المراد تحويلة :";
            // 
            // nud_price
            // 
            this.nud_price.DecimalPlaces = 2;
            this.nud_price.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_price.Location = new System.Drawing.Point(180, 195);
            this.nud_price.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nud_price.Name = "nud_price";
            this.nud_price.Size = new System.Drawing.Size(172, 32);
            this.nud_price.TabIndex = 22;
            this.nud_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_add
            // 
            this.btn_add.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_add.Location = new System.Drawing.Point(180, 399);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(172, 62);
            this.btn_add.TabIndex = 30;
            this.btn_add.Text = "تحويل";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(98, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "الرصيد :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(98, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "الرصيد :";
            // 
            // lbl_Money2
            // 
            this.lbl_Money2.AutoSize = true;
            this.lbl_Money2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Money2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Money2.Location = new System.Drawing.Point(194, 159);
            this.lbl_Money2.Name = "lbl_Money2";
            this.lbl_Money2.Size = new System.Drawing.Size(28, 25);
            this.lbl_Money2.TabIndex = 33;
            this.lbl_Money2.Text = "....";
            this.lbl_Money2.Click += new System.EventHandler(this.lbl_Money2_Click);
            // 
            // lbl_Money1
            // 
            this.lbl_Money1.AutoSize = true;
            this.lbl_Money1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Money1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Money1.Location = new System.Drawing.Point(194, 66);
            this.lbl_Money1.Name = "lbl_Money1";
            this.lbl_Money1.Size = new System.Drawing.Size(28, 25);
            this.lbl_Money1.TabIndex = 34;
            this.lbl_Money1.Text = "....";
            // 
            // frm_stocktransfer
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(365, 467);
            this.Controls.Add(this.lbl_Money1);
            this.Controls.Add(this.lbl_Money2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nud_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_stockto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx_stockfrom);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "frm_stocktransfer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحويل رصيد بين الخزنات";
            this.Load += new System.EventHandler(this.frm_stocktransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_stockfrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_stockto;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_price;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Money2;
        private System.Windows.Forms.Label lbl_Money1;
    }
}