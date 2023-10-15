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
    public partial class frm_sales : DevExpress.XtraEditors.XtraForm
    {
        private static frm_sales frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static frm_sales GetFormsales
        {
            get
            {
                if (frm == null)
                {
                    frm = new frm_sales();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        database db = new database();
        DataTable tbl = new DataTable();
        public frm_sales()
        {
            InitializeComponent();

            if (frm == null)
                frm = this;
        }
        private void fillitems()
        {
            cbx_items.DataSource = db.readData("select * from products", "");
            cbx_items.DisplayMember = "Pro_name";
            cbx_items.ValueMember = "Pro_ID";
        }
        public void fillcustomer()
        {
            cbx_customer.DataSource = db.readData("select * from customers", "");
            cbx_customer.DisplayMember = "cust_Name";
            cbx_customer.ValueMember = "cust_ID";
        }
        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select MAX (Order_ID) from sales", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {
                txt_id.Text = "1";
            }
            else
            {
                txt_id.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();

            }
            dtp_date.Text = DateTime.Now.ToShortDateString();
            Dtp_reminder.Text = DateTime.Now.ToShortDateString();
            try
            {
                //الوقوف علي المنتج الاول
                cbx_items.SelectedIndex = 0;
                cbx_customer.SelectedIndex = 0;
            }
            catch (Exception) { }
            cbx_items.Text = "اختر منتج";
            Dgv_sale.Rows.Clear();
            rbtnCust_cash.Checked = true;
            txt_parcode.Clear();
            txt_parcode.Focus();
            txt_total.Clear();
        }
        string stock_ID = "";
        private void frm_sales_Load(object sender, EventArgs e)
        {
            fillitems();
            fillcustomer();
            dtp_date.Text = DateTime.Now.ToShortDateString();
            Dtp_reminder.Text = DateTime.Now.ToShortDateString();
            dtp_time.Text = DateTime.Now.ToShortTimeString();
            rbtnCust_cash_CheckedChanged(null, null);
            try
            { AutoNumber();
            }
            catch (Exception) { }
            stock_ID = Convert.ToString(Properties.Settings.Default.stock_id);
            lbl_username.Text = Properties.Settings.Default.usernane;
            Properties.Settings.Default.Save();
        }

        private void rbtnCust_cash_CheckedChanged(object sender, EventArgs e)
        {
            try {

                cbx_customer.Enabled = false;
                btn_customerbrouse.Enabled = false;
                Dtp_reminder.Enabled = false;



            } catch (Exception) { }
        }

        private void rbtncust_agel_CheckedChanged(object sender, EventArgs e)
        {
            try
            {

                cbx_customer.Enabled = true;
                btn_customerbrouse.Enabled = true;
                Dtp_reminder.Enabled = true;



            }
            catch (Exception) { }
        }

        private void btn_customerbrouse_Click(object sender, EventArgs e)
        {
            frm_customer frm = new frm_customer();
            frm.ShowDialog();
        }

        private void btn_items_Click(object sender, EventArgs e)
        {
            if (cbx_items.Text == "اختر منتج")
            {
                MessageBox.Show("من فضلك اخنر منتج", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbx_items.Items.Count <= 0)
            {
                MessageBox.Show("من فضلك ادخل المنتجات اولا ", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            DataTable tblitems = new DataTable();
            tblitems.Clear();
            DataTable tblunit= new DataTable();
            tblunit.Clear();
            tblitems = db.readData("select * from products where Pro_ID=" + cbx_items.SelectedValue + "", "");
            if (cbx_items.Items.Count >= 0)
            {
                try
                {
                    string Product_ID = tblitems.Rows[0][0].ToString();
                    string Product_Name = tblitems.Rows[0][1].ToString();
                    string Product_Qty = "1";
                    string Product_Price = "0";
                    decimal discound = 0;
                    string Product_unit = tblitems.Rows[0][14].ToString();
                   




                    Dgv_sale.Rows.Add(1);
                    int rowindex = Dgv_sale.Rows.Count - 1;
                    Dgv_sale.Rows[rowindex].Cells[0].Value = Product_ID;
                    Dgv_sale.Rows[rowindex].Cells[1].Value = Product_Name;
                    Dgv_sale.Rows[rowindex].Cells[3].Value = Product_Qty;
                    Dgv_sale.Rows[rowindex].Cells[2].Value = Product_unit;
                    tblunit = db.readData("select * from product_unit where Pro_ID = " + Dgv_sale.CurrentRow.Cells[0].Value + "and unit_Name = N'" + Dgv_sale.CurrentRow.Cells[2].Value + "'", "");

                                        decimal realprice = 0;
                                        try
                                        {
                                            realprice = Convert.ToDecimal(tblunit.Rows[0][5]) / Convert.ToDecimal(tblunit.Rows[0][3]);


                                        }
                                        catch (Exception) { }


                    Dgv_sale.Rows[rowindex].Cells[4].Value = realprice;
                    decimal total = Convert.ToDecimal(Product_Qty) * Convert.ToDecimal(realprice);


                    Dgv_sale.Rows[rowindex].Cells[5].Value = discound;
                    Dgv_sale.Rows[rowindex].Cells[6].Value = total;
                }
                catch (Exception) { }
                try
                {
                    decimal totalorder = 0;
                    for (int i = 0; i <= Dgv_sale.Rows.Count - 1; i++)
                    {
                        totalorder += Convert.ToDecimal(Dgv_sale.Rows[i].Cells[6].Value);
                        //لكي يكون التحديد علي اخر سطر
                        Dgv_sale.ClearSelection();
                        Dgv_sale.FirstDisplayedScrollingRowIndex = Dgv_sale.Rows.Count - 1;
                        Dgv_sale.Rows[Dgv_sale.Rows.Count - 1].Selected = true;

                    }
                    txt_total.Text = Math.Round(totalorder, 2).ToString();
                    lbl_itemscount.Text = (Dgv_sale.Rows.Count).ToString();
                }
                catch (Exception) { } } }
        private void UdateQty()
        {
            if (Dgv_sale.Rows.Count >= 1)
            {
                int index = Dgv_sale.SelectedRows[0].Index;


                Properties.Settings.Default.Pro_ID = Convert.ToInt32(Dgv_sale.Rows[index].Cells[0].Value);
                Properties.Settings.Default.item_Qty = Convert.ToDecimal(Dgv_sale.Rows[index].Cells[3].Value);
                Properties.Settings.Default.item_salePrice = Convert.ToDecimal(Dgv_sale.Rows[index].Cells[4].Value);
                Properties.Settings.Default.item_Discount = Convert.ToDecimal(Dgv_sale.Rows[index].Cells[5].Value);
                Properties.Settings.Default.Pro_unit = Convert.ToString(Dgv_sale.Rows[index].Cells[2].Value);
                Properties.Settings.Default.Save();


                frm_saleQty frm = new frm_saleQty();
                frm.ShowDialog();
            }
        }
        private void frm_sales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btn_items_Click(null, null);

            } else if (e.KeyCode == Keys.F1)
            {
                txt_parcode.Clear();
                txt_parcode.Focus();
            }

            else if (e.KeyCode == Keys.F11)
            {
                UdateQty();


                try
                {
                    int index = Dgv_sale.SelectedRows[0].Index;
                    Dgv_sale.Rows[index].Cells[2].Value = Properties.Settings.Default.Pro_unit;
                    Dgv_sale.Rows[index].Cells[3].Value = Properties.Settings.Default.item_Qty;
                    Dgv_sale.Rows[index].Cells[4].Value = Properties.Settings.Default.item_salePrice;
                    Dgv_sale.Rows[index].Cells[5].Value = Properties.Settings.Default.item_Discount;
                }
                catch (Exception) { }
            }
            else if (e.KeyCode == Keys.F12)
            {
                payorder();
            }

        }

        //call to update rty in store
        private void updateqtyinstore(int pro_ID, decimal realQty,int x,decimal price_beforetax,decimal tax_value)
        {
            DataTable tblQty = new DataTable();
            decimal Qtyinstorefirstrow = 0;

            db.excetedate("delete from products_Qty where Qty <= 0", "");

            int countQty = 0;
            try {
                countQty =Convert.ToInt32( db.readData("select count(Pro_ID) from products_Qty where Pro_ID=" + pro_ID + " ", "").Rows[0][0]);


            } catch (Exception) { }

            decimal currentQty = realQty;
            for (int i = 0;i<=countQty-1;i++) {
                try
                {
                    tblQty.Clear();
                    tblQty = db.readData("select top 1 * from products_Qty where Pro_ID=" + pro_ID + "", "");

                    Qtyinstorefirstrow = Convert.ToDecimal(tblQty.Rows[0][3]);
                    if (Qtyinstorefirstrow - realQty >= 1)
                    {
                        db.excetedate("update products_Qty set Qty=Qty - " + realQty + "where Pro_ID =" + pro_ID + " and store_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + "and Qty = " + Qtyinstorefirstrow + "and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");
                        insertsalesRep7(x, price_beforetax, tax_value, realQty, Convert.ToDecimal(tblQty.Rows[0][4]));
                        currentQty -= realQty;
                        return;
                    }
                    else if (Qtyinstorefirstrow - realQty == 0)
                    {
                        //db.excetedate("delete products_Qty where Pro_ID =" + pro_ID + " and store_ID=" + cbx_storefrom.SelectedValue + "and Qty = 0 and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");
                        db.excetedate("update products_Qty set Qty=Qty - " + realQty + "where Pro_ID =" + pro_ID + " and store_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + "and Qty = " + Qtyinstorefirstrow + "and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");
                        db.excetedate("delete products_Qty where Qty <=0", "");
                        insertsalesRep7(x, price_beforetax, tax_value, realQty, Convert.ToDecimal(tblQty.Rows[0][4]));
                        currentQty -= realQty;
                        return;
                    }
                    else if (Qtyinstorefirstrow - realQty < 0)
                    {
                        db.excetedate("update products_Qty set Qty=Qty - " + Qtyinstorefirstrow + "where Pro_ID =" + pro_ID + " and store_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + "and Qty = " + Qtyinstorefirstrow + "and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");
                        db.excetedate("delete products_Qty where Qty <=0", "");
                        insertsalesRep7(x, price_beforetax, tax_value, Qtyinstorefirstrow, Convert.ToDecimal(tblQty.Rows[0][4]));
                        currentQty -= Qtyinstorefirstrow;
                        decimal baky = Math.Abs(Qtyinstorefirstrow - realQty);


                        tblQty.Clear();
                        tblQty = db.readData("select top 1 * from products_Qty where Pro_ID=" + pro_ID + "", "");

                        Qtyinstorefirstrow = Convert.ToDecimal(tblQty.Rows[0][3]);

                        if (Qtyinstorefirstrow - baky >= 0)
                        {

                            db.excetedate("update products_Qty set Qty=Qty - " + baky + "where Pro_ID =" + pro_ID + " and store_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + "and Qty = " + Qtyinstorefirstrow + "and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");
                            db.excetedate("delete products_Qty where Qty <=0", "");
                            insertsalesRep7(x, price_beforetax, tax_value, baky, Convert.ToDecimal(tblQty.Rows[0][4]));
                            return;
                        }
                        else if (Qtyinstorefirstrow - baky < 0)
                        {

                            decimal secondbaky = Math.Abs(Qtyinstorefirstrow - baky);
                            db.excetedate("update products_Qty set Qty=Qty - " + Qtyinstorefirstrow + "where Pro_ID =" + pro_ID + " and store_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + "and Qty = " + Qtyinstorefirstrow + "and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");
                            db.excetedate("delete products_Qty where Qty <=0", "");
                            insertsalesRep7(x, price_beforetax, tax_value, Qtyinstorefirstrow, Convert.ToDecimal(tblQty.Rows[0][4]));
                            currentQty -= Qtyinstorefirstrow;
                            tblQty.Clear();
                            tblQty = db.readData("select top 1 * from products_Qty where Pro_ID=" + pro_ID + "", "");

                            Qtyinstorefirstrow = Convert.ToDecimal(tblQty.Rows[0][3]);

                            if (Qtyinstorefirstrow - secondbaky >= 0)
                            {

                                db.excetedate("update products_Qty set Qty=Qty - " + secondbaky + "where Pro_ID =" + pro_ID + " and store_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + "and Qty = " + Qtyinstorefirstrow + "and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");
                                db.excetedate("delete products_Qty where Qty <=0", "");
                                insertsalesRep7(x, price_beforetax, tax_value, secondbaky, Convert.ToDecimal(tblQty.Rows[0][4]));
                                return;
                            }
                            else if (Qtyinstorefirstrow - secondbaky < 0)
                            {

                                decimal therdbaky = Math.Abs(Qtyinstorefirstrow - baky);
                                db.excetedate("update products_Qty set Qty=Qty - " + Qtyinstorefirstrow + "where Pro_ID =" + pro_ID + " and store_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + "and Qty = " + Qtyinstorefirstrow + "and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");
                                db.excetedate("delete products_Qty where Qty <=0", "");
                                insertsalesRep7(x, price_beforetax, tax_value, Qtyinstorefirstrow, Convert.ToDecimal(tblQty.Rows[0][4]));
                                currentQty -= Qtyinstorefirstrow;
                                tblQty.Clear();
                                tblQty = db.readData("select top 1 * from products_Qty where Pro_ID=" + pro_ID + "", "");

                                Qtyinstorefirstrow = Convert.ToDecimal(tblQty.Rows[0][3]);

                                if (Qtyinstorefirstrow - therdbaky >= 0)
                                {

                                    db.excetedate("update products_Qty set Qty=Qty - " + therdbaky + "where Pro_ID =" + pro_ID + " and store_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + "and Qty = " + Qtyinstorefirstrow + "and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");
                                    db.excetedate("delete products_Qty where Qty <=0", "");
                                    insertsalesRep7(x, price_beforetax, tax_value, therdbaky, Convert.ToDecimal(tblQty.Rows[0][4]));
                                    return;
                                }
                                else if (Qtyinstorefirstrow - therdbaky < 0)
                                {

                                    decimal forthbaky = Math.Abs(Qtyinstorefirstrow - baky);
                                    db.excetedate("update products_Qty set Qty=Qty - " + Qtyinstorefirstrow + "where Pro_ID =" + pro_ID + " and store_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + "and Qty = " + Qtyinstorefirstrow + "and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");
                                    db.excetedate("delete products_Qty where Qty <=0", "");
                                    insertsalesRep7(x, price_beforetax, tax_value, Qtyinstorefirstrow, Convert.ToDecimal(tblQty.Rows[0][4]));

                                    currentQty -= Qtyinstorefirstrow;
                                    tblQty.Clear();
                                    tblQty = db.readData("select top 1 * from products_Qty where Pro_ID=" + pro_ID + "", "");

                                    Qtyinstorefirstrow = Convert.ToDecimal(tblQty.Rows[0][3]);


                                    if (Qtyinstorefirstrow - forthbaky >= 0)
                                    {

                                        db.excetedate("update products_Qty set Qty=Qty - " + forthbaky + "where Pro_ID =" + pro_ID + " and store_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + "and Qty = " + Qtyinstorefirstrow + "and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");
                                        db.excetedate("delete products_Qty where Qty <=0", "");
                                        insertsalesRep7(x, price_beforetax, tax_value, forthbaky, Convert.ToDecimal(tblQty.Rows[0][4]));

                                        return;
                                    }
                                    else if (Qtyinstorefirstrow - forthbaky < 0)
                                    {


                                        db.excetedate("update products_Qty set Qty=Qty - " + Qtyinstorefirstrow + "where Pro_ID =" + pro_ID + " and store_ID=" + Convert.ToDecimal(tblQty.Rows[0][1]) + "and Qty = " + Qtyinstorefirstrow + "and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");
                                        db.excetedate("delete products_Qty where Qty <=0", "");
                                        insertsalesRep7(x, price_beforetax, tax_value, Qtyinstorefirstrow, Convert.ToDecimal(tblQty.Rows[0][4]));

                                        currentQty -= Qtyinstorefirstrow;



                                    }

                                }
                            }
                        }
                    }
                    if(currentQty<=0)
                    { return; }
                }
                catch (Exception) { }
            }
        }


        //to imsert data into sales table and updare qty in store
  string cust_name = "";
        private void insertdatasalesupdatestoreQty()
        {
            string d = dtp_date.Value.ToString("dd/MM/yyyy");
            string dreminder = Dtp_reminder.Value.ToString("dd/MM/yyyy");

          
            if (rbtncust_agel.Checked == true)
            { cust_name = cbx_customer.Text; }
            else
            {
                if (txt_customer.Text == "")
                    cust_name = "عميل نقدي";

                else if (txt_customer.Text != "")
                {
                    cust_name = txt_customer.Text;
                }
            }
            Properties.Settings.Default.totalOrder = Convert.ToDecimal(txt_total.Text);
            Properties.Settings.Default.madfou3 = 0;
            Properties.Settings.Default.baky = 0;
            Properties.Settings.Default.Save();


            frm_paysale frm = new frm_paysale();
            frm.ShowDialog();

            db.excetedate("insert into sales values(" + txt_id.Text + " , '" + d + "', N'" + cust_name + "')", "");
            decimal tax_value = 0, totaltax=0, price_beforetax = 0, qtyinmain = 0, realqty = 0;

            DataTable tblpro = new DataTable();
            tblpro.Clear();
            DataTable tblQty = new DataTable();
            tblQty.Clear();
            for (int i = 0; i <= Dgv_sale.Rows.Count - 1; i++)
            {



                tblpro = (db.readData("select * from products where Pro_ID =" + Dgv_sale.Rows[i].Cells[0].Value + "", ""));
                tblQty = (db.readData("select * from product_unit where Pro_ID =" + Dgv_sale.Rows[i].Cells[0].Value + "and unit_Name=N'" + Dgv_sale.Rows[i].Cells[2].Value + "'", ""));
                qtyinmain = Convert.ToDecimal(tblQty.Rows[0][3]);



                tax_value = (Convert.ToDecimal(tblpro.Rows[0][9]) - Convert.ToDecimal(tblpro.Rows[0][4])) / qtyinmain;
                price_beforetax = Convert.ToDecimal(tblpro.Rows[0][4]);
                realqty = Convert.ToDecimal(Dgv_sale.Rows[i].Cells[3].Value) / qtyinmain;
                totaltax += tax_value * Convert.ToDecimal(Dgv_sale.Rows[i].Cells[3].Value);
                if (Convert.ToDecimal(tblpro.Rows[0][2])-realqty < 0)
                {

                    MessageBox.Show("الكميه الموجوده في المخزن غير كافية", "تأكيد");

                    return;
                }

                db.excetedate("insert into sales_details values (" + txt_id.Text + ",N'" + cust_name + "'," + Dgv_sale.Rows[i].Cells[0].Value + ",N'" + d + "'," + Dgv_sale.Rows[i].Cells[3].Value + ",N'" + Properties.Settings.Default.usernane + "'," + price_beforetax + ", " + Dgv_sale.Rows[i].Cells[5].Value + "," + Dgv_sale.Rows[i].Cells[6].Value + "," + Properties.Settings.Default.totalOrder + "," + Properties.Settings.Default.madfou3 + "," + Properties.Settings.Default.baky + ",N'" + Dgv_sale.Rows[i].Cells[2].Value + "'," + tax_value + "," + Dgv_sale.Rows[i].Cells[4].Value + ",N'" + dtp_time.Text + "')", "");
               


                db.excetedate("update products set Qty = Qty - " + realqty + " where Pro_ID = " + Dgv_sale.Rows[i].Cells[0].Value + "", "");
                updateqtyinstore(Convert.ToInt32(Dgv_sale.Rows[i].Cells[0].Value),realqty,i,price_beforetax,tax_value);

               
            }
            decimal totalbeforetax = 0;
            totalbeforetax = Convert.ToDecimal(txt_total.Text) - totaltax;
            db.excetedate("insert into taxes_Report (Order_Num,Order_Type,tax_type,sup_name,cust_name,total_order,total_tax,total_Aftertax,date)values(" + txt_id.Text + ", N'فاتورة مبيعات',N'قيمة مضافة',N'لا يوجد',N'"+cust_name+"'," + totalbeforetax + "," + totaltax + "," + txt_total.Text + ",N'" + d + "')", "");


        }
        private void insertsalesRep7(int i,decimal price_beforetax,decimal tax_value,decimal realQty,decimal buyprice)
        {
            string d = dtp_date.Value.ToString("dd/MM/yyyy");
            try {
                db.excetedate("insert into sales_Rb7h values (" + txt_id.Text + ",N'" + cust_name + "'," + Dgv_sale.Rows[i].Cells[0].Value + ",N'" + d + "'," + realQty + ",N'" + Properties.Settings.Default.usernane + "'," + price_beforetax + ", " + Dgv_sale.Rows[i].Cells[5].Value + "," + Dgv_sale.Rows[i].Cells[6].Value + "," + Properties.Settings.Default.totalOrder + "," + Properties.Settings.Default.madfou3 + "," + Properties.Settings.Default.baky + ",N'" + Dgv_sale.Rows[i].Cells[2].Value + "'," + tax_value + "," + Dgv_sale.Rows[i].Cells[4].Value + ",N'" + dtp_time.Text + "',"+buyprice+")", "");
            }
            catch (Exception) { }





        }        
            private void payorder()
        {
            if (Dgv_sale.Rows.Count >= 1)
            {
                string d = dtp_date.Value.ToString("dd/MM/yyyy");
                string dreminder = Dtp_reminder.Value.ToString("dd/MM/yyyy");
                

                //call to inser data in sales details and sales rebh7 and update Qty in store
                insertdatasalesupdatestoreQty();

                

                if (Properties.Settings.Default.chekButton == true)
                {
                    try
                    {
                       


                        if (rbtnCust_cash.Checked == true)
                        {
                            db.excetedate("insert into customer_report values(" + txt_id.Text + "," + Properties.Settings.Default.madfou3 + ",'" + d + "',N'" + cust_name + "')", "");

                        }
                        else if (rbtncust_agel.Checked == true)
                        {
                            db.excetedate("insert into customer_mony values(" + txt_id.Text + ",N'" + cust_name + "'," + Properties.Settings.Default.baky + ",'" + d + "','" + dreminder + "')", "");

                            if (Properties.Settings.Default.madfou3 >= 1)
                            {
                                db.excetedate("insert into customer_report values(" + txt_id.Text + "," + Properties.Settings.Default.madfou3 + ",'" + d + "',N'" + cust_name + "')", "");
                            }
                        }
                        insertmonyintostock();
                        if (Properties.Settings.Default.salesprint == true)
                        {
                            int data = 0;
                            if (Properties.Settings.Default.printername == "")
                            {
                                MessageBox.Show("من فضلك حدد اسم الطابعه اولا من شاشة اعدادات البرنامج", "تاكيد"); return;
                            }
                            try
                            {

                                data = Convert.ToInt32(db.readData("select count(name) from orderprintdata", "").Rows[0][0]);

                            }
                            catch (Exception) { }
                            if (data <= 0)
                            {
                                MessageBox.Show("من فضلك ادخل بيانات الفاتوره اولا في شاشة اعدادات البرنامج", "تاكيد"); return;

                            }
                            for (int i = 0; i <= Properties.Settings.Default.salesprintnum - 1; i++)
                            {
                              print();
                            }
                        }
                        AutoNumber();
                    }
                    catch (Exception) { }
                }
            }
        }
        //ادخال الاموال ف الخزنه والتحديث دائما
        private void insertmonyintostock()
        {
            string d = dtp_date.Value.ToString("dd/MM/yyyy");
            DataTable tblstock = new DataTable();

            if (Properties.Settings.Default.pay_visa == false)
            {

                db.excetedate("insert into stock_insert (stock_ID ,Mony ,Date ,Name ,Type ,Reason) values (" + stock_ID + "," + Properties.Settings.Default.madfou3 + ",N'" + d + "',N'" + Properties.Settings.Default.usernane + "' ,N'عمليات بيع',N'')", "");
                db.excetedate("update stock set Mony=Mony + " + Properties.Settings.Default.madfou3 + "where stock_ID = " + stock_ID + "", "");
            }
            else
            {
                db.excetedate("insert into bank_insert (Mony ,Date ,Name ,Type ,Reason) values (" + Properties.Settings.Default.madfou3 + ",N'" + d + "',N'" + Properties.Settings.Default.usernane + "' ,N'عمليات بيع',N'')", "");
                db.excetedate("update bank set Mony=Mony + " + Properties.Settings.Default.madfou3 + "", "");

            }
        }
        private void print()
        {
     
            int id = Convert.ToInt32(txt_id.Text);
            DataTable tblrpt = new DataTable();
            tblrpt.Clear();
            tblrpt = db.readData("SELECT [Order_ID]as'رقم الفاتوره',[Cus_name]as'اسم العميل',products.[Pro_name]as'المنتج',sales_details.[Qty]as'الكميه',unit as 'الوحدة',[price_tax]as' السعر شامل الضريبة',[discound]as'الخصم',[total]as'الاجمالي',[TotalOrder]as'اجمالي الفاتوره',[madfoo3]as'المبلغ الدفوع',[Baky]as'المتبقي',[User_name]as'الكاشير',[Date]as'التاريخ',[sales_details].tax_value as'الضريبة' FROM [dbo].[sales_details],products where products.Pro_ID =sales_details.Pro_ID and Order_ID =" + id + "", "");
            Frm_printing frm = new Frm_printing();
            frm.crystalReportViewer1.RefreshReport();
            if (Properties.Settings.Default.saleprintkind == "8cm")
            {
                 Rpt_OrderSale rpt = new Rpt_OrderSale();


                rpt.SetDatabaseLogon("", "", "DESKTOP-NJ3N9G2", "therd");
                rpt.SetDataSource(tblrpt);
                rpt.SetParameterValue("ID", id);
                frm.crystalReportViewer1.ReportSource = rpt;
                //لتحديد خيارات الطابعه
                System.Drawing.Printing.PrintDocument PrintDocument = new System.Drawing.Printing.PrintDocument();
                //للطباعه علي الطابعه المتحدده علي الجهاز
                //  rpt.PrintOptions.PrinterName = PrintDocument.PrinterSettings.PrinterName;
                //للطباعه علي الطابعه المتحدده داخل البرنامج
                rpt.PrintOptions.PrinterName = Properties.Settings.Default.printername;

                rpt.PrintToPrinter(1, true, 0, 0);
               // frm.ShowDialog();

            }
            else if (Properties.Settings.Default.saleprintkind == "A4")
            {
                OrdersaleA4 rpt = new OrdersaleA4();


                rpt.SetDatabaseLogon("", "", "DESKTOP-NJ3N9G2", "therd");
                rpt.SetDataSource(tblrpt);
                rpt.SetParameterValue("id", id);
                frm.crystalReportViewer1.ReportSource = rpt;
                //لتحديد خيارات الطابعه
                System.Drawing.Printing.PrintDocument PrintDocument = new System.Drawing.Printing.PrintDocument();
                //للطباعه علي الطابعه المتحدده علي الجهاز
                //  rpt.PrintOptions.PrinterName = PrintDocument.PrinterSettings.PrinterName;
                //للطباعه علي الطابعه المتحدده داخل البرنامج
                rpt.PrintOptions.PrinterName = Properties.Settings.Default.printername;

              // rpt.PrintToPrinter(1, true, 0, 0);
                 frm.ShowDialog();
            }


        }
        private void txt_parcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
              
                DataTable tblitems = new DataTable();
                tblitems.Clear();
                DataTable tblunit = new DataTable();
                tblunit.Clear();
                tblitems = db.readData("select * from products where Barcode=" + txt_parcode.Text + "", "");
                if (cbx_items.Items.Count >= 0)
                {
                    try
                    {
                        cbx_items.SelectedValue = Convert.ToInt32(tblitems.Rows[0][0]);

                        string Product_ID = tblitems.Rows[0][0].ToString();
                        string Product_Name = tblitems.Rows[0][1].ToString();
                        string Product_Qty = "1";
                        string Product_Price = "0";
                        decimal discound = 0;
                        string Product_unit = tblitems.Rows[0][14].ToString();





                        Dgv_sale.Rows.Add(1);
                        int rowindex = Dgv_sale.Rows.Count - 1;
                        Dgv_sale.Rows[rowindex].Cells[0].Value = Product_ID;
                        Dgv_sale.Rows[rowindex].Cells[1].Value = Product_Name;
                        Dgv_sale.Rows[rowindex].Cells[3].Value = Product_Qty;
                        Dgv_sale.Rows[rowindex].Cells[2].Value = Product_unit;
                        tblunit = db.readData("select * from product_unit where Pro_ID = " + Dgv_sale.CurrentRow.Cells[0].Value + "and unit_Name = N'" + Dgv_sale.CurrentRow.Cells[2].Value + "'", "");

                        decimal realprice = 0;
                        try
                        {
                            realprice = Convert.ToDecimal(tblunit.Rows[0][5]) / Convert.ToDecimal(tblunit.Rows[0][3]);


                        }
                        catch (Exception) { }


                        Dgv_sale.Rows[rowindex].Cells[4].Value = realprice;
                        decimal total = Convert.ToDecimal(Product_Qty) * Convert.ToDecimal(realprice);


                        Dgv_sale.Rows[rowindex].Cells[5].Value = discound;
                        Dgv_sale.Rows[rowindex].Cells[6].Value = total;
                    }
                    catch (Exception) { }
                    try
                    {
                        decimal totalorder = 0;
                        for (int i = 0; i <= Dgv_sale.Rows.Count - 1; i++)
                        {
                            totalorder += Convert.ToDecimal(Dgv_sale.Rows[i].Cells[6].Value);
                            //لكي يكون التحديد علي اخر سطر
                            Dgv_sale.ClearSelection();
                            Dgv_sale.FirstDisplayedScrollingRowIndex = Dgv_sale.Rows.Count - 1;
                            Dgv_sale.Rows[Dgv_sale.Rows.Count - 1].Selected = true;

                        }
                        txt_total.Text = Math.Round(totalorder, 2).ToString();
                        lbl_itemscount.Text = (Dgv_sale.Rows.Count).ToString();
                    }
                    catch (Exception) { }
                }
            }
        }

        private void btn_deleteitems_Click(object sender, EventArgs e)
        {
            if (Dgv_sale.Rows.Count >= 1)

            {
                int index = Dgv_sale.SelectedRows[0].Index;
                Dgv_sale.Rows.RemoveAt(index);

                if (Dgv_sale.Rows.Count <= 0)
                {

                    txt_total.Text = "0";
                }
                try
                {
                    decimal totalorder = 0;
                    for (int i = 0; i <= Dgv_sale.Rows.Count - 1; i++)
                    {

                        totalorder += Convert.ToDecimal(Dgv_sale.Rows[i].Cells[6].Value);
                        //هذه الاكواد لتحديد اخر سطر والسطر الذي قبله عند المسح
                        Dgv_sale.ClearSelection();
                        Dgv_sale.FirstDisplayedScrollingRowIndex = Dgv_sale.Rows.Count - 1;
                        Dgv_sale.Rows[Dgv_sale.Rows.Count - 1].Selected = true;


                    }
                    txt_total.Text = Math.Round(totalorder, 2).ToString();
                    lbl_itemscount.Text = (Dgv_sale.Rows.Count).ToString();

                }
                catch (Exception) { }

            }
        }

        private void Dgv_sale_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            decimal item_Qty = 0, item_salePrice = 0, item_Discount = 0;
            try
            {

                int index = Dgv_sale.SelectedRows[0].Index;
                item_Qty = Convert.ToDecimal(Dgv_sale.Rows[index].Cells[3].Value);
                item_salePrice = Convert.ToDecimal(Dgv_sale.Rows[index].Cells[4].Value);
                item_Discount = Convert.ToDecimal(Dgv_sale.Rows[index].Cells[5].Value);

                decimal total = 0;
                total = (item_Qty * item_salePrice) - item_Discount;

                Dgv_sale.Rows[index].Cells[6].Value = total;



                decimal totalorder = 0;

                for (int i = 0; i <= Dgv_sale.Rows.Count - 1; i++)
                {
                    totalorder += Convert.ToDecimal(Dgv_sale.Rows[i].Cells[6].Value);


                }
                txt_total.Text = Math.Round(totalorder, 2).ToString();

            }
            catch (Exception) { }
    }

     
    } }
                                                                                                                                                                                                                                                           