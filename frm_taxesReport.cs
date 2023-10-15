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
    public partial class frm_taxesReport : DevExpress.XtraEditors.XtraForm
    {
        public frm_taxesReport()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();
        private void frm_taxesReport_Load(object sender, EventArgs e)
        {
            dtp_from.Text = DateTime.Now.ToShortDateString();
            dtp_to.Text = DateTime.Now.ToShortDateString();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
            tbl.Clear();
            string date1;
            string date2;
            date1 = dtp_from.Value.ToString("yyyy-MM-dd");
            date2 = dtp_to.Value.ToString("yyyy-MM-dd");

            string sale = "فاتورة مبيعات", buy= "فاتورة مشتريات", returnsale= " مرتجعات مبيعات", returnbuy= " مرتجعات مشتريات";

            if(checksale.Checked==true)
            {
                sale = "فاتورة مبيعات";
            }
            else
            {
                sale = "";
            }
            if (checkbuy.Checked == true)
            {
                buy = "فاتورة مشتريات";
            }
            else
            {
                buy = "";
            }
            ///////////////////////////////
            ///
            if (checksaleReturn.Checked == true)
            {
                returnsale = " مرتجعات مبيعات";
            }
            else
            {
                returnsale = "";
            }
            /////
            ///
            if (checkbuyReturn.Checked == true)
            {
                returnbuy = " مرتجعات مشتريات";
            }
            else
            {
                returnbuy = "";
            }


            tbl = db.readData("SELECT [Order_ID]as'رقم العمليه',[Order_Num]as'رقم الفاتوره',[Order_Type]as'نوع العملية',[tax_type]as'نوع الضريبة',[sup_name]as'اسم المورد',[cust_name]as'اسم العميل',[total_order]as'اجمالي الفاتوره قبل الضريبه',[total_tax]as'اجمالي الضريبة',[total_Aftertax]as'اجمالي الفاتوره بعد الضريبه',[date]as'تاريخ العملية'FROM [dbo].[taxes_Report] where Order_Type in(N'"+sale+"',N'"+buy+"',N'"+returnsale+"',N'"+returnbuy+"') and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "");
            
            Dgv_search.DataSource = tbl;

            if (Dgv_search.Rows.Count >= 1)
            {
                try
                {
                    decimal totalprice = 0, totaltax = 0, totalaftertax=0;
                    for (int i = 0; i <= Dgv_search.Rows.Count - i; i++)
                    {
                        totalprice += Convert.ToDecimal(Dgv_search.Rows[i].Cells[6].Value);
                        totaltax += Convert.ToDecimal(Dgv_search.Rows[i].Cells[7].Value);
                        totalaftertax += Convert.ToDecimal(Dgv_search.Rows[i].Cells[8].Value);
                    }

                    txttotal.Text = Math.Round(totalprice, 2).ToString();
                    txttotaltax.Text = Math.Round(totaltax, 2).ToString();
                    txttotalaftertax.Text = Math.Round(totalaftertax, 2).ToString();
                }
                catch (Exception) { }
            }


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (Dgv_search.Rows.Count >= 1)
            {
                if (MessageBox.Show("هل انت متاكد من مسح البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    db.excetedate("delete from taxes_Report where Order_ID=" + Dgv_search.CurrentRow.Cells[0].Value + " ", "تم المسح بنجاح");
                    btn_search_Click(null, null);
                }
            }
        }
        private void printall()
        {
            string date1;
            string date2;
            date1 = dtp_from.Value.ToString("yyyy-MM-dd");
            date2 = dtp_to.Value.ToString("yyyy-MM-dd");

            int id = Convert.ToInt32(Dgv_search.CurrentRow.Cells[0].Value);
            DataTable tblrpt = new DataTable();
            tblrpt.Clear();

            string sale = "فاتورة مبيعات", buy = "فاتورة مشتريات", returnsale = " مرتجعات مبيعات", returnbuy = " مرتجعات مشتريات";

            if (checksale.Checked == true)
            {
                sale = "فاتورة مبيعات";
            }
            else
            {
                sale = "";
            }
            if (checkbuy.Checked == true)
            {
                buy = "فاتورة مشتريات";
            }
            else
            {
                buy = "";
            }
            ///////////////////////////////
            ///
            if (checksaleReturn.Checked == true)
            {
                returnsale = " مرتجعات مبيعات";
            }
            else
            {
                returnsale = "";
            }
            /////
            ///
            if (checkbuyReturn.Checked == true)
            {
                returnbuy = " مرتجعات مشتريات";
            }
            else
            {
                returnbuy = "";
            }



            tblrpt = db.readData("SELECT [Order_ID]as'رقم العمليه',[Order_Num]as'رقم الفاتوره',[Order_Type]as'نوع العملية',[tax_type]as'نوع الضريبة',[sup_name]as'اسم المورد',[cust_name]as'اسم العميل',[total_order]as'اجمالي الفاتوره قبل الضريبه',[total_tax]as'اجمالي الضريبة',[total_Aftertax]as'اجمالي الفاتوره بعد الضريبه',[date]as'تاريخ العملية'FROM [dbo].[taxes_Report] where Order_Type in(N'" + sale + "',N'" + buy + "',N'" + returnsale + "',N'" + returnbuy + "') and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");
            Frm_printing frm = new Frm_printing();

            rpt_taxesReport rpt = new rpt_taxesReport();
            frm.crystalReportViewer1.RefreshReport();
            rpt.SetDatabaseLogon("", "", "DESKTOP-NJ3N9G2", "therd");
            rpt.SetDataSource(tblrpt);
            rpt.SetParameterValue("to", date1);
            rpt.SetParameterValue("from", date2);
            frm.crystalReportViewer1.ReportSource = rpt;
            //لتحديد خيارات الطابعه
            System.Drawing.Printing.PrintDocument PrintDocument = new System.Drawing.Printing.PrintDocument();
            rpt.PrintOptions.PrinterName = PrintDocument.PrinterSettings.PrinterName;

                 rpt.PrintToPrinter(1, true, 0, 0);

                     //  frm.ShowDialog();
        }

        private void printsummary()
        {
            string date1;
            string date2;
            date1 = dtp_from.Value.ToString("yyyy-MM-dd");
            date2 = dtp_to.Value.ToString("yyyy-MM-dd");

           
            DataTable tblrpt = new DataTable();
            tblrpt.Clear();

           

            tblrpt = db.readData("select ISNULL( sum(total_order),0) as'اجمالي فواتير المبيعات' ,ISNULL( sum(total_tax),0) as'قيمة ضرائب المبيعات',ISNULL( sum(total_Aftertax),0) as'السعر بعد ضرائب المبيعات' from taxes_Report where Order_Type =N'فاتورة مبيعات' and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");
            Frm_printing frm = new Frm_printing();

            rpt_TaxesReportSummary rpt = new rpt_TaxesReportSummary();
            frm.crystalReportViewer1.RefreshReport();
            rpt.SetDatabaseLogon("", "", "DESKTOP-NJ3N9G2", "therd");
            rpt.SetDataSource(tblrpt);
            rpt.SetParameterValue("@fromsale", date1);
            rpt.SetParameterValue("@tosale", date2);
            rpt.SetParameterValue("@frombuy", date1);
            rpt.SetParameterValue("@tobuy", date2);
            frm.crystalReportViewer1.ReportSource = rpt;
            //لتحديد خيارات الطابعه
            System.Drawing.Printing.PrintDocument PrintDocument = new System.Drawing.Printing.PrintDocument();
            rpt.PrintOptions.PrinterName = PrintDocument.PrinterSettings.PrinterName;

            rpt.PrintToPrinter(1, true, 0, 0);

             //frm.ShowDialog();
        }
        private void btn_printReport_Click(object sender, EventArgs e)
        {

            if (Dgv_search.Rows.Count >= 1)
            {
                printall();

            }
        }

        private void btn_printsummary_Click(object sender, EventArgs e)
        {
            if (Dgv_search.Rows.Count >= 1)
            {
                printsummary();

            }
        }
    }
}