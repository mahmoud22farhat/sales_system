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
    public partial class frm_saleReport : DevExpress.XtraEditors.XtraForm
    {
        public frm_saleReport()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();

        private void filluser()
        {
            cbx_user.DataSource = db.readData("select * from users", "");
            cbx_user.DisplayMember = "user_Name";
            cbx_user.ValueMember = "user_ID";
        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            tbl.Clear();
            string date1;
            string date2;
            date1 = dtp_from.Value.ToString("yyyy-MM-dd");
            date2 = dtp_to.Value.ToString("yyyy-MM-dd");
            if (checkOrderNumber.Checked == false)
            {
                if (rbtn_alluser.Checked == true)
                {
                    tbl = db.readData("SELECT [Order_ID]as'رقم الفاتوره',[Cus_name]as'اسم العميل',products.[Pro_name]as'المنتج',sales_details.[Qty]as'الكميه',unit as 'الوحدة',price as'السعر قبل الضريبة',[sales_details].tax_value as'الضريبة',[price_tax]as' السعر شامل الضريبة',[discound]as'الخصم',[total]as'اجمالي الصنف',[TotalOrder]as'اجمالي الفاتوره',[madfoo3]as'المبلغ الدفوع',[Baky]as'المتبقي',[User_name]as'الكاشير',[Date]as'التاريخ' FROM [dbo].[sales_details],products where products.Pro_ID =sales_details.Pro_ID and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");
                }
                else if (rbtn_oneuser.Checked == true)
                {
                    tbl = db.readData("SELECT [Order_ID]as'رقم الفاتوره',[Cus_name]as'اسم العميل',products.[Pro_name]as'المنتج',sales_details.[Qty]as'الكميه',unit as 'الوحدة',price as'السعر قبل الضريبة',[sales_details].tax_value as'الضريبة',[price_tax]as' السعر شامل الضريبة',[discound]as'الخصم',[total]as'اجمالي الصنف',[TotalOrder]as'اجمالي الفاتوره',[madfoo3]as'المبلغ الدفوع',[Baky]as'المتبقي',[User_name]as'الكاشير',[Date]as'التاريخ' FROM [dbo].[sales_details],products where products.Pro_ID =sales_details.Pro_ID and User_name = N'" + cbx_user.Text + "' and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");

                }
            }
            else if (checkOrderNumber.Checked == true)
            {
                if (rbtn_alluser.Checked == true)
                {
                    tbl = db.readData("SELECT [Order_ID]as'رقم الفاتوره',[Cus_name]as'اسم العميل',products.[Pro_name]as'المنتج',sales_details.[Qty]as'الكميه',unit as 'الوحدة',price as'السعر قبل الضريبة',[sales_details].tax_value as'الضريبة',[price_tax]as' السعر شامل الضريبة',[discound]as'الخصم',[total]as'اجمالي الصنف',[TotalOrder]as'اجمالي الفاتوره',[madfoo3]as'المبلغ الدفوع',[Baky]as'المتبقي',[User_name]as'الكاشير',[Date]as'التاريخ' FROM [dbo].[sales_details],products where products.Pro_ID =sales_details.Pro_ID and Order_ID =" + txt_numberOrder.Text + "  and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");

                }
                else if (rbtn_oneuser.Checked == true)
                {
                    tbl = db.readData("SELECT [Order_ID]as'رقم الفاتوره',[Cus_name]as'اسم العميل',products.[Pro_name]as'المنتج',sales_details.[Qty]as'الكميه',unit as 'الوحدة',price as'السعر قبل الضريبة',[sales_details].tax_value as'الضريبة',[price_tax]as' السعر شامل الضريبة',[discound]as'الخصم',[total]as'اجمالي الصنف',[TotalOrder]as'اجمالي الفاتوره',[madfoo3]as'المبلغ الدفوع',[Baky]as'المتبقي',[User_name]as'الكاشير',[Date]as'التاريخ' FROM [dbo].[sales_details],products where products.Pro_ID =sales_details.Pro_ID and User_name = N'" + cbx_user.Text + "' and Order_ID =" + txt_numberOrder.Text + "  and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");

                }
            }
            Dgv_search.DataSource = tbl;

            if (Dgv_search.Rows.Count >= 1)
            {
                try
                {
                    decimal totalprice = 0,totaltax = 0,totalpricetax=0;
                    for (int i = 0; i <= Dgv_search.Rows.Count - i; i++)
                    {
                        totalprice += (Convert.ToDecimal(Dgv_search.Rows[i].Cells[5].Value)* Convert.ToDecimal(Dgv_search.Rows[i].Cells[3].Value)) - Convert.ToDecimal(Dgv_search.Rows[i].Cells[8].Value);
                        totaltax += (Convert.ToDecimal(Dgv_search.Rows[i].Cells[6].Value) * Convert.ToDecimal(Dgv_search.Rows[i].Cells[3].Value));
                        totalpricetax += Convert.ToDecimal(Dgv_search.Rows[i].Cells[9].Value);

                    }
                    txt_total.Text = Math.Round(totalprice, 2).ToString();
                    txt_totaltax.Text = Math.Round(totaltax, 2).ToString();
                    txt_pricetax.Text = Math.Round(totalpricetax, 2).ToString();
                }
                catch (Exception) { }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {


            if (Dgv_search.Rows.Count >= 1)
                {
           
            tbl.Clear();
            string date1;
            string date2;
            date1 = dtp_from.Value.ToString("yyyy-MM-dd");
            date2 = dtp_to.Value.ToString("yyyy-MM-dd");
  
              if (MessageBox.Show("هل انت متاكد من مسح البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                    db.excetedate("delete from sales where convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "تم المسح بنجاح");
                    btn_search_Click_1(null, null);
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
            tblrpt = db.readData("SELECT [Order_ID]as'رقم الفاتوره',[Cus_name]as'اسم العميل',products.[Pro_name]as'المتج',sales_details.[Qty]as'الكميه',sales_details.price_tax as'السعر',[discound]as'الخصم',[total]as'الاجمالي',[TotalOrder]as'اجمالي الفاتوره',[madfoo3]as'المبلغ الدفوع',[Baky]as'المتبقي',[User_name]as'الكاشير',[Date]as'التاريخ'FROM [dbo].[sales_details],products where products.Pro_ID =sales_details.Pro_ID and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ORDER BY Order_ID ASC", "");
            Frm_printing frm = new Frm_printing();

            rpt_salesReport rpt = new rpt_salesReport();
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
        private void print()
        {

            //لطباعة الفاتوره المحدده
            int id = Convert.ToInt32(Dgv_search.CurrentRow.Cells[0].Value);


            DataTable tblrpt = new DataTable();
            tblrpt.Clear();
            tblrpt = db.readData("SELECT [Order_ID]as'رقم الفاتوره',[Cus_name]as'اسم العميل',products.[Pro_name]as'المتج',sales_details.[Qty]as'الكميه',[price]as'السعر',[discound]as'الخصم',[total]as'الاجمالي',[TotalOrder]as'اجمالي الفاتوره',[madfoo3]as'المبلغ الدفوع',[Baky]as'المتبقي',[User_name]as'الكاشير',[Date]as'التاريخ'FROM [dbo].[sales_details],products where products.Pro_ID =sales_details.Pro_ID and Order_ID =" + id + "", "");
            Frm_printing frm = new Frm_printing();

            Rpt_OrderSale rpt = new Rpt_OrderSale();
            frm.crystalReportViewer1.RefreshReport();
            rpt.SetDatabaseLogon("", "", "DESKTOP-NJ3N9G2", "therd");
            rpt.SetDataSource(tblrpt);
            rpt.SetParameterValue("id", id);
            frm.crystalReportViewer1.ReportSource = rpt;
            //لتحديد خيارات الطابعه
            System.Drawing.Printing.PrintDocument PrintDocument = new System.Drawing.Printing.PrintDocument();
            rpt.PrintOptions.PrinterName = PrintDocument.PrinterSettings.PrinterName;
                 rpt.PrintToPrinter(1, true, 0, 0);
          //  frm.ShowDialog();

        }
        private void btn_orderprint_Click(object sender, EventArgs e)
        {

            if (Dgv_search.Rows.Count >= 1)
            {
                print();

            }
        }

        private void frm_saleReport_Load(object sender, EventArgs e)
        {
            dtp_date.Text = DateTime.Now.ToShortDateString();
            dtp_to.Text = DateTime.Now.ToShortDateString();
            filluser();
        }
    }
}