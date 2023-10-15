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
    public partial class frm_Employeesalary : DevExpress.XtraEditors.XtraForm
    {
        public frm_Employeesalary()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();
        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select MAX (Order_ID) from employee_salary", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))

            {
                txt_id.Text = "1";
            }
            else
            {
                txt_id.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();

            }
           
          
            txt_notes.Clear();
            txt_safysalary.Clear();
            txt_totalBorrow.Clear();
            txt_totalsalary.Clear();
            dtp_date.Text = DateTime.Now.ToShortDateString();
            dtp_reminder.Text = DateTime.Now.ToShortDateString();

           
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
        private void frm_Employeesalary_Load(object sender, EventArgs e)
        {
            try
            {
                AutoNumber();
                fillemployee();
            }
            catch (Exception) { }
            stock_ID =Convert.ToString( Properties.Settings.Default.stock_id);
        }

        private void cbx_employee_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //لعرض تاريخ صرف المرتب
            try
            {
                tbl.Clear();
                tbl = db.readData("select salary,date from Employee_ where emp_ID = "+cbx_employee.SelectedValue+"", "");
                txt_totalsalary.Text = tbl.Rows[0][0].ToString();

                this.Text = tbl.Rows[0][1].ToString();
                DateTime dt = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                dtp_reminder.Value = dt;
                 //لعرض المسحوبات والسلفيات
           try {
                    decimal totalborrow = 0;
                    DataTable tblcheck = new DataTable();
                    tblcheck.Clear();
                    tblcheck = db.readData("select * from employee_salarymainus where emp_ID = " + cbx_employee.SelectedValue + "and pay = N'NO' ","");

                    
                    for(int i=0;i<=tblcheck.Rows.Count - 1; i++)
                    {
                        totalborrow += Convert.ToDecimal(tblcheck.Rows[i][4]);


                    }
                    //لعرض صافي المرتب
                    txt_totalBorrow.Text = (Math.Round(totalborrow, 2)).ToString();


                    txt_safysalary.Text = (Convert.ToDecimal(txt_totalsalary.Text) - Convert.ToDecimal(txt_totalBorrow.Text)).ToString() ;
                } catch (Exception) { }
            } catch (Exception) { }
        }
        private void payBorrow()
        {
            DataTable tblprice = new DataTable();
            tblprice.Clear();
            tblprice = db.readData("select price from employee_salarymainus where emp_ID =" + cbx_employee.SelectedValue + "", "");
            decimal totalsa = Convert.ToDecimal(txt_totalsalary.Text);

            for (int i = 0; i <= tblprice.Rows.Count - 1; i++)
            {
                if (totalsa >= Convert.ToDecimal(tblprice.Rows[i][0]))
                {
                    db.excetedate("update employee_salarymainus set pay='YES' where emp_ID =" + cbx_employee.SelectedValue + " and pay =N'NO' and emp_Name = N'" + cbx_employee.Text + "' and price = " + Convert.ToDecimal(tblprice.Rows[i][0]) + "", "");


                    totalsa = totalsa - Convert.ToDecimal(tblprice.Rows[i][0]);
                }
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            string d = dtp_date.Value.ToString("dd/MM/yyyy");
            string DReminder = dtp_reminder.Value.ToString("dd/MM/yyyy");


            if (cbx_employee.Items.Count <= 0)
            {

                MessageBox.Show("من فضلك تاكد من اكتمال الموظفين", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            //لادخال الاموال في الخزنه
            decimal stock_money = 0;
            tbl.Clear();
            tbl = db.readData("select * from stock where stock_ID = " + stock_ID + "", "");
            stock_money = Convert.ToDecimal(tbl.Rows[0][1]);

            if (Convert.ToDecimal(txt_safysalary.Text) > stock_money)
            {

                MessageBox.Show("المبلغ الموجود في الخزنه غر كافي لاجراء العمليه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                return;
            }
            db.excetedate("insert into stock_pull (stock_ID ,Mony ,Date ,Name ,Type ,Reason) values (" + stock_ID + "," + txt_safysalary.Text + ",N'" + d + "', N'"+ Properties.Settings.Default.usernane+"' ,N'مرتبات',N'" + txt_notes.Text + "')", "");
            db.excetedate("update stock set Mony=Mony - " + txt_safysalary.Text + "where stock_ID = " + stock_ID + "", "");


            db.excetedate("Insert into employee_salary values("+txt_id.Text+" ,"+cbx_employee.SelectedValue+" , "+txt_totalsalary.Text+" ,"+txt_totalBorrow.Text+" ,"+txt_safysalary.Text+", N'"+d+"', N'"+DReminder+"',N'"+txt_notes.Text+"'  )", "تمت عملية الصرف بنجاح");
          
            try {
                payBorrow();



            } catch (Exception) { }

              AutoNumber();
        }
      
    }
}