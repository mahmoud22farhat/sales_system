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
    public partial class frm_deservedtype : DevExpress.XtraEditors.XtraForm
    {
        public frm_deservedtype()
        {
            InitializeComponent();
        }

        database db = new database();
        DataTable tbl = new DataTable();
        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select MAX (Des_ID) from deserved_type", "");
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
            tbl = db.readData("select * from deserved_type", "");
            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لايوجد بيانات في هذه الشاشة");
            }
            else
            {
                txt_id.Text = tbl.Rows[row][0].ToString();
                txt_name.Text = tbl.Rows[row][1].ToString();
              

            }
            btn_add.Enabled = false;
            btn_new.Enabled = true;
            btn_delete.Enabled = true;
            btn_deleteall.Enabled = true;
            btn_save.Enabled = true;
        }

        private void frm_deservedtype_Load(object sender, EventArgs e)
        {
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
                tbl = db.readData("select count(Des_ID) from deserved_type", "");
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
            tbl = db.readData("select count(Des_ID) from deserved_type", "");
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
            tbl = db.readData("select count(Des_ID) from deserved_type", "");

            row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            show();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم النوع");
                return;
            }
            //اضافة بيانات العميل باللغه العربيه
            db.excetedate("insert into deserved_type values(" + txt_id.Text + " ,N'" + txt_name.Text + "' )", "تم الادخال بنجاح");

            AutoNumber();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            db.readData("update deserved_type set Name=N'" + txt_name.Text + "' where Des_ID=" + txt_id.Text + "", "تم تعديل البيانات بنجاح");
            AutoNumber();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من مسح البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from deserved_type where Des_ID=" + txt_id.Text + "", "تم مسح البيانات بنجاح");
                AutoNumber();
            }
        }

        private void btn_deleteall_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من مسح جميع البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from deserved_type ", "تم مسح جميع العملاء بنجاح");
                AutoNumber();
            }
        }
    }
}