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
    public partial class frm_EmployeeBorrowitemsReport : DevExpress.XtraEditors.XtraForm
    {
        public frm_EmployeeBorrowitemsReport()
        {
            InitializeComponent();
        }
            database db = new database();
            DataTable tbl = new DataTable();
        private void frm_EmployeeBorrowitemsReport_Load(object sender, EventArgs e)
        {
            fillemployee();
            dtp_from.Text = DateTime.Now.ToShortDateString();
            dtp_to.Text = DateTime.Now.ToShortDateString();
        }
        private void fillemployee()
        {
            cbx_employee.DataSource = db.readData("select * from Employee_", "");
            cbx_employee.DisplayMember = "emp_Name";
            cbx_employee.ValueMember = "emp_ID";
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
                if (rbtn_allEmp.Checked == true) { 
                tbl = db.readData("SELECT [Order_ID] as'رقم المنتج',products.Pro_name as'اسم المنتج',Employee_.emp_Name as'اسم الموظف',[employee_Borrowiitems].[Date] as'تاريخ السحب',[employee_Borrowiitems].[Qty] as'الكميه المسحوبه'FROM [dbo].[employee_Borrowiitems],products,Employee_ where employee_Borrowiitems.emp_ID=Employee_.emp_ID and employee_Borrowiitems.item_ID = products.Pro_ID and convert( date,employee_Borrowiitems.Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "");
                 }
                else {
                    tbl = db.readData("SELECT [Order_ID] as'رقم المنتج',products.Pro_name as'اسم المنتج',Employee_.emp_Name as'اسم الموظف',[employee_Borrowiitems].[Date] as'تاريخ السحب',[employee_Borrowiitems].[Qty] as'الكميه المسحوبه'FROM [dbo].[employee_Borrowiitems],products,Employee_ where employee_Borrowiitems.emp_ID=Employee_.emp_ID and employee_Borrowiitems.item_ID = products.Pro_ID and employee_Borrowiitems.emp_ID="+cbx_employee.SelectedValue+" and convert( date,employee_Borrowiitems.Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "");

                }
                if (tbl.Rows.Count >= 1)
                {
                    Dgv_search.DataSource = tbl;
                    decimal sum = 0;
                    for (int i = 0; i <= tbl.Rows.Count - 1; i++)
                    {
                        sum += Convert.ToDecimal(tbl.Rows[i][4]);
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
                db.excetedate("delete from employee_Borrowiitems where convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "تم مسح البيانات بنجاح");

            }
        }
    }
}