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
using System.Data.SqlClient;
using System.Data;
//استدعاء مكتبة الطابعات
using System.Drawing.Printing;
//استدعاء مكتبة حفظ الصور في قاعدة البيانات
using System.IO;
namespace sales
{
    public partial class frm_setting : DevExpress.XtraEditors.XtraForm
    {
        public frm_setting()
        {
            InitializeComponent();
        }
        database db = new database();

        private void showorderdata()
        {
            tbl.Clear();
            tbl = db.readData("select * from orderprintdata", "");

            if (tbl.Rows.Count >= 1)
            {
                txt_name.Text = tbl.Rows[0][1].ToString();
                txt_address.Text = tbl.Rows[0][2].ToString();
                txt_description.Text = tbl.Rows[0][3].ToString();
                txt_phone1.Text = tbl.Rows[0][4].ToString();
                txt_phone2.Text = tbl.Rows[0][5].ToString();
            }
            //استرجاع الصوره من قاعدة البيانات
            try {

                Byte[] byteimage = new Byte[0];
                byteimage = (Byte[])(tbl.Rows[0][0]);
                MemoryStream MemoryStream = new MemoryStream(byteimage);

                picturelogo.BackgroundImage = Image.FromStream(MemoryStream);

            } catch (Exception) { }
        }
        //اظهار اسماء الطابعات في الكومبو بوكس
        string printername = "";
        private void showprinters()
        {
            for (int i = 0; i <= PrinterSettings.InstalledPrinters.Count - 1; i++)
            {
                printername = PrinterSettings.InstalledPrinters[i];
                cbx_print.Items.Add(printername);

                cbx_print.SelectedIndex = 0;
            }
            if (Properties.Settings.Default.printername == "")
                cbx_print.SelectedIndex = 0;
            else
            {
                cbx_print.Text = Properties.Settings.Default.printername;

            }
        }

        private void frm_setting_Load(object sender, EventArgs e)
        {

            try {

                showprinters();


            } catch (Exception) { }
            try
            {


                showorderdata();

            }
            catch (Exception) { }
            try
            {


                showgeneralsetting();

            }
            catch (Exception) { }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cbx_print.SelectedValue == "")
            {
                MessageBox.Show("من فضلك اختار طابعه", "تاكيد");
                return;
            }
            Properties.Settings.Default.printername = cbx_print.Text;
            Properties.Settings.Default.Save();

