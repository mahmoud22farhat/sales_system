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
    public partial class frm_stockbanktransfer : DevExpress.XtraEditors.XtraForm
    {
        public frm_stockbanktransfer()
        {
            InitializeComponent();
        }

        database db = new database();
        DataTable tbl = new DataTable();
        private void fillstock()
        {
            cbx_stock.DataSource = db.readData("select * from stock_Data", "");
            cbx_stock.DisplayMember = "stock_name";
            cbx_stock.ValueMember = "stock_ID";
        }
        private void onloadscreen()
        {

            tbl.Clear();
            DataTable tblBank = new DataTable();
            tblBank.Clear();
            tbl = db.readData("select * from stock where stock_ID = " + cbx_stock.SelectedValue + "", "");
            if (tbl.Rows.Count <= 0)
            {
                db.excetedate("insert into stock values (" + cbx_stock.SelectedValue + " , 0)", "");
                tbl = db.readData("select * from stock where stock_ID =" + cbx_stock.SelectedValue + "", "");
            }
            if (Convert.ToDecimal(tbl.Rows[0][1]) <= 0)
            {
                lbl_MoneyStock.Text = "0";
            }
            else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
            {
                lbl_MoneyStock.Text = Convert.ToDecimal(tbl.Rows[0][1]) + "";
            }
            tblBank = db.readData("select * from bank", "");


            if (Convert.ToDecimal(tblBank.Rows[0][0]) <= 0)
            {
                lbl_MoneyBank.Text = "0";
            }
            else if (Convert.ToDecimal(tblBank.Rows[0][0]) >= 1)
            {
                lbl_MoneyBank.Text = Convert.ToDecimal(tblBank.Rows[0][0]) + "";
            }

            nud_price.Value = 1;
            txt_name.Clear();
        }
        private void frm_stockbanktransfer_Load(object sender, EventArgs e)
        {
            fillstock();
            onloadscreen();
        }
        private void cbx_stock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select * from stock where stock_ID = " + cbx_stock.SelectedValue + "", "");
            if (tbl.Rows.Count <= 0)
            {
                db.excetedate("insert into stock values (" + cbx_stock.SelectedValue + " , 0)", "");
                tbl = db.readData("select * from stock where stock_ID =" + cbx_stock.SelectedValue + "", "");
            }
            if (Convert.ToDecimal(tbl.Rows[0][1]) <= 0)
            {
                lbl_MoneyStock.Text = "0";
            }
            else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
            {
                lbl_MoneyStock.Text = Convert.ToDecimal(tbl.Rows[0][1]) + "";
            }
            nud_price.Value = 1;
            txt_name.Clear();
        }
        private void fromStockToBank()
        {
            if (nud_price.Value > Convert.ToDecimal(lbl_MoneyStock.Text))
            {
                MessageBox.Show("لا يمكن تحويل مبلغ اكبر من الموجود في الخزنه", "تأكيد");
                return;
            }

            string d = dtp_date.Value.ToString("dd/MM/yyyy");

            db.excetedate("update stock set Mony=Mony - " + nud_price.Value + " where stock_ID = " + cbx_stock.SelectedValue + " ", "");

            db.excetedate("insert into stock_pull (stock_ID ,Mony ,Date ,Name ,Type ,Reason) values (" + cbx_stock.SelectedValue + "," + nud_price.Value + ",N'" + d + "',N'" + txt_name.Text + "' ,N'تحويل الي بنك ',N'')", "");

            db.excetedate("update bank set Mony=Mony + "+nud_price.Value+" ", "");

            db.excetedate("insert into bank_insert (Mony ,Date ,Name ,Type ,Reason) values (" + nud_price.Value + ",N'" + d + "',N'" + txt_name.Text + "' ,N'تحويل من خزنة ',N'')", "");

            db.excetedate("insert into stock_bsnktransfer (Mony ,Date ,from_ ,to_ ,Name) values (" + nud_price.Value + ",N'" + d + "',N'" + cbx_stock.Text + "',N'البنك',N'" + txt_name.Text + "' )", "تم عملية التحويل بنجاح");
            onloadscreen();
        }
        private void ToStockFromBank()
        {

            if (nud_price.Value > Convert.ToDecimal(lbl_MoneyBank.Text))
            {
                MessageBox.Show("لا يمكن تحويل مبلغ اكبر من الموجود في البنك", "تأكيد");
                return;
            }

            string d = dtp_date.Value.ToString("dd/MM/yyyy");

            db.excetedate("update stock set Mony=Mony + " + nud_price.Value + " where stock_ID = " + cbx_stock.SelectedValue + " ", "");

            db.excetedate("insert into stock_insert (stock_ID ,Mony ,Date ,Name ,Type ,Reason) values (" + cbx_stock.SelectedValue + "," + nud_price.Value + ",N'" + d + "',N'" + txt_name.Text + "' ,N'تحويل من بنك ',N'')", "");

            db.excetedate("update bank set Mony=Mony - " + nud_price.Value + " ", "");

            db.excetedate("insert into bank_pull (Mony ,Date ,Name ,Type ,Reason) values (" + nud_price.Value + ",N'" + d + "',N'" + txt_name.Text + "' ,N'تحويل الي خزنة ',N'')", "");

            db.excetedate("insert into stock_bsnktransfer (Mony ,Date ,from_ ,to_ ,Name) values (" + nud_price.Value + ",N'" + d + "',N'البنك',N'" + cbx_stock.Text + "',N'" + txt_name.Text + "' )", "تم عملية التحويل بنجاح");
            onloadscreen();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string d = dtp_date.Value.ToString("dd/MM/yyyy");
                if (cbx_stock.Items.Count <= 0) { MessageBox.Show("من فضلك املئ بيانات الخزنات اولا", "تأكيد"); return; }


                if (txt_name.Text == "")
                {
                    { MessageBox.Show("من فضلك ادخل اسم الشخص المسؤل عن التحويل", "تأكيد"); return; }
                }
                if(rbtn_fromStockToBank.Checked == true)
                {
                    fromStockToBank();
                }
                else if (rbtn_ToStockFromBank.Checked == true)
                {
                    ToStockFromBank();
                }
            }
            catch (Exception) { }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}