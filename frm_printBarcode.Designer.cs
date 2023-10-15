namespace sales
{
    partial class frm_printBarcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_printBarcode));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_randombarcode = new DevExpress.XtraEditors.SimpleButton();
            this.cbx_product = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_salepricetaxe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_parcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_proname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_printpreview = new DevExpress.XtraEditors.SimpleButton();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_randombarcode);
            this.groupBox1.Controls.Add(this.cbx_product);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_randombarcode
            // 
            this.btn_randombarcode.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold);
            this.btn_randombarcode.Appearance.Options.UseFont = true;
            this.btn_randombarcode.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_randombarcode.ImageOptions.Image")));
            this.btn_randombarcode.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_randombarcode.Location = new System.Drawing.Point(311, 6);
            this.btn_randombarcode.Name = "btn_randombarcode";
            this.btn_randombarcode.Size = new System.Drawing.Size(267, 39);
            this.btn_randombarcode.TabIndex = 45;
            this.btn_randombarcode.Text = "توليد رقم باركود عشوائي";
            this.btn_randombarcode.Click += new System.EventHandler(this.btn_randombarcode_Click);
            // 
            // cbx_product
            // 
            this.cbx_product.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_product.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_product.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_product.FormattingEnabled = true;
            this.cbx_product.Location = new System.Drawing.Point(6, 9);
            this.cbx_product.Name = "cbx_product";
            this.cbx_product.Size = new System.Drawing.Size(212, 33);
            this.cbx_product.TabIndex = 43;
            this.cbx_product.SelectionChangeCommitted += new System.EventHandler(this.cbx_product_SelectionChangeCommitted);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(224, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 25);
            this.label15.TabIndex = 44;
            this.label15.Text = "اختر منتج:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_salepricetaxe);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_parcode);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_proname);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Purple;
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(613, 262);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات الباركود";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("3 of 9 Barcode", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(29, 160);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 30, 140, 0);
            this.label3.Size = new System.Drawing.Size(428, 80);
            this.label3.TabIndex = 28;
            this.label3.Text = "Label111";
            // 
            // txt_salepricetaxe
            // 
            this.txt_salepricetaxe.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salepricetaxe.Location = new System.Drawing.Point(15, 118);
            this.txt_salepricetaxe.Name = "txt_salepricetaxe";
            this.txt_salepricetaxe.Size = new System.Drawing.Size(464, 32);
            this.txt_salepricetaxe.TabIndex = 27;
            this.txt_salepricetaxe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(485, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "سعر البيع:";
            // 
            // txt_parcode
            // 
            this.txt_parcode.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_parcode.Location = new System.Drawing.Point(15, 80);
            this.txt_parcode.Name = "txt_parcode";
            this.txt_parcode.Size = new System.Drawing.Size(464, 32);
            this.txt_parcode.TabIndex = 25;
            this.txt_parcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(485, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "رقم الباركود:";
            // 
            // txt_proname
            // 
            this.txt_proname.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_proname.Location = new System.Drawing.Point(15, 42);
            this.txt_proname.Name = "txt_proname";
            this.txt_proname.Size = new System.Drawing.Size(464, 32);
            this.txt_proname.TabIndex = 23;
            this.txt_proname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(485, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "اسم المنتج:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.simpleButton3);
            this.groupBox3.Controls.Add(this.btn_printpreview);
            this.groupBox3.Controls.Add(this.btn_print);
            this.groupBox3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 339);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(618, 87);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "العمليات المتاحه";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.simpleButton3.Location = new System.Drawing.Point(20, 34);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(191, 39);
            this.simpleButton3.TabIndex = 47;
            this.simpleButton3.Text = "حفظ تعداد الباركود";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btn_printpreview
            // 
            this.btn_printpreview.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printpreview.Appearance.Options.UseFont = true;
            this.btn_printpreview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_printpreview.ImageOptions.Image")));
            this.btn_printpreview.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_printpreview.Location = new System.Drawing.Point(430, 34);
            this.btn_printpreview.Name = "btn_printpreview";
            this.btn_printpreview.Size = new System.Drawing.Size(181, 39);
            this.btn_printpreview.TabIndex = 46;
            this.btn_printpreview.Text = "معاينه وطباعه";
            this.btn_printpreview.Click += new System.EventHandler(this.btn_printpreview_Click);
            // 
            // btn_print
            // 
            this.btn_print.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Appearance.Options.UseFont = true;
            this.btn_print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_print.ImageOptions.Image")));
            this.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_print.Location = new System.Drawing.Point(230, 34);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(181, 39);
            this.btn_print.TabIndex = 45;
            this.btn_print.Text = "طباعه مباشره";
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // frm_printBarcode
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(629, 445);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "frm_printBarcode";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_printBarcode";
            this.Load += new System.EventHandler(this.frm_printBarcode_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbx_product;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.SimpleButton btn_randombarcode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_salepricetaxe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_parcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_proname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btn_printpreview;
        private DevExpress.XtraEditors.SimpleButton btn_print;
    }
}