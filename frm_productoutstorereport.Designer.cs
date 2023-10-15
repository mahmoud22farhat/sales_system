namespace sales
{
    partial class frm_productoutstorereport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_productoutstorereport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtn_onestore = new System.Windows.Forms.RadioButton();
            this.rbtn_allstore = new System.Windows.Forms.RadioButton();
            this.cbx_store = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Dgv_search = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_print = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_total
            // 
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_total.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(802, 367);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(141, 32);
            this.txt_total.TabIndex = 71;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_delete.Location = new System.Drawing.Point(162, 364);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(138, 34);
            this.btn_delete.TabIndex = 70;
            this.btn_delete.Text = "مسح البيانات";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.ImageOptions.Image")));
            this.btn_search.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_search.Location = new System.Drawing.Point(358, 49);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(242, 34);
            this.btn_search.TabIndex = 68;
            this.btn_search.Text = "بحث";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(132, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "الي:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(308, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "من:";
            // 
            // dtp_to
            // 
            this.dtp_to.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_to.Location = new System.Drawing.Point(6, 8);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_to.Size = new System.Drawing.Size(120, 26);
            this.dtp_to.TabIndex = 8;
            this.dtp_to.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // dtp_from
            // 
            this.dtp_from.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_from.Location = new System.Drawing.Point(178, 8);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_from.Size = new System.Drawing.Size(124, 26);
            this.dtp_from.TabIndex = 7;
            this.dtp_from.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtp_to);
            this.groupBox3.Controls.Add(this.dtp_from);
            this.groupBox3.Location = new System.Drawing.Point(606, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 41);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            // 
            // rbtn_onestore
            // 
            this.rbtn_onestore.AutoSize = true;
            this.rbtn_onestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_onestore.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_onestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_onestore.Location = new System.Drawing.Point(127, 20);
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
            this.rbtn_allstore.Location = new System.Drawing.Point(233, 20);
            this.rbtn_allstore.Name = "rbtn_allstore";
            this.rbtn_allstore.Size = new System.Drawing.Size(101, 32);
            this.rbtn_allstore.TabIndex = 1;
            this.rbtn_allstore.TabStop = true;
            this.rbtn_allstore.Text = "كل المخازن";
            this.rbtn_allstore.UseVisualStyleBackColor = false;
            // 
            // cbx_store
            // 
            this.cbx_store.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_store.FormattingEnabled = true;
            this.cbx_store.Location = new System.Drawing.Point(0, 20);
            this.cbx_store.Name = "cbx_store";
            this.cbx_store.Size = new System.Drawing.Size(121, 30);
            this.cbx_store.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(636, 371);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 28);
            this.label14.TabIndex = 72;
            this.label14.Text = "اجمال الكميات التالفة:\r\n";
            // 
            // Dgv_search
            // 
            this.Dgv_search.AllowUserToAddRows = false;
            this.Dgv_search.AllowUserToDeleteRows = false;
            this.Dgv_search.AllowUserToResizeColumns = false;
            this.Dgv_search.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dgv_search.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dgv_search.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_search.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_search.Location = new System.Drawing.Point(12, 91);
            this.Dgv_search.Name = "Dgv_search";
            this.Dgv_search.ReadOnly = true;
            this.Dgv_search.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_search.Size = new System.Drawing.Size(931, 270);
            this.Dgv_search.TabIndex = 69;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_onestore);
            this.groupBox1.Controls.Add(this.rbtn_allstore);
            this.groupBox1.Controls.Add(this.cbx_store);
            this.groupBox1.Location = new System.Drawing.Point(10, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 52);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المخازن المحول منها";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(288, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 40);
            this.label2.TabIndex = 64;
            this.label2.Text = "تقرير اخراج المنتجات التالفة من المخزن";
            // 
            // btn_print
            // 
            this.btn_print.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Appearance.Options.UseFont = true;
            this.btn_print.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_print.ImageOptions.Image")));
            this.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_print.Location = new System.Drawing.Point(10, 367);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(146, 31);
            this.btn_print.TabIndex = 73;
            this.btn_print.Text = "طباعة";
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // frm_productoutstorereport
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(950, 408);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Dgv_search);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "frm_productoutstorereport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير اخراج المنتجات التالفة من المخزن";
            this.Load += new System.EventHandler(this.frm_productoutstorereport_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_total;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtn_onestore;
        private System.Windows.Forms.RadioButton rbtn_allstore;
        private System.Windows.Forms.ComboBox cbx_store;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView Dgv_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_print;
    }
}