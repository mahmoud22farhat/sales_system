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
    public partial class frm_salesRp7h : DevExpress.XtraEditors.XtraForm
    {
        public frm_salesRp7h()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();

        private void frm_salesRp7h_Load(object sender, EventArgs e)
        {

            dtp_date.Text = DateTime.Now.ToShortDateString();
            dtp_to.Text = DateTime.Now.ToShortDateString();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            string date1;
            string date2;
            date1 = dtp_from.Value.ToString("yyyy-MM-dd");
            date2 = dtp_to.Value.ToString("yyyy-MM-dd");
            if (checkOrderNumber.Checked == false)
            {
                tbl = db.readData("SELECT [Order_ID]as'رقم الفاتوره',[Cus_name]as'اسم العميل',products.[Pro_name]as'المتج',[sales_Rb7h].[Qty]as'الكميه',BuyPrice as 'سعر الشراء',[price]as'سعر البيع',[discound]as'الخصم',[total]as'الاجمالي',(sale_price - BuyPrice) * (sales_Rb7h.Qty) as 'اجمالي الربح',[TotalOrder]as'اجمالي الفاتوره',[madfoo3]as'المبلغ الدفوع',[Baky]as'المتبقي',[User_name]as'الكاشير',[Date]as'التاريخ'FROM [dbo].[sales_Rb7h],products where products.Pro_ID =[sales_Rb7h].Pro_ID and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");
            }
            else if (checkOrderNumber.Checked == true)
            {
                tbl = db.readData("SELECT [Order_ID]as'رقم الفاتوره',[Cus_name]as'اسم العميل',products.[Pro_name]as'المتج',[sales_Rb7h].[Qty]as'الكميه',BuyPrice as 'سعر الشراء',[price]as'سعر البيع',[discound]as'الخصم',[total]as'الاجمالي',(sale_price - BuyPrice) * (sales_Rb7h.Qty) as 'اجمالي الربح',[TotalOrder]as'اجمالي الفاتوره',[madfoo3]as'المبلغ الدفوع',[Baky]as'المتبقي',[User_name]as'الكاشير',[Date]as'التاريخ'FROM [dbo].[sales_Rb7h],products where products.Pro_ID =[sales_Rb7h].Pro_ID  and Order_ID=" + txt_numberOrder.Text + "  and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");

            }
            Dgv_search.DataSource = tbl;

            if (Dgv_search.Rows.Count >= 1)
            {
                try
                {
                    decimal totalOrder = 0,totalRep7 = 0 ;
                    for (int i = 0; i <= Dgv_search.Rows.Count - i; i++)
                    {
                        totalOrder += Convert.ToDecimal(Dgv_search.Rows[i].Cells[7].Value);
                        totalRep7 += Convert.ToDecimal(Dgv_search.Rows[i].Cells[8].Value);
                    }

                    txt_total.Text = Math.Round(totalOrder, 2).ToString();
                   txt_totalRp7h.Text = Math.Round(totalRep7, 2).ToString();
                }
                catch (Exception) { }
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {if (Dgv_search.Rows.Count >= 1)
                {  

           tbl.Clear();
                string date1;
                string date2;
                date1 = dtp_from.Value.ToString("yyyy-MM-dd");
                date2 = dtp_to.Value.ToString("yyyy-MM-dd");

                 
                  if (MessageBox.Show("هل انت متاكد من مسح البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                
                    db.excetedate("delete from sales_Rb7h where convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "تم المسح بنجاح");
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
            tblrpt = db.readData("SELECT [Order_ID]as'رقم الفاتوره',[Cus_name]as'اسم العميل',products.[Pro_name]as'المتج',[sales_Rb7h].[Qty]as'الكميه',BuyPrice as 'سعر الشراء',[price]as'سعر البيع',[discound]as'الخصم',[total]as'الاجمالي',(sale_price - BuyPrice) * (sales_Rb7h.Qty) as 'اجمالي الربح',[TotalOrder]as'اجمالي الفاتوره',[madfoo3]as'المبلغ الدفوع',[Baky]as'المتبقي',[User_name]as'الكاشير',[Date]as'التاريخ'FROM [dbo].[sales_Rb7h],products where products.Pro_ID =[sales_Rb7h].Pro_ID and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ORDER BY Order_ID ASC", "");
            Frm_printing frm = new Frm_printing();

            rpt_salesRb7h rpt = new rpt_salesRb7h();
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

            // frm.ShowDialog();
        }
        private void btn_printOrederall_Click(object sender, EventArgs e)
        {
            if (Dgv_search.Rows.Count >= 1)
            {
                printall();

            }
        }
    }
}