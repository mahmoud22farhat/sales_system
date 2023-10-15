namespace sales
{
    partial class frm_storetransferreport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_storetransferreport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_onestorefrom = new System.Windows.Forms.RadioButton();
            this.rbtn_allstorefrom = new System.Windows.Forms.RadioButton();
            this.cbx_storefrom = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtn_onestoreto = new System.Windows.Forms.RadioButton();
            this.rbtn_allstoreto = new System.Windows.Forms.RadioButton();
            this.cbx_storeto = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.Dgv_search = new System.Windows.Forms.DataGridView();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(412, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 40);
            this.label2.TabIndex = 53;
            this.label2.Text = "اجمالي  المنتجات المحوله";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_onestorefrom);
            this.groupBox1.Controls.Add(this.rbtn_allstorefrom);
            this.groupBox1.Controls.Add(this.cbx_storefrom);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 52);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المخازن المحول منها";
            // 
            // rbtn_onestorefrom
            // 
            this.rbtn_onestorefrom.AutoSize = true;
            this.rbtn_onestorefrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_onestorefrom.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_onestorefrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_onestorefrom.Location = new System.Drawing.Point(127, 20);
            this.rbtn_onestorefrom.Name = "rbtn_onestorefrom";
            this.rbtn_onestorefrom.Size = new System.Drawing.Size(103, 32);
            this.rbtn_onestorefrom.TabIndex = 2;
            this.rbtn_onestorefrom.Text = "مخزن محدد";
            this.rbtn_onestorefrom.UseVisualStyleBackColor = false;
            // 
            // rbtn_allstorefrom
            // 
            this.rbtn_allstorefrom.AutoSize = true;
            this.rbtn_allstorefrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_allstorefrom.Checked = true;
            this.rbtn_allstorefrom.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_allstorefrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_allstorefrom.Location = new System.Drawing.Point(233, 20);
            this.rbtn_allstorefrom.Name = "rbtn_allstorefrom";
            this.rbtn_allstorefrom.Size = new System.Drawing.Size(101, 32);
            this.rbtn_allstorefrom.TabIndex = 1;
            this.rbtn_allstorefrom.TabStop = true;
            this.rbtn_allstorefrom.Text = "كل المخازن";
            this.rbtn_allstorefrom.UseVisualStyleBackColor = false;
            // 
            // cbx_storefrom
            // 
            this.cbx_storefrom.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_storefrom.FormattingEnabled = true;
            this.cbx_storefrom.Location = new System.Drawing.Point(0, 20);
            this.cbx_storefrom.Name = "cbx_storefrom";
            this.cbx_storefrom.Size = new System.Drawing.Size(121, 30);
            this.cbx_storefrom.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtn_onestoreto);
            this.groupBox2.Controls.Add(this.rbtn_allstoreto);
            this.groupBox2.Controls.Add(this.cbx_storeto);
            this.groupBox2.Location = new System.Drawing.Point(360, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 52);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المخازن المحول لها";
            // 
            // rbtn_onestoreto
            // 
            this.rbtn_onestoreto.AutoSize = true;
            this.rbtn_onestoreto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_onestoreto.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_onestoreto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_onestoreto.Location = new System.Drawing.Point(127, 20);
            this.rbtn_onestoreto.Name = "rbtn_onestoreto";
            this.rbtn_onestoreto.Size = new System.Drawing.Size(103, 32);
            this.rbtn_onestoreto.TabIndex = 2;
            this.rbtn_onestoreto.Text = "مخزن محدد";
            this.rbtn_onestoreto.UseVisualStyleBackColor = false;
            // 
            // rbtn_allstoreto
            // 
            this.rbtn_allstoreto.AutoSize = true;
            this.rbtn_allstoreto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_allstoreto.Checked = true;
            this.rbtn_allstoreto.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_allstoreto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbtn_allstoreto.Location = new System.Drawing.Point(233, 20);
            this.rbtn_allstoreto.Name = "rbtn_allstoreto";
            this.rbtn_allstoreto.Size = new System.Drawing.Size(101, 32);
            this.rbtn_allstoreto.TabIndex = 1;
            this.rbtn_allstoreto.TabStop = true;
            this.rbtn_allstoreto.Text = "كل المخازن";
            this.rbtn_allstoreto.UseVisualStyleBackColor = false;
            // 
            // cbx_storeto
            // 
            this.cbx_storeto.Font = new System.Drawing.Font("Droid Arabic Kufi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_storeto.FormattingEnabled = true;
            this.cbx_storeto.Location = new System.Drawing.Point(0, 20);
            this.cbx_storeto.Name = "cbx_storeto";
            this.cbx_storeto.Size = new System.Drawing.Size(121, 30);
            this.cbx_storeto.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtp_to);
            this.groupBox3.Controls.Add(this.dtp_from);
            this.groupBox3.Location = new System.Drawing.Point(709, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(343, 41);
            this.groupBox3.TabIndex = 55;
            this.groupBox3.TabStop = false;
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
            // btn_search
            // 
            this.btn_search.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.ImageOptions.Image")));
            this.btn_search.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_search.Location = new System.Drawing.Point(419, 43);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(242, 34);
            this.btn_search.TabIndex = 56;
            this.btn_search.Text = "بحث";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_search.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_search.Location = new System.Drawing.Point(12, 143);
            this.Dgv_search.Name = "Dgv_search";
            this.Dgv_search.ReadOnly = true;
            this.Dgv_search.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_search.Size = new System.Drawing.Size(1040, 270);
            this.Dgv_search.TabIndex = 57;
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_delete.Location = new System.Drawing.Point(12, 424);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(138, 34);
            this.btn_delete.TabIndex = 59;
            this.btn_delete.Text = "مسح البيانات";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(745, 423);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 28);
            this.label14.TabIndex = 63;
            this.label14.Text = "اجمال الكميات المحوله:";
            // 
            // txt_total
            // 
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_total.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(911, 419);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(141, 32);
            this.txt_total.TabIndex = 62;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_storetransferreport
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1064, 464);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.Dgv_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "frm_storetransferreport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير المنتجات المحوله";
            this.Load += new System.EventHandler(this.frm_storetransferreport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_onestorefrom;
        private System.Windows.Forms.RadioButton rbtn_allstorefrom;
        private System.Windows.Forms.ComboBox cbx_storefrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtn_onestoreto;
        private System.Windows.Forms.RadioButton rbtn_allstoreto;
        private System.Windows.Forms.ComboBox cbx_storeto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.DataGridView Dgv_search;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_total;
    }
}