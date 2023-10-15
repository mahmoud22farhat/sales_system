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

namespace sales
{
    public partial class frm_printBarcode : DevExpress.XtraEditors.XtraForm
    {
        public frm_printBarcode()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();
        private void fillPro()
        {
            cbx_product.DataSource = db.readData("select * from products", "");
            cbx_product.DisplayMember = "Pro_name";
            cbx_product.ValueMember = "Pro_ID";
        }
        private void frm_printBarcode_Load(object sender, EventArgs e)
        {
            fillPro();


            //لتمرير البيانات الي شاشة الباركود

            txt_proname.Text = Properties.Settings.Default.Pro_Name;
            txt_parcode.Text = Properties.Settings.Default.Pro_Barcode;
            txt_salepricetaxe.Text = Convert.ToString(Properties.Settings.Default.Pro_price);




        }

        private void btn_randombarcode_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl.Clear();
            tbl = db.readData("select * from random_barcode", "");
            if (tbl.Rows.Count <= 0)

            {
                txt_parcode.Text = "1000000";
                db.excetedate("insert into random_barcode values(1000000) ", "");

            }
            else
            {
                txt_parcode.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
                db.excetedate("update random_barcode set Barcode=N'" + (Convert.ToInt32(tbl.Rows[0][0]) + 1) + "'", "");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            /*
                          حفظ تعداد الباركود

                   لاختيار رقم معين وبدء العد التلقائي به 
                                      
             */
            DataTable tbl = new DataTable();
            tbl.Clear();
            tbl = db.readData("select * from random_barcode", "");
            if (tbl.Rows.Count <= 0)
            {
                txt_parcode.Text = "1000000";
                db.excetedate("insert into random_barcode values(N'" + txt_parcode.Text + "') ", "تم الحفظ بنجاح");

            }
            else
            {

                db.excetedate("update random_barcode set Barcode=N'" + txt_parcode.Text + "'", "تم الحفظ بنجاح");
            }
        }

        private void cbx_product_SelectionChangeCommitted(object sender, EventArgs e)
        {

            //لجلب البيانات من جدول المنتجات
            if (cbx_product.Items.Count >= 0)
            {

                DataTable tbl = new DataTable();
                tbl.Clear();
                tbl = db.readData("select * from products where Pro_ID =" + cbx_product.SelectedValue + "", "");
                if (tbl.Rows.Count >= 1)
                {
                    txt_proname.Text = tbl.Rows[0][1].ToString();
                    txt_parcode.Text = tbl.Rows[0][5].ToString();
                    txt_salepricetaxe.Text = tbl.Rows[0][9].ToString();
                }
            }
        }

        private void btn_printpreview_Click(object sender, EventArgs e)
        {
            if(txt_parcode.Text=="" ||txt_proname.Text=="" ||txt_salepricetaxe.Text=="")
            {

                MessageBox.Show("من فضلك اكمل البيانات", "");
                return;
            }

           
            DataSet1 DS = new DataSet1();
            DS.Clear();

                     /*
                                 الدله trim

                                لالغاء اي مسافه موجوده في النص
                                وعلامة لنجمه لتحديد النص كامل
             
             
                                 */

            rpt_CrystalReport rpt = new rpt_CrystalReport();
            DS.Tables["print_barcode"].Rows.Add(txt_proname.Text , txt_parcode.Text , txt_salepricetaxe.Text , "*" +txt_parcode.Text.Trim() +"*");
            rpt.SetDataSource(DS);
            Frm_printing frm = new Frm_printing();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.crystalReportViewer1.Refresh();
          //  frm.ShowDialog();
            rpt.PrintToPrinter(1, true, 0, 0);
            Properties.Settings.Default.Pro_Barcode =txt_parcode.Text ;
            Properties.Settings.Default.Save();
            db.excetedate("update products set Barcode=N'"+txt_parcode.Text+"' where Pro_name =N'"+txt_proname.Text+"'", "");
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (txt_parcode.Text == "" || txt_proname.Text == "" || txt_salepricetaxe.Text == "")
            {

                MessageBox.Show("من فضلك اكمل البيانات", "");
                return;
            }


            DataSet1 DS = new DataSet1();
            DS.Clear();

            /*
                        الدله trim

                       لالغاء اي مسافه موجوده في النص
                       وعلامة لنجمه لتحديد النص كامل


                        */

            rpt_CrystalReport rpt = new rpt_CrystalReport();
            DS.Tables["print_barcode"].Rows.Add(txt_proname.Text, txt_parcode.Text, txt_salepricetaxe.Text, "*" + txt_parcode.Text.Trim() + "*");
            rpt.SetDataSource(DS);
            Frm_printing frm = new Frm_printing();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.crystalReportViewer1.Refresh();
            //   frm.ShowDialog();
            //لتحديد خيارات الطابعه
            System.Drawing.Printing.PrintDocument PrintDocument = new System.Drawing.Printing.PrintDocument();
            rpt.PrintOptions.PrinterName = PrintDocument.PrinterSettings.PrinterName;
            rpt.PrintToPrinter(1, true, 0, 0);
            Properties.Settings.Default.Pro_Barcode = txt_parcode.Text;
            Properties.Settings.Default.Save();
            db.excetedate("update products set Barcode=N'" + txt_parcode.Text + "' where Pro_name =N'" + txt_proname.Text + "'", "");
        }
    }
}