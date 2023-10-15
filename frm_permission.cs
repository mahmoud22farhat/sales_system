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
    public partial class frm_permission : DevExpress.XtraEditors.XtraForm
    {
        public frm_permission()
        {
            InitializeComponent();
        }

        database db = new database();
        DataTable tbl = new DataTable(); DataTable tblstore = new DataTable();
        private void AutoNumber()
        {
            tblstore.Clear();
            tblstore = db.readData("SELECT [user_ID]as'رقم المستخدم',[user_Name]as'اسم المستخدم',[type]as'نوعة',[Rb7h]as'نسبة الربح'FROM [dbo].[users]", "");
            Dgv_search.DataSource = tblstore;
            tbl.Clear();
            tbl = db.readData("select MAX (user_ID) from users", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))

            {
                txt_id.Text = "1";
            }
            else
            {
                txt_id.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            //حذف البانات بعد اتمام ملية اضافه .....ليتم اضافة عميل جديد


            txt_password.Clear();
            txt_user.Clear();
            nud_rb7h.Value = 1;
            try
            {

                cbx_stock.SelectedIndex = 0;
                cbx_type.SelectedIndex = 0;
            }
            catch (Exception) { }
            fillusers();
            btn_add.Enabled = true;
            btn_new.Enabled = true;
            btn_delete.Enabled = false;

            btn_save.Enabled = false;

        }


        int row;
        private void show()
        {
            tbl.Clear();
            tbl = db.readData("select * from users", "");
            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لايوجد بيانات في هذه الشاشة");
            }
            else
            {
                txt_id.Text = tbl.Rows[row][0].ToString();
                txt_user.Text = tbl.Rows[row][1].ToString();
                txt_password.Text = tbl.Rows[row][2].ToString();
                cbx_type.Text = tbl.Rows[row][3].ToString();
                cbx_stock.SelectedValue = Convert.ToDecimal(tbl.Rows[row][4]);
                nud_rb7h.Value = Convert.ToDecimal(tbl.Rows[row][5]);
            }
            btn_add.Enabled = false;
            btn_new.Enabled = true;
            btn_delete.Enabled = true;

            btn_save.Enabled = true;
        }
        private void fillstock()
        {
            cbx_stock.DataSource = db.readData("select * from stock_Data", "");
            cbx_stock.DisplayMember = "stock_name";
            cbx_stock.ValueMember = "stock_ID";
        }
        private void fillusers()
        {
            cbx_user1.DataSource = db.readData("select * from users", "");
            cbx_user1.DisplayMember = "user_Name";
            cbx_user1.ValueMember = "user_ID";

            cbx_user2.DataSource = db.readData("select * from users", "");
            cbx_user2.DisplayMember = "user_Name";
            cbx_user2.ValueMember = "user_ID";


            cbx_user3.DataSource = db.readData("select * from users", "");
            cbx_user3.DisplayMember = "user_Name";
            cbx_user3.ValueMember = "user_ID";


            cbx_user4.DataSource = db.readData("select * from users", "");
            cbx_user4.DisplayMember = "user_Name";
            cbx_user4.ValueMember = "user_ID";


            cbx_user5.DataSource = db.readData("select * from users", "");
            cbx_user5.DisplayMember = "user_Name";
            cbx_user5.ValueMember = "user_ID";




            cbx_user6.DataSource = db.readData("select * from users", "");
            cbx_user6.DisplayMember = "user_Name";
            cbx_user6.ValueMember = "user_ID";




            cbx_user7.DataSource = db.readData("select * from users", "");
            cbx_user7.DisplayMember = "user_Name";
            cbx_user7.ValueMember = "user_ID";



            cbx_user8.DataSource = db.readData("select * from users", "");
            cbx_user8.DisplayMember = "user_Name";
            cbx_user8.ValueMember = "user_ID";


            cbx_user9.DataSource = db.readData("select * from users", "");
            cbx_user9.DisplayMember = "user_Name";
            cbx_user9.ValueMember = "user_ID";


            cbx_user10.DataSource = db.readData("select * from users", "");
            cbx_user10.DisplayMember = "user_Name";
            cbx_user10.ValueMember = "user_ID";


            cbx_user11.DataSource = db.readData("select * from users", "");
            cbx_user11.DisplayMember = "user_Name";
            cbx_user11.ValueMember = "user_ID";



        }
        private void frm_permission_Load(object sender, EventArgs e)
        {
            try
            {
                fillstock();
                AutoNumber();


            }
            catch (Exception) { }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                MessageBox.Show("من فضلك ادخل اسم المستخدم");
                return;
            }
            if (txt_password.Text == "")
            {
                MessageBox.Show("من فضلك ادخل كلمة السر");
                return;
            }
            //اضافة بيانات العميل باللغه العربيه
            db.excetedate("insert into users values(" + txt_id.Text + " ,N'" + txt_user.Text + "' ,N'" + txt_password.Text + "' ,N'" + cbx_type.Text + "' ,N'" + cbx_stock.SelectedValue + "'," + nud_rb7h.Value + ")", "تم الادخال بنجاح");
            db.excetedate("insert into users_setting  values(" + txt_id.Text + ",0,0,0,0,0,0,0,0,0,0,0,0)", "");
            db.excetedate("insert into user_customer  values(" + txt_id.Text + ",0,0,0)", "");
            db.excetedate("insert into user_employee  values(" + txt_id.Text + ",0,0,0)", "");
            db.excetedate("insert into user_buy  values(" + txt_id.Text + ",0,0)", "");
            db.excetedate("insert into user_sale  values(" + txt_id.Text + ",0,0,0)", "");
            db.excetedate("insert into user_return  values(" + txt_id.Text + ",0,0)", "");
            db.excetedate("insert into user_deserved  values(" + txt_id.Text + ",0,0,0,0,0,0,0)", "");
            db.excetedate("insert into user_money  values(" + txt_id.Text + ",0,0,0,0,0,0,0,0,0)", "");
            db.excetedate("insert into user_employeeafffairs  values(" + txt_id.Text + ",0,0,0,0,0,0,0)", "");
            db.excetedate("insert into user_report  values(" + txt_id.Text + ",0,0,0,0,0,0)", "");
            db.excetedate("insert into user_backup  values(" + txt_id.Text + ",0,0)", "");
            db.excetedate("insert into user_supplier  values(" + txt_id.Text + ",0,0,0)", "");
            db.excetedate("insert into user_emp  values(" + txt_id.Text + ",0,0,0,0,0,0,0)", "");
            db.excetedate("insert into user_supplier  values(" + txt_id.Text + ",0,0,0)", "");
            AutoNumber();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            db.readData("update users set user_Name=N'" + txt_user.Text + "' ,User_password=N'" + txt_password.Text + "' ,type=N'" + cbx_type.Text + "' ,stock_ID=N'" + cbx_stock.SelectedValue + "',Rb7h=" + nud_rb7h.Value + "where user_ID=" + txt_id.Text + "", "تم تعديل البيانات بنجاح");
            AutoNumber();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من مسح البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from users where user_ID=" + txt_id.Text + "", "تم مسح البيانات بنجاح");

                DataTable tbluser = new DataTable();
                tbluser = db.readData("select * from users", "");
                string type = "مدير";
                db.excetedate("insert into users values(1, N'"+ Properties.Settings.Default.usernane+"', N'"+ Properties.Settings.Default.usernane+"',N'" + type + "',1,0  )", "");

                AutoNumber();
            }
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
                tbl = db.readData("select count(user_ID) from users", "");
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
            tbl = db.readData("select count(user_ID) from users", "");
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
            tbl = db.readData("select count(user_ID) from users", "");

            row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            show();
        }

        private void Dgv_search_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (Dgv_search.Rows.Count >= 1)
                {
                    tbl.Clear();
                    tbl = db.readData("select * from users", "");

                    txt_id.Text = tbl.Rows[0][0].ToString();
                    txt_user.Text = tbl.Rows[0][1].ToString();
                    txt_password.Text = tbl.Rows[0][2].ToString();
                    cbx_type.Text = tbl.Rows[0][3].ToString();
                    cbx_stock.SelectedValue = Convert.ToDecimal(tbl.Rows[0][4]);
                    nud_rb7h.Value = Convert.ToDecimal(tbl.Rows[0][5]);

                    btn_add.Enabled = false;
                    btn_new.Enabled = true;
                    btn_delete.Enabled = true;

                    btn_save.Enabled = true;

                }
            }
            catch (Exception) { }
        }
        DataTable tblsearch = new DataTable();
        private void cbx_user1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                tblsearch.Clear();
                tblsearch = db.readData("select * from users_setting where user_ID=" + cbx_user1.SelectedValue + "", "");
                if (tblsearch.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(tblsearch.Rows[0][1]) == 1)
                    {
                        checkUnits.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][1]) == 0)
                    {
                        checkUnits.Checked = false;
                    }
                }
                ////////////////////////////////////////////////////
                if (Convert.ToInt32(tblsearch.Rows[0][2]) == 1)
                {
                    checkPermission.Checked = true;

                }
                else if (Convert.ToInt32(tblsearch.Rows[0][2]) == 0)
                {
                    checkPermission.Checked = false;
                }
                ////////////////////////////////////////////////////////////////////
                if (Convert.ToInt32(tblsearch.Rows[0][3]) == 1)
                {
                    checkSetting.Checked = true;

                }
                else if (Convert.ToInt32(tblsearch.Rows[0][3]) == 0)
                {
                    checkSetting.Checked = false;
                }
                //////////////////////////////////////////
                if (Convert.ToInt32(tblsearch.Rows[0][4]) == 1)
                {
                    checkitemadd.Checked = true;

                }
                else if (Convert.ToInt32(tblsearch.Rows[0][4]) == 0)
                {
                    checkitemadd.Checked = false;
                }
                //////////////////////////////////////////
                if (Convert.ToInt32(tblsearch.Rows[0][5]) == 1)
                {
                    checkViewitem.Checked = true;

                }
                else if (Convert.ToInt32(tblsearch.Rows[0][5]) == 0)
                {
                    checkViewitem.Checked = false;
                }
                //////////////////////////////////////////
                if (Convert.ToInt32(tblsearch.Rows[0][6]) == 1)
                {
                    checkItemsgroup.Checked = true;

                }
                else if (Convert.ToInt32(tblsearch.Rows[0][6]) == 0)
                {
                    checkItemsgroup.Checked = false;
                }
                //////////////////////////////////////////
                if (Convert.ToInt32(tblsearch.Rows[0][7]) == 1)
                {
                    checkstoreAdd.Checked = true;

                }
                else if (Convert.ToInt32(tblsearch.Rows[0][7]) == 0)
                {
                    checkstoreAdd.Checked = false;
                }
                //////////////////////////////////////////
                if (Convert.ToInt32(tblsearch.Rows[0][8]) == 1)
                {
                    checkstoreGard.Checked = true;

                }
                else if (Convert.ToInt32(tblsearch.Rows[0][8]) == 0)
                {
                    checkstoreGard.Checked = false;
                }
                //////////////////////////////////////////
                if (Convert.ToInt32(tblsearch.Rows[0][9]) == 1)
                {
                    checkstoretransfer.Checked = true;

                }
                else if (Convert.ToInt32(tblsearch.Rows[0][9]) == 0)
                {
                    checkstoretransfer.Checked = false;
                } //////////////////////////////////////////
                if (Convert.ToInt32(tblsearch.Rows[0][10]) == 1)
                {
                    checkstoreout.Checked = true;

                }
                else if (Convert.ToInt32(tblsearch.Rows[0][10]) == 0)
                {
                    checkstoreout.Checked = false;
                } //////////////////////////////////////////
                if (Convert.ToInt32(tblsearch.Rows[0][11]) == 1)
                {
                    checkstoretransferreport.Checked = true;

                }
                else if (Convert.ToInt32(tblsearch.Rows[0][11]) == 0)
                {
                    checkstoretransferreport.Checked = false;
                } //////////////////////////////////////////
                if (Convert.ToInt32(tblsearch.Rows[0][12]) == 1)
                {
                    checkstoreoutreport.Checked = true;

                }
                else if (Convert.ToInt32(tblsearch.Rows[0][12]) == 0)
                {
                    checkstoreoutreport.Checked = false;
                }





            }       //لكي يظهر لي رساله بالخطأ
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_save1_Click(object sender, EventArgs e)
        {
            try
            {

                int setting, units, permission, itemview, itemadd, itemgroup, storeadd = 0,storeGard=0, storetransfer=0, storeout=0, storetransferreport=0, storeoutreport=0;

                if (checkUnits.Checked == true)
                    units = 1;
                else
                    units = 0;
                if (checkSetting.Checked == true)
                    setting = 1;
                else setting = 0;
                if (checkPermission.Checked == true)
                    permission = 1;
                else permission = 0;
                if (checkViewitem.Checked == true)
                    itemview = 1;
                else itemview = 0;
                if (checkitemadd.Checked == true)
                    itemadd = 1;
                else itemadd = 0;
                if (checkItemsgroup.Checked == true)
                    itemgroup = 1;
                else itemgroup = 0;
                if (checkstoreAdd.Checked == true)
                    storeadd = 1;
                else storeadd = 0;
                if (checkstoreGard.Checked == true)
                    storeGard = 1;
                else storeGard = 0;
                if (checkstoretransfer.Checked == true)
                    storetransfer = 1;
                else storetransfer = 0;
                if (checkstoreout.Checked == true)
                    storeout = 1;
                else storeout = 0;
                if (checkstoretransferreport.Checked == true)
                    storetransferreport = 1;
                else storetransferreport = 0;
                if (checkstoreoutreport.Checked == true)
                    storeoutreport = 1;
                else storeoutreport = 0;

                db.excetedate("update users_setting set unit=" + units + ",user_permission=" + permission + ",setting=" + setting + ",item_add=" + itemadd + ",item_view=" + itemview + ",item_group=" + itemgroup + ",store_add=" + storeadd + ",store_gard =" + storeGard+ ",store_transfer =" + storetransfer + ",store_out =" + storeout + ",store_transferreport =" + storetransferreport + ",store_outreport =" + storeoutreport + "where user_ID = " + cbx_user1.SelectedValue + " ", "تم التعديل بنجاح");
                cbx_user1.SelectedIndex = 0;


            }
            catch (Exception) { }
        }

        private void cbx_user2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                tblsearch.Clear();
                tblsearch = db.readData("select * from user_customer where user_ID=" + cbx_user2.SelectedValue + "", "");
                if (tblsearch.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(tblsearch.Rows[0][1]) == 1)
                    {
                        checkcustinformation.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][1]) == 0)
                    {
                        checkcustinformation.Checked = false;
                    }

                    ////////////////////////////////////////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][2]) == 1)
                    {
                        checkcustmoney.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][2]) == 0)
                    {
                        checkcustmoney.Checked = false;
                    }
                    ////////////////////////////////////////////////////////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][3]) == 1)
                    {
                        checkcustreport.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][3]) == 0)
                    {
                        checkcustreport.Checked = false;
                    }
                }
            }
            catch (Exception) { }
        }

        private void btn_save2_Click(object sender, EventArgs e)
        {
            try
            {

                int custinformaton, custmoney, custreport = 0;

                if (checkcustinformation.Checked == true)
                    custinformaton = 1;
                else
                    custinformaton = 0;
                if (checkcustmoney.Checked == true)
                    custmoney = 1;
                else custmoney = 0;
                if (checkcustreport.Checked == true)
                    custreport = 1;
                else custreport = 0;



                db.excetedate("update user_customer set cust_information=" + custinformaton + ",cust_money=" + custmoney + ",cust_report=" + custreport + "where user_ID = " + cbx_user2.SelectedValue + " ", "تم التعديل بنجاح");
                cbx_user2.SelectedIndex = 0;



            }       //لكي يظهر لي رساله بالخطأ
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void cbx_user3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                tblsearch.Clear();
                tblsearch = db.readData("select * from user_supplier where user_ID=" + cbx_user3.SelectedValue + "", "");
                if (tblsearch.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(tblsearch.Rows[0][1]) == 1)
                    {
                        checkesupp.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][1]) == 0)
                    {
                        checkesupp.Checked = false;

                    }
                    ////////////////////////////////////////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][2]) == 1)
                    {
                        checksuppmoney.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][2]) == 0)
                    {
                        checksuppmoney.Checked = false;
                    }
                    ////////////////////////////////////////////////////////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][3]) == 1)
                    {
                        checksuppreport.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][3]) == 0)
                    {
                        checksuppreport.Checked = false;
                    }
                }
            }
            catch (Exception) { }
        }

        private void btn_save3_Click(object sender, EventArgs e)
        {

            try
            {

                int empinformaton, empmoney, empreport = 0;

                if (checkcustinformation.Checked == true)
                    empinformaton = 1;
                else
                    empinformaton = 0;
                if (checkcustmoney.Checked == true)
                    empmoney = 1;
                else empmoney = 0;
                if (checkcustreport.Checked == true)
                    empreport = 1;
                else empreport = 0;



                db.excetedate("update user_supplier set supp_data=" + empinformaton + ",supp_money=" + empmoney + ",supp_report=" + empreport + "where user_ID = " + cbx_user3.SelectedValue + " ", "تم التعديل بنجاح");
                cbx_user3.SelectedIndex = 0;



            }       //لكي يظهر لي رساله بالخطأ
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void cbx_user4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                tblsearch.Clear();
                tblsearch = db.readData("select * from user_buy where user_ID=" + cbx_user4.SelectedValue + "", "");
                if (tblsearch.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(tblsearch.Rows[0][1]) == 1)
                    {
                        checkbuy.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][1]) == 0)
                    {
                        checkbuy.Checked = false;

                    }
                    ////////////////////////////////////////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][2]) == 1)
                    {
                        checkbuyreport.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][2]) == 0)
                    {
                        checkbuyreport.Checked = false;
                    }
                    ////////////////////////////////////////////////////////////////////

                }
            }
            catch (Exception) { }
        }

        private void btn_save4_Click(object sender, EventArgs e)
        {

            try
            {

                int buy, buyreport = 0;

                if (checkbuy.Checked == true)
                    buy = 1;
                else
                    buy = 0;
                if (checkbuyreport.Checked == true)
                    buyreport = 1;
                else buyreport = 0;



                db.excetedate("update user_buy set buy=" + buy + ",buyreport=" + buyreport + "where user_ID = " + cbx_user4.SelectedValue + " ", "تم التعديل بنجاح");
                cbx_user4.SelectedIndex = 0;

            }           //لكي يظهر لي رساله بالخطأ
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void cbx_user5_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                tblsearch.Clear();
                tblsearch = db.readData("select * from user_sale where user_ID=" + cbx_user5.SelectedValue + "", "");
                if (tblsearch.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(tblsearch.Rows[0][1]) == 1)
                    {
                        checksales.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][1]) == 0)
                    {
                        checksales.Checked = false;
                    }

                    ////////////////////////////////////////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][2]) == 1)
                    {
                        checksalereport.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][2]) == 0)
                    {
                        checksalereport.Checked = false;
                    }
                    ////////////////////////////////////////////////////////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][2]) == 1)
                    {
                        checksalerep7h.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][2]) == 0)
                    {
                        checksalerep7h.Checked = false;
                    }
                }
            }
            catch (Exception) { }
        }

        private void btn_save5_Click(object sender, EventArgs e)
        {
            try
            {

                int sale, salereport, salerep7h = 0;

                if (checksales.Checked == true)
                    sale = 1;
                else
                    sale = 0;
                if (checksalereport.Checked == true)
                    salereport = 1;
                else salereport = 0;
                if (checksalerep7h.Checked == true)
                    salerep7h = 1;
                else salerep7h = 0;


                db.excetedate("update user_sale set sale=" + sale + ",salereport=" + salereport + ",salerep7h=" + salerep7h + "where user_ID = " + cbx_user5.SelectedValue + " ", "تم التعديل بنجاح");
                cbx_user5.SelectedIndex = 0;

            }           //لكي يظهر لي رساله بالخطأ
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void cbx_user6_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                tblsearch.Clear();
                tblsearch = db.readData("select * from user_return where user_ID=" + cbx_user6.SelectedValue + "", "");
                if (tblsearch.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(tblsearch.Rows[0][1]) == 1)
                    {
                        checkreturn.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][1]) == 0)
                    {
                        checkreturn.Checked = false;

                    }
                    ////////////////////////////////////////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][2]) == 1)
                    {
                        checkreturnreport.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][2]) == 0)
                    {
                        checkreturnreport.Checked = false;
                    }

                }
            }
            catch (Exception) { }
        }

        private void btn_saave6_Click(object sender, EventArgs e)
        {
            try
            {

                int rreturn, returnreport = 0;

                if (checkreturn.Checked == true)
                    rreturn = 1;
                else
                    rreturn = 0;
                if (checkreturnreport.Checked == true)
                    returnreport = 1;
                else returnreport = 0;


                db.excetedate("update user_return set rreturn=" + rreturn + ",returnreport=" + returnreport + "where user_ID = " + cbx_user6.SelectedValue + " ", "تم التعديل بنجاح");
                cbx_user6.SelectedIndex = 0;

            }           //لكي يظهر لي رساله بالخطأ
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void cbx_user7_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                tblsearch.Clear();
                tblsearch = db.readData("select * from user_deserved where user_ID=" + cbx_user7.SelectedValue + "", "");
                if (tblsearch.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(tblsearch.Rows[0][1]) == 1)
                    {
                        checkdeservedtype.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][1]) == 0)
                    {
                        checkdeservedtype.Checked = false;
                    }

                    ////////////////////////////////////////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][2]) == 1)
                    {
                        checkdeserved.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][2]) == 0)
                    {
                        checkdeserved.Checked = false;
                    }
                    ////////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][3]) == 1)
                    {
                        checkdeservedreport.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][3]) == 0)
                    {
                        checkdeservedreport.Checked = false;
                    }
                    ///////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][4]) == 1)
                    {
                        checksanadkabd.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][4]) == 0)
                    {
                        checksanadkabd.Checked = false;
                    }
                    ////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][5]) == 1)
                    {
                        checksanadsarf.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][5]) == 0)
                    {
                        checksanadsarf.Checked = false;
                    }
                    ///////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][6]) == 1)
                    {
                        checksanadreport.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][6]) == 0)
                    {
                        checksanadreport.Checked = false;
                    }
                    ///////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][7]) == 1)
                    {
                        checktaxes.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][6]) == 0)
                    {
                        checktaxes.Checked = false;
                    }

                }
            }
            catch (Exception) { }
        }

        private void btn_save7_Click(object sender, EventArgs e)
        {
            try
            {

                int deservedtype, deserved, deservedreport, kabd, sarf, sanadreport = 0,taxes=0;

                if (checkdeservedtype.Checked == true)
                    deservedtype = 1;
                else
                    deservedtype = 0;
                if (checkdeserved.Checked == true)
                    deserved = 1;
                else deserved = 0;
                if (checkdeservedreport.Checked == true)
                    deservedreport = 1;
                else deservedreport = 0;
                if (checksanadkabd.Checked == true)
                    kabd = 1;
                else kabd = 0;
                if (checksanadsarf.Checked == true)
                    sarf = 1;
                else sarf = 0;
                if (checksanadreport.Checked == true)
                    sanadreport = 1;
                else sanadreport = 0;
                if (checktaxes.Checked == true)
                    taxes = 1;
                else taxes = 0;

                db.excetedate("update user_deserved set deservedtype=" + deservedtype + ",deserved=" + deserved + ",deservedreport=" + deservedreport + ",sanad_kabd=" + kabd + ",sanad_sarf=" + sarf + ",sanadreport=" + sanadreport + ",taxesreport=" + taxes+" where user_ID = " + cbx_user7.SelectedValue + " ", "تم التعديل بنجاح");
                cbx_user7.SelectedIndex = 0;

            }           //لكي يظهر لي رساله بالخطأ
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void cbx_user8_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                tblsearch.Clear();
                tblsearch = db.readData("select * from user_money where user_ID=" + cbx_user8.SelectedValue + "", "");
                if (tblsearch.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(tblsearch.Rows[0][1]) == 1)
                    {
                        checkstockadd.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][1]) == 0)
                    {
                        checkstockadd.Checked = false;
                    }

                    ////////////////////////////////////////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][2]) == 1)
                    {
                        checkstockaddmoney.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][2]) == 0)
                    {
                        checkstockaddmoney.Checked = false;
                    }
                    ////////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][3]) == 1)
                    {
                        checkbankaddmoney.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][3]) == 0)
                    {
                        checkbankaddmoney.Checked = false;
                    }
                    ///////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][4]) == 1)
                    {
                        checkstockpullmoney.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][4]) == 0)
                    {
                        checkstockpullmoney.Checked = false;
                    }
                    ////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][5]) == 1)
                    {
                        checkbankpullmoney.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][5]) == 0)
                    {
                        checkbankpullmoney.Checked = false;
                    }
                    ///////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][6]) == 1)
                    {
                        checkstocktransfer.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][6]) == 0)
                    {
                        checkstocktransfer.Checked = false;
                    }
                    ///////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][7]) == 1)
                    {
                        checkbalansstockandbank.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][7]) == 0)
                    {
                        checkbalansstockandbank.Checked = false;
                    }  ///////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][8]) == 1)
                    {
                        checktransferstok_bank.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][8]) == 0)
                    {
                        checktransferstok_bank.Checked = false;
                    }  ///////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][9]) == 1)
                    {
                        checkstockbankreport.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][9]) == 0)
                    {
                        checkstockbankreport.Checked = false;
                    }


                }
            }
            catch (Exception) { }
        }

        private void btn_save8_Click(object sender, EventArgs e)
        {
            try
            {

                int stockadd, stockaddmoney, bankaddmoney, stockpullmoney, bankpullmoney, stocktransfer, balance_bank_stock, transferbank_stock, report_bankstock = 0;

                if (checkstockadd.Checked == true)
                    stockadd = 1;
                else
                    stockadd = 0;
                if (checkstockaddmoney.Checked == true)
                    stockaddmoney = 1;
                else stockaddmoney = 0;
                if (checkbankaddmoney.Checked == true)
                    bankaddmoney = 1;
                else bankaddmoney = 0;
                if (checkstockpullmoney.Checked == true)
                    stockpullmoney = 1;
                else stockpullmoney = 0;
                if (checkbankpullmoney.Checked == true)
                    bankpullmoney = 1;
                else bankpullmoney = 0;
                if (checkstocktransfer.Checked == true)
                    stocktransfer = 1;
                else stocktransfer = 0;
                if (checkbalansstockandbank.Checked == true)
                    balance_bank_stock = 1;
                else balance_bank_stock = 0;
                if (checktransferstok_bank.Checked == true)
                    transferbank_stock = 1;
                else transferbank_stock = 0;
                if (checkstockbankreport.Checked == true)
                    report_bankstock = 1;
                else report_bankstock = 0;
                db.excetedate("update user_money set stockadd=" + stockadd + ",stockaddmoney=" + stockaddmoney + ",bankaddmoney=" + bankaddmoney + ",stockpullmoney=" + stockpullmoney + ",bankpullmoney=" + bankpullmoney + ",stocktransfer=" + stocktransfer + ",balance_bank_stock=" + balance_bank_stock + ",transferbank_stock=" + transferbank_stock + ",report_bankstock=" + report_bankstock + " where user_ID = " + cbx_user8.SelectedValue + " ", "تم التعديل بنجاح");
                cbx_user8.SelectedIndex = 0;

            }           //لكي يظهر لي رساله بالخطأ
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbx_user9_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                tblsearch.Clear();
                tblsearch = db.readData("select * from user_emp where user_ID=" + cbx_user9.SelectedValue + "", "");
                if (tblsearch.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(tblsearch.Rows[0][1]) == 1)
                    {
                        checkemployeee.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][1]) == 0)
                    {
                        checkemployeee.Checked = false;
                    }

                    ////////////////////////////////////////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][2]) == 1)
                    {
                        checkmonthpull.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][2]) == 0)
                    {
                        checkmonthpull.Checked = false;
                    }
                    ////////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][3]) == 1)
                    {
                        checkemployeesalary.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][3]) == 0)
                    {
                        checkemployeesalary.Checked = false;
                    }
                    ///////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][4]) == 1)
                    {
                        checksalereport.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][4]) == 0)
                    {
                        checksalereport.Checked = false;
                    }
                    ////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][5]) == 1)
                    {
                        checkpullreport.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][5]) == 0)
                    {
                        checkpullreport.Checked = false;
                    }
                    ///////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][6]) == 1)
                    {
                        checkborrow.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][6]) == 0)
                    {
                        checkborrow.Checked = false;
                    }
                    ///////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][7]) == 1)
                    {
                        checkborrowreport.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][7]) == 0)
                    {
                        checkborrowreport.Checked = false;

                    }
                    ///////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][8]) == 1)
                    {
                        checksalaryreport.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][7]) == 0)
                    {
                        checksalaryreport.Checked = false;

                    }
                }
            }
            catch (Exception) { }
        }

        private void btn_save9_Click(object sender, EventArgs e)
        {
            try
            {

                int employeee, employeepull, employeesalary, salaryreport , pullreport, borrow , borrowreport = 0;

                if (checkemployeee.Checked == true)
                    employeee = 1;
                else
                    employeee = 0;
                if (checkmonthpull.Checked == true)
                    employeepull = 1;
                else employeepull = 0;
                if (checkemployeesalary.Checked == true)
                    employeesalary= 1;
                else employeesalary = 0;
                if (checksalaryreport.Checked == true)
                    salaryreport = 1;
                else salaryreport = 0;
                if (checkpullreport.Checked == true)
                    pullreport = 1;
                else pullreport = 0;
                if (checkborrow.Checked == true)
                    borrow = 1;
                else borrow = 0;
                if (checkborrowreport.Checked == true)
                    borrowreport = 1;
                else borrowreport = 0;
               
                db.excetedate("update user_emp set employee=" + employeee + ",employeepull=" + employeepull + ",employeesalary=" + employeesalary + ",salaryreport=" + salaryreport + ",pullreport=" + pullreport + ",borrow=" + borrow + ",borrowreport=" + borrowreport + " where user_ID = " + cbx_user9.SelectedValue + " ", "تم التعديل بنجاح");
                cbx_user9.SelectedIndex = 0;

            }           //لكي يظهر لي رساله بالخطأ
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbx_user10_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {
                tblsearch.Clear();
                tblsearch = db.readData("select * from user_report where user_ID=" + cbx_user10.SelectedValue + "", "");
                if (tblsearch.Rows.Count >= 1)
                {
                    if (Convert.ToInt32(tblsearch.Rows[0][1]) == 1)
                    {
                        checkcustomerRE.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][1]) == 0)
                    {
                        checkcustomerRE.Checked = false;
                    }

                    ////////////////////////////////////////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][2]) == 1)
                    {
                        checkemployeeRE.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][2]) == 0)
                    {
                        checkemployeeRE.Checked = false;
                    }
                    ////////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][3]) == 1)
                    {
                        checkBuyRE.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][3]) == 0)
                    {
                        checkBuyRE.Checked = false;
                    }
                    ///////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][4]) == 1)
                    {
                        checksaleRE.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][4]) == 0)
                    {
                        checksaleRE.Checked = false;
                    }
                    ////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][5]) == 1)
                    {
                        checkreturnRE.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][5]) == 0)
                    {
                        checkreturnRE.Checked = false;
                    }
                    ///////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][6]) == 1)
                    {
                        checkdesrvedRE.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][6]) == 0)
                    {
                        checkdesrvedRE.Checked = false;
                    }
                    ///////////////////
                  
                }
            }
            catch (Exception) { }
        }

        private void btn_save10_Click(object sender, EventArgs e)
        {
            try
            {

                int customer_report, employee_report, buy_report, sale_report, return_report, desrved_report = 0;

                if (checkcustomerRE.Checked == true)
                    customer_report = 1;
                else
                    customer_report = 0;
                if (checkemployeeRE.Checked == true)
                    employee_report = 1;
                else employee_report = 0;
                if (checkBuyRE.Checked == true)
                    buy_report = 1;
                else buy_report = 0;
                if (checksaleRE.Checked == true)
                    sale_report = 1;
                else sale_report = 0;
                if (checkreturnRE.Checked == true)
                    return_report = 1;
                else return_report = 0;
                if (checkdesrvedRE.Checked == true)
                    desrved_report = 1;
                else desrved_report = 0;
              

                db.excetedate("update user_report set customer_report=" + customer_report + ",employee_report=" + employee_report + ",buy_report=" + buy_report + ",sale_report=" + sale_report + ",return_report=" + return_report + ",deserved_report=" + desrved_report + "where user_ID = " + cbx_user10.SelectedValue + " ", "تم التعديل بنجاح");
                cbx_user10.SelectedIndex = 0;

            }           //لكي يظهر لي رساله بالخطأ
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbx_user11_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                tblsearch.Clear();
                tblsearch = db.readData("select * from user_report where user_ID=" + cbx_user10.SelectedValue + "", "");
                if (tblsearch.Rows.Count >= 1)
                {
                   
                   
                    ////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][1]) == 1)
                    {
                        checktakebackup.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][1]) == 0)
                    {
                        checktakebackup.Checked = false;
                    }
                    ///////////////////
                    if (Convert.ToInt32(tblsearch.Rows[0][2]) == 1)
                    {
                        checkreturnbackup.Checked = true;

                    }
                    else if (Convert.ToInt32(tblsearch.Rows[0][2]) == 0)
                    {
                        checkreturnbackup.Checked = false;
                    }
                    ///////////////////

                }
            }
            catch (Exception) { }
        }

        private void btn_save11_Click(object sender, EventArgs e)
        {

            try
            {

                int takebackup, returnbackup = 0;

                if (checktakebackup.Checked == true)
                    takebackup = 1;
                else
                    takebackup = 0;
                if (checkreturnbackup.Checked == true)
                    returnbackup = 1;
                else returnbackup = 0;
               


                db.excetedate("update user_backup set take_backup=" + takebackup + ",return_backup=" + returnbackup + "where user_ID = " + cbx_user11.SelectedValue + " ", "تم التعديل بنجاح");
                cbx_user11.SelectedIndex = 0;

            }           //لكي يظهر لي رساله بالخطأ
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}