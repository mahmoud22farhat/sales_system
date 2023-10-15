namespace sales
{
    partial class frm_saleQty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_saleQty));
            this.btn_enter = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_discound = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_saleprice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Qty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_unit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_enter
            // 
            this.btn_enter.Appearance.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.Appearance.Options.UseFont = true;
            this.btn_enter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_enter.ImageOptions.Image")));
            this.btn_enter.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_enter.Location = new System.Drawing.Point(7, 258);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(311, 41);
            this.btn_enter.TabIndex = 13;
            this.btn_enter.Text = "اضغط انتر";
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "الخصم:";
            // 
            // txt_discound
            // 
            this.txt_discound.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discound.Location = new System.Drawing.Point(122, 12);
            this.txt_discound.Multiline = true;
            this.txt_discound.Name = "txt_discound";
            this.txt_discound.Size = new System.Drawing.Size(196, 48);
            this.txt_discound.TabIndex = 11;
            this.txt_discound.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_discound.TextChanged += new System.EventHandler(this.txt_discound_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "سعر البيع:";
            // 
            // txt_saleprice
            // 
            this.txt_saleprice.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_saleprice.Location = new System.Drawing.Point(122, 125);
            this.txt_saleprice.Multiline = true;
            this.txt_saleprice.Name = "txt_saleprice";
            this.txt_saleprice.Size = new System.Drawing.Size(196, 48);
            this.txt_saleprice.TabIndex = 9;
            this.txt_saleprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "الكميه:";
            // 
            // txt_Qty
            // 
            this.txt_Qty.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Qty.Location = new System.Drawing.Point(122, 189);
            this.txt_Qty.Multiline = true;
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(196, 48);
            this.txt_Qty.TabIndex = 7;
            this.txt_Qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(28, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 31);
            this.label4.TabIndex = 33;
            this.label4.Text = "اختر وحدة:";
            // 
            // cbx_unit
            // 
            this.cbx_unit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_unit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_unit.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_unit.FormattingEnabled = true;
            this.cbx_unit.Location = new System.Drawing.Point(122, 66);
            this.cbx_unit.Name = "cbx_unit";
            this.cbx_unit.Size = new System.Drawing.Size(196, 44);
            this.cbx_unit.TabIndex = 32;
            this.cbx_unit.SelectionChangeCommitted += new System.EventHandler(this.cbx_unit_SelectionChangeCommitted);
            // 
            // frm_saleQty
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(329, 318);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbx_unit);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_discound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_saleprice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Qty);
            this.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frm_saleQty";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_saleQty_FormClosing);
            this.Load += new System.EventHandler(this.frm_saleQty_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_saleQty_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_enter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_discound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_saleprice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Qty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_unit;
    }
}