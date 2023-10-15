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
    public partial class frm_BuyReporter : DevExpress.XtraEditors.XtraForm
    {
        public frm_BuyReporter()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();
        private void fillsuppliers()
        {
            cbx_supliers.DataSource = db.readData("select * from supliers", "");
            cbx_supliers.DisplayMember = "sup_Name";
            cbx_supliers.ValueMember = "sup_ID";

        }

        private void frm_BuyReporter_Load(object sender, EventArgs e)
        {
            fillsuppliers();
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


            if (rbtn_allsupplier.Checked == true)
            {
                if (checkOrderNumber.Checked == false)
                {

                    tbl = db.readData("SELECT [Order_ID] as'رقم الفاتوره',supliers.sup_Name as 'اسم المورد',products.Pro_name as'اسم المنتج',[Date] as'تاريخ الفاتوره',[buy_datails].[Qty] as'الكميه',[unit_name]as'الوحدة',[price] as'السعر قبل الضريبة',buy_datails.tax_value as'الضريبة',[price_tax]as'السعر بعد الضريبة',[discound] as'الخصم',[total] as'اجمالي الصنف',[TotalOrder] as'الاجمالي العام',[madfoo3] as'المدفوع',[Baky] as'المبلغ المتبقي',[User_name] as'اسم المستخدم'FROM [dbo].[buy_datails],supliers,products where supliers.sup_ID = [buy_datails].Sup_ID and products.Pro_ID = [buy_datails].Pro_ID and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");
                }
                else if (checkOrderNumber.Checked == true)
                {
                    tbl = db.readData("SELECT [Order_ID] as'رقم الفاتوره',supliers.sup_Name as 'اسم المورد',products.Pro_name as'اسم المنتج',[Date] as'تاريخ الفاتوره',[buy_datails].[Qty] as'الكميه',[unit_name]as'الوحدة',[price] as'السعر قبل الضريبة',buy_datails.tax_value as'الضريبة',[price_tax]as'السعر بعد الضريبة',[discound] as'الخصم',[total] as'اجمالي الصنف',[TotalOrder] as'الاجمالي العام',[madfoo3] as'المدفوع',[Baky] as'المبلغ المتبقي',[User_name] as'اسم المستخدم'FROM [dbo].[buy_datails],supliers,products where supliers.sup_ID = [buy_datails].Sup_ID and products.Pro_ID = [buy_datails].Pro_ID and Order_ID =" + txt_numberOrder.Text+" and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");
                }
            }
            else if (rbtn_onesupplier.Checked == true)
            {
                if (checkOrderNumber.Checked == false)

                {

                    tbl = db.readData("SELECT [Order_ID] as'رقم الفاتوره',supliers.sup_Name as 'اسم المورد',products.Pro_name as'اسم المنتج',[Date] as'تاريخ الفاتوره',[buy_datails].[Qty] as'الكميه',[unit_name]as'الوحدة',[price] as'السعر قبل الضريبة',buy_datails.tax_value as'الضريبة',[price_tax]as'السعر بعد الضريبة',[discound] as'الخصم',[total] as'اجمالي الصنف',[TotalOrder] as'الاجمالي العام',[madfoo3] as'المدفوع',[Baky] as'المبلغ المتبقي',[User_name] as'اسم المستخدم'FROM [dbo].[buy_datails],supliers,products where supliers.sup_ID = [buy_datails].Sup_ID and products.Pro_ID = [buy_datails].Pro_ID and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' and  [buy_datails].Sup_ID = " + cbx_supliers.SelectedValue + " ", "");
                }
                else if (checkOrderNumber.Checked == true)
                {
                    tbl = db.readData("SELECT [Order_ID] as'رقم الفاتوره',supliers.sup_Name as 'اسم المورد',products.Pro_name as'اسم المنتج',[Date] as'تاريخ الفاتوره',[buy_datails].[Qty] as'الكميه',[unit_name]as'الوحدة',[price] as'السعر قبل الضريبة',buy_datails.tax_value as'الضريبة',[price_tax]as'السعر بعد الضريبة',[discound] as'الخصم',[total] as'اجمالي الصنف',[TotalOrder] as'الاجمالي العام',[madfoo3] as'المدفوع',[Baky] as'المبلغ المتبقي',[User_name] as'اسم المستخدم'FROM [dbo].[buy_datails],supliers,products where supliers.sup_ID = [buy_datails].Sup_ID and products.Pro_ID = [buy_datails].Pro_ID and Order_ID =" + txt_numberOrder.Text + " and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' and  [buy_datails].Sup_ID = " + cbx_supliers.SelectedValue + " ", "");
                }
            }
            Dgv_search.DataSource = tbl;

            if (Dgv_search.Rows.Count >= 1)
            {
                try
                {
                    decimal totalprice = 0,totaltax=0;
                    for (int i = 0; i <= Dgv_search.Rows.Count - i; i++)
                    {
                        totalprice += Convert.ToDecimal(Dgv_search.Rows[i].Cells[10].Value);
                        totaltax += Convert.ToDecimal(Dgv_search.Rows[i].Cells[7].Value)* Convert.ToDecimal(Dgv_search.Rows[i].Cells[4].Value);
                    }

                    txt_total.Text = Math.Round(totalprice, 2).ToString();
                    txttotaltax.Text = Math.Round(totaltax, 2).ToString();

                }
                catch (Exception) { }
            }
        }
        private void print()
        {
            int id = Convert.ToInt32(Dgv_search.CurrentRow.Cells[0].Value);
            DataTable tblrpt = new DataTable();

            tblrpt.Clear();
            tblrpt = db.readData("SELECT [Order_ID] as'رقم الفاتوره',supliers.sup_Name as 'اسم المورد',products.Pro_name as'اسم المنتج',[Date] as'تاريخ الفاتوره',[buy_datails].[Qty] as'الكميه',[unit_name]as'الوحدة',[User_name] as'اسم المستخدم',[price] as'السعر قبل الضريبة',buy_datails.tax_value as'الضريبة',[price_tax]as'السعر بعد الضريبة',[discound] as'الخصم',[total] as'اجمالي الصنف',[TotalOrder] as'الاجمالي العام',[madfoo3] as'المدفوع',[Baky] as'المبلغ المتبقي'FROM [dbo].[buy_datails],supliers,products where supliers.sup_ID = [buy_datails].Sup_ID and products.Pro_ID = [buy_datails].Pro_ID and Order_ID =" + id + "", "");

            Frm_printing frm = new Frm_printing();
            frm.crystalReportViewer1.RefreshReport();
            if (Properties.Settings.Default.buyprintkind == "8cm")
            {
                RptOrderBuy rpt = new RptOrderBuy();


                rpt.SetDatabaseLogon("", "", "DESKTOP-NJ3N9G2", "therd");
                rpt.SetDataSource(tblrpt);
                rpt.SetParameterValue("id", id);
                frm.crystalReportViewer1.ReportSource = rpt;
                //لتحديد خيارات الطابعه
                System.Drawing.Printing.PrintDocument PrintDocument = new System.Drawing.Printing.PrintDocument();
                //للطباعه علي الطابعه المتحدده علي الجهاز
                //  rpt.PrintOptions.PrinterName = PrintDocument.PrinterSettings.PrinterName;
                //للطباعه علي الطابعه المتحدده داخل البرنامج
                rpt.PrintOptions.PrinterName = Properties.Settings.Default.printername;

                rpt.PrintToPrinter(1, true, 0, 0);
                // frm.ShowDialog();

            }
            else if (Properties.Settings.Default.buyprintkind == "A4")
            {
                RptOrderBuyA4 rpt = new RptOrderBuyA4();


                rpt.SetDatabaseLogon("", "", "DESKTOP-NJ3N9G2", "therd");
                rpt.SetDataSource(tblrpt);
                rpt.SetParameterValue("id", id);
                frm.crystalReportViewer1.ReportSource = rpt;
                //لتحديد خيارات الطابعه
                System.Drawing.Printing.PrintDocument PrintDocument = new System.Drawing.Printing.PrintDocument();
                //للطباعه علي الطابعه المتحدده علي الجهاز
                //  rpt.PrintOptions.PrinterName = PrintDocument.PrinterSettings.PrinterName;
                //للطباعه علي الطابعه المتحدده داخل البرنامج
                rpt.PrintOptions.PrinterName = Properties.Settings.Default.printername;

                rpt.PrintToPrinter(1, true, 0, 0);
                // frm.ShowDialog();
            }



        }

        private void btn_print_Click_1(object sender, EventArgs e)
        {
            if (Dgv_search.Rows.Count >= 1)
            {
                print();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
      
                if (Dgv_search.Rows.Count >= 1)
                {
                if (MessageBox.Show("هل انت متاكد من مسح البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes )
            {
            
                    db.excetedate("delete from buy where Order_ID=" + Dgv_search.CurrentRow.Cells[0].Value + " ", "تم المسح بنجاح");
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

            //int id = Convert.ToInt32(Dgv_search.CurrentRow.Cells[0].Value);
            DataTable tblrpt = new DataTable();
            tblrpt.Clear();
            tblrpt = db.readData("SELECT [Order_ID] as'رقم الفاتوره',supliers.sup_Name as 'اسم المورد',products.Pro_name as'اسم المنتج',[Date] as'تاريخ الفاتوره',[buy_datails].[Qty] as'الكميه',[unit_name]as'الوحدة',[User_name] as'اسم المستخدم',[price] as'السعر قبل الضريبة',buy_datails.tax_value as'الضريبة',[price_tax]as'السعر بعد الضريبة',[discound] as'الخصم',[total] as'اجمالي الصنف',[TotalOrder] as'الاجمالي العام',[madfoo3] as'المدفوع',[Baky] as'المبلغ المتبقي'FROM [dbo].[buy_datails],supliers,products where supliers.sup_ID = [buy_datails].Sup_ID and products.Pro_ID = [buy_datails].Pro_ID and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");

            Frm_printing frm = new Frm_printing();
            frm.crystalReportViewer1.RefreshReport();

            rpt_BuyReport rpt = new rpt_BuyReport();

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
        private void btn_printAll_Click(object sender, EventArgs e)
        {

            if (Dgv_search.Rows.Count >= 1)
            {
                printall();

            }
        }

    
    }
}
        
    

        




    