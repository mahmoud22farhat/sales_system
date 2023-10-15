using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace sales
{
    public partial class frm_store : DevExpress.XtraEditors.XtraForm
    {
        public frm_store()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable(); DataTable tblstore = new DataTable();
        private void AutoNumber()
        {
            tblstore.Clear();
            tblstore = db.readData("select store_ID as 'رقم المخزن', store_Name as 'اسم المخزن' from store", "");
            Dgv_search.DataSource = tblstore;
            tbl.Clear();
            tbl = db.readData("select MAX (store_ID) from store", "");
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
            tbl = db.readData("select * from store", "");
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
        private void frm_store_Load(object sender, EventArgs e)
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
                tbl = db.readData("select count(store_ID) from store", "");
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
            tbl = db.readData("select count(store_ID) from store", "");
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
            tbl = db.readData("select count(store_ID) from store", "");

            row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم الوحدة");
                return;
            }
            //اضافة بيانات العميل باللغه العربيه
            db.excetedate("insert into store (store_ID,store_Name)values(" + txt_id.Text + " ,N'" + txt_name.Text + "' )", "تم الادخال بنجاح");

            AutoNumber();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            db.readData("update store set store_Name=N'" + txt_name.Text + "' where store_ID=" + txt_id.Text + "", "تم تعديل البيانات بنجاح");
            AutoNumber();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من مسح البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from store where store_ID=" + txt_id.Text + "", "تم مسح البيانات بنجاح");
                AutoNumber();
            }
        }

        private void btn_deleteall_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من مسح جميع البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from store ", "تم مسح جميع المخازن بنجاح");
                AutoNumber();
            }
        }

        private void Dgv_search_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (Dgv_search.Rows.Count >= 1)
                {
                    DataTable tblshow = new DataTable();
                    tblshow.Clear();
                    tblshow = db.readData("select * from store where store_ID =" + Dgv_search.CurrentRow.Cells[0].Value + "", "");

                    txt_id.Text = tblshow.Rows[0][0].ToString();
                    txt_name.Text = tblshow.Rows[0][1].ToString();



                    btn_add.Enabled = false;
                    btn_new.Enabled = true;
                    btn_delete.Enabled = true;
                    btn_deleteall.Enabled = true;
                    btn_save.Enabled = true;
                }

            }
            catch (Exception) { }
        }
    }
    }
