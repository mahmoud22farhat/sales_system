namespace sales
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnmanager = new System.Windows.Forms.RadioButton();
            this.rbtnemployee = new System.Windows.Forms.RadioButton();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new DevExpress.XtraEditors.SimpleButton();
            this.btn_exit = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(21, 75);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(173, 32);
            this.txt_username.TabIndex = 9;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_username_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(31, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "ادخل اسم المستخدم";
            // 
            // rbtnmanager
            // 
            this.rbtnmanager.AutoSize = true;
            this.rbtnmanager.Checked = true;
            this.rbtnmanager.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnmanager.Location = new System.Drawing.Point(12, 12);
            this.rbtnmanager.Name = "rbtnmanager";
            this.rbtnmanager.Size = new System.Drawing.Size(54, 29);
            this.rbtnmanager.TabIndex = 10;
            this.rbtnmanager.TabStop = true;
            this.rbtnmanager.Text = "مدير";
            this.rbtnmanager.UseVisualStyleBackColor = true;
            // 
            // rbtnemployee
            // 
            this.rbtnemployee.AutoSize = true;
            this.rbtnemployee.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnemployee.Location = new System.Drawing.Point(97, 12);
            this.rbtnemployee.Name = "rbtnemployee";
            this.rbtnemployee.Size = new System.Drawing.Size(100, 29);
            this.rbtnemployee.TabIndex = 11;
            this.rbtnemployee.Text = "موظف عادي";
            this.rbtnemployee.UseVisualStyleBackColor = true;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Droid Arabic Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(21, 144);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(173, 32);
            this.txt_pass.TabIndex = 13;
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pass_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Droid Arabic Kufi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(38, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "ادخل كلمة السر";
            // 
            // btn_login
            // 
            this.btn_login.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Appearance.Options.UseFont = true;
            this.btn_login.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_login.ImageOptions.Image")));
            this.btn_login.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_login.Location = new System.Drawing.Point(12, 182);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(195, 41);
            this.btn_login.TabIndex = 14;
            this.btn_login.Text = "دخول";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Appearance.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Appearance.Options.UseFont = true;
            this.btn_exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.ImageOptions.Image")));
            this.btn_exit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightTop;
            this.btn_exit.Location = new System.Drawing.Point(213, 182);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(206, 41);
            this.btn_exit.TabIndex = 15;
            this.btn_exit.Text = "خروج";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sales.Properties.Resources._5b5b68ddf9de812ffc941238e66049ac;
            this.pictureBox1.Location = new System.Drawing.Point(218, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // frm_login
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(432, 237);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnemployee);
            this.Controls.Add(this.rbtnmanager);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Droid Arabic Kufi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = true;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "frm_login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة الدخول للنظام";
            this.Load += new System.EventHandler(this.frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnmanager;
        private System.Windows.Forms.RadioButton rbtnemployee;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_login;
        private DevExpress.XtraEditors.SimpleButton btn_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}