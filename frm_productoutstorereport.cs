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
    public partial class frm_productoutstorereport : DevExpress.XtraEditors.XtraForm
    {
        public frm_productoutstorereport()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();
        private void fillstore()
        {
            cbx_store.DataSource = db.readData("select * from store", "");
            cbx_store.DisplayMember = "store_Name";
            cbx_store.ValueMember = "store_ID";          
        }
        private void frm_productoutstorereport_Load(object sender, EventArgs e)
        {
            fillstore();
            dtp_from.Text = DateTime.Now.ToShortDateString();
            dtp_to.Text = DateTime.Now.ToShortDateString();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string date1;
                string date2;
                date1 = dtp_from.Value.ToString("yyyy-MM-dd");
                date2 = dtp_to.Value.ToString("yyyy-MM-dd");

                tbl.Clear();

                if (rbtn_allstore.Checked == true)
                {

                    tbl = db.readData("SELECT [Order_ID]as'رقم العملية',[pro_name]as'اسم المتج',[store_name]as'خارج من',[Qty]as'الكمية',[unit]as'الوحدة',[Date]as'تاريخ الخروج',[Name]as'اسم المسئول',[Reason]as'سبب التلف'FROM [dbo].[product_outstore] where convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "");
                }
                else if (rbtn_onestore.Checked == true)
                { 
                    tbl = db.readData("SELECT [Order_ID]as'رقم العملية',[pro_name]as'اسم المتج',[store_name]as'خارج من',[Qty]as'الكمية',[unit]as'الوحدة',[Date]as'تاريخ الخروج',[Name]as'اسم المسئول',[Reason]as'سبب التلف'FROM [dbo].[product_outstore] where store_name =N'" + cbx_store.Text + "' and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");
                }
             
              


                Dgv_search.DataSource = tbl;
            }
            catch (Exception) { }
            if (Dgv_search.Rows.Count >= 1)
            {

                decimal totalQty = 0;
                for (int i = 0; i <= Dgv_search.Rows.Count - i; i++)
                {
                    totalQty += Convert.ToDecimal(Dgv_search.Rows[i].Cells[3].Value);
                }
                txt_total.Text = Math.Round(totalQty, 2).ToString();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string date1;
            string date2;
            date1 = dtp_from.Value.ToString("yyyy-MM-dd");
            date2 = dtp_to.Value.ToString("yyyy-MM-dd");

            if (MessageBox.Show("هل انت متاكد من مسح البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.excetedate("delete from product_outstore where convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "تم مسح البيانات بنجاح");
                btn_search_Click(null, null);
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        { 


        string date1;
        string date2;
        date1 = dtp_from.Value.ToString("yyyy-MM-dd");
            date2 = dtp_to.Value.ToString("yyyy-MM-dd");

            int id = Convert.ToInt32(Dgv_search.CurrentRow.Cells[0].Value);
        DataTable tblrpt = new DataTable();
        tblrpt.Clear();
            tblrpt = db.readData("SELECT[Order_ID] as'رقم العملية',[pro_name]as'اسم المتج',[store_name]as'خارج من',[Qty]as'الكمية',[unit]as'الوحدة',[Date]as'تاريخ الخروج',[Name]as'اسم المسئول',[Reason]as'سبب التلف'FROM[dbo].[product_outstore] where convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");
            Frm_printing frm = new Frm_printing();

        rpt_deservedreport rpt = new rpt_deservedreport();
        frm.crystalReportViewer1.RefreshReport();
            rpt.SetDatabaseLogon("", "", "DESKTOP-NJ3N9G2", "therd");
            rpt.SetDataSource(tblrpt);
            rpt.SetParameterValue("from", date1);
            rpt.SetParameterValue("to", date2);
            frm.crystalReportViewer1.ReportSource = rpt;
            //لتحديد خيارات الطابعه
            System.Drawing.Printing.PrintDocument PrintDocument = new System.Drawing.Printing.PrintDocument();
        rpt.PrintOptions.PrinterName = PrintDocument.PrinterSettings.PrinterName;

           // rpt.PrintToPrinter(1, true, 0, 0);

            frm.ShowDialog();


    }
    }
}