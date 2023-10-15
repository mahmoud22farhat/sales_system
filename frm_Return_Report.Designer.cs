namespace sales
{
    partial class frm_Return_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Return_Report));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtn_salesReturn = new System.Windows.Forms.RadioButton();
            this.rbtn_allReturn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_buyReturn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_to = new System.Windows.Forms.DateTimePicker();
            this.dtp_from = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new DevExpress.XtraEditors.SimpleButton();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.Dgv_search = new System.Windows.Forms.DataGridView();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txttotaltax = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(397, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 40);
            this.label2.TabIndex = 53;
            this.label2.Text = "تقارير المرتجعات في فتره";
            // 
            // rbtn_salesReturn
            // 
            this.rbtn_salesReturn.AutoSize = true;
            this.rbtn_salesReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_salesReturn.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbtn_salesReturn.ForeColor = System.Drawing.Color.SlateBlue;
            this.rbtn_salesReturn.Location = new System.Drawing.Point(184, 28);
            this.rbtn_salesReturn.Name = "rbtn_salesReturn";
            this.rbtn_salesReturn.Size = new System.Drawing.Size(150, 32);
            this.rbtn_salesReturn.TabIndex = 2;
            this.rbtn_salesReturn.Text = "مرتجعات مبيعات";
            this.rbtn_salesReturn.UseVisualStyleBackColor = false;
            // 
            // rbtn_allReturn
            // 
            this.rbtn_allReturn.AutoSize = true;
            this.rbtn_allReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_allReturn.Checked = true;
            this.rbtn_allReturn.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_allReturn.ForeColor = System.Drawing.Color.SlateBlue;
            this.rbtn_allReturn.Location = new System.Drawing.Point(340, 28);
            this.rbtn_allReturn.Name = "rbtn_allReturn";
            this.rbtn_allReturn.Size = new System.Drawing.Size(130, 32);
            this.rbtn_allReturn.TabIndex = 1;
            this.rbtn_allReturn.TabStop = true;
            this.rbtn_allReturn.Text = "كل المرتجعات";
            this.rbtn_allReturn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_buyReturn);
            this.groupBox1.Controls.Add(this.rbtn_salesReturn);
            this.groupBox1.Controls.Add(this.rbtn_allReturn);
            this.groupBox1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(3, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 62);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فلترة البحث";
            // 
            // rbtn_buyReturn
            // 
            this.rbtn_buyReturn.AutoSize = true;
            this.rbtn_buyReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.rbtn_buyReturn.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold);
            this.rbtn_buyReturn.ForeColor = System.Drawing.Color.SlateBlue;
            this.rbtn_buyReturn.Location = new System.Drawing.Point(6, 30);
            this.rbtn_buyReturn.Name = "rbtn_buyReturn";
            this.rbtn_buyReturn.Size = new System.Drawing.Size(162, 32);
            this.rbtn_buyReturn.TabIndex = 3;
            this.rbtn_buyReturn.Text = "مرتجعات مشتريات";
            this.rbtn_buyReturn.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtp_to);
            this.groupBox2.Controls.Add(this.dtp_from);
            this.groupBox2.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(485, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 62);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "حدد فتره";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.SlateBlue;
            this.label3.Location = new System.Drawing.Point(121, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "الي:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(284, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "من:";
            // 
            // dtp_to
            // 
            this.dtp_to.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_to.Location = new System.Drawing.Point(6, 28);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_to.Size = new System.Drawing.Size(109, 32);
            this.dtp_to.TabIndex = 8;
            this.dtp_to.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // dtp_from
            // 
            this.dtp_from.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_from.Location = new System.Drawing.Point(171, 28);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_from.Size = new System.Drawing.Size(107, 32);
            this.dtp_from.TabIndex = 7;
            this.dtp_from.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // btn_search
            // 
            this.btn_search.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_search.Appearance.Options.UseFont = true;
            this.btn_search.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.ImageOptions.Image")));
            this.btn_search.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_search.Location = new System.Drawing.Point(846, 65);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(174, 42);
            this.btn_search.TabIndex = 56;
            this.btn_search.Text = "بحث";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(722, 395);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 28);
            this.label14.TabIndex = 64;
            this.label14.Text = "اجمالي المرتجعات:";
            // 
            // txt_total
            // 
            this.txt_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_total.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F);
            this.txt_total.Location = new System.Drawing.Point(871, 391);
            this.txt_total.Multiline = true;
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(149, 32);
            this.txt_total.TabIndex = 63;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_search.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_search.Location = new System.Drawing.Point(3, 115);
            this.Dgv_search.Name = "Dgv_search";
            this.Dgv_search.ReadOnly = true;
            this.Dgv_search.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_search.Size = new System.Drawing.Size(1017, 270);
            this.Dgv_search.TabIndex = 62;
            // 
            // btn_delete
            // 
            this.btn_delete.Appearance.BackColor = System.Drawing.Color.Red;
            this.btn_delete.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_delete.Appearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseBackColor = true;
            this.btn_delete.Appearance.Options.UseBorderColor = true;
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btn_delete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.ImageOptions.Image")));
            this.btn_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_delete.Location = new System.Drawing.Point(3, 391);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(138, 40);
            this.btn_delete.TabIndex = 65;
            this.btn_delete.Text = "مسح ";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(418, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 28);
            this.label4.TabIndex = 67;
            this.label4.Text = "اجمالي الضرائب:";
            // 
            // txttotaltax
            // 
            this.txttotaltax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotaltax.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotaltax.Location = new System.Drawing.Point(556, 391);
            this.txttotaltax.Multiline = true;
            this.txttotaltax.Name = "txttotaltax";
            this.txttotaltax.Size = new System.Drawing.Size(149, 32);
            this.txttotaltax.TabIndex = 66;
            this.txttotaltax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_Return_Report
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1032, 437);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttotaltax);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.Dgv_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "frm_Return_Report";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير المرتجعات";
            this.Load += new System.EventHandler(this.Return_Report_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtn_salesReturn;
        private System.Windows.Forms.RadioButton rbtn_allReturn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_buyReturn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_to;
        private System.Windows.Forms.DateTimePicker dtp_from;
        private DevExpress.XtraEditors.SimpleButton btn_search;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.DataGridView Dgv_search;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttotaltax;
    }
}