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
    public partial class frm_StockPullmoney : DevExpress.XtraEditors.XtraForm
    {
        public frm_StockPullmoney()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();

        private void onloadscreen()
        {
            fillstock();
            tbl.Clear();
            tbl = db.readData("select * from stock where stock_ID = " + cbx_stock.SelectedValue + "", "");
            if (tbl.Rows.Count <= 0)
            {
                db.excetedate("insert into stock values (" + cbx_stock.SelectedValue + " , 0)", "");
                tbl = db.readData("select * from stock where stock_ID =" + cbx_stock.SelectedValue + "", "");

            }
            if (Convert.ToDecimal(tbl.Rows[0][1]) <= 0)
            {
                lbl_Mony.Text = "0";
            }
            else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
            {
                lbl_Mony.Text = Convert.ToDecimal(tbl.Rows[0][1]) + "";
            }
            nud_price.Value = 1;
            txt_name.Clear();
            txt_reason.Clear();

        }
        private void fillstock()
        {
            cbx_stock.DataSource = db.readData("select * from stock_Data", "");
            cbx_stock.DisplayMember = "stock_name";
            cbx_stock.ValueMember = "stock_ID";
        }
        private void frm_StockPullmoney_Load(object sender, EventArgs e)
        {
            try
            {
                onloadscreen();
            }
            catch (Exception) { }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (cbx_stock.Items.Count >= 1)
            {
                string d = dtp_date.Value.ToString("dd/MM/yyyy");

                if (txt_name.Text == "") { MessageBox.Show("من فضلك ادخل اسم الساحب", "تأكيد"); return; }
                if (nud_price.Value <= 0) { MessageBox.Show("لابد ان يكون مبلغ السحب اكبر من صفر", "تأكيد"); return; }

                //if (nud_price.Value > Convert.ToDecimal(lbl_Mony.Text))
                //{
                //    MessageBox.Show("لا يمكن سحب قيمه اكبر من الموجود في الخزنه", "تأكيد"); return;
                //}

                tbl.Clear();
                tbl = db.readData("select * from stock where stock_ID = " + cbx_stock.SelectedValue + "", "");
                if (nud_price.Value > Convert.ToDecimal(tbl.Rows[0][1]))
                {
                    MessageBox.Show("لا يمكن سحب قيمه اكبر من الموجود في الخزنه", "تأكيد"); return;
                }

                db.excetedate("update stock set Mony=Mony - " + nud_price.Value + " where stock_ID = " + cbx_stock.SelectedValue + "", "");

                db.excetedate("insert into stock_pull (stock_ID ,Mony ,Date ,Name ,Type ,Reason) values (" + cbx_stock.SelectedValue + "," + nud_price.Value + ",N'" + d + "',N'" + txt_name.Text + "' ,N'سحب يدوي ',N'" + txt_reason.Text + "')", "تم السحب بنجاح");
                onloadscreen();
            }
        }

        private void cbx_stock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
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
                    lbl_Mony.Text = "0";
                }
                else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
                {
                    lbl_Mony.Text = Convert.ToDecimal(tbl.Rows[0][1]) + "";
                }
            }
            catch (Exception) { }
        }
    }
}