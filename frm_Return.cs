using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
//استدعاء مكتبة فيجوال بيسك
using Microsoft.VisualBasic;
using DevExpress.XtraEditors;

namespace sales
{
    public partial class frm_Return : DevExpress.XtraEditors.XtraForm
    {
        public frm_Return()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();
        private void fillstore()
        {
            cbx_store1.DataSource = db.readData("select * from store", "");
            cbx_store1.DisplayMember = "store_Name";
            cbx_store1.ValueMember = "store_ID";

            cbx_store2.DataSource = db.readData("select * from store", "");
            cbx_store2.DisplayMember = "store_Name";
            cbx_store2.ValueMember = "store_ID";


        }
        string stock_ID = "";
        private void frm_Return_Load(object sender, EventArgs e)
        {
            if (rbtn_sale.Checked == true)
            {
                lbl_name1.Text = "اسم العميل :";
            }
            else
            {
                lbl_name1.Text = "اسم المورد :";
            }
            dtp_date.Text = DateTime.Now.ToShortDateString();

            fillstore();

            stock_ID =Convert.ToString (Properties.Settings.Default.stock_id);
        }
        private void salesReturn()
        {

            tbl.Clear();
            tbl = db.readData("SELECT [Order_ID]as'رقم الفاتوره',[Cus_name]as'اسم العميل',products.[Pro_name]as'المنتج',sales_details.[Qty]as'الكميه',unit as 'الوحدة',price as'السعر قبل الضريبة',sales_details.tax_value *sales_details.Qty as'الضريبة',[price_tax]as' السعر شامل الضريبة',[discound]as'الخصم',[total]as'الاجمالي',[TotalOrder]as'اجمالي الفاتوره',[madfoo3]as'المبلغ المدفوع',[Baky]as'المتبقي',[User_name]as'الكاشير',[Date]as'التاريخ' FROM [dbo].[sales_details],products where products.Pro_ID =sales_details.Pro_ID and Order_ID=" + txt_id.Text + " ", "");
            Dgv_search.DataSource = tbl;

            //عندما تريد القرائه من الصف بنفسه
            //decimal bakyDB = 0;
            //try
            //{
            //    bakyDB = Convert.ToDecimal(db.readData("select Baky from sales_details where Order_ID =" + txt_id.Text + " ", "").Rows[0][0]);

            //}
            //catch (Exception){ }
            if (Dgv_search.Rows.Count >= 1)
            {
                try
                {
                    decimal totalorder = 0, totalMadfou3 = 0, baky = 0, taxvalue = 0, totalaftertax = 0;
                    for (int i = 0; i <= Dgv_search.Rows.Count - i; i++)
                    {
                        totalorder += Convert.ToDecimal(Dgv_search.Rows[i].Cells[9].Value) - Convert.ToDecimal(Dgv_search.Rows[i].Cells[6].Value);
                        taxvalue += Convert.ToDecimal(Dgv_search.Rows[i].Cells[6].Value);
                        totalaftertax += Convert.ToDecimal(Dgv_search.Rows[i].Cells[9].Value);

                    }
                    totalMadfou3 = Convert.ToDecimal(Dgv_search.Rows[0].Cells[9].Value);
                    txt_totalorder.Text = Convert.ToString(Math.Round(totalorder, 2));
                    txt_madfou3.Text = (Math.Round(totalMadfou3, 2)).ToString();
                    txt_totaltax.Text = (Math.Round(taxvalue, 2)).ToString();
                    txt_totalaftertax.Text = (Math.Round(totalaftertax, 2)).ToString();
                    baky = totalaftertax - totalMadfou3;
                    txt_baky.Text = (Math.Round(baky, 2)).ToString();
                    resetCustsup();
                }
                catch (Exception) { }
            }
        }
        private void buyReturn()
        {

            tbl.Clear();
            tbl = db.readData("SELECT [Order_ID] as'رقم الفاتوره',supliers.sup_Name as 'اسم المورد',products.Pro_name as'اسم المنتج',[Date] as'تاريخ الفاتوره',[buy_datails].[Qty] as'الكميه',[unit_name]as'الوحدة',[User_name] as'اسم المستخدم',[price] as'السعر قبل الضريبة',buy_datails.tax_value * [buy_datails].[Qty] as'الضريبة',[price_tax]as'السعر بعد الضريبة',[discound] as'الخصم',[total] as'اجمالي الصنف',[TotalOrder] as'الاجمالي العام',[madfoo3] as'المدفوع',[Baky] as'المبلغ المتبقي'FROM [dbo].[buy_datails],supliers,products where supliers.sup_ID = [buy_datails].Sup_ID and products.Pro_ID = [buy_datails].Pro_ID and Order_ID =" + txt_id.Text + " ", "");
            Dgv_search.DataSource = tbl;

            //عندما تريد القرائه من الصف بنفسه
            //decimal bakyDB = 0;
            //try
            //{
            //    bakyDB = Convert.ToDecimal(db.readData("select Baky from sales_details where Order_ID =" + txt_id.Text + " ", "").Rows[0][0]);

            //}
            //catch (Exception){ }
            if (Dgv_search.Rows.Count >= 1)
            {
                try
                {
                    decimal totalorder = 0, totalMadfou3 = 0, baky = 0,taxvalue = 0,totalaftertax = 0;
                    for (int i = 0; i <= Dgv_search.Rows.Count - i; i++)
                    {
                        totalorder += Convert.ToDecimal(Dgv_search.Rows[i].Cells[11].Value) - Convert.ToDecimal(Dgv_search.Rows[i].Cells[8].Value);
                        taxvalue += Convert.ToDecimal(Dgv_search.Rows[i].Cells[8].Value);
                        totalaftertax += Convert.ToDecimal(Dgv_search.Rows[i].Cells[11].Value);

                    }
                    totalMadfou3 = Convert.ToDecimal(Dgv_search.Rows[0].Cells[13].Value);
                    txt_totalorder.Text = Convert.ToString(Math.Round(totalorder, 2));
                    txt_madfou3.Text = (Math.Round(totalMadfou3, 2)).ToString();
                    txt_totaltax.Text = (Math.Round(taxvalue, 2)).ToString();
                    txt_totalaftertax.Text= (Math.Round(totalaftertax, 2)).ToString();
                    baky = totalaftertax - totalMadfou3;
                    txt_baky.Text = (Math.Round(baky, 2)).ToString();
                    resetCustsup();
                }
                catch (Exception) { }
            }
        }
        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txt_id.Text == "")
                {
                    MessageBox.Show("من فضلك ادخل رقم الفاتوره", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (rbtn_sale.Checked == true)
                {
                    salesReturn();
                }
                else if (rbtn_buy.Checked == true)
                {
                    buyReturn();
                }


            }
        }

