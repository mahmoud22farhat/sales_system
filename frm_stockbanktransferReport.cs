using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace sales
{
    public partial class frm_stockbanktransferReport : DevExpress.XtraEditors.XtraForm
    {
        public frm_stockbanktransferReport()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();
        
        private void frm_stockbanktransferReport_Load(object sender, EventArgs e)
        {
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
                tbl = db.readData("SELECT [Order_ID] as'رقم العملية',[Mony] as'المبلغ المحول',[Date] as'تاريخ العمليه',[from_] as'تحويل من',[to_] as'تحويل الي',[Name] as'اسم الشخص المسؤل عن التحويل'FROM [dbo].[stock_bsnktransfer] where convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "");

                if (tbl.Rows.Count >= 1)
                {
                    Dgv_search.DataSource = tbl;
                    decimal sum = 0;
                    for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                    {
                        sum += Convert.ToDecimal(tbl.Rows[i][1]);
                    }
                    txt_total.Text = Math.Round(sum, 2).ToString();
                }
                else
                { txt_total.Text = "0"; }

            }
            catch (Exception) { }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string date1;
            string date2;
            date1 = dtp_from.Value.ToString("yyyy-MM-dd");
            date2 = dtp_to.Value.ToString("yyyy-MM-dd");

            if (MessageBox.Show("هل انت متاكد من مسح البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.excetedate("delete from stock_bsnktransfer where convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "تم مسح البيانات بنجاح");

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
            tblrpt = db.readData("SELECT [Order_ID] as'رقم العملية',[Mony] as'المبلغ المحول',[Date] as'تاريخ العمليه',[from_] as'تحويل من',[to_] as'تحويل الي',[Name] as'اسم الشخص المسؤل عن التحويل'FROM [dbo].[stock_bsnktransfer] where convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");
            Frm_printing frm = new Frm_printing();

            rpt_stockbanktransferReport rpt = new rpt_stockbanktransferReport();
            frm.crystalReportViewer1.RefreshReport();
            rpt.SetDatabaseLogon("", "", "DESKTOP-NJ3N9G2", "therd");
            rpt.SetDataSource(tblrpt);
            rpt.SetParameterValue("from", date1);
            rpt.SetParameterValue("to", date2);
            frm.crystalReportViewer1.ReportSource = rpt;
            //لتحديد خيارات الطابعه
            System.Drawing.Printing.PrintDocument PrintDocument = new System.Drawing.Printing.PrintDocument();
            rpt.PrintOptions.PrinterName = PrintDocument.PrinterSettings.PrinterName;

            rpt.PrintToPrinter(1, true, 0, 0);

           //  frm.ShowDialog();
        }
    }
}