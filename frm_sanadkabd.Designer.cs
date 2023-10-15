namespace sales
{
    partial class frm_sanadkabd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_sanadkabd));
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_price = new System.Windows.Forms.NumericUpDown();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_next = new DevExpress.XtraEditors.SimpleButton();
            this.btn_priv = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_first = new DevExpress.XtraEditors.SimpleButton();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_last = new DevExpress.XtraEditors.SimpleButton();
            this.btn_deleteall = new DevExpress.XtraEditors.SimpleButton();
            this.btn_new = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_from = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(201, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "تاريخ القبض:";
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(6, 15);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_date.Size = new System.Drawing.Size(189, 32);
            this.dtp_date.TabIndex = 2;
            this.dtp_date.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(500, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "المبلغ:";
            // 
            // nud_price
            // 
            this.nud_price.DecimalPlaces = 2;
            this.nud_price.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_price.Location = new System.Drawing.Point(314, 90);
            this.nud_price.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nud_price.Name = "nud_price";
            this.nud_price.Size = new System.Drawing.Size(172, 32);
            this.nud_price.TabIndex = 1;
            this.nud_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_reason
            // 
            this.txt_reason.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reason.Location = new System.Drawing.Point(6, 91);
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(189, 32);
            this.txt_reason.TabIndex = 4;
            this.txt_reason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(201, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "السبب:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(500, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم العملية:";
            // 
            // btn_next
            // 
            this.btn_next.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Appearance.Options.UseFont = true;
            this.btn_next.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.ImageOptions.Image")));
            this.btn_next.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_next.Location = new System.Drawing.Point(178, 29);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(51, 31);
            this.btn_next.TabIndex = 0;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_priv
            // 
            this.btn_priv.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_priv.Appearance.Options.UseFont = true;
            this.btn_priv.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_priv.ImageOptions.Image")));
            this.btn_priv.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_priv.Location = new System.Drawing.Point(99, 29);
            this.btn_priv.Name = "btn_priv";
            this.btn_priv.Size = new System.Drawing.Size(51, 31);
            this.btn_priv.TabIndex = 3;
            this.btn_priv.Click += new System.EventHandler(this.btn_priv_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(500, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "المسئول عن القبض:";
            // 
            // btn_first
            // 
            this.btn_first.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_first.Appearance.Options.UseFont = true;
            this.btn_first.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_first.ImageOptions.Image")));
            this.btn_first.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_first.Location = new System.Drawing.Point(16, 29);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(51, 31);
            this.btn_first.TabIndex = 2;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(314, 6);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(172, 32);
            this.txt_id.TabIndex = 0;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_next);
            this.groupBox2.Controls.Add(this.btn_priv);
            this.groupBox2.Controls.Add(this.btn_first);
            this.groupBox2.Controls.Add(this.btn_last);
            this.groupBox2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(152, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 66);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "اسهم التنقل";
            // 
            // btn_last
            // 
            this.btn_last.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_last.Appearance.Options.UseFont = true;
            this.btn_last.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_last.ImageOptions.Image")));
            this.btn_last.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_last.Location = new System.Drawing.Point(259, 29);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(51, 31);
            this.btn_last.TabIndex = 1;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_deleteall
            // 
            this.btn_deleteall.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteall.Appearance.Options.UseFont = true;
            this.btn_deleteall.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteall.ImageOptions.Image")));
            this.btn_deleteall.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_deleteall.Location = new System.Drawing.Point(7, 7);
            this.btn_deleteall.Name = "btn_deleteall";
            this.btn_deleteall.Size = new System.Drawing.Size(125, 41);
            this.btn_deleteall.TabIndex = 0;
            this.btn_deleteall.Text = "مسح الكل";
            this.btn_deleteall.Click += new System.EventHandler(this.btn_deleteall_Click);
            // 
            // btn_new
            // 
            this.btn_new.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Appearance.Options.UseFont = true;
            this.btn_new.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.ImageOptions.Image")));
            this.btn_new.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_new.Location = new System.Drawing.Point(271, 7);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(105, 41);
            this.btn_new.TabIndex = 1;
            this.btn_new.Text = "جديد";
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_delete.Location = new System.Drawing.Point(149, 7);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(105, 41);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_add.Location = new System.Drawing.Point(388, 7);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(161, 41);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "اضافة وطباعه";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_deleteall);
            this.groupBox3.Controls.Add(this.btn_new);
            this.groupBox3.Controls.Add(this.btn_delete);
            this.groupBox3.Controls.Add(this.btn_add);
            this.groupBox3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(40, 230);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(557, 57);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_from);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtp_date);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nud_price);
            this.groupBox1.Controls.Add(this.txt_reason);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(5, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txt_from
            // 
            this.txt_from.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_from.Location = new System.Drawing.Point(6, 47);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(189, 32);
            this.txt_from.TabIndex = 3;
            this.txt_from.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(201, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "قبض من:";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(314, 47);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(172, 32);
            this.txt_name.TabIndex = 0;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_sanadkabd
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(639, 292);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frm_sanadkabd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سند قبض";
            this.Load += new System.EventHandler(this.frm_sanadkabd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_price;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_next;
        private DevExpress.XtraEditors.SimpleButton btn_priv;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btn_first;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btn_last;
        private DevExpress.XtraEditors.SimpleButton btn_deleteall;
        private DevExpress.XtraEditors.SimpleButton btn_new;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_from;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_name;
    }
}