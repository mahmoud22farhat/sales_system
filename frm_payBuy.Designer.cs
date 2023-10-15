namespace sales
{
    partial class frm_payBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_payBuy));
            this.btn_enter = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_matloop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_madfooE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_baky = new System.Windows.Forms.TextBox();
            this.btn_return = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_enter
            // 
            this.btn_enter.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.Appearance.Options.UseFont = true;
            this.btn_enter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_enter.ImageOptions.Image")));
            this.btn_enter.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_enter.Location = new System.Drawing.Point(10, 241);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(232, 41);
            this.btn_enter.TabIndex = 13;
            this.btn_enter.Text = "للحفظ والطباعه انتر";
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "المطلوب :";
            // 
            // txt_matloop
            // 
            this.txt_matloop.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matloop.Location = new System.Drawing.Point(125, 11);
            this.txt_matloop.Multiline = true;
            this.txt_matloop.Name = "txt_matloop";
            this.txt_matloop.ReadOnly = true;
            this.txt_matloop.Size = new System.Drawing.Size(239, 48);
            this.txt_matloop.TabIndex = 11;
            this.txt_matloop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_matloop.TextChanged += new System.EventHandler(this.txt_matloop_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "المدفوع :";
            // 
            // txt_madfooE
            // 
            this.txt_madfooE.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_madfooE.Location = new System.Drawing.Point(125, 90);
            this.txt_madfooE.Multiline = true;
            this.txt_madfooE.Name = "txt_madfooE";
            this.txt_madfooE.Size = new System.Drawing.Size(239, 48);
            this.txt_madfooE.TabIndex = 9;
            this.txt_madfooE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_madfooE.TextChanged += new System.EventHandler(this.txt_madfooE_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "الباقي :";
            // 
            // txt_baky
            // 
            this.txt_baky.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_baky.Location = new System.Drawing.Point(125, 165);
            this.txt_baky.Multiline = true;
            this.txt_baky.Name = "txt_baky";
            this.txt_baky.ReadOnly = true;
            this.txt_baky.Size = new System.Drawing.Size(239, 48);
            this.txt_baky.TabIndex = 7;
            this.txt_baky.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_return
            // 
            this.btn_return.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Appearance.Options.UseFont = true;
            this.btn_return.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_return.ImageOptions.Image")));
            this.btn_return.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_return.Location = new System.Drawing.Point(267, 241);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(108, 41);
            this.btn_return.TabIndex = 14;
            this.btn_return.Text = "رجوع";
            this.btn_return.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(300, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 33);
            this.label4.TabIndex = 34;
            this.label4.Text = "f12";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(91, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 33);
            this.label5.TabIndex = 35;
            this.label5.Text = "Enter";
            // 
            // frm_payBuy
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(401, 336);
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
            this.Name = "frm_payBuy";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_payBuy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_payBuy_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_enter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_matloop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_madfooE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_baky;
        private DevExpress.XtraEditors.SimpleButton btn_return;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}