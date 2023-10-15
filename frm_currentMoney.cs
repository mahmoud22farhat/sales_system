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
    public partial class frm_currentMoney : DevExpress.XtraEditors.XtraForm
    {
        public frm_currentMoney()
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

           
        }
        private void frm_currentMoney_Load(object sender, EventArgs e)
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
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            frm_StockAddMony frm = new frm_StockAddMony();
            frm.ShowDialog();
        }

        private void btn_bank_Click(object sender, EventArgs e)
        {
            frm_BankAddMoney frm = new frm_BankAddMoney();

            frm.ShowDialog();
        }
    }
}