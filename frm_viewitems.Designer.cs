namespace sales
{
    partial class frm_viewitems
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbx_group = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_search = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_totalQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_totalall = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_totalpart = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_totaltaxe = new System.Windows.Forms.TextBox();
            this.txtbarcode = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_group
            // 
            this.cbx_group.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_group.FormattingEnabled = true;
            this.cbx_group.Location = new System.Drawing.Point(135, 18);
            this.cbx_group.Name = "cbx_group";
            this.cbx_group.Size = new System.Drawing.Size(121, 33);
            this.cbx_group.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(12, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 28);
            this.label14.TabIndex = 62;
            this.label14.Text = "بحث بالمجموعه";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.BlueViolet;
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.BlueViolet;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton1.Location = new System.Drawing.Point(262, 18);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 32);
            this.simpleButton1.TabIndex = 63;
            this.simpleButton1.Text = "بحث";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.BlueViolet;
            this.simpleButton2.Appearance.BackColor2 = System.Drawing.Color.BlueViolet;
            this.simpleButton2.Appearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseBorderColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton2.Location = new System.Drawing.Point(579, 18);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 32);
            this.simpleButton2.TabIndex = 66;
            this.simpleButton2.Text = "بحث";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(348, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 65;
            this.label1.Text = "بحث بالباركود";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.BlueViolet;
            this.simpleButton3.Appearance.BackColor2 = System.Drawing.Color.BlueViolet;
            this.simpleButton3.Appearance.BorderColor = System.Drawing.Color.BlueViolet;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseBorderColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton3.Location = new System.Drawing.Point(878, 16);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 32);
            this.simpleButton3.TabIndex = 69;
            this.simpleButton3.Text = "بحث";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(667, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 68;
            this.label2.Text = "بحث بالاسم";
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
            this.Dgv_search.Location = new System.Drawing.Point(3, 57);
            this.Dgv_search.Name = "Dgv_search";
            this.Dgv_search.ReadOnly = true;
            this.Dgv_search.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Dgv_search.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Blue;
            this.Dgv_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_search.Size = new System.Drawing.Size(1018, 349);
            this.Dgv_search.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 28);
            this.label3.TabIndex = 72;
            this.label3.Text = "اجمالي الكميه:";
            // 
            // txt_totalQty
            // 
            this.txt_totalQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_totalQty.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalQty.Location = new System.Drawing.Point(123, 423);
            this.txt_totalQty.Multiline = true;
            this.txt_totalQty.Name = "txt_totalQty";
            this.txt_totalQty.ReadOnly = true;
            this.txt_totalQty.Size = new System.Drawing.Size(64, 32);
            this.txt_totalQty.TabIndex = 71;
            this.txt_totalQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(193, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 28);
            this.label4.TabIndex = 74;
            this.label4.Text = "اجمالي بيع الجمله:";
            // 
            // txt_totalall
            // 
            this.txt_totalall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_totalall.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalall.Location = new System.Drawing.Point(333, 423);
            this.txt_totalall.Multiline = true;
            this.txt_totalall.Name = "txt_totalall";
            this.txt_totalall.ReadOnly = true;
            this.txt_totalall.Size = new System.Drawing.Size(113, 32);
            this.txt_totalall.TabIndex = 73;
            this.txt_totalall.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(452, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 28);
            this.label5.TabIndex = 76;
            this.label5.Text = "اجمالي بيع التجزأه:";
            // 
            // txt_totalpart
            // 
            this.txt_totalpart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_totalpart.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalpart.Location = new System.Drawing.Point(588, 423);
            this.txt_totalpart.Multiline = true;
            this.txt_totalpart.Name = "txt_totalpart";
            this.txt_totalpart.ReadOnly = true;
            this.txt_totalpart.Size = new System.Drawing.Size(113, 32);
            this.txt_totalpart.TabIndex = 75;
            this.txt_totalpart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(707, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 28);
            this.label6.TabIndex = 78;
            this.label6.Text = "اجمالي بيع بعد الضرائب:\r\n";
            // 
            // txt_totaltaxe
            // 
            this.txt_totaltaxe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_totaltaxe.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totaltaxe.Location = new System.Drawing.Point(878, 423);
            this.txt_totaltaxe.Multiline = true;
            this.txt_totaltaxe.Name = "txt_totaltaxe";
            this.txt_totaltaxe.ReadOnly = true;
            this.txt_totaltaxe.Size = new System.Drawing.Size(113, 32);
            this.txt_totaltaxe.TabIndex = 77;
            this.txt_totaltaxe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbarcode
            // 
            this.txtbarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbarcode.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbarcode.Location = new System.Drawing.Point(457, 18);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(113, 32);
            this.txtbarcode.TabIndex = 79;
            this.txtbarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(759, 16);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(113, 32);
            this.txtname.TabIndex = 80;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_viewitems
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1024, 473);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtbarcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_totaltaxe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_totalpart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_totalall);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_totalQty);
            this.Controls.Add(this.Dgv_search);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbx_group);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "frm_viewitems";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة عرض المنتجات";
            this.Load += new System.EventHandler(this.frm_viewitems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_group;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_totalQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_totalall;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_totalpart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_totaltaxe;
        private System.Windows.Forms.TextBox txtbarcode;
        private System.Windows.Forms.TextBox txtname;
    }
}