using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using System.IO;

namespace sales
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        int user_ID = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            try{
                user_ID =Convert.ToInt32( db.readData("select * from users where user_Name=N'" + Properties.Settings.Default.usernane+"'", "").Rows[0][0]);

            } catch (Exception) { }

            barStaticItem3.Caption = "التاريخ |" + DateTime.Now.ToShortDateString();
            barStaticItem4.Caption = "اسم المستخدم |" + Properties.Settings.Default.usernane;

        }

        private bool sheckuser(string filed,string table)
        {
            DataTable tblsearch = new DataTable();
            tblsearch = db.readData("select "+filed+" from "+table+" where user_ID = " + user_ID+"", "");
            if (Convert.ToDecimal(tblsearch.Rows[0][0])==0)
            {
                MessageBox.Show("انت لا تملك صلاحية الدخول لهذه الشاشة", "تحذير",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("cust_information", "user_customer");
            if (check == true)
            {
                frm_customer frm = new frm_customer();
                frm.ShowDialog();
            }
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("supp_data", "user_supplier");
            if (check == true)
            {
                frm_supliers frm = new frm_supliers();
                frm.ShowDialog();
            }
        }
        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("deservedtype", "user_deserved");
            if (check == true)
            {

                frm_deservedtype frm = new frm_deservedtype();
                frm.ShowDialog();
            }
        }
        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("deserved", "user_deserved");
            if (check == true)
            {
                frm_deserved frm = new frm_deserved();
                frm.ShowDialog();
            }
        }
        private void barButtonItem23_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("deservedreport", "user_deserved");
            if (check == true)
            {
                deservedRepor frm = new deservedRepor();
                frm.ShowDialog();
            }
        }
        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("item_add", "users_setting");
            if (check == true)
            {
                frm_products frm = new frm_products();
                frm.ShowDialog();
            }
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("buy", "user_buy");
            if (check == true)
            {
                frm_buy frm = new frm_buy();
                frm.ShowDialog();
            }
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("supp_money", "user_supplier");
            if (check == true)
            {
                frm_supliermony frm = new frm_supliermony();
                frm.ShowDialog();
            }
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("supp_report", "user_supplier");
            if (check == true)
            {
                frm_suppplierReport frm = new frm_suppplierReport();
                frm.ShowDialog();

            }
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("buyreport", "user_buy");
            if (check == true)
            {
                frm_BuyReporter frm = new frm_BuyReporter();
                frm.ShowDialog();
            }
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("sale", "user_sale");
            if (check == true)
            {
                frm_sales frm = new frm_sales();
                frm.ShowDialog();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("cust_money", "user_customer");
            if (check == true)
            {
                frm_customerMony frm = new frm_customerMony();
                frm.ShowDialog();
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("cust_report", "user_customer");
            if (check == true)
            {
                frm_customerReport frm = new frm_customerReport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("salereport", "user_sale");
            if (check == true)
            {
                frm_saleReport frm = new frm_saleReport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("salerep7h", "user_sale");
            if (check == true)
            {
                frm_salesRp7h frm = new frm_salesRp7h();
                frm.ShowDialog();
            }
        }
        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("rreturn", "user_return");
            if (check == true)
            {
                frm_Return frm = new frm_Return();
                frm.ShowDialog();
            }
        }

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("returnreport", "user_return");
            if (check == true)
            {
                frm_Return_Report frm = new frm_Return_Report();
                frm.ShowDialog();
            }
        }
        private void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("stockadd", "user_money");
            if (check == true)
            {
                frm_AddStock frm = new frm_AddStock();
                frm.ShowDialog();
            }
        }

        private void barButtonItem32_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("stockaddmoney", "user_money");
            if (check == true)
            {
                frm_StockAddMony frm = new frm_StockAddMony();
                frm.ShowDialog();
            }
        }

        private void barButtonItem33_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("bankaddmoney", "user_money");
            if (check == true)
            {
                frm_BankAddMoney frm = new frm_BankAddMoney();
                frm.ShowDialog();
            }
        }

        private void barButtonItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("stockpullmoney", "user_money");
            if (check == true)
            {
                frm_StockPullmoney frm = new frm_StockPullmoney();
                frm.ShowDialog();
            }
        }

        private void barButtonItem35_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("bankpullmoney", "user_money");
            if (check == true)
            {
                frm_BankPullmoney frm = new frm_BankPullmoney();
                frm.ShowDialog();
            }
        }
        private void barButtonItem36_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("stocktransfer", "user_money");
            if (check == true)
            {
                frm_stocktransfer frm = new frm_stocktransfer();
                frm.ShowDialog();
            }
        }

        private void barButtonItem37_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("transferbank_stock", "user_money");
            if (check == true)
            {
                frm_stockbanktransfer frm = new frm_stockbanktransfer();
                frm.ShowDialog();
            }
        }

        private void barButtonItem39_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("balance_bank_stock", "user_money");
            if (check == true)
            {
                frm_currentMoney frm = new frm_currentMoney();
                frm.ShowDialog();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem40_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("report_bankstock", "user_money");
            if (check == true)
            {
                frm_StockAddmoneyreport frm = new frm_StockAddmoneyreport();
                frm.ShowDialog();
            }
        }
        private void barButtonItem41_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("report_bankstock", "user_money");
            if (check == true)
            {
                frm_bankAddmoneyreport frm = new frm_bankAddmoneyreport();
                frm.ShowDialog();
            }
        }
        private void barButtonItem42_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { bool check = sheckuser("report_bankstock", "user_money");
            if (check == true)
            {
                frm_stockPullmoneyreport frm = new frm_stockPullmoneyreport();
            frm.ShowDialog();
        }
            }
        private void barButtonItem43_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("report_bankstock", "user_money");
            if (check == true)
            {
                frm_bankPullmoneyreport frm = new frm_bankPullmoneyreport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem44_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("report_bankstock", "user_money");
            if (check == true)
            {
                frm_stocktransferReport frm = new frm_stocktransferReport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem45_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("report_bankstock", "user_money");
            if (check == true)
            {
                frm_stockbanktransferReport frm = new frm_stockbanktransferReport();
                frm.ShowDialog();
            }
        }
        private void barButtonItem46_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("employee", "user_emp");
            if (check == true)
            {
                frm_Employee frm = new frm_Employee();
                frm.ShowDialog();
            }
        }
        private void barButtonItem48_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("employeesalary", "user_emp");
            if (check == true)
            {
                frm_Employeesalary frm = new frm_Employeesalary();
                frm.ShowDialog();
            }
        }
        private void barButtonItem47_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("employeepull", "user_emp");
            if (check == true)
            {
                frm_Employeeborrowitems frm = new frm_Employeeborrowitems();
                frm.ShowDialog();
            }
        }

        private void barButtonItem49_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("borrow", "user_emp");
            if (check == true)
            {
                frm_EmployeeBorrowMoney frm = new frm_EmployeeBorrowMoney();
                frm.ShowDialog();
            }
        }

        private void barButtonItem50_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("pullreport", "user_emp");
            if (check == true)
            {
                frm_EmployeeBorrowitemsReport frm = new frm_EmployeeBorrowitemsReport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem52_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("borrowreport", "user_emp");
            if (check == true)
            {
                frm_EmployeeBorrowMoneyReport frm = new frm_EmployeeBorrowMoneyReport();
                frm.ShowDialog();
            }
        }
        private void barButtonItem51_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("salaryreport", "user_emp");
            if (check == true)
            {
                frm_EmployeesalaryReport frm = new frm_EmployeesalaryReport();
                frm.ShowDialog();
            }
        }
        private void barButtonItem53_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("sanad_kabd", "user_deserved");
            if (check == true)
            {
                frm_sanadkabd frm = new frm_sanadkabd();
                frm.ShowDialog();
            }
        }

        private void barButtonItem54_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("sanad_sarf", "user_deserved");
            if (check == true)
            {
                frm_sanadsarf frm = new frm_sanadsarf();
                frm.ShowDialog();
            }
        }
        private void barButtonItem56_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("sanadreport", "user_deserved");
            if (check == true)
            {
                frm_sanadreport frm = new frm_sanadreport();
                frm.ShowDialog();
            }
        }
        database db = new database();
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("take_backup", "user_backup");
            if (check == true)
            {
                try
                {
                    string d = DateTime.Now.Date.ToString("yyyy-MM-dd");
                    SaveFileDialog open = new SaveFileDialog();
                    open.Filter = "Back Files (*.back) | *.back";
                    open.FileName = "sales_BackUp_" + d;


                    if (open.ShowDialog() == DialogResult.OK)
                    {

                        db.excetedate("backup database therd TO disk = '" + open.FileName + "'", "");

                    MessageBox.Show("تم اخذ نسخه احتياطيه بنجاح", "");
                    }

                }
                catch (Exception) { }


            }

            
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            bool check = sheckuser("return_backup", "user_backup");
            if (check == true)
            {
                Server server = new Server(@"DESKTOP-NJ3N9G2");
                Microsoft.SqlServer.Management.Smo.Database db = server.Databases["therd"];

                //لقفل اي عمليه موجوده علي قاعدة البيانات
                if (db != null)
                {
                    server.KillAllProcesses(db.Name);

                }
                //لأخذ النسخه ووضعها في قاعدة البيانات مباشرة
                Restore restore = new Restore();


                restore.Database = db.Name;
                restore.Action = RestoreActionType.Database;

                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Backup Files (*.back)|*.back|All Files (*.*)|*.*";               
                open.FilterIndex = 1;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    restore.Devices.AddDevice(open.FileName, DeviceType.File);
                    restore.ReplaceDatabase = true;
                    restore.NoRecovery = false;
                    restore.SqlRestore(server);
                    MessageBox.Show("تم استرجاع النسخه الاحتياطيه بنجاح", "تاكيد");
                }

            }
        }
        private void barButtonItem57_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("unit", "users_setting");
            if (check == true)
            {
                frm_unit frm = new frm_unit();
                frm.ShowDialog();
            }
        }

        private void barButtonItem58_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("item_group", "users_setting");
            if (check == true)
            {
                frm_productgroup frm = new frm_productgroup();
                frm.ShowDialog();
            }
        }
        private void barButtonItem59_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("store_add", "users_setting");
            if (check == true)
            {
                frm_store frm = new frm_store();
                frm.ShowDialog();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("user_permission", "users_setting");
            if (check == true)
            {
                frm_permission frm = new frm_permission();
                frm.ShowDialog();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("setting", "users_setting");
            if (check == true)
            {
                frm_setting frm = new frm_setting();
                frm.ShowDialog();
            }
        }
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("item_view", "users_setting");
            if (check == true)
            {
                frm_viewitems frm = new frm_viewitems();
                frm.ShowDialog();
            }
        }

        private void barButtonItem60_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("store_gard", "users_setting");
            if (check == true)
            {
                frm_storeGard frm = new frm_storeGard();
                frm.ShowDialog();
            }
        }
        private void barButtonItem61_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("store_transfer", "users_setting");
            if (check == true)
            {
                frm_storetransfer frm = new frm_storetransfer();
                frm.ShowDialog();
            }
        }

        private void barButtonItem62_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("store_transferreport", "users_setting");
            if (check == true)
            {
                frm_storetransferreport frm = new frm_storetransferreport();
                frm.ShowDialog();
            }
        }
        private void barButtonItem63_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("store_out", "users_setting");
            if (check == true)
            {
                frm_productoutstore frm = new frm_productoutstore();
                frm.ShowDialog();
            }
        }
        private void barButtonItem64_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("store_outreport", "users_setting");
            if (check == true)
            {
                frm_productoutstorereport frm = new frm_productoutstorereport();
                frm.ShowDialog();
            }
        }

        private void barButtonItem67_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool check = sheckuser("taxesreport", "user_deserved");
            if (check == true)
            {
                frm_taxesReport frm = new frm_taxesReport();
                frm.ShowDialog();
            }
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = sheckuser("salerep7h", "user_sale");
            if (check == true)
            {
                frm_salesRp7h frm = new frm_salesRp7h();
                frm.ShowDialog();
            }
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = sheckuser("user_permission", "users_setting");
            if (check == true)
            {
                frm_permission frm = new frm_permission();
                frm.ShowDialog();
            }
        }

        private void tileItem8_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = sheckuser("cust_money", "user_customer");
            if (check == true)
            {
                frm_customerMony frm = new frm_customerMony();
                frm.ShowDialog();
            }
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = sheckuser("supp_money", "user_supplier");
            if (check == true)
            {
                frm_supliermony frm = new frm_supliermony();
                frm.ShowDialog();
            }
        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = sheckuser("item_add", "users_setting");
            if (check == true)
            {
                frm_products frm = new frm_products();
                frm.ShowDialog();
            }
        }

        private void tileItem6_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = sheckuser("sale", "user_sale");
            if (check == true)
            {
                frm_sales frm = new frm_sales();
                frm.ShowDialog();
            }
        }

        private void tileItem5_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = sheckuser("buy", "user_buy");
            if (check == true)
            {
                frm_buy frm = new frm_buy();
                frm.ShowDialog();
            }
        }

        private void tileItem7_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = sheckuser("balance_bank_stock", "user_money");
            if (check == true)
            {
                frm_currentMoney frm = new frm_currentMoney();
                frm.ShowDialog();
            }
        }

        private void tileItem9_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            bool check = sheckuser("rreturn", "user_return");
            if (check == true)
            {
                frm_Return frm = new frm_Return();
                frm.ShowDialog();
            }
        }

        private void tileItem10_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            frm_product7adeltalab frm = new frm_product7adeltalab();
            frm.ShowDialog();
        }
    }
}
