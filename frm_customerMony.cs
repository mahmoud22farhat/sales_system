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
    public partial class frm_customerMony : DevExpress.XtraEditors.XtraForm
    {
        public frm_customerMony()
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
       string stock_ID = "";
        private void frm_customerMony_Load(object sender, EventArgs e)
        {
            stock_ID = Convert.ToString(Properties.Settings.Default.stock_id);

            try
            {
                fillcustomer();
            }
            catch (Exception) { }
            if (Dgv_search.Rows.Count >= 1)
            {
                try
                {
                    dtp_date.Text = DateTime.Now.ToShortDateString();
                    tbl.Clear();
                    tbl = db.readData("SELECT [Order_ID]as 'رقم الفاتوره',[cust_Name]as 'العميل',[price]as 'المبلغ المستحق',[Order_Date]as 'تاريخ الفاتوره',[Reminder_Date]as 'تاريخ الاستحقاق'FROM [dbo].[customer_mony]", "");

                    Dgv_search.DataSource = tbl;
                    decimal totalprice = 0;
                    for (int i = 0; i <= Dgv_search.Rows.Count - i; i++)
                    {
                        totalprice += Convert.ToDecimal(Dgv_search.Rows[i].Cells[2].Value);
                    }
                    txt_total.Text = Math.Round(totalprice, 2).ToString();
                }
                catch (Exception) { }
            }
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
           
                    tbl.Clear();
            if (rbtn_allcust.Checked == true)
            {
                tbl = db.readData("SELECT [Order_ID]as 'رقم الفاتوره',[cust_Name]as 'العميل',[price]as 'المبلغ المستحق',[Order_Date]as 'تاريخ الفاتوره',[Reminder_Date]as 'تاريخ الاستحقاق'FROM [dbo].[customer_mony]", "");
            }
            else if (rbtn_onecust.Checked == true)
            {
                tbl = db.readData("SELECT [Order_ID]as 'رقم الفاتوره',[cust_Name]as 'العميل',[price]as 'المبلغ المستحق',[Order_Date]as 'تاريخ الفاتوره',[Reminder_Date]as 'تاريخ الاستحقاق'FROM [dbo].[customer_mony] where cust_Name =N'" + cbx_customer.Text + "'", "");

            }
            Dgv_search.DataSource = tbl;

            if (Dgv_search.Rows.Count >= 1)
            {
                try
                {
                    decimal totalprice = 0;
                    for (int i = 0; i <= Dgv_search.Rows.Count - i; i++)
                    {
                        totalprice += Convert.ToDecimal(Dgv_search.Rows[i].Cells[2].Value);
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
                string d = dtp_date.Value.ToString("dd/MM/yyyy");
                
                if (rbtn_payall.Checked == true)
                {
                    if (MessageBox.Show("هل انت متاكد من تسديد المبلغ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (rbtn_allcust.Checked == true) { MessageBox.Show("من فضلك حدد اسم عميل", "تأكيد"); return; }
                        db.excetedate("delete from customer_mony where Order_ID =" + Dgv_search.CurrentRow.Cells[0].Value + " and price = " + Dgv_search.CurrentRow.Cells[2].Value + " ", "");
                        db.excetedate("insert into customer_report values (" + Dgv_search.CurrentRow.Cells[0].Value + ", " + Dgv_search.CurrentRow.Cells[2].Value + "," + d + ",N'" + cbx_customer.Text + "' )", "تم تسديد المبلغ بنجاح");
                        frm_customerMony_Load(null, null);
                    }
                }
                else if (rbtn_paypart.Checked == true)
                {

                    if (MessageBox.Show("هل انت متاكد من تسديد المبلغ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {                  
                        if (rbtn_payall.Checked == true) { MessageBox.Show("من فضلك حدد اسم مورد", "تأكيد"); return; }
                        decimal money = Convert.ToDecimal(Dgv_search.CurrentRow.Cells[2].Value) - nud_price.Value;
                        db.excetedate("update customer_mony set  price =" + money + " where Order_ID = " + Dgv_search.CurrentRow.Cells[0].Value + " and price =" + Dgv_search.CurrentRow.Cells[2].Value + " ", "");
                        db.excetedate("insert into customer_report values (" + Dgv_search.CurrentRow.Cells[0].Value + ", " + nud_price.Value + "," + d + ",N'" + cbx_customer.Text + "' )", "تم تسديد المبلغ بنجاح");
                        frm_customerMony_Load(null, null);

                    }
                }
                if (rbtn_payall.Checked == true)
                {
                    db.excetedate("insert into stock_insert (stock_ID ,Mony ,Date ,Name ,Type ,Reason) values (" + stock_ID + "," + Dgv_search.CurrentRow.Cells[2].Value + ",N'" + d + "', N'" + Properties.Settings.Default.usernane + "' ,N'مستحقات العملاء',N'')", "");
                    db.excetedate("update stock set Mony=Mony + " + Dgv_search.CurrentRow.Cells[2].Value + "where stock_ID = " + stock_ID + "", "");
                }
                else
                {
                    db.excetedate("insert into stock_insert(stock_ID ,Mony ,Date ,Name ,Type ,Reason) values (" + stock_ID + "," + nud_price.Value + ",N'" + d + "', N'" + Properties.Settings.Default.usernane + "' ,N'مصروفات',N'')", "");
                    db.excetedate("update stock set Mony=Mony + " + nud_price.Value + "where stock_ID = " + stock_ID + "", "");

                }
            }
        }
        private void printonecustomer()
        {
            string name = Convert.ToString(cbx_customer.Text);
            DataTable tblrpt = new DataTable();

            tblrpt.Clear();
            tblrpt = db.readData("SELECT [Order_ID]as 'رقم الفاتوره',[cust_Name]as 'العميل',[price]as 'المبلغ المستحق',[Order_Date]as 'تاريخ الفاتوره',[Reminder_Date]as 'تاريخ الاستحقاق'FROM [dbo].[customer_mony] where cust_Name = N'"+name+"'", "");

            Frm_printing frm = new Frm_printing();

            rpt_CustomerMony rpt = new rpt_CustomerMony();
            frm.crystalReportViewer1.RefreshReport();
            rpt.SetDatabaseLogon("", "", "DESKTOP-NJ3N9G2", "therd");
            rpt.SetDataSource(tblrpt);
            rpt.SetParameterValue("Name", name);
            frm.crystalReportViewer1.ReportSource = rpt;
            //لتحديد خيارات الطابعه
            System.Drawing.Printing.PrintDocument PrintDocument = new System.Drawing.Printing.PrintDocument();
            rpt.PrintOptions.PrinterName = PrintDocument.PrinterSettings.PrinterName;
              rpt.PrintToPrinter(1, true, 0, 0);
           // frm.ShowDialog();

        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (rbtn_allcust.Checked == true)
            {
                if (Dgv_search.Rows.Count >= 0)
                {
                    printonecustomer();
                }

            }
        }

      
    }
}
