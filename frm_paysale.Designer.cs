namespace sales
{
    partial class frm_paysale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_paysale));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_return = new DevExpress.XtraEditors.SimpleButton();
            this.btn_enter = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_matloop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_madfooE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_baky = new System.Windows.Forms.TextBox();
            this.checkVisa = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(99, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 33);
            this.label5.TabIndex = 45;
            this.label5.Text = "Enter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(308, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 33);
            this.label4.TabIndex = 44;
            this.label4.Text = "f12";
            // 
            // btn_return
            // 
            this.btn_return.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Appearance.Options.UseFont = true;
            this.btn_return.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_return.ImageOptions.Image")));
            this.btn_return.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_return.Location = new System.Drawing.Point(275, 261);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(108, 41);
            this.btn_return.TabIndex = 43;
            this.btn_return.Text = "رجوع";
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.Appearance.Options.UseFont = true;
            this.btn_enter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_enter.ImageOptions.Image")));
            this.btn_enter.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_enter.Location = new System.Drawing.Point(48, 261);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(202, 41);
            this.btn_enter.TabIndex = 42;
            this.btn_enter.Text = "للحفظ والطباعه انتر";
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 31);
            this.label3.TabIndex = 41;
            this.label3.Text = "المطلوب:";
            // 
            // txt_matloop
            // 
            this.txt_matloop.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matloop.Location = new System.Drawing.Point(115, 14);
            this.txt_matloop.Multiline = true;
            this.txt_matloop.Name = "txt_matloop";
            this.txt_matloop.ReadOnly = true;
            this.txt_matloop.Size = new System.Drawing.Size(274, 48);
            this.txt_matloop.TabIndex = 40;
            this.txt_matloop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 31);
            this.label2.TabIndex = 39;
            this.label2.Text = "المدفوع:";
            // 
            // txt_madfooE
            // 
            this.txt_madfooE.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_madfooE.Location = new System.Drawing.Point(115, 93);
            this.txt_madfooE.Multiline = true;
            this.txt_madfooE.Name = "txt_madfooE";
            this.txt_madfooE.Size = new System.Drawing.Size(274, 48);
            this.txt_madfooE.TabIndex = 38;
            this.txt_madfooE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_madfooE.TextChanged += new System.EventHandler(this.txt_madfooE_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 31);
            this.label1.TabIndex = 37;
            this.label1.Text = "الباقي:";
            // 
            // txt_baky
            // 
            this.txt_baky.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_baky.Location = new System.Drawing.Point(115, 168);
            this.txt_baky.Multiline = true;
            this.txt_baky.Name = "txt_baky";
            this.txt_baky.ReadOnly = true;
            this.txt_baky.Size = new System.Drawing.Size(274, 48);
            this.txt_baky.TabIndex = 36;
            this.txt_baky.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkVisa
            // 
            this.checkVisa.AutoSize = true;
            this.checkVisa.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkVisa.Location = new System.Drawing.Point(115, 222);
            this.checkVisa.Name = "checkVisa";
            this.checkVisa.Size = new System.Drawing.Size(253, 35);
            this.checkVisa.TabIndex = 46;
            this.checkVisa.Text = "دفع عن طريق البطاقه الائتمانية";
            this.checkVisa.UseVisualStyleBackColor = true;
            // 
            // frm_paysale
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(401, 350);
            this.Controls.Add(this.checkVisa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_matloop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_madfooE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_baky);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_paysale";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_paysale_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_paysale_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btn_return;
        private DevExpress.XtraEditors.SimpleButton btn_enter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_matloop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_madfooE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_baky;
        private System.Windows.Forms.CheckBox checkVisa;
    }
}