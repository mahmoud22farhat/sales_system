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
    public partial class frm_deserved : DevExpress.XtraEditors.XtraForm
    {
        public frm_deserved()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();
        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select MAX (Des_ID) from deserved", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))

            {
                txt_id.Text = "1";
            }
            else
            {
                txt_id.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();

            }
            nud_price.Value = 1;
            dtp_date.Text = DateTime.Now.ToShortDateString();
            txt_note.Clear();
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
            tbl = db.readData("select * from deserved", "");
            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لايوجد بيانات في هذه الشاشة");
            }
            else
            {
                try { 
                txt_id.Text = tbl.Rows[row][0].ToString();
                nud_price.Value = Convert.ToDecimal(tbl.Rows[row][1]);
                this.Text = tbl.Rows[row][2].ToString();
                DateTime dt = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                dtp_date.Value = dt;

                //dtp_date.Text = tbl.Rows[row][2].ToString();
                txt_note.Text = tbl.Rows[row][3].ToString();
                cbx_type.SelectedValue = Convert.ToDecimal(tbl.Rows[row][4]);
                }
                catch (Exception) { }


            }
            btn_add.Enabled = false;
            btn_new.Enabled = true;
            btn_delete.Enabled = true;
            btn_deleteall.Enabled = true;
            btn_save.Enabled = true;
        }
       
        private void filltype()
        {
            cbx_type.DataSource = db.readData("select * from deserved_type","");
            cbx_type.DisplayMember = "Name";
            cbx_type.ValueMember = "Des_ID";
        }
        string stock_ID = "";
        private void frm_deserved_Load(object sender, EventArgs e)
        {
            AutoNumber();
            filltype();
           stock_ID= Convert.ToString(Properties.Settings.Default.stock_id);
        }

      

        private void btn_first_Click(object sender, EventArgs e)
        {
            row = 0;
            show();
        }
        private void btna_Click(object sender, EventArgs e)
        {
            if (cbx_type.Items.Count <=0)
            {
                MessageBox.Show("من فضلك ادخل الانواع اولا");
                return;
            }
            //اضافة بيانات العميل باللغه العربيه
            string d = dtp_date.Value.ToString("dd/MM/yyyy");
            db.excetedate("insert into deserved values(" + txt_id.Text + " ,N'" + nud_price.Value + "' ,N'" + d + "' ,N'" + txt_note.Text + "' ," + cbx_type.SelectedValue + " )", "تم الادخال بنجاح");

            AutoNumber();
        }

        private void btn_priv_Click(object sender, EventArgs e)
        {
            if (row == 0)
            {
                tbl.Clear();
                tbl = db.readData("select count(Des_ID) from deserved", "");
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
            tbl = db.readData("select count(Des_ID) from deserved", "");
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
            tbl = db.readData("select count(Des_ID) from deserved", "");

            row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string d = dtp_date.Value.ToString("dd/MM/yyyy");
            if (cbx_type.Items.Count <= 0)
            {
                MessageBox.Show("من فضلك ادخل الانواع اولا");
                return;
            }

            decimal stock_money = 0;
            tbl.Clear();
            tbl = db.readData("select * from stock where stock_ID = " + stock_ID + "", "");
            stock_money = Convert.ToDecimal(tbl.Rows[0][1]);

            if (Convert.ToDecimal(nud_price.Value) > stock_money)
            {

                MessageBox.Show("المبلغ الموجود في الخزنه غر كافي لاجراء العمليه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                return;
            }
            db.excetedate("insert into stock_pull (stock_ID ,Mony ,Date ,Name ,Type ,Reason) values (" + stock_ID + "," + nud_price.Value + ",N'" + d + "', N'" + Properties.Settings.Default.usernane + "' ,N'مصروفات',N'" + txt_note.Text + "')", "");
            db.excetedate("update stock set Mony=Mony - " + nud_price.Value + "where stock_ID = " + stock_ID + "", "");



            db.excetedate("insert into deserved values(" + txt_id.Text + " ," + nud_price.Value + " ,N'" + d + "' ,N'" + txt_note.Text + "' ," + cbx_type.SelectedValue + " )", "تم الادخال بنجاح");

            AutoNumber();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            AutoNumber();
            filltype();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(nud_price.Value <= 0 )
            {
                MessageBox.Show("لا يمكن ادخال اقل من واحد", "تاكيد");
                return;
            }
            string d = dtp_date.Value.ToString("dd/MM/yyyy");

            db.readData("update deserved set price=" + nud_price.Value + ",Date='"+d+"',notes=N'"+txt_note.Text+ "',type_ID="+cbx_type.SelectedValue+" where Des_ID=" + txt_id.Text + "", "تم تعديل البيانات بنجاح");
            AutoNumber();
        
    }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من مسح البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string d = dtp_date.Value.ToString("dd/MM/yyyy");

                db.readData("delete from deserved where Des_ID=" + txt_id.Text + "", "تم مسح البيانات بنجاح");
                AutoNumber();
            }
        }

        private void btn_deleteall_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من مسح جميع البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from deserved ", "تم مسح جميع العملاء بنجاح");
                AutoNumber();
            }
        }

        private void txt_note_TextChanged(object sender, EventArgs e)
        {

        }
    }
}