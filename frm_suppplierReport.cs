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
    public partial class frm_suppplierReport : DevExpress.XtraEditors.XtraForm
    {
        public frm_suppplierReport()
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
        private void frm_suppplierReport_Load(object sender, EventArgs e)
        {
            try
            {
                fillsuppliers();
            }
            catch (Exception) { }
            dtp_date.Text = DateTime.Now.ToShortDateString();
            tbl.Clear();
        
                tbl = db.readData("SELECT [Order_ID] as'رقم الفاتوره',[price] as 'المبلغ المدفوع',[Date]as 'تاريخ الدفع',supliers.sup_Name as 'اسم المورد' FROM [dbo].[suplier_Report],supliers where supliers.sup_ID = suplier_Report.sup_ID ", "");
            
          
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
                    if (rbtn_allsupplier.Checked == true)
                    {
                        tbl = db.readData("SELECT [Order_ID] as'رقم الفاتوره',[price] as 'المبلغ المدفوع',[Date]as 'تاريخ الدفع',supliers.sup_Name as 'اسم المورد' FROM [dbo].[suplier_Report],supliers where supliers.sup_ID = suplier_Report.sup_ID ", "");
                    }
                    else if (rbtn_onesupplier.Checked == true)
                    {
                        tbl = db.readData("SELECT [Order_ID] as'رقم الفاتوره',[price] as 'المبلغ المدفوع',[Date]as 'تاريخ الدفع',supliers.sup_Name as 'اسم المورد' FROM [dbo].[suplier_Report],supliers where supliers.sup_ID = suplier_Report.sup_ID and supliers.sup_ID =" + cbx_supliers.SelectedValue + "  ", "");

                    }
                    Dgv_search.DataSource = tbl;
         if (Dgv_search.Rows.Count >= 1)
            {
                try {

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
            if (Dgv_search.Rows.Count >=1)
            { 
            if (MessageBox.Show("هل انت متاكد من مسح البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            { if(rbtn_onesupplier.Checked == true)
                    {
                        db.excetedate("delete from suplier_Report where sup_ID =" +cbx_supliers.SelectedValue+" ", "تم مسح البيانات بنجاح");
                        frm_suppplierReport_Load(null, null);

                    }
                    else { MessageBox.Show("من فضلك حدد مورد اولا", "تاكيد");return; }

                }
        }
        }

     
    }
}