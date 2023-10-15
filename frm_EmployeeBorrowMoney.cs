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
    public partial class frm_EmployeeBorrowMoney : DevExpress.XtraEditors.XtraForm
    {
        public frm_EmployeeBorrowMoney()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();
        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select MAX (Order_ID) from Empployee_BorrowMoney", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))

            {
                txt_id.Text = "1";
            }
            else
            {
                txt_id.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();

            }
            nud_price.Value = 1;
            txt_name.Clear();
            txt_notes.Clear();
            txt_creditor.Clear();
            dtp_date.Text = DateTime.Now.ToShortDateString();
            dtp_reminder.Text = DateTime.Now.ToShortDateString();

            Rbtn_Normal_CheckedChanged(null, null);
            try
            {

                cbx_employee.SelectedIndex = 0;
            

            }
            catch (Exception) { }
        }
     
        private void fillemployee()
        {
            cbx_employee.DataSource = db.readData("select * from Employee_", "");
            cbx_employee.DisplayMember = "emp_Name";
            cbx_employee.ValueMember = "emp_ID";
        }
        string stock_ID = "";
        private void frm_EmployeeBorrowMoney_Load(object sender, EventArgs e)
        {
            try
            {
                AutoNumber();
                fillemployee();
             

            }
            catch (Exception) { }
            stock_ID = Convert.ToString(Properties.Settings.Default.stock_id);
        }

        private void Rbtn_Normal_CheckedChanged(object sender, EventArgs e)
        {
            cbx_employee.Enabled = false;
            txt_name.Enabled = true;
        }

        private void Rbtn_employee_CheckedChanged(object sender, EventArgs e)
        {
            cbx_employee.Enabled = true;
            txt_name.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        { string d = dtp_date.Value.ToString("dd/MM/yyyy");
            string DReminder = dtp_reminder.Value.ToString("dd/MM/yyyy");


            if (cbx_employee.Items.Count <= 0)
            {

                MessageBox.Show("من فضلك تاكد من اكتمال الموظفين", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            if (nud_price.Value <= 0)
            {
                MessageBox.Show("لابد ان يكون المبلغ لا يقل عن واحد", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return;

            }
            string name = "";
            if (Rbtn_employee.Checked == true)
            { name = cbx_employee.Text; }
            else
            {
                if (txt_name.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل اسم الشخص المدين", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                }
                name = txt_name.Text;            
                }
            decimal stock_money = 0;
            tbl.Clear();
            tbl = db.readData("select * from stock where stock_ID = "+stock_ID+"", "");
            stock_money = Convert.ToDecimal(tbl.Rows[0][1]);

            if(nud_price.Value>stock_money)
            {

                MessageBox.Show("المبلغ الموجود في الخزنه غر كافي لاجراء العمليه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            if (Rbtn_employee.Checked == true) { 
                db.excetedate("insert into employee_salarymainus (emp_ID,emp_Name,date,price,pay) values(" + cbx_employee.SelectedValue + " ,N'" + name+ "' ,N'" + d + "' ," + nud_price.Value + " , 'no')", "");
              }
            db.excetedate("insert into stock_pull (stock_ID ,Mony ,Date ,Name ,Type ,Reason) values (" + stock_ID + "," + nud_price.Value + ",N'" + d + "',N'" + txt_creditor.Text + "' ,N'سلفيات',N'" + txt_notes.Text + "')", "");
            db.excetedate("update stock set Mony=Mony - "+nud_price.Value+"where stock_ID = "+stock_ID+"", "");           
            db.excetedate("insert into Empployee_BorrowMoney values ("+txt_id.Text+" ,N'"+txt_creditor.Text+"' ,N'"+name+ "' ,N'" + d + "' ,N'" + DReminder + "' , "+nud_price.Value+" ,N'"+txt_notes.Text+"') ", "تمت العمليه بنجاح");
            AutoNumber();
        }
    }
}