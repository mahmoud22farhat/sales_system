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
    public partial class frm_Return_Report : DevExpress.XtraEditors.XtraForm
    {
        public frm_Return_Report()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();
        private void Return_Report_Load(object sender, EventArgs e)
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
            tbl.Clear();
            if (rbtn_allReturn.Checked == true)
            {
                tbl = db.readData("SELECT [returns_details].[Order_ID]as'رقم العمليه',[Sup_Name]as'اسم المورد',[Cust_Name]as'اسم العميل',[Pro_Name]as'المنتج',[Qty]as'الكمية',[unit_name]as'الوحده',[price]as'السعر',[tax_value]as'الضريبه' ,[price_tax]as'السعر بعد الضريبه',[total]as'اجمالي الصنف',[Date]as'التاريخ',[total_Orer]as'اجمالي الفاتوره',[Madfoo3]as'المبلغ المدفوع',[Baky]as'الباقي',[User_name]as'اسم المستخدم'FROM [dbo].[returns_details] where convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "");
            }


            else if (rbtn_salesReturn.Checked == true)
            {
                tbl = db.readData(" SELECT [returns_details].[Order_ID]as'رقم العمليه',[Sup_Name]as'اسم المورد',[Cust_Name]as'اسم العميل',[Pro_Name]as'المنتج',[Qty]as'الكمية',[unit_name]as'الوحده',[price]as'السعر',[tax_value]as'الضريبه' ,[price_tax]as'السعر بعد الضريبه',[total]as'اجمالي الصنف',[Date]as'التاريخ',[total_Orer]as'اجمالي الفاتوره',[Madfoo3]as'المبلغ المدفوع',[Baky]as'الباقي',[User_name]as'اسم المستخدم'FROM [dbo].[returns_details], returns where returns_details.Order_ID = returns.Order_ID and Order_Type= N'مرتجعات مبيعات' and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "");
            }
            else if (rbtn_buyReturn.Checked == true)
            {
                tbl = db.readData("SELECT [returns_details].[Order_ID]as'رقم العمليه',[Sup_Name]as'اسم المورد',[Cust_Name]as'اسم العميل',[Pro_Name]as'المنتج',[Qty]as'الكمية',[unit_name]as'الوحده',[price]as'السعر',[tax_value]as'الضريبه' ,[price_tax]as'السعر بعد الضريبه',[total]as'اجمالي الصنف',[Date]as'التاريخ',[total_Orer]as'اجمالي الفاتوره',[Madfoo3]as'المبلغ المدفوع',[Baky]as'الباقي',[User_name]as'اسم المستخدم'FROM [dbo].[returns_details], returns where returns_details.Order_ID = returns.Order_ID and Order_Type=N'مرتجعات مشتريات' and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "");

            }
            Dgv_search.DataSource = tbl;
            if (Dgv_search.Rows.Count >= 1)
            {
                decimal totalprice = 0, totaltax = 0;
                for (int i = 0; i <= Dgv_search.Rows.Count - i; i++)
                {
                    totalprice += Convert.ToDecimal(Dgv_search.Rows[i].Cells[9].Value);
                    totaltax += Convert.ToDecimal(Dgv_search.Rows[i].Cells[7].Value);
                }
                txt_total.Text = Math.Round(totalprice, 2).ToString();
                txttotaltax.Text = Math.Round(totaltax, 2).ToString();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
            string date1;
            string date2;
            date1 = dtp_from.Value.ToString("yyyy-MM-dd");
            date2 = dtp_to.Value.ToString("yyyy-MM-dd");
           
            if (Dgv_search.Rows.Count >= 1)
            {
                 if (MessageBox.Show("هل انت متاكد من مسح البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.excetedate("delete from returns where Order_ID = " + Dgv_search.CurrentRow.Cells[0].Value + "  ", "");

                    db.excetedate("delete from returns_details where Order_ID = " + Dgv_search.CurrentRow.Cells[0].Value + "", "تم المسح بنجاح");
                    btn_search_Click(null, null);
                }
            }
        }
    }
}