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
    public partial class frm_supliermony : DevExpress.XtraEditors.XtraForm
    {
        public frm_supliermony()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();

        private void nud_price_ValueChanged(object sender, EventArgs e)
        {

        }
        private void fillsuppliers()
        {
            cbx_supliers.DataSource = db.readData("select * from supliers", "");
            cbx_supliers.DisplayMember = "sup_Name";
            cbx_supliers.ValueMember = "sup_ID";

        }
        string stock_ID = "";
        private void frm_supliermony_Load(object sender, EventArgs e)
        {
            Convert.ToString(Properties.Settings.Default.stock_id);
            try
            {
                fillsuppliers();
            }
            catch (Exception) { }
            dtp_date.Text = DateTime.Now.ToShortDateString();
            tbl.Clear();
            tbl = db.readData("SELECT [Order_ID]as 'رقم الفاتوره',supliers.sup_Name as 'اسم المورد',[price] as'السعر',[Order_Date]as'تاريخ الفاتوره',[Reminder_Date]as'تاريخ الاستحقاق'FROM [therd].[dbo].[suplier_mony],supliers where supliers.sup_ID = [suplier_mony].sup_ID", "");

            Dgv_search.DataSource = tbl;
            decimal totalprice = 0;
            for (int i = 0; i <= Dgv_search.Rows.Count - i; i++)
            {
                totalprice += Convert.ToDecimal(Dgv_search.Rows[i].Cells[2].Value);
            }
            txt_total.Text = Math.Round(totalprice, 2).ToString();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (Dgv_search.Rows.Count >= 1)
            {
                try
                {
                    tbl.Clear();
                    if (rbtn_allsupplier.Checked == true)
                    {
                        tbl = db.readData("SELECT [Order_ID]as 'رقم الفاتوره',supliers.sup_Name as 'اسم المورد',[price] as'السعر',[Order_Date]as'تاريخ الفاتوره',[Reminder_Date]as'تاريخ الاستحقاق'FROM [therd].[dbo].[suplier_mony],supliers where supliers.sup_ID = [suplier_mony].sup_ID", "");
                    }
                    else if (rbtn_onesupplier.Checked == true)
                    {
                        tbl = db.readData("SELECT [Order_ID]as 'رقم الفاتوره',supliers.sup_Name as 'اسم المورد',[price] as'السعر',[Order_Date]as'تاريخ الفاتوره',[Reminder_Date]as'تاريخ الاستحقاق'FROM [therd].[dbo].[suplier_mony],supliers where supliers.sup_ID = [suplier_mony].sup_ID and supliers.sup_ID = " + cbx_supliers.SelectedValue + " ", "");

                    }
                    Dgv_search.DataSource = tbl;
                    decimal totalprice = 0;
                    for (int i = 0; i <= Dgv_search.Rows.Count - i; i++)
                    {
                        totalprice += Convert.ToDecimal(Dgv_search.Rows[i].Cells[3].Value);
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

                decimal stock_money = 0;
                tbl.Clear();
                tbl = db.readData("select * from stock where stock_ID = " + stock_ID + "", "");
                stock_money = Convert.ToDecimal(tbl.Rows[0][1]);
                if (rbtn_payall.Checked == true)
                {
                    if (Convert.ToDecimal(Dgv_search.CurrentRow.Cells[2].Value) > stock_money)
                    {

                        MessageBox.Show("المبلغ الموجود في الخزنه غر كافي لاجراء العمليه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                        return;
                    }

                }
                else
                {

                    if (Convert.ToDecimal(nud_price.Value) > stock_money)
                    {

                        MessageBox.Show("المبلغ الموجود في الخزنه غر كافي لاجراء العمليه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                        return;
                    }
                }
            if (rbtn_payall.Checked == true)
            {
                if (MessageBox.Show("هل انت متاكد من تسديد المبلغ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    if (rbtn_allsupplier.Checked == true) { MessageBox.Show("من فضلك حدد اسم مورد", "تأكيد"); return; }
                    db.excetedate("delete from suplier_mony where Order_ID =" + Dgv_search.CurrentRow.Cells[0].Value + " and price = " + Dgv_search.CurrentRow.Cells[2].Value + " ", "");
                    db.excetedate("insert into suplier_Report values (" + Dgv_search.CurrentRow.Cells[0].Value + ", " + Dgv_search.CurrentRow.Cells[2].Value + "," + d + "," + cbx_supliers.SelectedValue + " )", "تم تسديد المبلغ بنجاح");
                    frm_supliermony_Load(null, null);
                }
            }
            else if (rbtn_paypart.Checked == true)
            {

                if (MessageBox.Show("هل انت متاكد من تسديد المبلغ", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {


                    if (rbtn_allsupplier.Checked == true) { MessageBox.Show("من فضلك حدد اسم مورد", "تأكيد"); return; }
                    decimal money = Convert.ToDecimal(Dgv_search.CurrentRow.Cells[2].Value) - nud_price.Value;
                    db.excetedate("update suplier_mony set  price =" + money + " where Order_ID = " + Dgv_search.CurrentRow.Cells[0].Value + " and price =" + Dgv_search.CurrentRow.Cells[2].Value + " ", "");
                    db.excetedate("insert into suplier_Report values (" + Dgv_search.CurrentRow.Cells[0].Value + ", " + nud_price.Value + "," + d + "," + cbx_supliers.SelectedValue + " )", "تم تسديد المبلغ بنجاح");
                    frm_supliermony_Load(null, null);

                }

            }
                if (rbtn_payall.Checked == true)
                {
                    db.excetedate("insert into stock_pull (stock_ID ,Mony ,Date ,Name ,Type ,Reason) values (" + stock_ID + "," + Dgv_search.CurrentRow.Cells[2].Value + ",N'" + d + "', N'" + Properties.Settings.Default.usernane + "' ,N'مستحقات الموردين',N'')", "");
                    db.excetedate("update stock set Mony=Mony - " + Dgv_search.CurrentRow.Cells[2].Value + "where stock_ID = " + stock_ID + "", "");
                }
                else
                {
                    db.excetedate("insert into stock_pull (stock_ID ,Mony ,Date ,Name ,Type ,Reason) values (" + stock_ID + "," + nud_price.Value + ",N'" + d + "', N'" + Properties.Settings.Default.usernane + "' ,N'مصروفات الموردين',N'')", "");
                    db.excetedate("update stock set Mony=Mony + " + nud_price.Value + "where stock_ID = " + stock_ID + "", "");

                }


            }
    }


        private void printonesupplier()
        {
            int id = Convert.ToInt32(cbx_supliers.SelectedValue);
            DataTable tblrpt = new DataTable();
            tblrpt.Clear();
            tblrpt = db.readData("SELECT [Order_ID]as 'رقم الفاتوره',supliers.sup_Name as 'اسم المورد',[price] as'السعر',[Order_Date]as'تاريخ الفاتوره',[Reminder_Date]as'تاريخ الاستحقاق'FROM [therd].[dbo].[suplier_mony],supliers where supliers.sup_ID = [suplier_mony].sup_ID and supliers.sup_ID =" + id + "", "");
            Frm_printing frm = new Frm_printing();

            rpt_suppliermony rpt = new rpt_suppliermony();
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
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (rbtn_allsupplier.Checked ==true)
            {
                if(Dgv_search.Rows.Count >= 0)
                {
                    printonesupplier();
                }
            
                        }
        }
    }
}
