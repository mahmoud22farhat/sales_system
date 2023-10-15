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
    public partial class frm_BankPullmoney : DevExpress.XtraEditors.XtraForm
    {
        public frm_BankPullmoney()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();

        private void onloadscreen()
        {

            tbl.Clear();
            tbl = db.readData("select * from bank ", "");
            if (tbl.Rows.Count <= 0)
            {
                db.excetedate("insert into bank values (0)", "");
                tbl = db.readData("select * from bank ", "");
            }
            if (Convert.ToDecimal(tbl.Rows[0][0]) <= 0)
            {
                lbl_Mony.Text = "0";
            }
            else if (Convert.ToDecimal(tbl.Rows[0][0]) >= 1)
            {
                lbl_Mony.Text = Convert.ToDecimal(tbl.Rows[0][0]) + "";
            }


            nud_price.Value = 1;
            txt_name.Clear();
            txt_reason.Clear();
        }
        private void frm_BankPullmoney_Load(object sender, EventArgs e)
        {
            try
            {
                onloadscreen();
            }
            catch (Exception) { }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string d = dtp_date.Value.ToString("dd/MM/yyyy");

            if (txt_name.Text == "") { MessageBox.Show("من فضلك ادخل اسم الساحب", "تأكيد"); return; }
            if (nud_price.Value <= 0) { MessageBox.Show("لابد ان يكون مبلغ السحب اكبر من صفر", "تأكيد"); return; }


            if (nud_price.Value > Convert.ToDecimal(lbl_Mony.Text))
            {
                MessageBox.Show("لا يمكن سحب قيمه اكبر من الموجود في البنك", "تأكيد"); return;
            }

            //tbl.Clear();
            //tbl = db.readData("select * from stock where stock_ID = " + cbx_stock.SelectedValue + "", "");
            //if (nud_price.Value > Convert.ToDecimal(tbl.Rows[0][1]))
            //{
            //    MessageBox.Show("لا يمكن سحب قيمه اكبر من الموجود في البنك", "تأكيد"); return;
            //}

            db.excetedate("update bank set Mony=Mony - " + nud_price.Value + "", "");
            db.excetedate("insert into bank_pull (Mony ,Date ,Name ,Type ,Reason) values (" + nud_price.Value + ",N'" + d + "',N'" + txt_name.Text + "' ,N'سحب يدوي ',N'" + txt_reason.Text + "')", "تم السحب بنجاح");
            onloadscreen();
        }
    }
}