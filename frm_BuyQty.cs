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
    public partial class frm_BuyQty : DevExpress.XtraEditors.XtraForm
    {
        public frm_BuyQty()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();
        private void frm_BuyQty_Load(object sender, EventArgs e)
        {

            txt_Qty.Text =( Properties.Settings.Default.item_Qty).ToString();
            txt_buyprice.Text = (Properties.Settings.Default.item_BuyPrice).ToString();
            txt_discound.Text = (Properties.Settings.Default.item_Discount).ToString();


            try
            {
                //لاظهار الوحدات في الكومبو بوكس
                cbx_unit.DataSource = db.readData("select * from product_unit where Pro_ID = " + Properties.Settings.Default.Pro_ID + "", "");
                cbx_unit.DisplayMember = "unit_Name";
                cbx_unit.ValueMember = "unit_ID";

            }
            catch (Exception) { }
            cbx_unit.Text= (Properties.Settings.Default.Pro_unit).ToString();
            txt_Qty.Focus();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (txt_Qty.Text == "") { MessageBox.Show("من فضلك ادخل الكمية", "تأكيد"); return; }
            if (txt_buyprice.Text == "") { MessageBox.Show("من فضلك ادخل سعر الشراء", "تأكيد"); return; }
            if (txt_discound.Text == "") { MessageBox.Show("من فضلك ادخل الخصم ", "تأكيد"); return; }


            Properties.Settings.Default.item_Qty = Convert.ToDecimal(txt_Qty.Text);
            Properties.Settings.Default.item_BuyPrice = Convert.ToDecimal(txt_buyprice.Text);
            Properties.Settings.Default.Pro_unit = Convert.ToString(cbx_unit.Text);

            if (Properties.Settings.Default.salediscountforcasher == true)
            {
                try
                {
                    if (Properties.Settings.Default.itemdiscount == "value")
                    {
                        Properties.Settings.Default.item_Discount = Convert.ToDecimal(txt_discound.Text);
                        Properties.Settings.Default.Save();
                    }
                    else if (Properties.Settings.Default.itemdiscount == "present")
                    {

                        decimal persentvalue = 0;
                        persentvalue = (Convert.ToDecimal(txt_buyprice.Text) / 100) * Convert.ToDecimal(txt_discound.Text);


                        Properties.Settings.Default.item_Discount = persentvalue;
                        Properties.Settings.Default.Save();
                    }
                }
                catch (Exception) { }
            }
            else
            {
                if (Convert.ToDecimal(txt_discound.Text) >= 1)
                {
                    MessageBox.Show("غير مسموح لك بعمل خصم", "تأكيد");
                    txt_discound.Text = "0";
                    return;
                }


            }

            Properties.Settings.Default.Save();
            Close();
        }

        private void frm_BuyQty_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) {


                if (txt_Qty.Text == "") { MessageBox.Show("من فضلك ادخل الكمية", "تأكيد"); return; }
                if (txt_buyprice.Text == "") { MessageBox.Show("من فضلك ادخل سعر الشراء", "تأكيد"); return; }
                if (txt_discound.Text == "") { MessageBox.Show("من فضلك ادخل الخصم ", "تأكيد"); return; }


                Properties.Settings.Default.item_Qty = Convert.ToDecimal(txt_Qty.Text);
                Properties.Settings.Default.item_BuyPrice = Convert.ToDecimal(txt_buyprice.Text);
                Properties.Settings.Default.Pro_unit = Convert.ToString(cbx_unit.Text);

                if (Properties.Settings.Default.salediscountforcasher == true)
                {
                    try
                    {
                        if (Properties.Settings.Default.itemdiscount == "value")
                        {
                            Properties.Settings.Default.item_Discount = Convert.ToDecimal(txt_discound.Text);
                            Properties.Settings.Default.Save();
                        }
                        else if (Properties.Settings.Default.itemdiscount == "present")
                        {

                            decimal persentvalue = 0;
                            persentvalue = (Convert.ToDecimal(txt_buyprice.Text) / 100) * Convert.ToDecimal(txt_discound.Text);


                            Properties.Settings.Default.item_Discount = persentvalue;
                            Properties.Settings.Default.Save();
                        }
                    }
                    catch (Exception) { }
                }
                else
                {
                    if (Convert.ToDecimal(txt_discound.Text) >= 1)
                    {
                        MessageBox.Show("غير مسموح لك بعمل خصم", "تأكيد");
                        txt_discound.Text = "0";
                        return;
                    }


                }

                Properties.Settings.Default.Save();
                Close();


            }
        }

        private void frm_BuyQty_FormClosing(object sender, FormClosingEventArgs e)
        {
            try {
                int index = frm_buy.GetFormbuy.Dgv_buy.SelectedRows[0].Index;
                frm_buy.GetFormbuy.Dgv_buy.Rows[index].Cells[2].Value = Properties.Settings.Default.Pro_unit;
                frm_buy.GetFormbuy.Dgv_buy.Rows[index].Cells[3].Value = Properties.Settings.Default.item_Qty;
                frm_buy.GetFormbuy.Dgv_buy.Rows[index].Cells[4].Value = Properties.Settings.Default.item_BuyPrice;
                try
                {
                    if (Properties.Settings.Default.itemdiscount == "value")
                    {
                        Properties.Settings.Default.item_Discount = Convert.ToDecimal(txt_discound.Text);
                        Properties.Settings.Default.Save();
                    }
                    else if (Properties.Settings.Default.itemdiscount == "present")
                    {

                        decimal persentvalue = 0;
                        persentvalue = (Convert.ToDecimal(txt_buyprice.Text) / 100) * Convert.ToDecimal(txt_discound.Text);


                        Properties.Settings.Default.item_Discount = persentvalue;
                        Properties.Settings.Default.Save();
                    }
                }
                catch (Exception) { }
            }
            catch (Exception) { }
        }

        private void cbx_unit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable tblitems = new DataTable();
            tblitems.Clear();
            DataTable tblprice = new DataTable();
            tblprice.Clear();
            DataTable tblunit = new DataTable();
            tblunit.Clear();
            try
            {

                int countQty = 0;
                try
                {
                    countQty = Convert.ToInt32(db.readData("select count(Pro_ID) from products_Qty where Pro_ID =  " + Properties.Settings.Default.Pro_ID + "", "").Rows[0][0]);
                }
                catch (Exception) { }


                tblprice = db.readData("select * from products_Qty where Pro_ID = " + Properties.Settings.Default.Pro_ID + "", "");
                string Product_Price = tblprice.Rows[countQty - 1][4].ToString();


                tblunit = db.readData("select * from product_unit where Pro_ID = " + Properties.Settings.Default.Pro_ID + "and unit_ID = " + cbx_unit.SelectedValue+ "", "");

                decimal realprice = 0;
                try
                {
                    realprice = Convert.ToDecimal(Product_Price) / Convert.ToDecimal(tblunit.Rows[0][3]);


                }
                catch (Exception) { }
                txt_buyprice.Text = Math.Round(realprice, 2) + "";
            }
            catch (Exception) { }
        }

        private void txt_discound_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
