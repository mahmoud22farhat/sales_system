using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace sales
{
    public partial class frm_storetransfer : DevExpress.XtraEditors.XtraForm
    {
        public frm_storetransfer()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();
        private void fillproduct()
        {
            cbx_product.DataSource = db.readData("select * from products", "");
            cbx_product.DisplayMember = "Pro_name";
            cbx_product.ValueMember = "Pro_ID";
        }
        private void fillstorefrom()
        {
            cbx_storefrom.DataSource = db.readData("select * from store", "");
            cbx_storefrom.DisplayMember = "store_Name";
            cbx_storefrom.ValueMember = "store_ID";
        }
        private void fillstoreto()
        {
            cbx_storeto.DataSource = db.readData("select * from store", "");
            cbx_storeto.DisplayMember = "store_Name";
            cbx_storeto.ValueMember = "store_ID";
        }
        private void frm_storetransfer_Load(object sender, EventArgs e)
        {
            fillproduct();
            fillstorefrom();
            fillstoreto();
            dtp_date.Text = DateTime.Now.ToShortDateString();

        }
        private void txt_barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                if(txt_barcode.Text!="")
                {
                    tbl.Clear();
                    tbl = db.readData("select * from products where Barcode = N'" + txt_barcode.Text+"'", "");

                    if(tbl.Rows.Count>=1)
                    {
                        cbx_product.SelectedValue = Convert.ToDecimal(tbl.Rows[0][0]);
                    }
                }
            }                   
        }
        // انا عاوزه يعرض الوحدات بتاعة المنتج بعد ما اختار المنتج من السي بي اكس
        private void cbx_product_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbx_unite.DataSource = db.readData("select * from product_unit where Pro_ID = " + cbx_product.SelectedValue+"", "");
            cbx_unite.DisplayMember = "unit_Name";
            cbx_unite.ValueMember = "unit_ID";
        }
        private void updateqtyinstore(int pro_ID,decimal realQty)
        {
            DataTable tblQty = new DataTable();
            decimal Qtyinstorefirstrow = 0;

            db.excetedate("delete from products_Qty where Qty <= 0", "");

            tblQty.Clear();
            tblQty = db.readData("select top 1 * from products_Qty where Pro_ID="+pro_ID+"and store_ID="+cbx_storefrom.SelectedValue+"", "");

            Qtyinstorefirstrow = Convert.ToDecimal(tblQty.Rows[0][3]);
            if(Qtyinstorefirstrow - realQty>=1)
            {
                db.excetedate("update products_Qty set Qty=Qty - "+realQty+ "where Pro_ID =" + pro_ID+ " and store_ID=" + cbx_storefrom.SelectedValue+"and Qty = "+ Qtyinstorefirstrow + "and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");

            }
            else if(Qtyinstorefirstrow - realQty ==0)
            {
                //db.excetedate("delete products_Qty where Pro_ID =" + pro_ID + " and store_ID=" + cbx_storefrom.SelectedValue + "and Qty = 0 and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");
                db.excetedate("update products_Qty set Qty=Qty - " + realQty + "where Pro_ID =" + pro_ID + " and store_ID=" + cbx_storefrom.SelectedValue + "and Qty = " + Qtyinstorefirstrow + "and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");
                db.excetedate("delete products_Qty where Qty <=0", "");
            }
            else if(Qtyinstorefirstrow - realQty <0)
                {
                db.excetedate("update products_Qty set Qty=Qty - " + realQty + "where Pro_ID =" + pro_ID + " and store_ID=" + cbx_storefrom.SelectedValue + "and Qty = " + Qtyinstorefirstrow + "and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");
                db.excetedate("delete products_Qty where Qty <=0", "");

                decimal baky =Math.Abs(Qtyinstorefirstrow - realQty);


                tblQty.Clear();
                tblQty = db.readData("select top 1 * from products_Qty where Pro_ID=" + pro_ID + "and store_ID=" + cbx_storefrom.SelectedValue + "", "");

                Qtyinstorefirstrow = Convert.ToDecimal(tblQty.Rows[0][3]);

                if(Qtyinstorefirstrow-baky >= 0)
                {

                    db.excetedate("update products_Qty set Qty=Qty - " + baky + "where Pro_ID =" + pro_ID + " and store_ID=" + cbx_storefrom.SelectedValue + "and Qty = " + Qtyinstorefirstrow + "and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");
                    db.excetedate("delete products_Qty where Qty <=0", "");

                }
                else if(Qtyinstorefirstrow - baky < 0)
                {

                    decimal secondbaky = Math.Abs(Qtyinstorefirstrow - baky);
                    db.excetedate("update products_Qty set Qty=Qty - " + Qtyinstorefirstrow + "where Pro_ID =" + pro_ID + " and store_ID=" + cbx_storefrom.SelectedValue + "and Qty = " + Qtyinstorefirstrow + "and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");
                    db.excetedate("delete products_Qty where Qty <=0", "");


                    tblQty.Clear();
                    tblQty = db.readData("select top 1 * from products_Qty where Pro_ID=" + pro_ID + "and store_ID=" + cbx_storefrom.SelectedValue + "", "");

                    Qtyinstorefirstrow = Convert.ToDecimal(tblQty.Rows[0][3]);

                    if (Qtyinstorefirstrow - secondbaky >= 0)
                    {

                        db.excetedate("update products_Qty set Qty=Qty - " + secondbaky + "where Pro_ID =" + pro_ID + " and store_ID=" + cbx_storefrom.SelectedValue + "and Qty = " + Qtyinstorefirstrow + "and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");
                        db.excetedate("delete products_Qty where Qty <=0", "");

                    }
                    else if (Qtyinstorefirstrow - secondbaky < 0)
                    {

                        decimal therdbaky = Math.Abs(Qtyinstorefirstrow - baky);
                        db.excetedate("update products_Qty set Qty=Qty - " + Qtyinstorefirstrow + "where Pro_ID =" + pro_ID + " and store_ID=" + cbx_storefrom.SelectedValue + "and Qty = " + Qtyinstorefirstrow + "and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");
                        db.excetedate("delete products_Qty where Qty <=0", "");


                        tblQty.Clear();
                        tblQty = db.readData("select top 1 * from products_Qty where Pro_ID=" + pro_ID + "and store_ID=" + cbx_storefrom.SelectedValue + "", "");

                        Qtyinstorefirstrow = Convert.ToDecimal(tblQty.Rows[0][3]);

                        if (Qtyinstorefirstrow - therdbaky >= 0)
                        {

                            db.excetedate("update products_Qty set Qty=Qty - " + therdbaky + "where Pro_ID =" + pro_ID + " and store_ID=" + cbx_storefrom.SelectedValue + "and Qty = " + Qtyinstorefirstrow + "and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");
                            db.excetedate("delete products_Qty where Qty <=0", "");

                        }
                        else if (Qtyinstorefirstrow - therdbaky < 0)
                        {

                            decimal forthbaky = Math.Abs(Qtyinstorefirstrow - baky);
                            db.excetedate("update products_Qty set Qty=Qty - " + Qtyinstorefirstrow + "where Pro_ID =" + pro_ID + " and store_ID=" + cbx_storefrom.SelectedValue + "and Qty = " + Qtyinstorefirstrow + "and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");
                            db.excetedate("delete products_Qty where Qty <=0", "");


                            tblQty.Clear();
                            tblQty = db.readData("select top 1 * from products_Qty where Pro_ID=" + pro_ID + "and store_ID=" + cbx_storefrom.SelectedValue + "", "");

                            Qtyinstorefirstrow = Convert.ToDecimal(tblQty.Rows[0][3]);


                            if (Qtyinstorefirstrow - forthbaky >= 0)
                            {

                                db.excetedate("update products_Qty set Qty=Qty - " + forthbaky + "where Pro_ID =" + pro_ID + " and store_ID=" + cbx_storefrom.SelectedValue + "and Qty = " + Qtyinstorefirstrow + "and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");
                                db.excetedate("delete products_Qty where Qty <=0", "");

                            }
                            else if (Qtyinstorefirstrow - forthbaky < 0)
                            {


                                db.excetedate("update products_Qty set Qty=Qty - " + Qtyinstorefirstrow + "where Pro_ID =" + pro_ID + " and store_ID=" + cbx_storefrom.SelectedValue + "and Qty = " + Qtyinstorefirstrow + "and Buy_price =" + Convert.ToDecimal(tblQty.Rows[0][4]) + " ", "");
                                db.excetedate("delete products_Qty where Qty <=0", "");




                            }

                            }
                        }
                }

            }
        }
        private void insertQtyinstore(int pro_ID, decimal realQty)
        {
            if(nud_saleprice.Value<=0||nud_Buyprice.Value<=0)
            {
                MessageBox.Show("من فضلك ادخل سعر الشراء وسعر البيع للمنتج الذي تريد تحويله", "تاكيد");
                return;
            }
            if (Convert.ToInt32(cbx_storefrom.SelectedValue)== Convert.ToInt32(cbx_storeto.SelectedValue))
            {
                MessageBox.Show("لا يمكن التحويل لنفس المخزن", "تاكيد");
                return;
            }
            string d = dtp_date.Value.ToString("dd/MM/yyyy");
          
            db.excetedate("insert into products_Qty values ("+pro_ID+","+cbx_storeto.SelectedValue+",N'"+cbx_storeto.Text+"',"+realQty+","+nud_Buyprice.Value+","+nud_saleprice.Value+")", "");

        }



        private void btn_add_Click(object sender, EventArgs e)
        {
            DataTable tblunit = new DataTable();
            decimal Qtyinmain = 0, realqty = 0, totalqtyinstore = 0;
         
            try
            {
                 int pro_ID = Convert.ToInt32(cbx_product.SelectedValue);
                tblunit.Clear();
                tblunit = db.readData("select * from product_unit where Pro_ID=" + pro_ID + "and unit_Name=N'" + cbx_unite.Text + "'", "");
                try
                {
                    Qtyinmain = Convert.ToDecimal(tbl.Rows[0][3]);

                }
                catch (Exception) { }
                if (Qtyinmain > 1)
                {
                    realqty = nud_Qty.Value / Qtyinmain;

                }
                else
                {
                    realqty = nud_Qty.Value;
                }

                try
                {

                    totalqtyinstore = Convert.ToDecimal(db.readData("select sum (Qty) from products_Qty where Pro_ID=" + pro_ID + "and store_ID=" + cbx_storefrom.SelectedValue + "", "").Rows[0][0]);

                }
                catch (Exception) { }

                if(totalqtyinstore-realqty<0)
                {
                    MessageBox.Show("الكميه المراد تحويلها غير موجوده بالمخزن حاليا", "تاكيد");
                    return;
                }
                updateqtyinstore(pro_ID,realqty);
                insertQtyinstoreintoproducttransfer();
                insertQtyinstore(pro_ID, realqty);
             
                MessageBox.Show("تمت عملية التحويل بنجاح", "تاكيد");
                autonumber();
            }   
            catch (Exception) { }
          
}

        private void insertQtyinstoreintoproducttransfer()
        {
            string d = dtp_date.Value.ToString("yyyy-MM-dd");

            db.excetedate("insert into products_transfer (Pro_ID,pro_name,store_from,store_to,Qty,unit,Buy_price,sale_price,Date,Name,Reason) values(" + cbx_product.SelectedValue + ",N'" + cbx_product.Text + "',N'" + cbx_storefrom.Text + "',N'" + cbx_storeto.Text + "'," + nud_Qty.Value + ",N'" + cbx_unite.Text + "'," + nud_Buyprice.Value + "," + nud_saleprice.Value + ",N'" + d + "',N'" + txt_name.Text + "',N'" + txt_reason.Text + "')", "");
        }
        private void autonumber()
        {
            try
            {
                cbx_product.SelectedIndex = 0;
                cbx_storefrom.SelectedIndex = 0;
                cbx_storeto.SelectedIndex = 0;
                cbx_unite.SelectedIndex = 0;
                nud_Buyprice.Value = 1;
                nud_Qty.Value = 1;
                nud_saleprice.Value = 1;
                txt_name.Clear();
                txt_reason.Clear();
            }
            catch (Exception) { }
        }
    }
}