namespace sales
{
    partial class frm_EmployeeBorrowMoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EmployeeBorrowMoney));
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_creditor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.Rbtn_employee = new System.Windows.Forms.RadioButton();
            this.Rbtn_Normal = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_employee = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_reminder = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_price = new System.Windows.Forms.NumericUpDown();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.ImageOptions.Image")));
            this.btn_save.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter;
            this.btn_save.Location = new System.Drawing.Point(237, 255);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(194, 41);
            this.btn_save.TabIndex = 23;
            this.btn_save.Text = "حفظ العمليه";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(270, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 36);
            this.label6.TabIndex = 21;
            this.label6.Text = "السلفيات";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_notes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_date);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_creditor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.Rbtn_employee);
            this.groupBox1.Controls.Add(this.Rbtn_Normal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbx_employee);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtp_reminder);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nud_price);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(3, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 208);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(180, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "ملاحظات:";
            // 
            // txt_notes
            // 
            this.txt_notes.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_notes.Location = new System.Drawing.Point(1, 143);
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(172, 65);
            this.txt_notes.TabIndex = 21;
            this.txt_notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(180, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "تاريخ السلف:";
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(1, 14);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_date.Size = new System.Drawing.Size(172, 32);
            this.dtp_date.TabIndex = 18;
            this.dtp_date.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(514, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "اسم الدائن:";
            // 
            // txt_creditor
            // 
            this.txt_creditor.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_creditor.Location = new System.Drawing.Point(336, 173);
            this.txt_creditor.Name = "txt_creditor";
            this.txt_creditor.Size = new System.Drawing.Size(172, 32);
            this.txt_creditor.TabIndex = 17;
            this.txt_creditor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(514, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "اسم الشخص:";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(336, 91);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(172, 32);
            this.txt_name.TabIndex = 15;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Rbtn_employee
            // 
            this.Rbtn_employee.AutoSize = true;
            this.Rbtn_employee.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_employee.Location = new System.Drawing.Point(332, 50);
            this.Rbtn_employee.Name = "Rbtn_employee";
            this.Rbtn_employee.Size = new System.Drawing.Size(67, 29);
            this.Rbtn_employee.TabIndex = 13;
            this.Rbtn_employee.Text = "موظف";
            this.Rbtn_employee.UseVisualStyleBackColor = true;
            this.Rbtn_employee.CheckedChanged += new System.EventHandler(this.Rbtn_employee_CheckedChanged);
            // 
            // Rbtn_Normal
            // 
            this.Rbtn_Normal.AutoSize = true;
            this.Rbtn_Normal.Checked = true;
            this.Rbtn_Normal.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_Normal.Location = new System.Drawing.Point(413, 50);
            this.Rbtn_Normal.Name = "Rbtn_Normal";
            this.Rbtn_Normal.Size = new System.Drawing.Size(97, 29);
            this.Rbtn_Normal.TabIndex = 12;
            this.Rbtn_Normal.TabStop = true;
            this.Rbtn_Normal.Text = "شخص عادي";
            this.Rbtn_Normal.UseVisualStyleBackColor = true;
            this.Rbtn_Normal.CheckedChanged += new System.EventHandler(this.Rbtn_Normal_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(514, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "اختر موظف:";
            // 
            // cbx_employee
            // 
            this.cbx_employee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_employee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_employee.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_employee.FormattingEnabled = true;
            this.cbx_employee.Location = new System.Drawing.Point(336, 132);
            this.cbx_employee.Name = "cbx_employee";
            this.cbx_employee.Size = new System.Drawing.Size(172, 33);
            this.cbx_employee.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(180, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "تاريخ الاستحقاق:";
            // 
            // dtp_reminder
            // 
            this.dtp_reminder.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_reminder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_reminder.Location = new System.Drawing.Point(1, 55);
            this.dtp_reminder.Name = "dtp_reminder";
            this.dtp_reminder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtp_reminder.Size = new System.Drawing.Size(172, 32);
            this.dtp_reminder.TabIndex = 6;
            this.dtp_reminder.Value = new System.DateTime(2022, 12, 25, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(180, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "المبلغ:";
            // 
            // nud_price
            // 
            this.nud_price.DecimalPlaces = 2;
            this.nud_price.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_price.Location = new System.Drawing.Point(1, 94);
            this.nud_price.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nud_price.Name = "nud_price";
            this.nud_price.Size = new System.Drawing.Size(172, 32);
            this.nud_price.TabIndex = 4;
            this.nud_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(342, 5);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(166, 32);
            this.txt_id.TabIndex = 1;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(514, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم العمليه:";
            // 
            // frm_EmployeeBorrowMoney
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(619, 309);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "frm_EmployeeBorrowMoney";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_EmployeeBorrowMoney";
            this.Load += new System.EventHandler(this.frm_EmployeeBorrowMoney_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_employee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_reminder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_price;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_creditor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.RadioButton Rbtn_employee;
        private System.Windows.Forms.RadioButton Rbtn_Normal;
    }
}