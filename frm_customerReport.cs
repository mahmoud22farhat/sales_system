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
    public partial class frm_customerReport : DevExpress.XtraEditors.XtraForm
    {
        public frm_customerReport()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();
        private void fillcustomer()
        {
            cbx_customer.DataSource = db.readData("select * from customers", "");
            cbx_customer.DisplayMember = "cust_Name";
            cbx_customer.ValueMember = "cust_ID";

        }
        private void frm_customerReport_Load(object sender, EventArgs e)
        {
            try
            {
                fillcustomer();
            }
            catch (Exception) { }
            dtp_date.Text = DateTime.Now.ToShortDateString();
            tbl.Clear();

            tbl = db.readData("SELECT [Order_ID]as'رقم الفاتوره',[price]as'المبلغ المدفوع',[Date]as'تاريخ الدفع',[cust_Name]as'اسم العميل'FROM [dbo].[customer_report] ", "");


            Dgv_search.DataSource = tbl;
            decimal totalprice = 0;
            for (int i = 0; i <= Dgv_search.Rows.Count - i; i++)
            {
                totalprice += Convert.ToDecimal(Dgv_search.Rows[i].Cells[1].Value);
            }
            txt_total.Text = Math.Round(totalprice, 2).ToString();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
          


                tbl.Clear();
                if (rbtn_allcustomer.Checked == true)
                {
                    tbl = db.readData("SELECT [Order_ID]as'رقم الفاتوره',[price]as'المبلغ المدفوع',[Date]as'تاريخ الدفع',[cust_Name]as'اسم العميل'FROM [dbo].[customer_report] ", "");
                }
                else if (rbtn_onecustomer.Checked == true)
                {
                    tbl = db.readData("SELECT [Order_ID]as'رقم الفاتوره',[price]as'المبلغ المدفوع',[Date]as'تاريخ الدفع',[cust_Name]as'اسم العميل'FROM [dbo].[customer_report] where cust_Name =N'" + cbx_customer.Text + "' ", "");

                }

                Dgv_search.DataSource = tbl;
             if (Dgv_search.Rows.Count >= 1)
            {
                try
                {

                    decimal totalprice = 0;
                    for (int i = 0; i <= Dgv_search.Rows.Count - i; i++)
                    {
                        totalprice += Convert.ToDecimal(Dgv_search.Rows[i].Cells[1].Value);
                    }
                    txt_total.Text = Math.Round(totalprice, 2).ToString();
                }
                catch (Exception) { }
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (Dgv_search.Rows.Count >= 1)
            {
                if (MessageBox.Show("هل انت متاكد من مسح البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (rbtn_onecustomer.Checked == true)
                    {
                        db.excetedate("delete from customer_report where cust_Name =N'" + cbx_customer.Text + "' ", "تم مسح البيانات بنجاح");
                        frm_customerReport_Load(null, null);

                    }
                    else { MessageBox.Show("من فضلك حدد عميل اولا", "تاكيد"); return; }

                }
            }
        }

      
    }
    }

