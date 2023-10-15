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
    public partial class frm_EmployeeBorrowMoneyReport : DevExpress.XtraEditors.XtraForm
    {
        public frm_EmployeeBorrowMoneyReport()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();
        private void frm_EmployeeBorrowMoneyReport_Load(object sender, EventArgs e)
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
                if (rbtn_all.Checked == true)
                {
                    tbl = db.readData("SELECT [Order_ID] as'رقم العملية',[Borrow_From] as'الدائن',[Borrow_To] as'المدين-سلف لـ',[order_Date] as'تاريخ السلف',[Date_Reminder] as'تاريخ الاستحقاق',[price] as'المبلغ',[notes] as'ملاحظات'FROM [dbo].[Empployee_BorrowMoney] where convert( date,[order_Date] ,105 ) between '" + date1 + "' and '" + date2 + "'", "");
                }
                else
                {
                    tbl = db.readData("SELECT [Order_ID] as'رقم العملية',[Borrow_From] as'الدائن',[Borrow_To] as'المدين-سلف لـ',[order_Date] as'تاريخ السلف',[Date_Reminder] as'تاريخ الاستحقاق',[price] as'المبلغ',[notes] as'ملاحظات'FROM [dbo].[Empployee_BorrowMoney] where [Borrow_To] = N'"+txt_Name.Text+"' and convert( date,[order_Date] ,105 ) between '" + date1 + "' and '" + date2 + "'", "");

                }
                if (tbl.Rows.Count >= 1)
                {
                    Dgv_search.DataSource = tbl;
                    decimal sum = 0;
                    for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                    {
                        sum += Convert.ToDecimal(tbl.Rows[i][5]);
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
                db.excetedate("delete from employee_Borrowiitems where convert( date,[order_Date] ,105 ) between '" + date1 + "' and '" + date2 + "'", "تم مسح البيانات بنجاح");

            }
        }
    }
}