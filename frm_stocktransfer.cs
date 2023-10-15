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
    public partial class frm_stocktransfer : DevExpress.XtraEditors.XtraForm
    {
        public frm_stocktransfer()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();
        private void fillstock()
        {
            cbx_stockfrom.DataSource = db.readData("select * from stock_Data", "");
            cbx_stockfrom.DisplayMember = "stock_name";
            cbx_stockfrom.ValueMember = "stock_ID";

            cbx_stockto.DataSource = db.readData("select * from stock_Data", "");
            cbx_stockto.DisplayMember = "stock_name";
            cbx_stockto.ValueMember = "stock_ID";
        }
        private void onloadscreen()
        {
           
            tbl.Clear();
            tbl = db.readData("select * from stock where stock_ID = " + cbx_stockfrom.SelectedValue + "", "");
            if (tbl.Rows.Count <= 0)
            {
                db.excetedate("insert into stock values (" + cbx_stockfrom.SelectedValue + " , 0)", "");
                tbl = db.readData("select * from stock where stock_ID =" + cbx_stockfrom.SelectedValue + "", "");

            }
            if (Convert.ToDecimal(tbl.Rows[0][1]) <= 0)
            {
                lbl_Money1.Text = "0";
                lbl_Money2.Text = "0";
            }
            else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
            {
                lbl_Money1.Text = Convert.ToDecimal(tbl.Rows[0][1]) + "";
                lbl_Money2.Text = Convert.ToDecimal(tbl.Rows[0][1]) + "";
            }
            nud_price.Value = 1;
            txt_name.Clear();
            txt_reason.Clear();

        }
        private void frm_stocktransfer_Load(object sender, EventArgs e)
        {
            fillstock();
            try {
                onloadscreen();
            }
            catch (Exception) { }
        }
        private void fromstock1()
        {
            tbl.Clear();
            tbl = db.readData("select * from stock where stock_ID = " + cbx_stockfrom.SelectedValue + "", "");
            if (tbl.Rows.Count <= 0)
            {
                db.excetedate("insert into stock values (" + cbx_stockfrom.SelectedValue + " , 0)", "");
                tbl = db.readData("select * from stock where stock_ID =" + cbx_stockfrom.SelectedValue + "", "");

            }
            if (Convert.ToDecimal(tbl.Rows[0][1]) <= 0)
            {
                lbl_Money1.Text = "0";
            
            }
            else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
            {
                lbl_Money1.Text = Convert.ToDecimal(tbl.Rows[0][1]) + "";
              
            }
            nud_price.Value = 1;
            txt_name.Clear();
            txt_reason.Clear();
        }
        private void cbx_stockfrom_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                fromstock1();
            }
            catch (Exception) { }
        }
        private void tostock2()
        {
            tbl.Clear();
            tbl = db.readData("select * from stock where stock_ID = " + cbx_stockto.SelectedValue + "", "");
            if (tbl.Rows.Count <= 0)
            {
                db.excetedate("insert into stock values (" + cbx_stockto.SelectedValue + " , 0)", "");
                tbl = db.readData("select * from stock where stock_ID =" + cbx_stockto.SelectedValue + "", "");

            }
            if (Convert.ToDecimal(tbl.Rows[0][1]) <= 0)
            {
                lbl_Money2.Text = "0";

            }
            else if (Convert.ToDecimal(tbl.Rows[0][1]) >= 1)
            {
                lbl_Money2.Text = Convert.ToDecimal(tbl.Rows[0][1]) + "";

            }
            nud_price.Value = 1;
            txt_name.Clear();
            txt_reason.Clear();

        }
        private void cbx_stockto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                tostock2();
            }
            catch (Exception) { }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbx_stockto.Items.Count <= 0) { MessageBox.Show("من فضلك املئ بيانات الخزنات اولا", "تأكيد"); return; }
                if (Convert.ToInt32( cbx_stockfrom.SelectedValue) == Convert.ToInt32(cbx_stockto.SelectedValue)) { MessageBox.Show("لا يمكن تحويل رصيد الي نفس الخزنه", "تأكيد"); return; }

                if (nud_price.Value>Convert.ToDecimal(lbl_Money1.Text))
                {
                    { MessageBox.Show("الرصيد الموجود في الخزنه لا يكفي للتحويل", "تأكيد"); return; }
                }
                if(txt_name.Text== "")
                {
                    { MessageBox.Show("من فضلك ادخل اسم الشخص المسؤل عن التحويل", "تأكيد"); return; }
                }
                if (txt_reason.Text == "")
                {
                    { MessageBox.Show("من فضلك ادخل سبب التحويل", "تأكيد"); return; }
                }
                string d = dtp_date.Value.ToString("dd/MM/yyyy");

                db.excetedate("update stock set Mony=Mony - " + nud_price.Value + " where stock_ID = " + cbx_stockfrom.SelectedValue + " ", "");
                db.excetedate("update stock set Mony=Mony + " + nud_price.Value + " where stock_ID = " + cbx_stockto.SelectedValue + " ", "");

                db.excetedate("insert into stock_pull (stock_ID ,Mony ,Date ,Name ,Type ,Reason) values (" + cbx_stockfrom.SelectedValue + "," + nud_price.Value + ",N'" + d + "',N'" + txt_name.Text + "' ,N'تحويل الي خزنه اخري ',N'" + txt_reason.Text + "')", "");
                db.excetedate("insert into stock_insert (stock_ID ,Mony ,Date ,Name ,Type ,Reason) values (" + cbx_stockfrom.SelectedValue + "," + nud_price.Value + ",N'" + d + "',N'" + txt_name.Text + "' ,N'تحويل من خزنه اخري ',N'" + txt_reason.Text + "')", "");
                db.excetedate("insert into stock_transfer (Mony ,Date ,from_ ,to_ ,Name ,Reason) values (" +nud_price.Value+ ",N'" + d + "',"+cbx_stockfrom.SelectedValue+","+cbx_stockto.SelectedValue+",N'" + txt_name.Text + "' ,N'" + txt_reason.Text + "')", "تم عملية التحويل بنجاح");
                onloadscreen();
            }
            catch (Exception) { }
        }

        private void lbl_Money2_Click(object sender, EventArgs e)
        {

        }
    }
}