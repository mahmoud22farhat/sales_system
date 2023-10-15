using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using System.Data.SqlClient;
using System.IO;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace sales
{
    public partial class frm_login : DevExpress.XtraEditors.XtraForm
    {
        Thread t;
        public frm_login()
        {
            InitializeComponent();
            try {
                t = new Thread(new ThreadStart(startsplash));
                t.Start();
                Thread.Sleep(5000);
                t.Abort();
            } catch (Exception) { }

        }
        
        private void startsplash()
        {
            try
            {
                Application.Run(new splash());

            }
            catch (Exception) { }
        }


        database db = new database();
        DataTable tbl = new DataTable();
        private string file;
        private object server;

        //للتاكد من ان قاعدة البيانات موجوده ام لا
        private bool sheckdatabase()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NJ3N9G2;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("", conn);
            SqlDataReader rdr;
            try
            {
                cmd.CommandText = "exec sys.sp_databases";
                conn.Open();

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr.GetString(0) == "therd")
                    {
                        return true;
                        break;
                    }
                }
            }
            catch (Exception)
            { return false;
            }
                conn.Close();
                rdr.Dispose();
                cmd.Dispose();
                return false;
            }
        
        private void createdatabase()
        {
           

            bool check = sheckdatabase();
            if (check== false)
            {
                try {
                    //string conn = @"Data Source=DESKTOP-NJ3N9G2;Integrated Security=True";
                    //string script = File.ReadAllText(Application.StartupPath + @"\script.sql");
                    //SqlConnection co = new SqlConnection(conn);
                    //Server server = new Server(new ServerConnection(co));

                    //server.ConnectionContext.ExecuteNonQuery(script);


                    var filecontent = File.ReadAllText(Application.StartupPath + @"\script.sql");
                    var sqlqueries = filecontent.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);
                    var con = new SqlConnection(@"Data Source=DESKTOP-NJ3N9G2;Integrated Security=True");
                    var cmd = new SqlCommand("quary", con);
                    con.Open();
                    foreach(var quary in sqlqueries)
                    {
                        cmd.CommandText = quary;
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
            } catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        }
        private void frm_login_Load(object sender, EventArgs e)
        {
            
            try {
             createdatabase();

            } catch (Exception) { }
            txt_username.Clear();
            txt_username.Focus();
        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                txt_pass.Focus();
            }
        }

        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btn_login_Click(null, null);
            }
        }
        private bool trial()
        {
            int num = Properties.Settings.Default.trial;

            int thisnum = num + 1;
            Properties.Settings.Default.trial = thisnum;
            Properties.Settings.Default.Save();
            if (thisnum >= 100)
            {
                MessageBox.Show("هذه نسخة تجريبية تم انتهائها", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;

            }
            else
            {
                int Baky = 50 - thisnum;
                MessageBox.Show("هذه نسخة تجريبية ومتبقي لك  " + Baky + " مره", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            return true;

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Product_key == "no")
            {
                Frm_serial frm = new Frm_serial();
                frm.ShowDialog();

            }
            else
            {
                tbl.Clear();
                if (rbtnmanager.Checked == true)
                    tbl = db.readData("select * from users where user_Name=N'" + txt_username.Text + "'and User_password =N'" + txt_pass.Text + "'and type=N'مدير'", "");
               else if (rbtnemployee.Checked == true)
                    tbl = db.readData("select * from users where user_Name=N'" + txt_username.Text + "'and User_password =N'" + txt_pass.Text + "'and type=N'مستخدم عادي'", "");

                if (tbl.Rows.Count <= 0)
                { //اذا كان غير موجود اي يوزر للدخول للبرنامج
                    //try
                    //{
                        DataTable tblstock = new DataTable();
                        tblstock = db.readData("select * from stock_Data", "");
                        if (tblstock.Rows.Count <= 0)
                        {
                            db.excetedate("insert into stock_Data values (1,N'الخزنة الرئيسية')", "");
                        }
                        string type = "مدير";
                        db.excetedate("insert into users values (1 , N'" + Properties.Settings.Default.usernane + "', N'" + Properties.Settings.Default.usernane + "',N'" + type + "',1,0)", "");

                        db.excetedate("insert into users_setting  values(1,1,1,1,1,1,1,1,1,1,1,1,1)", "");
                        db.excetedate("insert into user_customer  values(1,1,1,1)", "");
                        db.excetedate("insert into user_employee  values(1,1,1,1)", "");
                        db.excetedate("insert into user_buy  values(1,1,1)", "");
                        db.excetedate("insert into user_sale  values(1,1,1,1)", "");
                        db.excetedate("insert into user_return  values(1,1,1)", "");
                        db.excetedate("insert into user_deserved  values(1,1,1,1,1,1,1,1)", "");
                        db.excetedate("insert into user_money  values(1,1,1,1,1,1,1,1,1,1)", "");
                        db.excetedate("insert into user_employeeafffairs  values(1,1,1,1,1,1,1,1)", "");
                        db.excetedate("insert into user_report  values(1,1,1,1,1,1,1)", "");
                        db.excetedate("insert into user_backup  values(1,1,1)", "");
                    db.excetedate("insert into user_supplier  values(1,1,1,1)", "");
                    db.excetedate("insert into user_emp  values(1,1,1,1,1,1,1,1)", "");
                    db.excetedate("insert into user_supplier  values(1,1,1,1)", "");
                    tbl.Clear();
                        if (rbtnmanager.Checked == true)
                            tbl = db.readData("select * from users where user_Name=N'" + txt_username.Text + "'and User_password =N'" + txt_pass.Text + "'and type=N'مدير'", "");
                        if (rbtnemployee.Checked == true)
                            tbl = db.readData("select * from users where user_Name=N'" + txt_username.Text + "'and User_password =N'" + txt_pass.Text + "'and type=N'مستخدم عادي'", "");
                    //}
                    //catch (Exception) { }
                }
                //النسخه التجريبية
                if (tbl.Rows.Count >= 1)
                {
                    //bool check;
                    //check = trial();
                    //if (check == false)
                    //{
                    //    return;
                    //}

                    Properties.Settings.Default.usernane = txt_username.Text;
                    Properties.Settings.Default.stock_id = Convert.ToInt32(tbl.Rows[0][4]);
                    Properties.Settings.Default.Save();
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("كلمة السر او اسم المستخدم خطأ", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}