            MessageBox.Show("تم الحفظ بنجاح", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        string imagepath = "";
        private void btn_choose_Click(object sender, EventArgs e)
        {
            //OpenFileDialog op = new OpenFileDialog();
            //if (op.ShowDialog() == DialogResult.OK)

            //{
            //    picturelogo.Image = Image.FromFile(op.FileName);
            //}

            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Filter = "all files (*.*)|*.*";

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagepath = OpenFileDialog.FileName.ToString();
                picturelogo.Image = null;
                picturelogo.ImageLocation = imagepath;
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            picturelogo.BackgroundImage = null;
            picturelogo.Image = null;
            imagepath = "";
        }

        //تحويل الصوره الي بايت
        private void saveimg(string stmt, string paramaterName, string message)
        {
            //الوصول الي قاعدة البيانات
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NJ3N9G2;Initial Catalog=therd;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(stmt, conn);

            //لحفظ البيانات في قاعدة البيانات

            FileStream FileStream = new FileStream(/*تحديد مسار الصوره*/ imagepath,/*بخليها مفتوحه*/ FileMode.Open,/*صلاحية الوصول للصوره*/FileAccess.Read);


            //تحويل الصوره الي بايت

            Byte[] bytestream = new Byte[FileStream.Length];
            FileStream.Read(bytestream, 0, bytestream.Length);
            FileStream.Close();

            //*************************************************************


            SqlParameter parameter = new SqlParameter(paramaterName, SqlDbType.VarBinary, bytestream.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, bytestream);

            cmd.Parameters.Add(parameter);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            if (message != "")
            {
                MessageBox.Show(message, "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        DataTable tbl = new DataTable();

        private void btn_saveorder_Click(object sender, EventArgs e)
        {
            if (imagepath == "")
            {
                MessageBox.Show("من فضلك اختر لوجو", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            tbl.Clear();
            tbl = db.readData("select * from orderprintdata ", "");
            if (tbl.Rows.Count >= 1)
            {
                saveimg("update orderprintdata set Logo=@Logo ,name=N'" + txt_name.Text + "',address=N'" + txt_address.Text + "',description=N'" + txt_description.Text + "',phone1=N'" + txt_phone1.Text + "',phone2=N'" + txt_phone2.Text + "' ", "@Logo", "تم الحفظ بنجاح");
            }
            else
            {
                saveimg("insert into orderprintdata values( @Logo ,N'" + txt_name.Text + "',N'" + txt_address.Text + "',N'" + txt_description.Text + "',N'" + txt_phone1.Text + "',N'" + txt_phone2.Text + "') ", "@Logo", "تم الحفظ بنجاح");

            }
            imagepath = "";
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if(nud_buynumber.Value<1||nud_salenumber.Value<1)
            {
                MessageBox.Show("لا يمكن ان يقل عدد الفواتير المطبوعه عن 1", "تأكيد");
                return ;
            }


            if (rbtn_value.Checked == true)

                Properties.Settings.Default.itemdiscount = "value";

            else if (rbtn_present.Checked == true)

                Properties.Settings.Default.itemdiscount = "present";


            Properties.Settings.Default.salesprintnum = Convert.ToInt32(nud_salenumber.Value);

            Properties.Settings.Default.buyprintnum = Convert.ToInt32(nud_buynumber.Value);
            //////////////////////////////
            if (check_taxes.Checked == true)

                Properties.Settings.Default.taxes = true;
            else

                Properties.Settings.Default.taxes = false;
            ////////////////////////////////
            if (check_descound.Checked == true)

                Properties.Settings.Default.salediscountforcasher = true;
            else

                Properties.Settings.Default.salediscountforcasher = false;

            ////////////////////////////////
            if (check_saleprint.Checked == true)

                Properties.Settings.Default.salesprint = true;
            else

                Properties.Settings.Default.salesprint = false;

            ////////////////////////////////
            if (check_buyprint.Checked == true)

                Properties.Settings.Default.buyprint = true;
            else

                Properties.Settings.Default.buyprint = false;
            ////////////////////////////////
            if (rbtn8cmsales.Checked == true)
            {
                Properties.Settings.Default.saleprintkind = "8cm";
            }
            else if(rbtnA4sales.Checked == true)
                    {
                Properties.Settings.Default.saleprintkind = "A4";
                ////////////////////////////////
            }
            if (rbtn8cmbuy.Checked == true)

            {
                Properties.Settings.Default.buyprintkind = "8cm";
            }
            else if(rbtnA4buy.Checked == true)
            {
                Properties.Settings.Default.buyprintkind = "A4";
               
            }
            Properties.Settings.Default.Save();

            MessageBox.Show("من حفظ البيانات بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void showgeneralsetting()
        {
            if (Properties.Settings.Default.itemdiscount == "value" )

             rbtn_value.Checked = true ;

            else if (Properties.Settings.Default.itemdiscount == "present" )

             rbtn_present.Checked = true;

            (nud_salenumber.Value)  =Properties.Settings.Default.salesprintnum;
           (nud_buynumber.Value) =  Properties.Settings.Default.buyprintnum;

         
            //////////////////////////////
            if (   Properties.Settings.Default.taxes == true)

            check_taxes.Checked = true ;
            else

                check_taxes.Checked = false;
            ////////////////////////////////
            if (  Properties.Settings.Default.salediscountforcasher == true)

             check_descound.Checked = true ;
            else

                check_descound.Checked = false;

            ////////////////////////////////
            if ( Properties.Settings.Default.salesprint == true)

           check_saleprint.Checked = true    ;
            else

                check_saleprint.Checked = false;

            ////////////////////////////////
            if (    Properties.Settings.Default.buyprint  == true)

          check_buyprint.Checked= true  ;
            else

                check_buyprint.Checked = false;
            ////////////////////////////////
            if (  Properties.Settings.Default.saleprintkind == "8cm")
            {
             rbtn8cmsales.Checked= true ;
            }
            else if ( Properties.Settings.Default.saleprintkind == "A4")
            {
              rbtnA4sales.Checked = true ;
                ////////////////////////////////
            }
            if (  Properties.Settings.Default.buyprintkind  == "8cm")

            {
            rbtn8cmbuy.Checked= true  ;
            }
            else if (  Properties.Settings.Default.buyprintkind == "A4")
            {
              rbtnA4buy.Checked = true;

            }
          
        }
    }
}