        private void rbtn_sale_CheckedChanged(object sender, EventArgs e)
        {
            resetCustsup();
        }

        private void rbtn_buy_CheckedChanged(object sender, EventArgs e)
        {

            resetCustsup();
        }
        private void onLoadscreen()
        {
            tbl.Clear();
            Dgv_search.DataSource = tbl;
            txt_baky.Clear();
            txt_madfou3.Clear();
            txt_totalorder.Clear();
            txt_id.Clear();
            txt_name1.Clear();
            txt_name2.Clear();
            txt_id.Focus();
            txt_madfou3.Text = "0";
            txt_baky.Text = "0";
            rbtn_sale.Checked = true;
        }
        private void resetCustsup()
        {
            if (rbtn_sale.Checked == true)
            {
                lbl_name1.Text = "اسم العميل :";
                lbl_name2.Text = "اسم العميل :";
            }
            else
            {
                lbl_name1.Text = "اسم المورد :";
                lbl_name2.Text = "اسم المورد :";
            }
        }
        //عند ارجاع فاتورة مبيعات كامله
        string d = "";

        private void returnAllsales()
        {
            DataTable tblstock = new DataTable();
            d = dtp_date.Value.ToString("dd/MM/yyyy");
            if (txt_name1.Text == "") { MessageBox.Show("من فضلك ادخل اسم العميل", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            //لادخال الاموال في الخزنه
            decimal stock_money = 0;
            tblstock.Clear();
            tblstock = db.readData("select * from stock where stock_ID = " + stock_ID + "", "");
            stock_money = Convert.ToDecimal(tblstock.Rows[0][1]);

            if (Convert.ToDecimal(txt_totalaftertax.Text) > stock_money)
            {

                MessageBox.Show("المبلغ الموجود في الخزنه غر كافي لاجراء العمليه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }


            db.excetedate("delete from sales where order_ID =" + Dgv_search.CurrentRow.Cells[0].Value + "", "");
            db.excetedate("delete from sales_details where order_ID =" + Dgv_search.CurrentRow.Cells[0].Value + "", "");
            db.excetedate("delete from sales_Rb7h where order_ID =" + Dgv_search.CurrentRow.Cells[0].Value + "", "");


            //تدخيل البيانات في جدول المرتجعات

            db.excetedate("insert into returns (Ordear_Date , Order_Type) values('" + d + "',N'مرتجعات مبيعات')", "");
            int id = 1;
            try
            {
                id = Convert.ToInt32(db.readData("select max(order_ID) from returns", "").Rows[0][0]);
            }
            catch (Exception) { }

            decimal totaltax = 0;
            //تدخيل البيانات في جدول تفاصيل المرتجعات
            for (int i = 0; i <= Dgv_search.Rows.Count - i; i++)
            {
              
                db.excetedate("insert into returns_details values (" + id + ",N'',N'" + txt_name1.Text + "',N'" + Dgv_search.Rows[i].Cells[2].Value + "',N'" + d + "'," + Dgv_search.Rows[i].Cells[3].Value + "," + Dgv_search.Rows[i].Cells[5].Value + ", " + Dgv_search.Rows[i].Cells[9].Value + ",N'"+Properties.Settings.Default.usernane+"'," + txt_totalaftertax.Text + "," + txt_madfou3.Text + "," + txt_baky.Text + ","+txt_totaltax.Text+"," + Dgv_search.Rows[i].Cells[7].Value + ",N'" + Dgv_search.Rows[i].Cells[4].Value + "')", "");
                int Pro_id = 1;
                try
                {
                    Pro_id = Convert.ToInt32(db.readData("select Pro_ID from products where Pro_name =N'" + Dgv_search.Rows[i].Cells[2].Value + "'", "").Rows[0][0]);
                }
                catch (Exception) { }
                decimal Qtyinmain = 0, realQty = 0;
                  DataTable tblunit = new DataTable();
                  tblunit.Clear();

                tblunit = db.readData("select * from product_unit where Pro_ID=" + Pro_id + "and unit_Name=N'" + Dgv_search.Rows[i].Cells[4].Value + "'", "");
                try
                {
                    Qtyinmain = Convert.ToDecimal(tblunit.Rows[0][3]);
                }
                catch (Exception) { }
               
                    realQty = Convert.ToDecimal( Dgv_search.Rows[i].Cells[3].Value ) / Qtyinmain;

             db.excetedate("update products set Qty=Qty + " + realQty + " where Pro_ID =" + Pro_id + " ", "");

                DataTable tblQty = new DataTable();
                tblQty.Clear();
                tblQty = db.readData("select top 1 * from products_Qty where Pro_ID = "+Pro_id+" and store_ID = "+cbx_store1.SelectedValue+"", "");

                if (tblQty.Rows.Count >= 1)
                {
                    db.excetedate("update products_Qty set Qty=Qty + " + realQty + " where Pro_ID= " + Pro_id + " and store_ID = " + cbx_store1.SelectedValue + " and Qty = " + tblQty.Rows[0][3] + "and Buy_price =" + tblQty.Rows[0][4] + " ", "");
                }
                else
                {
                    tblQty.Clear();
                    tblQty = db.readData("select top 1 * from products_Qty where Pro_ID = " + Pro_id + " ", "");
                    if (tblQty.Rows.Count >= 1)
                    {
                        db.excetedate("insert into products_Qty values(" + Pro_id + "," + cbx_store1.SelectedValue + ",N'" + cbx_store1.Text + "'," + realQty + "," + tblQty.Rows[0][4] + "," + Dgv_search.Rows[i].Cells[7].Value + ")", "");
                    }
                    else
                    {//لجعل المستخدم يضع قيمة بنفسه
                        string buyprice = Microsoft.VisualBasic.Interaction.InputBox(" ادخل سعر الشراء للمنتج "+(Dgv_search.Rows[i].Cells[2].Value),"سعر الشراء","من فضلك ادخل السعر هنا",1,1);
                        db.excetedate("insert into products_Qty values(" + Pro_id + "," + cbx_store1.SelectedValue + ",N'" + cbx_store1.Text + "'," + realQty + "," + buyprice + "," + Dgv_search.Rows[i].Cells[7].Value + ")", "");
                    }
                }
                totaltax += Convert.ToDecimal(Dgv_search.Rows[i].Cells[5].Value);
            }

            db.excetedate("insert into stock_pull (stock_ID ,Mony ,Date ,Name ,Type ,Reason) values (" + stock_ID + "," + txt_totalaftertax.Text + ",N'" + d + "',N'"+Properties.Settings.Default.usernane+"' ,N' مرتجعات مبيعات',N'')", "");
            db.excetedate("update stock set Mony=Mony - " + txt_totalaftertax.Text + "where stock_ID = " + stock_ID + "", "");

            decimal totalbeforetax = 0;
            totalbeforetax = Convert.ToDecimal(txt_totalaftertax.Text) - totaltax;
            db.excetedate("insert into taxes_Report (Order_Num,Order_Type,tax_type,sup_name,cust_name,total_order,total_tax,total_Aftertax,date)values(" + Convert.ToDecimal(Dgv_search.CurrentRow.Cells[0].Value) + ", N' مرتجعات مبيعات',N'قيمة مضافة',N'لا يوجد',N'" + txt_name1.Text + "'," + totaltax + "," + totalbeforetax + "," + txt_totalaftertax.Text + ",N'" + d + "')", "");




            MessageBox.Show("تمت عملية الارجاع بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            onLoadscreen();


        }
        //عند ارجاع فاتورة مشتريات كامله
        private void returnAllBuy()
        {
            d = dtp_date.Value.ToString("dd/MM/yyyy");
            if (txt_name1.Text == "") { MessageBox.Show("من فضلك ادخل اسم المورد", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            db.excetedate("delete from buy where order_ID =" + Dgv_search.CurrentRow.Cells[0].Value + "", "");
            db.excetedate("delete from buy_datails where order_ID =" + Dgv_search.CurrentRow.Cells[0].Value + "", "");

            //تدخيل البيانات في جدول تفاصيل المرتجعات
            db.excetedate("insert into returns (Ordear_Date , Order_Type) values('" + d + "',N'مرتجعات مشتريات')", "");



            int id = 1;
            try
            {
                id = Convert.ToInt32(db.readData("select max(order_ID) from returns", "").Rows[0][0]);
            }
            catch (Exception) { }
            decimal totaltax = 0;
            for (int i = 0; i <= Dgv_search.Rows.Count - i; i++)
            {

                db.excetedate("insert into returns_details values (" + id + ",N'" + txt_name1.Text + "',N'',N'" + Dgv_search.Rows[i].Cells[2].Value + "',N'" + d + "'," + Dgv_search.Rows[i].Cells[3].Value + "," + Dgv_search.Rows[i].Cells[6].Value + ", " + Dgv_search.Rows[i].Cells[10].Value + ",N'" + Properties.Settings.Default.usernane + "'," + txt_totalaftertax.Text + "," + txt_madfou3.Text + "," + txt_baky.Text + "," + txt_totaltax.Text + "," + Dgv_search.Rows[i].Cells[8].Value + ",N'" + Dgv_search.Rows[i].Cells[4].Value + "')", "");
                int Proid = 1;
                try
                {
                    Proid = Convert.ToInt32(db.readData("select Pro_ID from products where Pro_name =N'" + Dgv_search.Rows[i].Cells[2].Value + "'", "").Rows[0][0]);
                }
                catch (Exception) { }

                decimal Qtyinmain = 0, realQty = 0;
                DataTable tblunit = new DataTable();
                tblunit.Clear();

                tblunit = db.readData("select * from product_unit where Pro_ID=" + Proid + "and unit_Name=N'" + Dgv_search.Rows[i].Cells[5].Value + "'", "");
                try
                {
                    Qtyinmain = Convert.ToDecimal(tblunit.Rows[0][3]);
                }
                catch (Exception) { }

                realQty = Convert.ToDecimal(Dgv_search.Rows[i].Cells[4].Value) / Qtyinmain;

              

                //تعديل الكميه في المخزن
                db.excetedate("update products set Qty=Qty - " + realQty+ " where Pro_ID =" + Proid + " ", "");

                DataTable tblQty = new DataTable();
                tblQty.Clear();
                tblQty = db.readData("select * from products_Qty where Pro_ID = " + Proid + "and store_ID=" + cbx_store1.SelectedValue + "", "");
                decimal def = 0;
                def = Convert.ToDecimal(tblQty.Rows[0][3]) - realQty;

                if (def < 0)
                {
                    MessageBox.Show("الكمية المراد ارجاعها غير موجوده في المخزن", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    db.excetedate("update products_Qty set Qty=Qty - " + realQty + " where Pro_ID= " + Proid + " and store_ID = " + cbx_store1.SelectedValue + " and Qty = " + tblQty.Rows[0][3] + "and Buy_price =" + tblQty.Rows[0][4] + " ", "");

                }
                totaltax += Convert.ToDecimal(Dgv_search.Rows[i].Cells[8].Value);
            }


           
         

            db.excetedate("insert into stock_insert (stock_ID ,Mony ,Date ,Name ,Type ,Reason) values (" + stock_ID + "," + txt_totalaftertax.Text + ",N'" + d + "',N'" + Properties.Settings.Default.usernane + "' ,N' مرتجعات مشتريات',N'')", "");
            db.excetedate("update stock set Mony=Mony + " + txt_totalaftertax.Text + "where stock_ID = " + stock_ID + "", "");


            decimal totalbeforetax = 0;
            totalbeforetax = Convert.ToDecimal(txt_totalaftertax.Text) - totaltax;
            db.excetedate("insert into taxes_Report (Order_Num,Order_Type,tax_type,sup_name,cust_name,total_order,total_tax,total_Aftertax,date)values(" + Convert.ToDecimal(Dgv_search.CurrentRow.Cells[0].Value) + ", N' مرتجعات مشتريات',N'قيمة مضافة',N'" + txt_name1.Text + "',N'لا يوجد'," + totalbeforetax + "," + totaltax + "," + txt_totalaftertax.Text + ",N'" + d + "')", "");



            MessageBox.Show("تمت عملية الارجاع بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            onLoadscreen();
        }
        private void btn_returnAll_Click(object sender, EventArgs e)
        {
            if (Dgv_search.Rows.Count >= 1)
            {

                if (rbtn_sale.Checked == true)
                {
                    returnAllsales();

                }
                else if (rbtn_buy.Checked == true)
                {
                    returnAllBuy();
                }
            }
        }
        //عندما يقرر المستخدم ارجاع صنف واحد فقط في المبيعات
        private void returnItemsaleOnly()
        {
            DataTable tblstock = new DataTable();
            d = dtp_date.Value.ToString("dd/MM/yyyy");
            if (txt_name2.Text == "") { MessageBox.Show("من فضلك ادخل اسم العميل", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            //لادخال الاموال في الخزنه
            decimal stock_money = 0;
            tblstock.Clear();
            tblstock = db.readData("select * from stock where stock_ID = " + stock_ID + "", "");
            stock_money = Convert.ToDecimal(tblstock.Rows[0][1]);

            if (Convert.ToDecimal(Dgv_search.CurrentRow.Cells[9].Value) > stock_money)
            {

                MessageBox.Show("المبلغ الموجود في الخزنه غر كافي لاجراء العمليه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
               int Pro_id = 1;
                            try
                            {
                                Pro_id = Convert.ToInt32(db.readData("select Pro_ID from products where Pro_name =N'" + Dgv_search.CurrentRow.Cells[2].Value + "'", "").Rows[0][0]);
                            }
                            catch (Exception) { }

            db.excetedate("delete from sales_details where order_ID =" + Dgv_search.CurrentRow.Cells[0].Value + "and Pro_ID ="+Pro_id+ "and Qty =" + Dgv_search.CurrentRow.Cells[3].Value + "and total =" + Dgv_search.CurrentRow.Cells[9].Value + "", "");
            db.excetedate("delete from sales_Rb7h where order_ID =" + Dgv_search.CurrentRow.Cells[0].Value + "and Pro_ID ="+Pro_id+ "and Qty =" + Dgv_search.CurrentRow.Cells[3].Value + "and total =" + Dgv_search.CurrentRow.Cells[9].Value + "", "");


            //تدخيل البيانات في جدول المرتجعات

            db.excetedate("insert into returns (Ordear_Date , Order_Type) values('" + d + "',N'مرتجعات مبيعات')", "");
            int id = 1;
            try
            {
                id = Convert.ToInt32(db.readData("select max(order_ID) from returns", "").Rows[0][0]);
            }
            catch (Exception) { }
            //تدخيل البيانات في جدول تفاصيل المرتجعات
           

                db.excetedate("insert into returns_details values (" + id + ",N'',N'" + txt_name1.Text + "',N'" + Dgv_search.CurrentRow.Cells[2].Value + "',N'" + d + "'," + Dgv_search.CurrentRow.Cells[3].Value + "," + Dgv_search.CurrentRow.Cells[5].Value + ", " + Dgv_search.CurrentRow.Cells[9].Value + ",N'" + Properties.Settings.Default.usernane + "'," + txt_totalaftertax.Text + "," + txt_madfou3.Text + "," + txt_baky.Text + "," + txt_totaltax.Text + "," + Dgv_search.CurrentRow.Cells[7].Value + ",N'" + Dgv_search.CurrentRow.Cells[4].Value + "')", "");
             
                decimal Qtyinmain = 0, realQty = 0, totaltax=0;
                DataTable tblunit = new DataTable();
                tblunit.Clear();

                tblunit = db.readData("select * from product_unit where Pro_ID=" + Pro_id + "and unit_Name=N'" + Dgv_search.CurrentRow.Cells[4].Value + "'", "");
                try
                {
                    Qtyinmain = Convert.ToDecimal(tblunit.Rows[0][3]);
                }
                catch (Exception) { }

                realQty = Convert.ToDecimal(Dgv_search.CurrentRow.Cells[3].Value) / Qtyinmain;

                db.excetedate("update products set Qty=Qty + " + realQty + " where Pro_ID =" + Pro_id + " ", "");

                DataTable tblQty = new DataTable();
                tblQty.Clear();
                tblQty = db.readData("select top 1 * from products_Qty where Pro_ID = " + Pro_id + " and store_ID = " + cbx_store2.SelectedValue + "", "");

                if (tblQty.Rows.Count >= 1)
                {
                    db.excetedate("update products_Qty set Qty=Qty + " + realQty + " where Pro_ID= " + Pro_id + " and store_ID = " + cbx_store2.SelectedValue + " and Qty = " + tblQty.Rows[0][3] + "and Buy_price =" + tblQty.Rows[0][4] + " ", "");
                }
                else
                {
                    tblQty.Clear();
                    tblQty = db.readData("select top 1 * from products_Qty where Pro_ID = " + Pro_id + " ", "");
                    if (tblQty.Rows.Count >= 1)
                    {
                        db.excetedate("insert into products_Qty values(" + Pro_id + "," + cbx_store2.SelectedValue + ",N'" + cbx_store2.Text + "'," + realQty + "," + tblQty.Rows[0][4] + "," + Dgv_search.CurrentRow.Cells[7].Value + ")", "");
                    }
                    else
                    {//لجعل المستخدم يضع قيمة بنفسه
                        string buyprice = Microsoft.VisualBasic.Interaction.InputBox(" ادخل سعر الشراء للمنتج " + (Dgv_search.CurrentRow.Cells[2].Value), "سعر الشراء", "من فضلك ادخل السعر هنا", 1, 1);
                        db.excetedate("insert into products_Qty values(" + Pro_id + "," + cbx_store2.SelectedValue + ",N'" + cbx_store1.Text + "'," + realQty + "," + buyprice + "," + Dgv_search.CurrentRow.Cells[7].Value + ")", "");
                    }
                }
            db.excetedate("insert into stock_pull (stock_ID ,Mony ,Date ,Name ,Type ,Reason) values (" + stock_ID + "," + Dgv_search.CurrentRow.Cells[9].Value + ",N'" + d + "',N'" + Properties.Settings.Default.usernane + "' ,N' مرتجعات مبيعات',N'')", "");
            db.excetedate("update stock set Mony=Mony - " + Dgv_search.CurrentRow.Cells[9].Value + "where stock_ID = " + stock_ID + "", "");
            totaltax = Convert.ToDecimal(Dgv_search.CurrentRow.Cells[6].Value);

            decimal totalbeforetax = 0,totalitem=0;
            totalitem= Convert.ToDecimal(Dgv_search.CurrentRow.Cells[3].Value)* Convert.ToDecimal(Dgv_search.CurrentRow.Cells[7].Value);
            totalbeforetax = Convert.ToDecimal(totalitem) - totaltax;
            db.excetedate("insert into taxes_Report (Order_Num,Order_Type,tax_type,sup_name,cust_name,total_order,total_tax,total_Aftertax,date)values(" + Convert.ToDecimal(Dgv_search.CurrentRow.Cells[0].Value) + ", N' مرتجعات مبيعات',N'قيمة مضافة',N'لا يوجد',N'" + txt_name2.Text + "'," + totalbeforetax + "," + totaltax + "," + totalitem + ",N'" + d + "')", "");




            MessageBox.Show("تمت عملية الارجاع بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            onLoadscreen();
        }

            //عندما يقرر المستخدم ارجاع صنف واحد فقط في المشتريات

        private void returnItemBuyOnly()
        {

            d = dtp_date.Value.ToString("dd/MM/yyyy");
            if (txt_name2.Text == "") { MessageBox.Show("من فضلك ادخل اسم المورد", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            int Proid = 1;
            try
            {
                Proid = Convert.ToInt32(db.readData("select Pro_ID from products where Pro_name =N'" + Dgv_search.CurrentRow.Cells[2].Value + "'", "").Rows[0][0]);
            }
            catch (Exception) { }


            db.excetedate("delete from buy_datails where order_ID =" + Dgv_search.CurrentRow.Cells[0].Value + "and Pro_ID=" + Proid + "and Qty = " + Dgv_search.CurrentRow.Cells[4].Value + "and total =" + Dgv_search.CurrentRow.Cells[11].Value + "and tax_value = " + Dgv_search.CurrentRow.Cells[8].Value + "", "");

            //تدخيل البيانات في جدول تفاصيل المرتجعات
            db.excetedate("insert into returns (Ordear_Date , Order_Type) values('" + d + "',N'مرتجعات مشتريات')", "");



            int id = 1;
            try
            {
                id = Convert.ToInt32(db.readData("select max(order_ID) from returns", "").Rows[0][0]);
            }
            catch (Exception) { }



            db.excetedate("insert into returns_details values (" + id + ",N'" + txt_name2.Text + "',N'',N'" + Dgv_search.CurrentRow.Cells[2].Value + "',N'" + d + "'," + Dgv_search.CurrentRow.Cells[3].Value + "," + Dgv_search.CurrentRow.Cells[6].Value + ", " + Dgv_search.CurrentRow.Cells[10].Value + ",N'" + Properties.Settings.Default.usernane + "'," + txt_totalaftertax.Text + "," + txt_madfou3.Text + "," + txt_baky.Text + "," + txt_totaltax.Text + "," + Dgv_search.CurrentRow.Cells[8].Value + ",N'" + Dgv_search.CurrentRow.Cells[4].Value + "')", "");

            decimal Qtyinmain = 0, realQty = 0;
            DataTable tblunit = new DataTable();
            tblunit.Clear();

            tblunit = db.readData("select * from product_unit where Pro_ID=" + Proid + "and unit_Name=N'" + Dgv_search.CurrentRow.Cells[5].Value + "'", "");
            try
            {
                Qtyinmain = Convert.ToDecimal(tblunit.Rows[0][3]);
            }
            catch (Exception) { }

            realQty = Convert.ToDecimal(Dgv_search.CurrentRow.Cells[4].Value) / Qtyinmain;



            //تعديل الكميه في المخزن
            db.excetedate("update products set Qty=Qty - " + realQty + " where Pro_ID =" + Proid + " ", "");

            DataTable tblQty = new DataTable();
            tblQty.Clear();
            tblQty = db.readData("select * from products_Qty where Pro_ID = " + Proid + "and store_ID=" + cbx_store2.SelectedValue + "", "");
            decimal def = 0;
            def = Convert.ToDecimal(tblQty.Rows[0][3]) - realQty;

            if (def < 0)
            {
                MessageBox.Show("الكمية المراد ارجاعها غير موجوده في المخزن", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                db.excetedate("update products_Qty set Qty=Qty - " + realQty + " where Pro_ID= " + Proid + " and store_ID = " + cbx_store2.SelectedValue + " and Qty = " + tblQty.Rows[0][3] + "and Buy_price =" + tblQty.Rows[0][4] + " ", "");

            }
            db.excetedate("insert into stock_insert (stock_ID ,Mony ,Date ,Name ,Type ,Reason) values (" + stock_ID + "," + Dgv_search.CurrentRow.Cells[11].Value + ",N'" + d + "',N'" + Properties.Settings.Default.usernane + "' ,N' مرتجعات مشتريات',N'')", "");
            db.excetedate("update stock set Mony=Mony + " + Dgv_search.CurrentRow.Cells[11].Value + "where stock_ID = " + stock_ID + "", "");

            decimal totaltax = 0;

            totaltax = Convert.ToDecimal(Dgv_search.CurrentRow.Cells[6].Value);

            decimal totalbeforetax = 0, totalitem = 0;
            totalitem = Convert.ToDecimal(Dgv_search.CurrentRow.Cells[3].Value) * Convert.ToDecimal(Dgv_search.CurrentRow.Cells[7].Value);
            totalbeforetax = Convert.ToDecimal(totalitem) - totaltax;
            db.excetedate("insert into taxes_Report (Order_Num,Order_Type,tax_type,sup_name,cust_name,total_order,total_tax,total_Aftertax,date)values(" + Convert.ToDecimal(Dgv_search.CurrentRow.Cells[0].Value) + ", N' مرتجعات مبيعات',N'قيمة مضافة',N'لا يوجد',N'" + txt_name2.Text + "'," + totalbeforetax + "," + totaltax + "," + totalitem + ",N'" + d + "')", "");



            MessageBox.Show("تمت عملية الارجاع بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            onLoadscreen();



        }

        private void returnQtysaleOnly()
        {



            DataTable tblstock = new DataTable();
            d = dtp_date.Value.ToString("dd/MM/yyyy");
            if (txt_name2.Text == "") { MessageBox.Show("من فضلك ادخل اسم العميل", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            //لادخال الاموال في الخزنه
            decimal stock_money = 0;
            tblstock.Clear();
            tblstock = db.readData("select * from stock where stock_ID = " + stock_ID + "", "");
            stock_money = Convert.ToDecimal(tblstock.Rows[0][1]);

            if ((Convert.ToDecimal(Dgv_search.CurrentRow.Cells[7].Value) * nud_Qty.Value) > stock_money)
            {

                MessageBox.Show("المبلغ الموجود في الخزنه غر كافي لاجراء العمليه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            int Pro_id = 1;
            try
            {
                Pro_id = Convert.ToInt32(db.readData("select Pro_ID from products where Pro_name =N'" + Dgv_search.CurrentRow.Cells[2].Value + "'", "").Rows[0][0]);
            }
            catch (Exception) { }

            decimal Qtyinmain = 0, realQty = 0;
            DataTable tblunit = new DataTable();
            tblunit.Clear();

            tblunit = db.readData("select * from product_unit where Pro_ID=" + Pro_id + "and unit_Name=N'" + Dgv_search.CurrentRow.Cells[4].Value + "'", "");
            try
            {
                Qtyinmain = Convert.ToDecimal(tblunit.Rows[0][3]);
            }
            catch (Exception) { }

            realQty =nud_Qty.Value / Qtyinmain;

            if ((Convert.ToDecimal(Dgv_search.CurrentRow.Cells[3].Value) - nud_Qty.Value) <= 0)
            {
                MessageBox.Show("الكمية المراد ارجاعها اكبر من الكمية التي تم بيعها", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            db.excetedate("update sales_details set Qty=Qty - "+realQty+" where order_ID =" + Dgv_search.CurrentRow.Cells[0].Value + "and Pro_ID =" + Pro_id + "and Qty =" + Dgv_search.CurrentRow.Cells[3].Value + "and total =" + Dgv_search.CurrentRow.Cells[9].Value + "", "");
            db.excetedate("update sales_Rb7h set Qty=Qty - " + realQty + " where order_ID =" + Dgv_search.CurrentRow.Cells[0].Value + "and Pro_ID =" + Pro_id + "and Qty =" + Dgv_search.CurrentRow.Cells[3].Value + "and total =" + Dgv_search.CurrentRow.Cells[9].Value + "", "");


            //تدخيل البيانات في جدول المرتجعات

            db.excetedate("insert into returns (Ordear_Date , Order_Type) values('" + d + "',N'مرتجعات مبيعات')", "");
            int id = 1;
            try
            {
                id = Convert.ToInt32(db.readData("select max(order_ID) from returns", "").Rows[0][0]);
            }
            catch (Exception) { }
            //تدخيل البيانات في جدول تفاصيل المرتجعات


            db.excetedate("insert into returns_details values (" + id + ",N'',N'" + txt_name2.Text + "',N'" +realQty + "',N'" + d + "'," + Dgv_search.CurrentRow.Cells[3].Value + "," + Dgv_search.CurrentRow.Cells[5].Value + ", " + Dgv_search.CurrentRow.Cells[9].Value + ",N'" + Properties.Settings.Default.usernane + "'," + txt_totalaftertax.Text + "," + txt_madfou3.Text + "," + txt_baky.Text + "," + txt_totaltax.Text + "," + Dgv_search.CurrentRow.Cells[7].Value + ",N'" + Dgv_search.CurrentRow.Cells[4].Value + "')", "");

          

            db.excetedate("update products set Qty=Qty + " + realQty + " where Pro_ID =" + Pro_id + " ", "");

            DataTable tblQty = new DataTable();
            tblQty.Clear();
            tblQty = db.readData("select top 1 * from products_Qty where Pro_ID = " + Pro_id + " and store_ID = " + cbx_store2.SelectedValue + "", "");

            if (tblQty.Rows.Count >= 1)
            {
                db.excetedate("update products_Qty set Qty=Qty + " + realQty + " where Pro_ID= " + Pro_id + " and store_ID = " + cbx_store2.SelectedValue + " and Qty = " + tblQty.Rows[0][3] + "and Buy_price =" + tblQty.Rows[0][4] + " ", "");
            }
            else
            {
                tblQty.Clear();
                tblQty = db.readData("select top 1 * from products_Qty where Pro_ID = " + Pro_id + " ", "");
                if (tblQty.Rows.Count >= 1)
                {
                    db.excetedate("insert into products_Qty values(" + Pro_id + "," + cbx_store2.SelectedValue + ",N'" + cbx_store2.Text + "'," + realQty + "," + tblQty.Rows[0][4] + "," + Dgv_search.CurrentRow.Cells[7].Value + ")", "");
                }
                else
                {//لجعل المستخدم يضع قيمة بنفسه
                    string buyprice = Microsoft.VisualBasic.Interaction.InputBox(" ادخل سعر الشراء للمنتج " + (Dgv_search.CurrentRow.Cells[2].Value), "سعر الشراء", "من فضلك ادخل السعر هنا", 1, 1);
                    db.excetedate("insert into products_Qty values(" + Pro_id + "," + cbx_store2.SelectedValue + ",N'" + cbx_store1.Text + "'," + realQty + "," + buyprice + "," + Dgv_search.CurrentRow.Cells[7].Value + ")", "");
                }
            }

            db.excetedate("insert into stock_pull (stock_ID ,Mony ,Date ,Name ,Type ,Reason) values (" + stock_ID + "," + ((Convert.ToDecimal(Dgv_search.CurrentRow.Cells[7].Value) * nud_Qty.Value)) + ",N'" + d + "',N'" + Properties.Settings.Default.usernane + "' ,N' مرتجعات مبيعات',N'')", "");
            db.excetedate("update stock set Mony=Mony - " + ((Convert.ToDecimal(Dgv_search.CurrentRow.Cells[7].Value) * nud_Qty.Value)) + "where stock_ID = " + stock_ID + "", "");

            //insert into taxes report
            decimal totaltax = 0 , itemtax=0;
            itemtax= Convert.ToDecimal(Dgv_search.CurrentRow.Cells[6].Value)/ Convert.ToDecimal(Dgv_search.CurrentRow.Cells[3].Value);
            totaltax = itemtax * nud_Qty.Value;

            decimal totalbeforetax = 0, totalitem = 0;
            totalitem =nud_Qty.Value * Convert.ToDecimal(Dgv_search.CurrentRow.Cells[7].Value);
            totalbeforetax = Convert.ToDecimal(totalitem) - totaltax;
            db.excetedate("insert into taxes_Report (Order_Num,Order_Type,tax_type,sup_name,cust_name,total_order,total_tax,total_Aftertax,date)values(" + Convert.ToDecimal(Dgv_search.CurrentRow.Cells[0].Value) + ", N' مرتجعات مبيعات',N'قيمة مضافة',N'لا يوجد',N'" + txt_name2.Text + "'," + totalbeforetax + "," + totaltax + "," + totalitem + ",N'" + d + "')", "");



            MessageBox.Show("تمت عملية الارجاع بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            onLoadscreen();



        }
        private void returnQtyBuyOnly()
        {
            d = dtp_date.Value.ToString("dd/MM/yyyy");
            if (txt_name2.Text == "") { MessageBox.Show("من فضلك ادخل اسم المورد", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            int Proid = 1;
            try
            {
                Proid = Convert.ToInt32(db.readData("select Pro_ID from products where Pro_name =N'" + Dgv_search.CurrentRow.Cells[2].Value + "'", "").Rows[0][0]);
            }
            catch (Exception) { }


            decimal Qtyinmain = 0, realQty = 0;
            DataTable tblunit = new DataTable();
            tblunit.Clear();

            tblunit = db.readData("select * from product_unit where Pro_ID=" + Proid + "and unit_Name=N'" + Dgv_search.CurrentRow.Cells[5].Value + "'", "");
            try
            {
                Qtyinmain = Convert.ToDecimal(tblunit.Rows[0][3]);
            }
            catch (Exception) { }

            realQty = nud_Qty.Value ;

            if ((Convert.ToDecimal(Dgv_search.CurrentRow.Cells[4].Value) - nud_Qty.Value) <= 0)
            {
                MessageBox.Show("الكمية المراد ارجاعها اكبر من الكمية التي تم شرائها", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }

            db.excetedate("update buy_datails set Qty=Qty - " + realQty + " where order_ID =" + Dgv_search.CurrentRow.Cells[0].Value + "and Pro_ID =" + Proid + "and Qty =" + Dgv_search.CurrentRow.Cells[4].Value + "and total =" + Dgv_search.CurrentRow.Cells[11].Value + "", "");

            //تدخيل البيانات في جدول تفاصيل المرتجعات
            db.excetedate("insert into returns (Ordear_Date , Order_Type) values('" + d + "',N'مرتجعات مشتريات')", "");



            int id = 1;
            try
            {
                id = Convert.ToInt32(db.readData("select max(order_ID) from returns", "").Rows[0][0]);
            }
            catch (Exception) { }



            db.excetedate("insert into returns_details values (" + id + ",N'" + txt_name2.Text + "',N'',N'" + Dgv_search.CurrentRow.Cells[2].Value + "',N'" + d + "'," + realQty+ "," + Dgv_search.CurrentRow.Cells[7].Value + ", " + Dgv_search.CurrentRow.Cells[11].Value + ",N'" + Properties.Settings.Default.usernane + "'," + txt_totalaftertax.Text + "," + txt_madfou3.Text + "," + txt_baky.Text + "," + txt_totaltax.Text + "," + Dgv_search.CurrentRow.Cells[9].Value + ",N'" + Dgv_search.CurrentRow.Cells[5].Value + "')", "");

            DataTable tblunit2 = new DataTable();
            tblunit2.Clear();

            tblunit2 = db.readData("select * from product_unit where Pro_ID=" + Proid + "and unit_Name=N'" + Dgv_search.CurrentRow.Cells[5].Value + "'", "");
            try
            {
                Qtyinmain = Convert.ToDecimal(tblunit2.Rows[0][3]);
            }
            catch (Exception) { }

            realQty = nud_Qty.Value/Qtyinmain;

            //تعديل الكميه في المخزن
            db.excetedate("update products set Qty=Qty - " + realQty + " where Pro_ID =" + Proid + " ", "");

            DataTable tblQty = new DataTable();
            tblQty.Clear();
            tblQty = db.readData("select * from products_Qty where Pro_ID = " + Proid + "and store_ID=" + cbx_store2.SelectedValue + "", "");
            decimal def = 0;
            def = Convert.ToDecimal(tblQty.Rows[0][3]) - realQty;

            if (def < 0)
            {
                MessageBox.Show("الكمية المراد ارجاعها غير موجوده في المخزن", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                db.excetedate("update products_Qty set Qty=Qty - " + realQty + " where Pro_ID= " + Proid + " and store_ID = " + cbx_store2.SelectedValue + " and Qty = " + tblQty.Rows[0][3] + "and Buy_price =" + tblQty.Rows[0][4] + " ", "");

            }
            db.excetedate("insert into stock_insert (stock_ID ,Mony ,Date ,Name ,Type ,Reason) values (" + stock_ID + "," + ((Convert.ToDecimal(Dgv_search.CurrentRow.Cells[9].Value) * nud_Qty.Value)) + ",N'" + d + "',N'" + Properties.Settings.Default.usernane + "' ,N' مرتجعات مشتريات',N'')", "");
            db.excetedate("update stock set Mony=Mony + " + ((Convert.ToDecimal(Dgv_search.CurrentRow.Cells[9].Value) * nud_Qty.Value)) + "where stock_ID = " + stock_ID + "", "");



            //insert into taxes report
            decimal totaltax = 0, itemtax = 0;
            itemtax = Convert.ToDecimal(Dgv_search.CurrentRow.Cells[8].Value) / Convert.ToDecimal(Dgv_search.CurrentRow.Cells[4].Value);
            totaltax = itemtax * nud_Qty.Value;

            decimal totalbeforetax = 0, totalitem = 0;
            totalitem = nud_Qty.Value * Convert.ToDecimal(Dgv_search.CurrentRow.Cells[9].Value);
            totalbeforetax = Convert.ToDecimal(totalitem) - totaltax;
            db.excetedate("insert into taxes_Report (Order_Num,Order_Type,tax_type,sup_name,cust_name,total_order,total_tax,total_Aftertax,date)values(" + Convert.ToDecimal(Dgv_search.CurrentRow.Cells[0].Value) + ", N' مرتجعات مشتريات',N'قيمة مضافة',N'" + txt_name2.Text + "',N'لا يوجد'," + totalbeforetax + "," + totaltax + "," + totalitem + ",N'" + d + "')", "");




            MessageBox.Show("تمت عملية الارجاع بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

            onLoadscreen();


        }
        private void btn_itemOne_Click(object sender, EventArgs e)
        {
            if (Dgv_search.Rows.Count >= 1)
            {
                if (rbtn_retunitemOnly.Checked == true)
                {
                    if (rbtn_sale.Checked == true)
                    {
                        returnItemsaleOnly();
                    }
                    else if (rbtn_buy.Checked == true)
                    {
                        returnItemBuyOnly();
                    }
                }
                else if (rbtn_retunQtyOnly.Checked == true)
                {
                    if (rbtn_sale.Checked == true)
                    {
                        returnQtysaleOnly();
                    }
                    else if (rbtn_buy.Checked == true)
                    {
                 returnQtyBuyOnly();
                    
                    
                }
                }
            }
        }
    }
}