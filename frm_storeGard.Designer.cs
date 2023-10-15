namespace sales
{
    partial class frm_storeGard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_storeGard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.rbtn_onestore = new System.Windows.Forms.RadioButton();
            this.rbtn_allstore = new System.Windows.Forms.RadioButton();
            this.cbx_store = new System.Windows.Forms.ComboBox();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_search = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_totalsale = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_totalbuy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_rep7h = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_onestore);
            this.groupBox1.Controls.Add(this.rbtn_allstore);
            this.groupBox1.Controls.Add(this.cbx_store);
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 58);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            // 
            // btn_search
            // 
            this.btn_search.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.ImageOptions.Image")));
            this.btn_search.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_search.Location = new System.Drawing.Point(407, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(238, 34);
            this.btn_search.TabIndex = 14;
            this.btn_search.Text = "جرد المخازن";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // rbtn_onestore
            // 
            this.rbtn_onestore.AutoSize = true;
            this.rbtn_onestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_onestore.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_onestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_onestore.Location = new System.Drawing.Point(135, 11);
            this.rbtn_onestore.Name = "rbtn_onestore";
            this.rbtn_onestore.Size = new System.Drawing.Size(103, 32);
            this.rbtn_onestore.TabIndex = 2;
            this.rbtn_onestore.Text = "مخزن محدد";
            this.rbtn_onestore.UseVisualStyleBackColor = false;
            // 
            // rbtn_allstore
            // 
            this.rbtn_allstore.AutoSize = true;
            this.rbtn_allstore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_allstore.Checked = true;
            this.rbtn_allstore.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_allstore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_allstore.Location = new System.Drawing.Point(239, 11);
            this.rbtn_allstore.Name = "rbtn_allstore";
            this.rbtn_allstore.Size = new System.Drawing.Size(101, 32);
            this.rbtn_allstore.TabIndex = 1;
            this.rbtn_allstore.TabStop = true;
            this.rbtn_allstore.Text = "كل المخازن";
            this.rbtn_allstore.UseVisualStyleBackColor = false;
            // 
            // cbx_store
            // 
            this.cbx_store.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_store.FormattingEnabled = true;
            this.cbx_store.Location = new System.Drawing.Point(8, 11);
            this.cbx_store.Name = "cbx_store";
            this.cbx_store.Size = new System.Drawing.Size(121, 32);
            this.cbx_store.TabIndex = 0;
            // 
            // txtbarcode
            // 
            this.txtbarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbarcode.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbarcode.Location = new System.Drawing.Point(859, 70);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(157, 32);
            this.txtbarcode.TabIndex = 81;
            this.txtbarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbarcode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(750, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 82;
            this.label2.Text = "بحث بالباركود:";
            // 
            // Dgv_search
            // 
            this.Dgv_search.AllowUserToAddRows = false;
            this.Dgv_search.AllowUserToDeleteRows = false;
            this.Dgv_search.AllowUserToResizeColumns = false;
            this.Dgv_search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_search.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_search.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_search.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_search.Location = new System.Drawing.Point(9, 121);
            this.Dgv_search.Name = "Dgv_search";
            this.Dgv_search.ReadOnly = true;
            this.Dgv_search.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_search.Size = new System.Drawing.Size(1007, 316);
            this.Dgv_search.TabIndex = 83;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(604, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 28);
            this.label5.TabIndex = 89;
            this.label5.Text = "اجمالي مبلغ المنجات(مبلغ البيع):";
            // 
            // txt_totalsale
            // 
            this.txt_totalsale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_totalsale.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalsale.Location = new System.Drawing.Point(834, 448);
            this.txt_totalsale.Multiline = true;
            this.txt_totalsale.Name = "txt_totalsale";
            this.txt_totalsale.ReadOnly = true;
            this.txt_totalsale.Size = new System.Drawing.Size(182, 32);
            this.txt_totalsale.TabIndex = 88;
            this.txt_totalsale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(250, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 28);
            this.label4.TabIndex = 87;
            this.label4.Text = "اجمالي مبلغ المنجات(مبلغ الشراء):";
            // 
            // txt_totalbuy
            // 
            this.txt_totalbuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_totalbuy.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalbuy.Location = new System.Drawing.Point(490, 448);
            this.txt_totalbuy.Multiline = true;
            this.txt_totalbuy.Name = "txt_totalbuy";
            this.txt_totalbuy.ReadOnly = true;
            this.txt_totalbuy.Size = new System.Drawing.Size(113, 32);
            this.txt_totalbuy.TabIndex = 86;
            this.txt_totalbuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(7, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 28);
            this.label3.TabIndex = 85;
            this.label3.Text = "الارباح المتوقعه:";
            // 
            // txt_rep7h
            // 
            this.txt_rep7h.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_rep7h.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rep7h.Location = new System.Drawing.Point(133, 448);
            this.txt_rep7h.Multiline = true;
            this.txt_rep7h.Name = "txt_rep7h";
            this.txt_rep7h.ReadOnly = true;
            this.txt_rep7h.Size = new System.Drawing.Size(111, 32);
            this.txt_rep7h.TabIndex = 84;
            this.txt_rep7h.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_storeGard
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1024, 497);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_totalsale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_totalbuy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_rep7h);
            this.Controls.Add(this.Dgv_search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "frm_storeGard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جرد المخازن";
            this.Load += new System.EventHandler(this.frm_storeGard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_onestore;
        private System.Windows.Forms.RadioButton rbtn_allstore;
        private System.Windows.Forms.ComboBox cbx_store;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_totalsale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_totalbuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_rep7h;
    }
}