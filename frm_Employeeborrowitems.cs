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
    public partial class frm_Employeeborrowitems : DevExpress.XtraEditors.XtraForm
    {
        public frm_Employeeborrowitems()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();
        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select MAX (Order_ID) from employee_Borrowiitems", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))

            {
                txt_id.Text = "1";
            }
            else
            {
                txt_id.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();

            }
            nud_Qty.Value = 1;
            dtp_date.Text = DateTime.Now.ToShortDateString();

            try {

                cbx_employee.SelectedIndex = 0;
                cbx_items.SelectedIndex = 0;

            } catch (Exception) { }
        }
        private void fillitems()
        {
            cbx_items.DataSource = db.readData("select * from products", "");
            cbx_items.DisplayMember = "Pro_name";
            cbx_items.ValueMember = "Pro_ID";
        }
        private void fillemployee()
        {
            cbx_employee.DataSource = db.readData("select * from Employee_", "");
            cbx_employee.DisplayMember = "emp_Name";
            cbx_employee.ValueMember = "emp_ID";
        }
        private void frm_Employeeborrowitems_Load(object sender, EventArgs e)
        {
            try
            {
                AutoNumber();
                fillemployee();
                fillitems();

            } catch (Exception) { }
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            if (cbx_items.Items.Count <= 0 || cbx_employee.Items.Count <= 0)
            {

                MessageBox.Show("من فضلك تاكد من اكتمال البيانات", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            if (nud_Qty.Value <= 0)
            {
                MessageBox.Show("لابد ان تكون الكميه المسحوبه لا تقل عن واحد", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return;

            }
            decimal price_ = 0,totalprice = 0;
            try {
            price_ = Convert.ToDecimal(db.readData("select sale_price from products where Pro_ID = " + cbx_items.SelectedValue + "", "").Rows[0][0]);

            } catch (Exception) { }

            totalprice = price_ * nud_Qty.Value;


            string d = dtp_date.Value.ToString("dd/MM/yyyy");
            db.excetedate("insert into employee_salarymainus (emp_ID,emp_Name,date,price,pay) values(" + cbx_employee.SelectedValue+ " ,N'" + cbx_employee.Text + "' ,N'"+d+"' ,"+totalprice+" , 'no')", "");
            db.excetedate("update products set Qty=Qty - "+nud_Qty.Value+"where Pro_ID="+cbx_items.SelectedValue+"", "");
          db.excetedate("insert into employee_Borrowiitems values("+txt_id.Text+" ,"+cbx_items.SelectedValue+" ,"+cbx_employee.SelectedValue+" ,'"+d+"' ,"+nud_Qty.Value+" )", "تمت الاضافه بنجاح");
            AutoNumber();
        }

        private void txt_barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txt_barcode.Text =="") { return; }
            DataTable tblsearch = new DataTable();
            if(e.KeyChar == 13)
            {
                tblsearch.Clear();
                tblsearch = db.readData("select * from products where Barcode=N'" + txt_barcode.Text+"'","");
                if(tblsearch.Rows.Count >=1)
                {
                    cbx_items.SelectedValue = Convert.ToDecimal(tblsearch.Rows[0][0]);
                }
            }
        }
    }
}