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
    public partial class frm_EmployeesalaryReport : DevExpress.XtraEditors.XtraForm
    {
        public frm_EmployeesalaryReport()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();
        private void frm_EmployeesalaryReport_Load(object sender, EventArgs e)
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
                if (rbtn_allemployee.Checked == true)
                {
                    tbl = db.readData("SELECT [Order_ID] as'رقم العملية',Employee_.emp_Name as'اسم الموظف',[total_salary] as'اجمالي المرتب',[total_Borrow] as'اجمالي السلفيات والمسحوبات',[safy_salary] as'صافي المرتب',[order_date] as'تاريخ الصرف',[Date_reminder] as'تاريخ الاستحقاق',[Notes] as'ملاحظات'FROM [dbo].[employee_salary],Employee_ where Employee_.emp_ID=employee_salary.emp_ID and convert( date,order_date ,105 ) between '" + date1 + "' and '" + date2 + "'", "");
                }
                else
                {
                    tbl = db.readData("SELECT [Order_ID] as'رقم العملية',Employee_.emp_Name as'اسم الموظف',[total_salary] as'اجمالي المرتب',[total_Borrow] as'اجمالي السلفيات والمسحوبات',[safy_salary] as'صافي المرتب',[order_date] as'تاريخ الصرف',[Date_reminder] as'تاريخ الاستحقاق',[Notes] as'ملاحظات'FROM [dbo].[employee_salary],Employee_ where Employee_.emp_ID=employee_salary.emp_ID and employee_salary.emp_ID =" + cbx_employee.SelectedValue + " and convert( date,order_date,105 ) between '" + date1 + "' and '" + date2 + "'", "");

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
                db.excetedate("delete from employee_salary where convert( date,[order_date] ,105 ) between '" + date1 + "' and '" + date2 + "'", "تم مسح البيانات بنجاح");

            }
        }

      
    }
}