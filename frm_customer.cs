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
    public partial class frm_customer : DevExpress.XtraEditors.XtraForm
    {
        public frm_customer()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();

        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select MAX (cust_ID) from customers" ,"");
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
            txt_note.Clear();
            txt_address.Clear();
            txt_search.Clear();

            
            btn_add.Enabled = true;
            btn_new.Enabled = true;
            btn_delete.Enabled = false;
            btn_deleteall.Enabled = false;
            btn_save.Enabled = false;

        }


        int row;
        private void show()
        {
            tbl.Clear();
            tbl = db.readData("select * from customers", "");
                if(tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لايوجد بيانات في هذه الشاشة");
                    }
                else
            {
                txt_id.Text = tbl.Rows[row][0].ToString();
                txt_name.Text = tbl.Rows[row][1].ToString();
                txt_address.Text = tbl.Rows[row][2].ToString();
                txt_phone.Text = tbl.Rows[row][3].ToString();
                txt_note.Text = tbl.Rows[row][4].ToString();

            
            }
            btn_add.Enabled = false;
            btn_new.Enabled = true;
            btn_delete.Enabled = true;
            btn_deleteall.Enabled = true;
            btn_save.Enabled = true;
        }
       

        private void frm_customer_Load(object sender, EventArgs e)
        {
            AutoNumber();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //اضافة بيانات العميل باللغه الانجليزيه
            //db.excetedate("insert into customers values ("+txt_id.Text+" ,'"+txt_name.Text+"' , '"+txt_address.Text+"' ,'"+txt_phone.Text+"' ,'"+txt_note+"')");
           // MessageBox.Show("تم اضافة البيانات بنجاح", "تأكيد");
           if(txt_name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم العميل");
                return;
            }
            //اضافة بيانات العميل باللغه العربيه
            db.excetedate("insert into customers values("+txt_id.Text+" ,N'"+txt_name.Text+"' ,N'"+txt_address.Text+"' ,N'"+txt_phone.Text+"' ,N'"+txt_note.Text+"')","تم الادخال بنجاح");

            AutoNumber();

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            AutoNumber();

        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            row = 0;
            show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            db.readData("update customers set cust_Name=N'"+txt_name.Text+"' ,cust_address=N'"+txt_address.Text+"' ,cust_phone=N'"+txt_phone.Text+"' ,notes=N'"+txt_note.Text+"'where cust_ID="+txt_id.Text+"", "تم تعديل البيانات بنجاح");
            AutoNumber();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من مسح البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from customers where cust_ID=" + txt_id.Text + "", "تم مسح البيانات بنجاح");
               AutoNumber();
            }
          

        }

        private void btn_deleteall_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من مسح جميع البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from customers ", "تم مسح جميع العملاء بنجاح");
                AutoNumber();
            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select count(cust_ID) from customers", "");

            row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            show();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select count(cust_ID) from customers", "");
            if (Convert.ToInt32(tbl.Rows[0][0]) -1 == row)
            { 
            row =0;
            show();
            }
            else
            {
                row ++;
                show();

            }
        }

        private void btn_priv_Click(object sender, EventArgs e)
        {if(row == 0)
            {
                tbl.Clear();
                tbl = db.readData("select count(cust_ID) from customers", "");
                row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
                show();
            }
            else
            {
             row--;
            show();

            }
           
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable tblsearch = new DataTable();
            tblsearch.Clear();
            tblsearch = db.readData("select * from customers where cust_name like N'%"+txt_search.Text+"%'    ", "");

            try {

            txt_id.Text = tblsearch.Rows[0][0].ToString();
            txt_name.Text = tblsearch.Rows[0][1].ToString();
            txt_address.Text = tblsearch.Rows[0][2].ToString();
            txt_phone.Text = tblsearch.Rows[0][3].ToString();
            txt_note.Text = tblsearch.Rows[0][4].ToString();
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

        private void frm_customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            try {
                frm_sales.GetFormsales.fillcustomer();


            } catch (Exception) { }
        }
    }
    
}