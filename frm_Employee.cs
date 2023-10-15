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
    public partial class frm_Employee : DevExpress.XtraEditors.XtraForm
    {
        public frm_Employee()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();

        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select MAX (emp_ID) from Employee_", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {
                txt_id.Text = "1";
            }
            else
            {
                txt_id.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            //حذف البانات بعد اتمام ملية اضافه .....ليتم اضافة عميل جديد
            txt_name.Clear();
            txt_phone.Clear();
            txt_salary.Clear();
            txt_address.Clear();
            txt_search.Clear();
            txt_nationaliD.Clear();
            dtp_date.Text = DateTime.Now.ToShortDateString();

            btn_add.Enabled = true;
            btn_new.Enabled = true;
            btn_delete.Enabled = false;
            btn_deleteall.Enabled = false;
            btn_save.Enabled = false;

         
        }
        int row;
        private void show()
        {
            try { 
            tbl.Clear();
            tbl = db.readData("select * from Employee_", "");
                if (tbl.Rows.Count <= 0)
                {
                    MessageBox.Show("لايوجد بيانات في هذه الشاشة");
                }
                else
                {
                    txt_id.Text = tbl.Rows[row][0].ToString();
                    txt_name.Text = tbl.Rows[row][1].ToString();
                    txt_salary.Text = tbl.Rows[row][2].ToString();

                    this.Text = tbl.Rows[row][3].ToString();
                    DateTime dt = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                    dtp_date.Value = dt;

                    //dtp_date.Text    = tbl.Rows[row][2].ToString();


                    txt_nationaliD.Text = tbl.Rows[row][4].ToString();
                    txt_phone.Text = tbl.Rows[row][5].ToString();
                    txt_address.Text = tbl.Rows[row][6].ToString();
                }
            }
            catch (Exception) { }
            btn_add.Enabled = false;
            btn_new.Enabled = true;
            btn_delete.Enabled = true;
            btn_deleteall.Enabled = true;
            btn_save.Enabled = true;
        }
        private void frm_Employee_Load(object sender, EventArgs e)
        {
            AutoNumber();

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            AutoNumber();

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الموظف");
                return;
            }
            if (txt_salary.Text == "")
            {
                MessageBox.Show("من فضلك ادخل راتب الموظف ");
                return;
            }
            if (txt_salary.Text == "")
            {
                MessageBox.Show("من فضلك ادخل هاتف الموظف ");
                return;
            }


            string d = dtp_date.Value.ToString("dd/MM/yyyy");
            db.excetedate("insert into Employee_ values("+txt_id.Text+",N'"+txt_name.Text+"',"+txt_salary.Text+",N'"+d+"',N'"+txt_nationaliD.Text+"',N'"+txt_phone.Text+"',N'"+txt_address.Text+"')", "تم الادخال بنجاح");
            AutoNumber();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string d = dtp_date.Value.ToString("dd/MM/yyyy");
            db.readData("update Employee_ set emp_Name= N'" + txt_name.Text + "',salary =" + txt_salary.Text + ",date=N'" + d + "',national_ID=N'" + txt_nationaliD.Text + "',emp_phone=N'" + txt_phone.Text + "',emp_address=N'" + txt_address.Text + "'where emp_ID="+txt_id.Text+" ", "تم التعديل بنجاح");
            AutoNumber();
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            row = 0;
            show();
        }

        private void btn_priv_Click(object sender, EventArgs e)
        {
            if (row == 0)
            {
                tbl.Clear();
                tbl = db.readData("select count(emp_ID) from Employee_", "");
                row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
                show();
            }
            else
            {
                row--;
                show();

            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {

            tbl.Clear();
            tbl = db.readData("select count(emp_ID) from Employee_", "");
            if (Convert.ToInt32(tbl.Rows[0][0]) - 1 == row)
            {
                row = 0;
                show();
            }
            else
            {
                row++;
                show();

            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select count(emp_ID) from Employee_", "");

            row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من مسح البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Employee_ where emp_ID=" + txt_id.Text + "", "تم مسح البيانات بنجاح");
                AutoNumber();
            }
        }

        private void btn_deleteall_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من مسح جميع البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Employee_ ", "تم مسح جميع الموظفين بنجاح");
                AutoNumber();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable tblsearch = new DataTable();
            tblsearch.Clear();
            tblsearch = db.readData("select * from Employee_ where emp_Name like N'%" + txt_search.Text + "%'    ", "");

            try
            {

                txt_id.Text = tblsearch.Rows[0][0].ToString();
                txt_name.Text = tblsearch.Rows[0][1].ToString();
                txt_salary.Text = tblsearch.Rows[0][2].ToString();

                this.Text = tblsearch.Rows[0][3].ToString();
                DateTime dt = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                dtp_date.Value = dt;

                //dtp_date.Text    = tbl.Rows[row][2].ToString();


                txt_nationaliD.Text = tblsearch.Rows[0][4].ToString();
                txt_phone.Text = tblsearch.Rows[0][5].ToString();
                txt_address.Text = tblsearch.Rows[0][6].ToString();
            }
            catch (Exception)
            {

            }
            btn_add.Enabled = false;
            btn_new.Enabled = true;
            btn_delete.Enabled = true;
            btn_deleteall.Enabled = true;
            btn_save.Enabled = true;
        }

        private void frm_Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                frm_sales.GetFormsales.fillcustomer();


            }
            catch (Exception) { }
        }
    }
}