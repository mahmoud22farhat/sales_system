namespace sales
{
    partial class frm_currentMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_currentMoney));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_MoneyBank = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_MoneyStock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_stock = new System.Windows.Forms.ComboBox();
            this.btn_stock = new DevExpress.XtraEditors.SimpleButton();
            this.btn_bank = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_MoneyBank);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_MoneyStock);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbx_stock);
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(393, 149);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lbl_MoneyBank
            // 
            this.lbl_MoneyBank.AutoSize = true;
            this.lbl_MoneyBank.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MoneyBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_MoneyBank.Location = new System.Drawing.Point(121, 108);
            this.lbl_MoneyBank.Name = "lbl_MoneyBank";
            this.lbl_MoneyBank.Size = new System.Drawing.Size(28, 25);
            this.lbl_MoneyBank.TabIndex = 40;
            this.lbl_MoneyBank.Text = "....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(218, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "رصيد البنك الحالي هو:";
            // 
            // lbl_MoneyStock
            // 
            this.lbl_MoneyStock.AutoSize = true;
            this.lbl_MoneyStock.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MoneyStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_MoneyStock.Location = new System.Drawing.Point(121, 58);
            this.lbl_MoneyStock.Name = "lbl_MoneyStock";
            this.lbl_MoneyStock.Size = new System.Drawing.Size(28, 25);
            this.lbl_MoneyStock.TabIndex = 38;
            this.lbl_MoneyStock.Text = "....";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(237, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "رصيد الخزنة المحددة:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(285, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "اختر خزنة:";
            // 
            // cbx_stock
            // 
            this.cbx_stock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_stock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_stock.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_stock.FormattingEnabled = true;
            this.cbx_stock.Location = new System.Drawing.Point(10, 5);
            this.cbx_stock.Name = "cbx_stock";
            this.cbx_stock.Size = new System.Drawing.Size(269, 33);
            this.cbx_stock.TabIndex = 35;
            this.cbx_stock.SelectionChangeCommitted += new System.EventHandler(this.cbx_stock_SelectionChangeCommitted);
            // 
            // btn_stock
            // 
            this.btn_stock.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock.Appearance.Options.UseFont = true;
            this.btn_stock.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_stock.ImageOptions.Image")));
            this.btn_stock.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_stock.Location = new System.Drawing.Point(9, 162);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(186, 49);
            this.btn_stock.TabIndex = 35;
            this.btn_stock.Text = "ايداع رصيد في الخزنه";
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // btn_bank
            // 
            this.btn_bank.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bank.Appearance.Options.UseFont = true;
            this.btn_bank.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_bank.ImageOptions.Image")));
            this.btn_bank.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_bank.Location = new System.Drawing.Point(212, 162);
            this.btn_bank.Name = "btn_bank";
            this.btn_bank.Size = new System.Drawing.Size(181, 49);
            this.btn_bank.TabIndex = 36;
            this.btn_bank.Text = "ايداع رصيد في البنك";
            this.btn_bank.Click += new System.EventHandler(this.btn_bank_Click);
            // 
            // frm_currentMoney
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(406, 217);
            this.Controls.Add(this.btn_bank);
            this.Controls.Add(this.btn_stock);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "frm_currentMoney";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "رصيد الخزنه والبنك الحالي";
            this.Load += new System.EventHandler(this.frm_currentMoney_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_MoneyBank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_MoneyStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_stock;
        private DevExpress.XtraEditors.SimpleButton btn_stock;
        private DevExpress.XtraEditors.SimpleButton btn_bank;
    }
}