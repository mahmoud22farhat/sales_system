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
    public partial class frm_buy : DevExpress.XtraEditors.XtraForm
    {
        private static frm_buy frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static frm_buy GetFormbuy
        {
            get
            {
                if (frm == null)
                {
                    frm = new frm_buy();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frm_buy()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }
        database db = new database();
        DataTable tbl = new DataTable();
        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select MAX (Order_ID) from buy", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {
                txt_id.Text = "1";
            }
            else
            {
                txt_id.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();

            }
            dtp_date.Text = DateTime.Now.ToShortDateString();
            dtp_agel.Text = DateTime.Now.ToShortDateString();
            try
            {
                cbx_items.SelectedIndex = 0;
                cbx_supplier.SelectedIndex = 0;
                cbx_store.SelectedIndex = 0;
            }
            catch (Exception) { }
            cbx_items.Text = "اختر منتج";
            Dgv_buy.Rows.Clear();
            rbtn_cash.Checked = true;
            txt_parcode.Clear();
            txt_parcode.Focus();
            txt_total.Clear();
        }
        private void fillitems()
        {
            cbx_items.DataSource = db.readData("select * from products", "");
            cbx_items.DisplayMember = "Pro_name";
            cbx_items.ValueMember = "Pro_ID";
        }
        public void fillsupplier()
        {
            cbx_supplier.DataSource = db.readData("select * from supliers", "");
            cbx_supplier.DisplayMember = "sup_Name";
            cbx_supplier.ValueMember = "sup_ID";
        }
        public void fillstore()
        {
            cbx_store.DataSource = db.readData("select * from store", "");
            cbx_store.DisplayMember = "store_Name";
            cbx_store.ValueMember = "store_ID";
        }
        string stock_ID = "";
        private void frm_buy_Load(object sender, EventArgs e)
        {
            fillitems();
            fillsupplier();
            fillstore();
            try
            {
                AutoNumber();
            }
            catch (Exception) { }
            stock_ID = Convert.ToString(Properties.Settings.Default.stock_id);





            dtp_date.Text = DateTime.Now.ToShortDateString();
            dtp_time.Text = DateTime.Now.ToShortTimeString();
            dtp_agel.Text = DateTime.Now.ToShortDateString();
            lbl_username.Text = Properties.Settings.Default.usernane;
            Properties.Settings.Default.Save();
        }

        private void btn_supplierbrouse_Click(object sender, EventArgs e)
        {
            frm_supliers frm = new frm_supliers();
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
                return;

            }
            DataTable tblitems = new DataTable();
            tblitems.Clear();
            DataTable tblprice = new DataTable();
            tblprice.Clear();
            DataTable tblunit = new DataTable();
            tblunit.Clear();
            tblitems = db.readData("select * from products where Pro_ID=" + cbx_items.SelectedValue + "", "");
            if (cbx_items.Items.Count >= 1)
            {
                try
                {

                    int countQty = 0;
                    try
                    {
                        countQty = Convert.ToInt32(db.readData("select count(Pro_ID) from products_Qty where Pro_ID =  " + cbx_items.SelectedValue + "", "").Rows[0][0]);
                    }
                    catch (Exception) { }


                    tblprice = db.readData("select * from products_Qty where Pro_ID = " + cbx_items.SelectedValue + "", "");



                    string Product_ID = tblitems.Rows[0][0].ToString();
                    string Product_Name = tblitems.Rows[0][1].ToString();
                    string Product_Qty = "1";
                    string Product_Price = tblprice.Rows[countQty - 1][4].ToString();
                    //string Product_Price = "10";
                    string Product_unit = tblitems.Rows[0][16].ToString();
                    decimal discound = 0;





                    Dgv_buy.Rows.Add(1);
                    int rowindex = Dgv_buy.Rows.Count - 1;
                    Dgv_buy.Rows[rowindex].Cells[0].Value = Product_ID;
                    Dgv_buy.Rows[rowindex].Cells[1].Value = Product_Name;
                    Dgv_buy.Rows[rowindex].Cells[2].Value = Product_unit;
                    Dgv_buy.Rows[rowindex].Cells[3].Value = Product_Qty;
                    tblunit = db.readData("select * from product_unit where Pro_ID = " + Dgv_buy.CurrentRow.Cells[0].Value + "and unit_Name = N'" + Dgv_buy.CurrentRow.Cells[2].Value + "'", "");

                    decimal realprice = 0;
                    try {
                        realprice = Convert.ToDecimal(Product_Price) / Convert.ToDecimal(tblunit.Rows[0][3]);


                    }
                    catch (Exception) { }
                    decimal total = Convert.ToDecimal(Product_Qty) * Convert.ToDecimal(realprice);

                    Dgv_buy.Rows[rowindex].Cells[4].Value = Math.Round(realprice, 2);
                    Dgv_buy.Rows[rowindex].Cells[5].Value = discound;
                    Dgv_buy.Rows[rowindex].Cells[6].Value = Math.Round(total, 2);
                }
                catch (Exception) { }
                try
                {
                    decimal totalorder = 0;
                    for (int i = 0; i <= Dgv_buy.Rows.Count - 1; i++)
                    {
                        totalorder += Convert.ToDecimal(Dgv_buy.Rows[i].Cells[6].Value);
                        Dgv_buy.ClearSelection();
                        Dgv_buy.FirstDisplayedScrollingRowIndex = Dgv_buy.Rows.Count - 1;
                        Dgv_buy.Rows[Dgv_buy.Rows.Count - 1].Selected = true;

                    }
                    txt_total.Text = Math.Round(totalorder, 2).ToString();
                    lbl_itemscount.Text = (Dgv_buy.Rows.Count).ToString();

                }
                catch (Exception) { }


            }
        }

        private void btn_deleteitems_Click(object sender, EventArgs e)
        {
            if (Dgv_buy.Rows.Count >= 1)

            {
                int index = Dgv_buy.SelectedRows[0].Index;
                Dgv_buy.Rows.RemoveAt(index);

                if (Dgv_buy.Rows.Count <= 0)
                {

                    txt_total.Text = "0";
                }
                try
                {
                    decimal totalorder = 0;
                    for (int i = 0; i <= Dgv_buy.Rows.Count - 1; i++)
                    {

                        totalorder += Convert.ToDecimal(Dgv_buy.Rows[i].Cells[6].Value);
                        //هذه الاكواد لتحديد اخر سطر والسطر الذي قبله عند المسح
                        Dgv_buy.ClearSelection();
                        Dgv_buy.FirstDisplayedScrollingRowIndex = Dgv_buy.Rows.Count - 1;
                        Dgv_buy.Rows[Dgv_buy.Rows.Count - 1].Selected = true;


                    }
                    txt_total.Text = Math.Round(totalorder, 2).ToString();
                    lbl_itemscount.Text = (Dgv_buy.Rows.Count).ToString();

                }
                catch (Exception) { }

            }
        }

        private void txt_parcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                DataTable tblitems = new DataTable();
                tblitems.Clear();
                DataTable tblprice = new DataTable();
                tblprice.Clear();
                DataTable tblunit = new DataTable();
                tblunit.Clear();
                tblitems = db.readData("select * from products where Barcode=" + txt_parcode.Text + "", "");
                if (cbx_items.Items.Count >= 1)
                {
                    cbx_items.SelectedValue = Convert.ToDecimal(tblitems.Rows[0][0]);
                    try
                    {

                        int countQty = 0;
                        try
                        {
                            countQty = Convert.ToInt32(db.readData("select count(Pro_ID) from products_Qty where Pro_ID =  " + cbx_items.SelectedValue + "", "").Rows[0][0]);
                        }
                        catch (Exception) { }


                        tblprice = db.readData("select * from products_Qty where Pro_ID = " + cbx_items.SelectedValue + "", "");



                        string Product_ID = tblitems.Rows[0][0].ToString();
                        string Product_Name = tblitems.Rows[0][1].ToString();
                        string Product_Qty = "1";
                        string Product_Price = tblprice.Rows[countQty - 1][4].ToString();
                        //string Product_Price = "10";
                        string Product_unit = tblitems.Rows[0][16].ToString();
                        decimal discound = 0;





                        Dgv_buy.Rows.Add(1);
                        int rowindex = Dgv_buy.Rows.Count - 1;
                        Dgv_buy.Rows[rowindex].Cells[0].Value = Product_ID;
                        Dgv_buy.Rows[rowindex].Cells[1].Value = Product_Name;
                        Dgv_buy.Rows[rowindex].Cells[2].Value = Product_unit;
                        Dgv_buy.Rows[rowindex].Cells[3].Value = Product_Qty;
                        tblunit = db.readData("select * from product_unit where Pro_ID = " + Dgv_buy.CurrentRow.Cells[0].Value + "and unit_Name = N'" + Dgv_buy.CurrentRow.Cells[2].Value + "'", "");

                        decimal realprice = 0;
                        try
                        {
                            realprice = Convert.ToDecimal(Product_Price) / Convert.ToDecimal(tblunit.Rows[0][3]);


                        }
                        catch (Exception) { }
                        decimal total = Convert.ToDecimal(Product_Qty) * Convert.ToDecimal(realprice);

                        Dgv_buy.Rows[rowindex].Cells[4].Value = Math.Round(realprice, 2);
                        Dgv_buy.Rows[rowindex].Cells[5].Value = discound;
                        Dgv_buy.Rows[rowindex].Cells[6].Value = Math.Round(total, 2);
                    }
                    catch (Exception) { }
                    try
                    {
                        decimal totalorder = 0;
                        for (int i = 0; i <= Dgv_buy.Rows.Count - 1; i++)
                        {
                            totalorder += Convert.ToDecimal(Dgv_buy.Rows[i].Cells[6].Value);
                            Dgv_buy.ClearSelection();
                            Dgv_buy.FirstDisplayedScrollingRowIndex = Dgv_buy.Rows.Count - 1;
                            Dgv_buy.Rows[Dgv_buy.Rows.Count - 1].Selected = true;

                        }
                        txt_total.Text = Math.Round(totalorder, 2).ToString();
                        lbl_itemscount.Text = (Dgv_buy.Rows.Count).ToString();

                    }
                    catch (Exception) { }


                }
            }
        }
        //ادخال البياناات في جدول المشتريات والتعديل عليه
        private void insertandupdatedata()
            {
            DataTable tblunit = new DataTable();
            tblunit.Clear();
            DataTable tblQty = new DataTable();
            tblQty.Clear();


            string d = dtp_date.Value.ToString("dd/MM/yyyy");
            string dreminder = dtp_agel.Value.ToString("dd/MM/yyyy");


            db.excetedate("insert into buy values (" + txt_id.Text + ",N'" + d + "'," + cbx_supplier.SelectedValue + ")", "");
            decimal tax_value = 0,totaltax=0, tax_persent = 0, price_beforetax = 0, qtyinmain = 0, realqty = 0;
            for (int i = 0; i <= Dgv_buy.Rows.Count - 1; i++)
            {

                try
                {


                    tax_persent = Convert.ToDecimal(db.readData("select * from products where Pro_ID =" + Dgv_buy.Rows[i].Cells[0].Value + "", "").Rows[0][8]);


                }
                catch (Exception) { }

                tax_value = (Convert.ToDecimal(Dgv_buy.Rows[i].Cells[4].Value) / 100) * tax_persent;
                price_beforetax = (Convert.ToDecimal(Dgv_buy.Rows[i].Cells[4].Value)) - tax_value;
                totaltax += tax_value * (Convert.ToDecimal(Dgv_buy.Rows[i].Cells[4].Value));
                db.excetedate("insert into buy_datails values (" + txt_id.Text + "," + cbx_supplier.SelectedValue + " ," + Dgv_buy.Rows[i].Cells[0].Value + ",N'" + d + "'," + Dgv_buy.Rows[i].Cells[3].Value + ",N'" + Properties.Settings.Default.usernane + "'," + price_beforetax + "," + Dgv_buy.Rows[i].Cells[5].Value + "," + Dgv_buy.Rows[i].Cells[6].Value + "," + txt_total.Text + "," + Properties.Settings.Default.madfou3 + "," + Properties.Settings.Default.baky + "," + tax_value + "," + Dgv_buy.Rows[i].Cells[4].Value + ",N'" + dtp_time.Text + "',N'" + Dgv_buy.Rows[i].Cells[2].Value + "')", "");


                tblunit = db.readData("select * from product_unit where Pro_ID =" + Dgv_buy.Rows[i].Cells[0].Value + "and unit_Name= N'" + Dgv_buy.Rows[i].Cells[2].Value + "'", "");

                qtyinmain = Convert.ToDecimal(tblunit.Rows[0][3]);
                realqty = Convert.ToDecimal(Dgv_buy.Rows[i].Cells[3].Value) / qtyinmain;


                //لتمييز اضافة الكرتونه او العلبه الي مخزن المنتجات

                db.excetedate("update products set Qty = Qty + "+realqty+" where Pro_ID = " + Dgv_buy.Rows[i].Cells[0].Value + "", "");


                tblQty = db.readData("select * from products_Qty where Pro_ID =" + Dgv_buy.Rows[i].Cells[0].Value + "and store_ID = " + cbx_store.SelectedValue + "and Buy_price =" + Dgv_buy.Rows[i].Cells[4].Value + " ", "");

                //عند اضافة نفس لبمنتج ولكن بسعر مختلف 
                if (tblQty.Rows.Count >= 1)
                {

                    db.excetedate("update products_Qty set Qty = Qty + " + Dgv_buy.Rows[i].Cells[3].Value + "where Pro_ID = " + Dgv_buy.Rows[i].Cells[0].Value + "", "");
                }
                else
                {
                    decimal saleprice = 0;
                    try
                    {
                        saleprice = Convert.ToDecimal(db.readData("select * from products where Pro_ID =" + Dgv_buy.Rows[i].Cells[0].Value + "", "").Rows[0][9]);

                    }
                    catch (Exception) { }

                    db.excetedate("insert into products_Qty values (" + Dgv_buy.Rows[i].Cells[0].Value + "," + cbx_store.SelectedValue + ",N'" + cbx_store.Text + "'," + realqty + "," + Dgv_buy.Rows[i].Cells[4].Value + "," + saleprice + ")", "");
                }
            }

            if (rbtn_cash.Checked == true)
            {
                db.excetedate("insert into suplier_Report values(" + txt_id.Text + "," + Properties.Settings.Default.madfou3 + ",'" + d + "'," + cbx_supplier.SelectedValue + ")", "");

            }
            else if (rbtn_agel.Checked == true)
            {


                db.excetedate("insert into suplier_mony values(" + txt_id.Text + "," + cbx_supplier.SelectedValue + "," + Properties.Settings.Default.baky + ",'" + d + "','" + dreminder + "')", "");

                if (Properties.Settings.Default.madfou3 >= 1)
                {
                    db.excetedate("insert into suplier_Report values(" + txt_id.Text + "," + Properties.Settings.Default.madfou3 + ",'" + d + "'," + cbx_supplier.SelectedValue + ")", "");

                }
            }
            decimal totalbeforetax = 0;
            totalbeforetax =Convert.ToDecimal( txt_total.Text) - totaltax;
            db.excetedate("insert into taxes_Report (Order_Num,Order_Type,tax_type,sup_name,cust_name,total_order,total_tax,total_Aftertax,date)values(" + txt_id.Text+", N'فاتورة مشتريات',N'قيمة مضافة',N'"+cbx_supplier.Text+"',N'لا يوجد',"+totalbeforetax+","+totaltax+","+txt_total.Text+",N'"+d+"')", "");


        }
        //التاكد من الفلوس الموجوده في الخزنه قبل عملية الشراء
        private bool checkifMoneyExist()
        {
            string d = dtp_date.Value.ToString("dd/MM/yyyy");
            DataTable tblstock = new DataTable();

           
            decimal stock_money = 0;

            tbl.Clear();
            tblstock = db.readData("select * from stock where stock_ID = " + stock_ID + "", "");
            stock_money = Convert.ToDecimal(tblstock.Rows[0][1]);

            if (Convert.ToDecimal(Properties.Settings.Default.madfou3) > stock_money)
            {

                MessageBox.Show("المبلغ الموجود في الخزنه غر كافي لاجراء العمليه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                return false;
            }
            db.excetedate("insert into stock_pull (stock_ID ,Mony ,Date ,Name ,Type ,Reason) values (" + stock_ID + "," + Properties.Settings.Default.madfou3 + ",N'" + d + "',N'"+Properties.Settings.Default.usernane+"' ,N'عمليات شراء',N'')", "");
            db.excetedate("update stock set Mony=Mony - " + Properties.Settings.Default.madfou3 + "where stock_ID = " + stock_ID + "", "");
            return true;
        }
        private void PayOrder()

        {
            string d = dtp_date.Value.ToString("dd/MM/yyyy");
            string dreminder = dtp_agel.Value.ToString("dd/MM/yyyy");
            //if (Dgv_buy.Rows.Count >= 1)
            {
                if (cbx_supplier.Items.Count <= 0) { MessageBox.Show("من فضلك اختر مورد اولا", "تاكيد"); return; }
                if (cbx_store.Items.Count <= 0) { MessageBox.Show("من فضلك االمخزن اولا", "تاكيد"); return; }
                try
                {
                    if (Dgv_buy.Rows.Count >= 1)
                    {
                        Properties.Settings.Default.totalOrder = Convert.ToDecimal(txt_total.Text);
                        Properties.Settings.Default.madfou3 = 0;
                        Properties.Settings.Default.baky = 0;
                        Properties.Settings.Default.Save();


                        frm_payBuy frm = new frm_payBuy();
                        frm.ShowDialog();
                    }
              


                 
                        if (Properties.Settings.Default.chekButton == true)
                            {

                                    bool check = checkifMoneyExist();
                                    if (check == false)
                                    {
                                        return;
                                    }

                                    insertandupdatedata();
                                    if (rbtn_cash.Checked == true)
                                    {
                                        db.excetedate("insert into suplier_Report values(" + txt_id.Text + "," + Properties.Settings.Default.madfou3 + ",'" + d + "'," + cbx_supplier.SelectedValue + ")", "");

                                    }
                                    else if (rbtn_agel.Checked == true)
                                    {


                                        db.excetedate("insert into suplier_mony values(" + txt_id.Text + "," + cbx_supplier.SelectedValue + "," + Properties.Settings.Default.baky + ",'" + d + "','" + dreminder + "')", "");

                                        if (Properties.Settings.Default.madfou3 >= 1)
                                        {
                                            db.excetedate("insert into suplier_Report values(" + txt_id.Text + "," + Properties.Settings.Default.madfou3 + ",'" + d + "'," + cbx_supplier.SelectedValue + ")", "");

                                        }
                                    }  
                         if(Properties.Settings.Default.buyprint ==true)
                         {
                            int data = 0;
                            if (Properties.Settings.Default.printername == "")
                            {
                                MessageBox.Show("من فضلك حدد اسم الطابعه اولا من شاشة اعدادات البرنامج", "تاكيد"); return;
                            }
                            try {

                                data = Convert.ToInt32(db.readData("select count(name) from orderprintdata", "").Rows[0][0]);

                            } catch (Exception) { }
                            if (data <= 0)
                            {
                                MessageBox.Show("من فضلك ادخل بيانات الفاتوره اولا في شاشة اعدادات البرنامج", "تاكيد"); return;

                            }
                            for (int i=0;i<=Properties.Settings.Default.buyprintnum - 1;i++)
                            {
                                    print();
                            }
                         }                          
                                     
                                AutoNumber();
                        }               
                }
                catch (Exception) { }
            }                       
        }
       

        private void print()
        {
            int id = Convert.ToInt32( txt_id.Text);
            DataTable tblrpt = new DataTable();

            tblrpt.Clear();
            tblrpt = db.readData("SELECT [Order_ID] as'رقم الفاتوره',supliers.sup_Name as 'اسم المورد',products.Pro_name as'اسم المنتج',[Date] as'تاريخ الفاتوره',[buy_datails].[Qty] as'الكميه',[unit_name]as'الوحدة',[User_name] as'اسم المستخدم',[price] as'السعر قبل الضريبة',buy_datails.tax_value as'الضريبة',[price_tax]as'السعر بعد الضريبة',[discound] as'الخصم',[total] as'اجمالي الصنف',[TotalOrder] as'الاجمالي العام',[madfoo3] as'المدفوع',[Baky] as'المبلغ المتبقي'FROM [dbo].[buy_datails],supliers,products where supliers.sup_ID = [buy_datails].Sup_ID and products.Pro_ID = [buy_datails].Pro_ID and Order_ID ="+id+"", "");

            Frm_printing frm = new Frm_printing();
            frm.crystalReportViewer1.RefreshReport();
            if(Properties.Settings.Default.buyprintkind=="8cm")
            {
             RptOrderBuy rpt = new RptOrderBuy();


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

                rpt.PrintToPrinter(1, true, 0, 0);
                // frm.ShowDialog();

            }
            else if (Properties.Settings.Default.buyprintkind == "A4")
            {
                RptOrderBuyA4 rpt = new RptOrderBuyA4();


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

                rpt.PrintToPrinter(1, true, 0, 0);
                // frm.ShowDialog();
            }



        }
           private void UdateQty()
        {
              if (Dgv_buy.Rows.Count >= 1)
            {
                int index = Dgv_buy.SelectedRows[0].Index;

                Properties.Settings.Default.item_Qty = Convert.ToDecimal( Dgv_buy.Rows[index].Cells[3].Value);
                   Properties.Settings.Default.item_BuyPrice = Convert.ToDecimal(Dgv_buy.Rows[index].Cells[4].Value);
                   Properties.Settings.Default.item_Discount = Convert.ToDecimal(Dgv_buy.Rows[index].Cells[5].Value);
                Properties.Settings.Default.Pro_unit= Convert.ToString(Dgv_buy.Rows[index].Cells[2].Value);
                Properties.Settings.Default.Pro_ID = Convert.ToInt32(Dgv_buy.Rows[index].Cells[0].Value);
                Properties.Settings.Default.Save();


                frm_BuyQty frm = new frm_BuyQty();
                 frm.ShowDialog();
            }
        }
            private void frm_buy_KeyDown(object sender, KeyEventArgs e)
        {
               if (e.KeyCode == Keys.F12)
            {
                  PayOrder();
               } else if (e.KeyCode == Keys.F11)
            {
                  UdateQty();

                try
                {
                    int index =Dgv_buy.SelectedRows[0].Index;
                    Dgv_buy.Rows[index].Cells[2].Value = Properties.Settings.Default.Pro_unit;
                    Dgv_buy.Rows[index].Cells[3].Value = Properties.Settings.Default.item_Qty;
                    Dgv_buy.Rows[index].Cells[4].Value = Properties.Settings.Default.item_BuyPrice;
                    Dgv_buy.Rows[index].Cells[5].Value = Properties.Settings.Default.item_Discount;
                }
                catch (Exception) { }
            
        } else if (e.KeyCode == Keys.F1)
            {
                txt_parcode.Clear();
                txt_parcode.Focus();


            }
         else if (e.KeyCode == Keys.F2)
            {
                btn_items_Click(null, null);

            }
            else if (e.KeyCode == Keys.Delete)
            {
                btn_deleteitems_Click(null, null);
            }

        }
        //لما اغير الكميه دا بيحسبلي الاجمالي
           private void Dgv_buy_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
              decimal item_Qty = 0, item_BuyPrice = 0, item_Discount = 0;
              try
            {
    
                  int index =Dgv_buy.SelectedRows[0].Index;
                
                item_Qty = Convert.ToDecimal(Dgv_buy.Rows[index].Cells[3].Value);
                item_BuyPrice = Convert.ToDecimal(Dgv_buy.Rows[index].Cells[4].Value);
                item_Discount = Convert.ToDecimal(Dgv_buy.Rows[index].Cells[5].Value);

                decimal total = 0;
                total = (item_Qty * item_BuyPrice) - item_Discount;

                Dgv_buy.Rows[index].Cells[6].Value = total;



                decimal totalorder = 0;

                for (int i = 0; i <= Dgv_buy.Rows.Count - 1; i++)
                {
                    totalorder += Convert.ToDecimal(Dgv_buy.Rows[i].Cells[6].Value);


                }
                txt_total.Text = Math.Round(totalorder, 2).ToString();

            }
            catch (Exception) { }
        }

        private void frm_buy_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_buy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }
    }
}