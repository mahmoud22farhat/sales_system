using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace sales
{
    public partial class frm_products : DevExpress.XtraEditors.XtraForm
    {
        public frm_products()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();

        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select MAX (Pro_ID) from products", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))

            {
                txt_id.Text = "1";
            }
            else
            {
                txt_id.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();

            }
            if(Properties.Settings.Default.taxes == true)
            {
                checkTaxes.Checked = true;
            }
            else
            {
                checkTaxes.Checked = false;
            }
            txt_parcode.Clear();
            txt_proname.Clear();
            txt_pronamesearch.Clear();

            nud_saleprice.Value = 1;
            nud_gomlaprice.Value = 1;
            nud_miniQty.Value = 0;
            nud_storeQty.Value = 1;
            nud_storeBuyprice.Value = 1;
            nud_maxdescound.Value = 0;
            nud_allQty.Value = 0;
            nud_uniteprice.Value = 1;
            nud_Qtyinmain.Value = 1;
            try
            {
                fillPro();

            }
            catch (Exception) { }
            try
            {
                cbx_mainunit.SelectedIndex = 0;
                cbx_unitSale.SelectedIndex = 0;
                cbx_unitBuy.SelectedIndex = 0;
                cbx_group.SelectedIndex = 0;
            }
            catch (Exception) { }
            try {

                Dgv_store.Rows.Clear();
                Dgv_unite.Rows.Clear();

            }
            catch(Exception){ }
            btn_add.Enabled = true;
            btn_new.Enabled = true;
            btn_delete.Enabled = false;
            btn_deleteall.Enabled = false;
            btn_save.Enabled = false;
            btn_printparcode.Enabled = false;
        }


        int row;
        private void show()
        {
            tbl.Clear();
            tbl = db.readData("select * from products", "");
            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لايوجد بيانات في هذه الشاشة");
            }
            else
            {
                try
                {
                    txt_id.Text = tbl.Rows[row][0].ToString();
                    txt_proname.Text = tbl.Rows[row][1].ToString();
                    nud_allQty.Value = Convert.ToDecimal(tbl.Rows[row][2]);
                    nud_gomlaprice.Value = Convert.ToDecimal(tbl.Rows[row][3]);
                    nud_saleprice.Value = Convert.ToDecimal(tbl.Rows[row][4]);
                    txt_parcode.Text = tbl.Rows[row][5].ToString();
                    nud_miniQty.Value = Convert.ToDecimal(tbl.Rows[row][6]);
                    nud_maxdescound.Value = Convert.ToDecimal(tbl.Rows[row][7]);
                    nud_taxe.Value = Convert.ToDecimal(tbl.Rows[row][8]);                  
                    txt_salepricetaxe.Text = tbl.Rows[row][9].ToString();
                    //لادخال متغير صنعته بنفسك وغير موجود في الفورم
                    if (tbl.Rows[row][10].ToString()=="خاضع للضريبه")
                    {
                        checkTaxes.Checked = true;
                    }
                    else
                    {
                        checkTaxes.Checked = false;
                    }
                   cbx_group.SelectedValue = Convert.ToDecimal(tbl.Rows[row][11]);
                    cbx_mainunit.SelectedValue = Convert.ToDecimal(tbl.Rows[row][13]);
                    cbx_unitSale.SelectedValue = Convert.ToDecimal(tbl.Rows[row][15]);
                    cbx_unitBuy.SelectedValue = Convert.ToDecimal(tbl.Rows[row][17]);
                }
                catch (Exception) { }
                //عند التنقل بالزراير(dgv_store) لعرض بيانات
                try {
                    DataTable tblstore = new DataTable();
                    tblstore.Clear();
                    tblstore = db.readData("select * from products_Qty where Pro_ID="+txt_id.Text+"", "");
                    Dgv_store.Rows.Clear();
                    if(tblstore.Rows.Count>=1)
                    {
                        //الداله دي بعطيلها عنصر وبتلف عليه 
                        foreach(DataRow row in tblstore.Rows)
                        {
                            Dgv_store.Rows.Add(1);
                            int indexrow = Dgv_store.Rows.Count - 1;
                            Dgv_store.Rows[indexrow].Cells[0].Value = row[2];
                            Dgv_store.Rows[indexrow].Cells[1].Value = row[3];
                            Dgv_store.Rows[indexrow].Cells[2].Value = row[4];
                        }
                    }
                }
                catch (Exception) { }
                //عند التنقل بالزراير(dgv_unit) لعرض بيانات
                try
                {
                    DataTable tblunit = new DataTable();
                    tblunit.Clear();
                    tblunit = db.readData("select * from product_unit where Pro_ID=" + txt_id.Text + "", "");
                    Dgv_unite.Rows.Clear();
                    if (tblunit.Rows.Count >= 1)
                    {
                        //الداله دي بعطيلها عنصر وبتلف عليه 
                        foreach (DataRow row in tblunit.Rows)
                        {
                            Dgv_unite.Rows.Add(1);
                            int indexrow = Dgv_unite.Rows.Count - 1;
                            Dgv_unite.Rows[indexrow].Cells[0].Value = row[2];
                            Dgv_unite.Rows[indexrow].Cells[1].Value = row[3];
                            Dgv_unite.Rows[indexrow].Cells[2].Value = row[4];
                        }
                    }
                }
                catch (Exception) { }
            }
            btn_add.Enabled = false;
            btn_new.Enabled = true;
            btn_delete.Enabled = true;
            btn_deleteall.Enabled = true;
            btn_save.Enabled = true;
            btn_printparcode.Enabled = true;
        }
        private void fillPro()
        {
            cbx_product.DataSource = db.readData("select * from products", "");
            cbx_product.DisplayMember = "Pro_name";
            cbx_product.ValueMember = "Pro_ID";
        }
        private void fillstore()
        {
            cbx_store.DataSource = db.readData("select * from store", "");
            cbx_store.DisplayMember = "store_Name";
            cbx_store.ValueMember = "store_ID";
        }
        //لملئ ثلاثه كومبو بوكس 
        private void fillunit()
        {

            cbx_mainunit.DataSource = db.readData("select * from unit", "");
            cbx_mainunit.DisplayMember = "unit_Name";
            cbx_mainunit.ValueMember = "unit_ID";


            cbx_unitSale.DataSource = db.readData("select * from unit", "");
            cbx_unitSale.DisplayMember = "unit_Name";
            cbx_unitSale.ValueMember = "unit_ID";


            cbx_unitBuy.DataSource = db.readData("select * from unit", "");
            cbx_unitBuy.DisplayMember = "unit_Name";
            cbx_unitBuy.ValueMember = "unit_ID";

            cbx_unite.DataSource = db.readData("select * from unit", "");
            cbx_unite.DisplayMember = "unit_Name";
            cbx_unite.ValueMember = "unit_ID";

        }
        private void fillgroups()
        {

            cbx_group.DataSource = db.readData("select * from prouducts_group", "");
            cbx_group.DisplayMember = "group_Name";
            cbx_group.ValueMember = "group_ID";
        }

        private void frm_products_Load(object sender, EventArgs e)
        {
            try
            {
                fillgroups();
                fillunit();
                fillstore();
                AutoNumber();
            }
            catch (Exception) { }



        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            row = 0;
            show();
        }

        private void btn_priv_Click(object sender, EventArgs e)
        {
            if (row == 0)
            {
                tbl.Clear();
                tbl = db.readData("select count(Pro_ID) from products", "");
                row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
                show();
            }
            else
            {
                row--;
                show();

            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select count(Pro_ID) from products", "");
            if (Convert.ToInt32(tbl.Rows[0][0]) - 1 == row)
            {
                row = 0;
                show();
            }
            else
            {
                row++;
                show();
            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select count(Pro_ID) from products", "");

            row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            show();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }


        //دالة بوول ترجعلي ترو وفولس بدلا من ريتيرن
        private bool productvalidation()
        {
            if (txt_proname.Text == "")
            {
                MessageBox.Show("من فضلك ادخل المنتج اولا");
                return false;
            }
            if (nud_saleprice.Value <= 0)

            {
                MessageBox.Show("لا يمكن ان يكون سعر البيع افل من واحد");
                return false;
            }

            if (nud_maxdescound.Value >= nud_saleprice.Value)
            {
                MessageBox.Show("لا يمكن ان يكون سعر االخصم المسموح اكبر من سعر البيع");
                return false;
            }

            if (nud_allQty.Value < nud_miniQty.Value)
            {
                MessageBox.Show("لا يمكن ان يكون حد الطلب اكبر من الكميه الموجوده");
                return false;
            }
            if (nud_gomlaprice.Value > Convert.ToDecimal(txt_salepricetaxe.Text))
            {
                MessageBox.Show("لا يمكن ان يكون سعر الجمله اكبر من سعر التجزأه");
                return false;
            }
            if (cbx_mainunit.Items.Count <= 0)
            {
                MessageBox.Show("من فضلك ادخل الوحدات اولا");
                return false;
            }
            if (cbx_group.Items.Count <= 0)
            {
                MessageBox.Show("من فضلك ادخل التصنيفات اولا");
                return false;
            }
            if (Dgv_store.Rows.Count <= 0)
            {
                MessageBox.Show("لا يمكن اضافة المنتج قبل اضافة كميه له علي الاقل");
                return false;
            }

            return true;

        }
        private void btn_add_Click(object sender, EventArgs e)
        {

            bool check = false;
            check = productvalidation();

            if (check == true)
            {
                productvalidation();
                string is_tax = "";
                if (checkTaxes.Checked == true)
                {
                    is_tax = "خاضع للضريبه";
                }
                else
                {
                    is_tax = "غير خاضع للضريبه";
                }
                db.excetedate("insert into products values(" + txt_id.Text + " ,N'" + txt_proname.Text + "' ," + nud_allQty.Value + " ," + nud_gomlaprice.Value + "," + nud_saleprice.Value + ",N'" + txt_parcode.Text + "'," + nud_miniQty.Value + "," + nud_maxdescound.Value + "," + nud_taxe.Value + "," + txt_salepricetaxe.Text + ",N'" + is_tax + "'," + cbx_group.SelectedValue + ",N'" + cbx_mainunit.Text + "'," + cbx_mainunit.SelectedValue + ",N'" + cbx_unitSale.Text + "'," + cbx_unitSale.SelectedValue + ",N'" + cbx_unitBuy.Text + "'," + cbx_unitBuy.SelectedValue + " )", "");
                for (int i = 0; i <= Dgv_store.Rows.Count - 1; i++)
                {
                    int store_ID = 0;
                    try
                    {
                        store_ID = Convert.ToInt32(db.readData("Select * from store where store_Name =N'" + Dgv_store.Rows[i].Cells[0].Value + "'", "").Rows[0][0]);
                    }
                    catch (Exception) { }
                    db.excetedate("insert into products_Qty values(" + txt_id.Text + "," + store_ID + ",N'" + Dgv_store.Rows[i].Cells[0].Value + "'," + Dgv_store.Rows[i].Cells[1].Value + "," + Dgv_store.Rows[i].Cells[2].Value + "," + txt_salepricetaxe.Text + ")", "");

                }
                for (int i = 0; i <= Dgv_unite.Rows.Count - 1; i++)
                {
                    int unit_ID = 0;
                    try
                    {
                        unit_ID = Convert.ToInt32(db.readData("Select * from unit where unit_Name =N'" + Dgv_unite.Rows[i].Cells[0].Value + "'", "").Rows[0][0]);
                    }
                    catch (Exception) { }
                    db.excetedate("insert into product_unit values(" + txt_id.Text + "," + unit_ID + ",N'" + Dgv_unite.Rows[i].Cells[0].Value + "'," + Dgv_unite.Rows[i].Cells[1].Value + "," + Dgv_unite.Rows[i].Cells[2].Value + "," + txt_salepricetaxe.Text + ")", "");

                }

              db.excetedate("insert into product_unit values(" + txt_id.Text + "," + cbx_mainunit.SelectedValue + ",N'" + cbx_mainunit.Text + "',1," + txt_salepricetaxe.Text + "," + txt_salepricetaxe.Text + ")", "");

                MessageBox.Show("تم اضافة المنتج بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AutoNumber();
            }
        }
        
        private void btn_save_Click(object sender, EventArgs e)
        {

            productvalidation();

            bool check = false;
            check = productvalidation();

            if (check == true)
            {

                string is_tax = "";
                if (checkTaxes.Checked == true)
                {
                    is_tax = "خاضع للضريبه";
                }
                else
                {
                    is_tax = "غير خاضع للضريبه";
                }
                db.excetedate("update products set Pro_name=N'" + txt_proname.Text + "' ,Qty=" + nud_allQty.Value + " ,gomla_price=" + nud_gomlaprice.Value + ",sale_price=" + nud_saleprice.Value + ",Barcode=N'" + txt_parcode.Text + "',minQty=" + nud_miniQty.Value + ",maxdiscound=" + nud_maxdescound.Value + ",tax_value=" + nud_taxe.Value + ",sale_pricetax=" + txt_salepricetaxe.Text + ",is_tax=N'" + is_tax + "',group_ID=" + cbx_group.SelectedValue + ",main_UnitName=N'" + cbx_mainunit.Text + "',main_UnitID=" + cbx_mainunit.SelectedValue + ",sale_unitname=N'" + cbx_unitSale.Text + "',sale_unitID=" + cbx_unitSale.SelectedValue + ",buy_UnitName=N'" + cbx_unitBuy.Text + "',buy_UnitID=" + cbx_unitBuy.SelectedValue + " where Pro_ID = "+txt_id.Text+"", "");

                db.excetedate("delete from products_Qty where Pro_ID = "+txt_id.Text+"", "");


                for (int i = 0; i <= Dgv_store.Rows.Count - 1; i++)
                {
                    int store_ID = 0;
                    try
                    {
                        store_ID = Convert.ToInt32(db.readData("Select * from store where store_Name =N'" + Dgv_store.Rows[i].Cells[0].Value + "'", "").Rows[0][0]);
                    }
                    catch (Exception) { }
                    db.excetedate("insert into products_Qty values(" + txt_id.Text + "," + store_ID + ",N'" + Dgv_store.Rows[i].Cells[0].Value + "'," + Dgv_store.Rows[i].Cells[1].Value + "," + Dgv_store.Rows[i].Cells[2].Value + "," + txt_salepricetaxe.Text + ")", "");
                }
                db.excetedate("delete from product_unit where Pro_ID = " + txt_id.Text + "", "");

                for (int i = 0; i <= Dgv_unite.Rows.Count - 1; i++)
                {
                    int unit_ID = 0;
                    try
                    {
                        unit_ID = Convert.ToInt32(db.readData("Select * from unit where unit_Name =N'" + Dgv_unite.Rows[i].Cells[0].Value + "'", "").Rows[0][0]);
                    }
                    catch (Exception) { }
                    db.excetedate("insert into product_unit values(" + txt_id.Text + "," + unit_ID + ",N'" + Dgv_unite.Rows[i].Cells[0].Value + "'," + Dgv_unite.Rows[i].Cells[1].Value + "," + Dgv_unite.Rows[i].Cells[2].Value + "," + txt_salepricetaxe.Text + ")", "");

                }
                string unit_name = cbx_mainunit.Text;

                for (int i = 0; i <= Dgv_unite.Rows.Count - 1; i++)
                {
                    //مقارنة الوحده المضافه بأول صف في الداتا جريد
                    if (unit_name == Convert.ToString(Dgv_unite.Rows[i].Cells[0].Value))
                    {
                        MessageBox.Show("تم حفظ المنتج بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                db.excetedate("insert into product_unit values(" + txt_id.Text + "," + cbx_mainunit.SelectedValue + ",N'" + cbx_mainunit.Text + "',1," + txt_salepricetaxe.Text + "," + txt_salepricetaxe.Text + ")", "");

                MessageBox.Show("تم حفظ المنتج بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AutoNumber();
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من مسح البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                db.readData("delete from products_Qty where Pro_ID=" + txt_id.Text + "", "");
                db.readData("delete from product_unit where Pro_ID=" + txt_id.Text + "", "");
                db.readData("delete from products where Pro_ID=" + txt_id.Text + "", "تم مسح البيانات بنجاح");

                AutoNumber();
            }
        }

        private void btn_deleteall_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من مسح البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                db.readData("delete from products_Qty ", "");
                db.readData("delete from product_unit ", "");
                db.readData("delete from products ", "تم مسح البيانات بنجاح");

                AutoNumber();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_pronamesearch.Text != "")
            {
                DataTable tblsearch = new DataTable();
                tblsearch.Clear();
                tblsearch = db.readData("select * from products where Pro_name Like N'%" + txt_pronamesearch.Text + "%'", "");
                if (tblsearch.Rows.Count <= 0)
                {
                    MessageBox.Show("لايوجد منتج بهذا الاسم");
                }
                else
                {
                    try
                    {
                        txt_id.Text = tblsearch.Rows[0][0].ToString();
                        txt_proname.Text = tblsearch.Rows[0][1].ToString();
                        nud_allQty.Value = Convert.ToDecimal(tblsearch.Rows[0][2]);
                        //     nud_Buyprice.Value = Convert.ToDecimal(tblsearch.Rows[0][3]);
                        nud_saleprice.Value = Convert.ToDecimal(tblsearch.Rows[0][4]);
                        txt_parcode.Text = tblsearch.Rows[0][5].ToString();
                        nud_miniQty.Value = Convert.ToDecimal(tblsearch.Rows[0][6]);
                        nud_maxdescound.Value = Convert.ToDecimal(tblsearch.Rows[0][7]);




                    }
                    catch (Exception) { }


                }
                btn_add.Enabled = false;
                btn_new.Enabled = true;
                btn_delete.Enabled = true;
                btn_deleteall.Enabled = true;
                btn_save.Enabled = true;
            }
        }

        private void cbx_product_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbx_product_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbx_product.Items.Count >= 1)
            {
                DataTable tblsearch = new DataTable();
                tblsearch.Clear();
                tblsearch = db.readData("select * from products where Pro_ID ="+cbx_product.SelectedValue+"", "");
                if (tblsearch.Rows.Count <= 0)
                {
                    //MessageBox.Show("لايوجد بيانات في هذه الشاشة");
                }
                else
                {
                    try
                    {
                        txt_id.Text = tblsearch.Rows[0][0].ToString();
                        txt_proname.Text = tblsearch.Rows[0][1].ToString();
                        nud_allQty.Value = Convert.ToDecimal(tblsearch.Rows[0][2]);
                        nud_gomlaprice.Value = Convert.ToDecimal(tblsearch.Rows[0][3]);
                        nud_saleprice.Value = Convert.ToDecimal(tblsearch.Rows[0][4]);
                        txt_parcode.Text = tblsearch.Rows[0][5].ToString();
                        nud_miniQty.Value = Convert.ToDecimal(tblsearch.Rows[0][6]);
                        nud_maxdescound.Value = Convert.ToDecimal(tblsearch.Rows[0][7]);
                        nud_taxe.Value = Convert.ToDecimal(tblsearch.Rows[0][8]);
                        txt_salepricetaxe.Text = tblsearch.Rows[0][9].ToString();
                        //لادخال متغير صنعته بنفسك وغير موجود في الفورم
                        if (tblsearch.Rows[0][10].ToString() == "خاضع للضريبه")
                        {
                            checkTaxes.Checked = true;
                        }
                        else
                        {
                            checkTaxes.Checked = false;
                        }
                        cbx_group.SelectedValue = Convert.ToDecimal(tblsearch.Rows[0][11]);
                        cbx_mainunit.SelectedValue = Convert.ToDecimal(tblsearch.Rows[0][13]);
                        cbx_unitSale.SelectedValue = Convert.ToDecimal(tblsearch.Rows[0][15]);
                        cbx_unitBuy.SelectedValue = Convert.ToDecimal(tblsearch.Rows[0][17]);
                    }
                    catch (Exception) { }
                    //عند التنقل بالزراير(dgv_store) لعرض بيانات
                    try
                    {
                        DataTable tblstore = new DataTable();
                        tblstore.Clear();
                        tblstore = db.readData("select * from products_Qty where Pro_ID=" + txt_id.Text + "", "");
                        Dgv_store.Rows.Clear();
                        if (tblstore.Rows.Count >= 1)
                        {
                            //الداله دي بعطيلها عنصر وبتلف عليه 
                            foreach (DataRow row in tblstore.Rows)
                            {
                                Dgv_store.Rows.Add(1);
                                int indexrow = Dgv_store.Rows.Count - 1;
                                Dgv_store.Rows[indexrow].Cells[0].Value = row[2];
                                Dgv_store.Rows[indexrow].Cells[1].Value = row[3];
                                Dgv_store.Rows[indexrow].Cells[2].Value = row[4];
                            }
                        }
                    }
                    catch (Exception) { }
                    //عند التنقل بالزراير(dgv_unit) لعرض بيانات
                    try
                    {
                        DataTable tblunit = new DataTable();
                        tblunit.Clear();
                        tblunit = db.readData("select * from product_unit where Pro_ID=" + txt_id.Text + "", "");
                        Dgv_unite.Rows.Clear();
                        if (tblunit.Rows.Count >= 1)
                        {
                            //الداله دي بعطيلها عنصر وبتلف عليه 
                            foreach (DataRow row in tblunit.Rows)
                            {
                                Dgv_unite.Rows.Add(1);
                                int indexrow = Dgv_unite.Rows.Count - 1;
                                Dgv_unite.Rows[indexrow].Cells[0].Value = row[2];
                                Dgv_unite.Rows[indexrow].Cells[1].Value = row[3];
                                Dgv_unite.Rows[indexrow].Cells[2].Value = row[4];
                            }
                        }
                    }
                    catch (Exception) { }
                }
                btn_add.Enabled = false;
                btn_new.Enabled = true;
                btn_delete.Enabled = true;
                btn_deleteall.Enabled = true;
                btn_save.Enabled = true;
                btn_printparcode.Enabled = true;
            }
            
        }
       
        private void nud_saleprice_ValueChanged(object sender, EventArgs e)
        { /*
         لحساب ضريبة القيمه المضافه من سعر البيع

         ناخذ السعر الاصلي وبالقسمه علي 100 
         
         ثم يتم ضرب الناتج في قيمة الضريبه اذا كانت( 5 او 15 )في المية    
             

             */
            try
            {
                decimal taxval = 0, saleprice = 0;
                saleprice = nud_saleprice.Value;
                taxval = (saleprice / 100) * nud_taxe.Value;

                if (checkTaxes.Checked == true)
                {
                    txt_salepricetaxe.Text = (saleprice + taxval).ToString();
                }
                else
                {
                    txt_salepricetaxe.Text = (saleprice).ToString();
                }


            }
            catch (Exception) { }
        }

        private void checkTaxes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTaxes.Checked == true)
            {
                nud_taxe.Value = 5;
            }
            else
            {
                nud_taxe.Value = 0;
            }
        }

        private void nud_taxe_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                decimal taxval = 0, saleprice = 0;
                saleprice = nud_saleprice.Value;
                taxval = (saleprice / 100) * nud_taxe.Value;

                if (checkTaxes.Checked == true)
                {
                    txt_salepricetaxe.Text = (saleprice + taxval).ToString();
                }
                else
                {
                    txt_salepricetaxe.Text = (saleprice).ToString();
                }


            }
            catch (Exception) { }
        }


        private void btn_addQty_Click(object sender, EventArgs e)
        {

            if (cbx_store.Items.Count >= 0)
            {
                if (nud_storeBuyprice.Value <= 0 || nud_storeQty.Value <= 0)
                {
                    MessageBox.Show("من فضلك ادخل الكميه وسعر الشراء ");
                    return;
                }
                Dgv_store.Rows.Add(1);
                int indexrow = Dgv_store.Rows.Count - 1;
                Dgv_store.Rows[indexrow].Cells[0].Value = cbx_store.Text;
                Dgv_store.Rows[indexrow].Cells[1].Value = nud_storeQty.Value;
                Dgv_store.Rows[indexrow].Cells[2].Value = nud_storeBuyprice.Value;


                decimal total = 0;
                for(int i=0;i<= Dgv_store.Rows.Count -1; i++)
                {

                    total += Convert.ToDecimal(Dgv_store.Rows[i].Cells[1].Value);

                }

                nud_allQty.Value = total;

            }


        }

        private void btn_showgroup_Click(object sender, EventArgs e)
        {

        }

        private void btn_removestore_Click(object sender, EventArgs e)
        {
            if (cbx_store.Items.Count >= 1)
            {
                Dgv_store.Rows.RemoveAt(Dgv_store.CurrentCell.RowIndex);
                decimal total = 0;
                for (int i = 0; i <= Dgv_store.Rows.Count - 1; i++)
                {

                    total += Convert.ToDecimal(Dgv_store.Rows[i].Cells[1].Value);

                }

                nud_allQty.Value = total;

            }
        }

        private void btn_addunite_Click(object sender, EventArgs e)
        {
            if (cbx_unite.Items.Count >= 0)
            {
                if (nud_uniteprice.Value <= 0 || nud_Qtyinmain.Value <= 0)
                {
                    MessageBox.Show("من فضلك ادخل عدد القطع وسعر الوحدة ");
                    return;
                }
                if (Convert.ToDecimal(cbx_unite.SelectedValue)== Convert.ToDecimal(cbx_mainunit.SelectedValue))
                {
                    MessageBox.Show("لا يمكن اختيار الوحدده الكبيري مثل الوحده الكبري ","تأكيد");
                    return;
                }

                //لعدم اضافة وحدات متكرره في داتا فيو يةنيتس

                string unit_name = cbx_unite.Text;

                for(int i = 0; i<=Dgv_unite.Rows.Count - 1;i++)
                {
                    //مقارنة الوحده المضافه بأول صف في الداتا جريد
                    if(unit_name == Convert.ToString(Dgv_unite.Rows[i].Cells[0].Value))
                        {
                        MessageBox.Show("هذه الوحدة تمت اضافتها من قبل ", "من فضلك راجع الوحدات");
                    }
                }


                Dgv_unite.Rows.Add(1);
                int indexrow = Dgv_unite.Rows.Count - 1;
                Dgv_unite.Rows[indexrow].Cells[0].Value = cbx_unite.Text;
                Dgv_unite.Rows[indexrow].Cells[1].Value = nud_Qtyinmain.Value;
                Dgv_unite.Rows[indexrow].Cells[2].Value = nud_uniteprice.Value;           
            }

        }

        private void btn_removeunite_Click(object sender, EventArgs e)
        {
            try { 
            if (cbx_unite.Items.Count >= 1)
            {
                Dgv_unite.Rows.RemoveAt(Dgv_unite.CurrentCell.RowIndex);
            }
            }
            catch (Exception) { }
        }
        private void nud_Qtyinmain_ValueChanged(object sender, EventArgs e)
        {
            try
            {             
                   nud_uniteprice.Value = Convert.ToDecimal(txt_salepricetaxe.Text)/nud_Qtyinmain.Value;            
            }
            catch (Exception) { }
        }

        private void btn_searchparcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {


                if (txt_searchparcode.Text!="")
                {
                    DataTable tblsearch = new DataTable();
                    tblsearch.Clear();
                    tblsearch = db.readData("select * from products where Barcode =N'"+txt_searchparcode.Text+"'", "");
                    if (tblsearch.Rows.Count <= 0)
                    {
                        //MessageBox.Show("لايوجد بيانات في هذه الشاشة");
                    }
                    else
                    {
                        try
                        {
                            txt_id.Text = tblsearch.Rows[0][0].ToString();
                            txt_proname.Text = tblsearch.Rows[0][1].ToString();
                            nud_allQty.Value = Convert.ToDecimal(tblsearch.Rows[0][2]);
                            nud_gomlaprice.Value = Convert.ToDecimal(tblsearch.Rows[0][3]);
                            nud_saleprice.Value = Convert.ToDecimal(tblsearch.Rows[0][4]);
                            txt_parcode.Text = tblsearch.Rows[0][5].ToString();
                            nud_miniQty.Value = Convert.ToDecimal(tblsearch.Rows[0][6]);
                            nud_maxdescound.Value = Convert.ToDecimal(tblsearch.Rows[0][7]);
                            nud_taxe.Value = Convert.ToDecimal(tblsearch.Rows[0][8]);
                            txt_salepricetaxe.Text = tblsearch.Rows[0][9].ToString();
                            //لادخال متغير صنعته بنفسك وغير موجود في الفورم
                            if (tblsearch.Rows[0][10].ToString() == "خاضع للضريبه")
                            {
                                checkTaxes.Checked = true;
                            }
                            else
                            {
                                checkTaxes.Checked = false;
                            }
                            cbx_group.SelectedValue = Convert.ToDecimal(tblsearch.Rows[0][11]);
                            cbx_mainunit.SelectedValue = Convert.ToDecimal(tblsearch.Rows[0][13]);
                            cbx_unitSale.SelectedValue = Convert.ToDecimal(tblsearch.Rows[0][15]);
                            cbx_unitBuy.SelectedValue = Convert.ToDecimal(tblsearch.Rows[0][17]);
                        }
                        catch (Exception) { }
                        //عند التنقل بالزراير(dgv_store) لعرض بيانات
                        try
                        {
                            DataTable tblstore = new DataTable();
                            tblstore.Clear();
                            tblstore = db.readData("select * from products_Qty where Pro_ID=" + txt_id.Text + "", "");
                            Dgv_store.Rows.Clear();
                            if (tblstore.Rows.Count >= 1)
                            {
                                //الداله دي بعطيلها عنصر وبتلف عليه 
                                foreach (DataRow row in tblstore.Rows)
                                {
                                    Dgv_store.Rows.Add(1);
                                    int indexrow = Dgv_store.Rows.Count - 1;
                                    Dgv_store.Rows[indexrow].Cells[0].Value = row[2];
                                    Dgv_store.Rows[indexrow].Cells[1].Value = row[3];
                                    Dgv_store.Rows[indexrow].Cells[2].Value = row[4];
                                }
                            }
                        }
                        catch (Exception) { }
                        //عند التنقل بالزراير(dgv_unit) لعرض بيانات
                        try
                        {
                            DataTable tblunit = new DataTable();
                            tblunit.Clear();
                            tblunit = db.readData("select * from product_unit where Pro_ID=" + txt_id.Text + "", "");
                            Dgv_unite.Rows.Clear();
                            if (tblunit.Rows.Count >= 1)
                            {
                                //الداله دي بعطيلها عنصر وبتلف عليه 
                                foreach (DataRow row in tblunit.Rows)
                                {
                                    Dgv_unite.Rows.Add(1);
                                    int indexrow = Dgv_unite.Rows.Count - 1;
                                    Dgv_unite.Rows[indexrow].Cells[0].Value = row[2];
                                    Dgv_unite.Rows[indexrow].Cells[1].Value = row[3];
                                    Dgv_unite.Rows[indexrow].Cells[2].Value = row[4];
                                }
                            }
                        }
                        catch (Exception) { }
                    }
                    btn_add.Enabled = false;
                    btn_new.Enabled = true;
                    btn_delete.Enabled = true;
                    btn_deleteall.Enabled = true;
                    btn_save.Enabled = true;
                    btn_printparcode.Enabled =true;
                }

            }
        }

        private void txt_pronamesearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {


                if (txt_pronamesearch.Text != "")
                {
                    DataTable tblsearch = new DataTable();
                    tblsearch.Clear();
                    tblsearch = db.readData("select * from products where Pro_name like N'%" + txt_pronamesearch.Text + "%'", "");
                    if (tblsearch.Rows.Count <= 0)
                    {
                        //MessageBox.Show("لايوجد بيانات في هذه الشاشة");
                    }
                    else
                    {
                        try
                        {
                            txt_id.Text = tblsearch.Rows[0][0].ToString();
                            txt_proname.Text = tblsearch.Rows[0][1].ToString();
                            nud_allQty.Value = Convert.ToDecimal(tblsearch.Rows[0][2]);
                            nud_gomlaprice.Value = Convert.ToDecimal(tblsearch.Rows[0][3]);
                            nud_saleprice.Value = Convert.ToDecimal(tblsearch.Rows[0][4]);
                            txt_parcode.Text = tblsearch.Rows[0][5].ToString();
                            nud_miniQty.Value = Convert.ToDecimal(tblsearch.Rows[0][6]);
                            nud_maxdescound.Value = Convert.ToDecimal(tblsearch.Rows[0][7]);
                            nud_taxe.Value = Convert.ToDecimal(tblsearch.Rows[0][8]);
                            txt_salepricetaxe.Text = tblsearch.Rows[0][9].ToString();
                            //لادخال متغير صنعته بنفسك وغير موجود في الفورم
                            if (tblsearch.Rows[0][10].ToString() == "خاضع للضريبه")
                            {
                                checkTaxes.Checked = true;
                            }
                            else
                            {
                                checkTaxes.Checked = false;
                            }
                            cbx_group.SelectedValue = Convert.ToDecimal(tblsearch.Rows[0][11]);
                            cbx_mainunit.SelectedValue = Convert.ToDecimal(tblsearch.Rows[0][13]);
                            cbx_unitSale.SelectedValue = Convert.ToDecimal(tblsearch.Rows[0][15]);
                            cbx_unitBuy.SelectedValue = Convert.ToDecimal(tblsearch.Rows[0][17]);
                        }
                        catch (Exception) { }
                        //عند التنقل بالزراير(dgv_store) لعرض بيانات
                        try
                        {
                            DataTable tblstore = new DataTable();
                            tblstore.Clear();
                            tblstore = db.readData("select * from products_Qty where Pro_ID=" + txt_id.Text + "", "");
                            Dgv_store.Rows.Clear();
                            if (tblstore.Rows.Count >= 1)
                            {
                                //الداله دي بعطيلها عنصر وبتلف عليه 
                                foreach (DataRow row in tblstore.Rows)
                                {
                                    Dgv_store.Rows.Add(1);
                                    int indexrow = Dgv_store.Rows.Count - 1;
                                    Dgv_store.Rows[indexrow].Cells[0].Value = row[2];
                                    Dgv_store.Rows[indexrow].Cells[1].Value = row[3];
                                    Dgv_store.Rows[indexrow].Cells[2].Value = row[4];
                                }
                            }
                        }
                        catch (Exception) { }
                        //عند التنقل بالزراير(dgv_unit) لعرض بيانات
                        try
                        {
                            DataTable tblunit = new DataTable();
                            tblunit.Clear();
                            tblunit = db.readData("select * from product_unit where Pro_ID=" + txt_id.Text + "", "");
                            Dgv_unite.Rows.Clear();
                            if (tblunit.Rows.Count >= 1)
                            {
                                //الداله دي بعطيلها عنصر وبتلف عليه 
                                foreach (DataRow row in tblunit.Rows)
                                {
                                    Dgv_unite.Rows.Add(1);
                                    int indexrow = Dgv_unite.Rows.Count - 1;
                                    Dgv_unite.Rows[indexrow].Cells[0].Value = row[2];
                                    Dgv_unite.Rows[indexrow].Cells[1].Value = row[3];
                                    Dgv_unite.Rows[indexrow].Cells[2].Value = row[4];
                                }
                            }
                        }
                        catch (Exception) { }
                    }
                    btn_add.Enabled = false;
                    btn_new.Enabled = true;
                    btn_delete.Enabled = true;
                    btn_deleteall.Enabled = true;
                    btn_save.Enabled = true;
                    btn_printparcode.Enabled = true;
                }
            }
        }
        private void btn_printparcode_Click(object sender, EventArgs e)
        {
            //لتمرير البيانات الي شاشة الباركود
            Properties.Settings.Default.Pro_Name = txt_proname.Text;
            Properties.Settings.Default.Pro_Barcode = txt_parcode.Text;
            Properties.Settings.Default.Pro_price = Convert.ToDecimal( txt_salepricetaxe.Text);
            Properties.Settings.Default.Save();
            frm_printBarcode frm = new frm_printBarcode();
            frm.ShowDialog();
            txt_parcode.Text = Properties.Settings.Default.Pro_Barcode;

        }
    }
}
