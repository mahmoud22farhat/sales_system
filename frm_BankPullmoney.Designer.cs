namespace sales
{
    partial class frm_BankPullmoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BankPullmoney));
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Mony = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_price = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Appearance.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.ImageOptions.Image")));
            this.btn_add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_add.Location = new System.Drawing.Point(136, 261);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(200, 52);
            this.btn_add.TabIndex = 46;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_reason
            // 
            this.txt_reason.Location = new System.Drawing.Point(136, 188);
            this.txt_reason.Multiline = true;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(200, 67);
            this.txt_reason.TabIndex = 45;
            this.txt_reason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(16, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 27);
            this.label7.TabIndex = 44;
            this.label7.Text = "سبب السحب :";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(136, 147);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(200, 35);
            this.txt_name.TabIndex = 43;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(20, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 27);
            this.label6.TabIndex = 42;
            this.label6.Text = "اسم الساحب :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(20, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 27);
            this.label4.TabIndex = 41;
            this.label4.Text = "تاريخ السحب :";
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(136, 115);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_date.Size = new System.Drawing.Size(200, 26);
            this.dtp_date.TabIndex = 40;
            this.dtp_date.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(5, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 27);
            this.label2.TabIndex = 39;
            this.label2.Text = "المبلغ المراد سحبه :";
            // 
            // lbl_Mony
            // 
            this.lbl_Mony.AutoSize = true;
            this.lbl_Mony.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mony.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Mony.Location = new System.Drawing.Point(229, 4);
            this.lbl_Mony.Name = "lbl_Mony";
            this.lbl_Mony.Size = new System.Drawing.Size(36, 27);
            this.lbl_Mony.TabIndex = 38;
            this.lbl_Mony.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(5, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 27);
            this.label3.TabIndex = 37;
            this.label3.Text = "رصيد البنك الحالي هو :";
            // 
            // nud_price
            // 
            this.nud_price.DecimalPlaces = 2;
            this.nud_price.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_price.Location = new System.Drawing.Point(136, 57);
            this.nud_price.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nud_price.Name = "nud_price";
            this.nud_price.Size = new System.Drawing.Size(200, 32);
            this.nud_price.TabIndex = 36;
            this.nud_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frm_BankPullmoney
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(350, 325);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Mony);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nud_price);
            this.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "frm_BankPullmoney";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سحب رصيد من البنك";
            this.Load += new System.EventHandler(this.frm_BankPullmoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Mony;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_price;
    }
}