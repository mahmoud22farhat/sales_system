namespace sales
{
    partial class frm_productoutstore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_productoutstore));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_unite = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_storefrom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_product = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_Qty = new System.Windows.Forms.NumericUpDown();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Qty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Controls.Add(this.txt_reason);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_name);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dtp_date);
            this.groupBox3.Location = new System.Drawing.Point(386, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 227);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بيانات العمليه";
            // 
            // btn_add
            // 
            this.btn_add.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_add.Location = new System.Drawing.Point(6, 165);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(189, 41);
            this.btn_add.TabIndex = 30;
            this.btn_add.Text = "اتمام العمليه";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_reason
            // 
            this.txt_reason.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reason.Location = new System.Drawing.Point(6, 93);
            this.txt_reason.Multiline = true;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(189, 66);
            this.txt_reason.TabIndex = 29;
            this.txt_reason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Indigo;
            this.label11.Location = new System.Drawing.Point(201, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "الاسباب:\r\n";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(6, 52);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(189, 32);
            this.txt_name.TabIndex = 23;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Indigo;
            this.label10.Location = new System.Drawing.Point(201, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "المسئول عن الاخراج:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Indigo;
            this.label9.Location = new System.Drawing.Point(201, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "التاريخ :";
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(6, 14);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_date.Size = new System.Drawing.Size(189, 32);
            this.dtp_date.TabIndex = 26;
            this.dtp_date.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbx_unite);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_storefrom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbx_product);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nud_Qty);
            this.groupBox1.Controls.Add(this.txt_barcode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 227);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المخزن المحول منه";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(201, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "الوحده:";
            // 
            // cbx_unite
            // 
            this.cbx_unite.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_unite.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_unite.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_unite.FormattingEnabled = true;
            this.cbx_unite.Location = new System.Drawing.Point(6, 184);
            this.cbx_unite.Name = "cbx_unite";
            this.cbx_unite.Size = new System.Drawing.Size(189, 33);
            this.cbx_unite.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(201, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "اسم المخزن:";
            // 
            // cbx_storefrom
            // 
            this.cbx_storefrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_storefrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_storefrom.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_storefrom.FormattingEnabled = true;
            this.cbx_storefrom.Location = new System.Drawing.Point(6, 107);
            this.cbx_storefrom.Name = "cbx_storefrom";
            this.cbx_storefrom.Size = new System.Drawing.Size(189, 33);
            this.cbx_storefrom.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(201, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "المنتج:";
            // 
            // cbx_product
            // 
            this.cbx_product.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_product.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_product.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_product.FormattingEnabled = true;
            this.cbx_product.Location = new System.Drawing.Point(6, 68);
            this.cbx_product.Name = "cbx_product";
            this.cbx_product.Size = new System.Drawing.Size(189, 33);
            this.cbx_product.TabIndex = 14;
            this.cbx_product.SelectionChangeCommitted += new System.EventHandler(this.cbx_product_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(201, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "الكميه:";
            // 
            // nud_Qty
            // 
            this.nud_Qty.DecimalPlaces = 2;
            this.nud_Qty.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_Qty.Location = new System.Drawing.Point(6, 146);
            this.nud_Qty.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nud_Qty.Name = "nud_Qty";
            this.nud_Qty.Size = new System.Drawing.Size(189, 32);
            this.nud_Qty.TabIndex = 12;
            this.nud_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_barcode
            // 
            this.txt_barcode.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_barcode.Location = new System.Drawing.Point(6, 30);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(189, 32);
            this.txt_barcode.TabIndex = 11;
            this.txt_barcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_barcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_barcode_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(201, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "الباركود:";
            // 
            // frm_productoutstore
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(755, 246);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "frm_productoutstore";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اخراج المنتجات التالفة";
            this.Load += new System.EventHandler(this.frm_productoutstore_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Qty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_unite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_storefrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_product;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_Qty;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Label label2;
    }
}