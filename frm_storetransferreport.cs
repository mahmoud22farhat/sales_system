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
    public partial class frm_storetransferreport : DevExpress.XtraEditors.XtraForm
    {
        public frm_storetransferreport()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();
        private void fillstore()
        {
            cbx_storefrom.DataSource = db.readData("select * from store", "");
            cbx_storefrom.DisplayMember = "store_Name";
            cbx_storefrom.ValueMember = "store_ID";


            cbx_storeto.DataSource = db.readData("select * from store", "");
            cbx_storeto.DisplayMember = "store_Name";
            cbx_storeto.ValueMember = "store_ID";
        }
        private void frm_storetransferreport_Load(object sender, EventArgs e)
        {
            fillstore();
            dtp_from.Text = DateTime.Now.ToShortDateString();
            dtp_to.Text = DateTime.Now.ToShortDateString();
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                string date1;
            string date2;
            date1 = dtp_from.Value.ToString("yyyy-MM-dd");
            date2 = dtp_to.Value.ToString("yyyy-MM-dd");

            tbl.Clear();
          
                if (rbtn_allstorefrom.Checked == true)
                {
                    if (rbtn_allstoreto.Checked == true)
                        tbl = db.readData("SELECT [Order_ID]as'رقم العملية',[pro_name]as'اسم المنتج',[store_from]as'المخزن المحول منه',[store_to]as'المخزن المحول له',[Qty]as'الكمية المحوله',[unit]as'الوحدة',[Buy_price]as'سعر الشراء',[sale_price]as'سعر البيع',[Date]as'التاريخ',[Name]as'اسم المسئول عن التحويل',[Reason]as'سبب التحويل'FROM [dbo].[products_transfer] where convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "");
                    else if (rbtn_onestoreto.Checked == true)
                        tbl = db.readData("SELECT [Order_ID]as'رقم العملية',[pro_name]as'اسم المنتج',[store_from]as'المخزن المحول منه',[store_to]as'المخزن المحول له',[Qty]as'الكمية المحوله',[unit]as'الوحدة',[Buy_price]as'سعر الشراء',[sale_price]as'سعر البيع',[Date]as'التاريخ',[Name]as'اسم المسئول عن التحويل',[Reason]as'سبب التحويل'FROM [dbo].[products_transfer] where store_to=N'" + cbx_storeto.Text + "' and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");
                }
                else if (rbtn_allstoreto.Checked == true)
                {
                    if (rbtn_allstorefrom.Checked == true)
                        tbl = db.readData("SELECT [Order_ID]as'رقم العملية',[pro_name]as'اسم المنتج',[store_from]as'المخزن المحول منه',[store_to]as'المخزن المحول له',[Qty]as'الكمية المحوله',[unit]as'الوحدة',[Buy_price]as'سعر الشراء',[sale_price]as'سعر البيع',[Date]as'التاريخ',[Name]as'اسم المسئول عن التحويل',[Reason]as'سبب التحويل'FROM [dbo].[products_transfer] where convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "");
                    else if (rbtn_onestorefrom.Checked == true)
                        tbl = db.readData("SELECT [Order_ID]as'رقم العملية',[pro_name]as'اسم المنتج',[store_from]as'المخزن المحول منه',[store_to]as'المخزن المحول له',[Qty]as'الكمية المحوله',[unit]as'الوحدة',[Buy_price]as'سعر الشراء',[sale_price]as'سعر البيع',[Date]as'التاريخ',[Name]as'اسم المسئول عن التحويل',[Reason]as'سبب التحويل'FROM [dbo].[products_transfer] where store_from=N'" + cbx_storefrom.Text + "' and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "");
                }
                ////////////--------------------------العكس----------------

                else if (rbtn_onestorefrom.Checked == true)
                {
                    if (rbtn_allstoreto.Checked == true)
                        tbl = db.readData("SELECT [Order_ID]as'رقم العملية',[pro_name]as'اسم المنتج',[store_from]as'المخزن المحول منه',[store_to]as'المخزن المحول له',[Qty]as'الكمية المحوله',[unit]as'الوحدة',[Buy_price]as'سعر الشراء',[sale_price]as'سعر البيع',[Date]as'التاريخ',[Name]as'اسم المسئول عن التحويل',[Reason]as'سبب التحويل'FROM [dbo].[products_transfer] where store_from=N'" + cbx_storefrom.Text + "' and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "");
                    else if (rbtn_onestoreto.Checked == true)
                        tbl = db.readData("SELECT [Order_ID]as'رقم العملية',[pro_name]as'اسم المنتج',[store_from]as'المخزن المحول منه',[store_to]as'المخزن المحول له',[Qty]as'الكمية المحوله',[unit]as'الوحدة',[Buy_price]as'سعر الشراء',[sale_price]as'سعر البيع',[Date]as'التاريخ',[Name]as'اسم المسئول عن التحويل',[Reason]as'سبب التحويل'FROM [dbo].[products_transfer] where store_to=N'" + cbx_storeto.Text + "' and store_from=N'" + cbx_storefrom.Text + "' and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "");
                }
                else if (rbtn_onestoreto.Checked == true)
                {
                    if (rbtn_allstorefrom.Checked == true)
                        tbl = db.readData("SELECT [Order_ID]as'رقم العملية',[pro_name]as'اسم المنتج',[store_from]as'المخزن المحول منه',[store_to]as'المخزن المحول له',[Qty]as'الكمية المحوله',[unit]as'الوحدة',[Buy_price]as'سعر الشراء',[sale_price]as'سعر البيع',[Date]as'التاريخ',[Name]as'اسم المسئول عن التحويل',[Reason]as'سبب التحويل'FROM [dbo].[products_transfer] where store_to=N'" + cbx_storeto.Text + "' and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "' ", "");
                    else if (rbtn_onestorefrom.Checked == true)
                        tbl = db.readData("SELECT [Order_ID]as'رقم العملية',[pro_name]as'اسم المنتج',[store_from]as'المخزن المحول منه',[store_to]as'المخزن المحول له',[Qty]as'الكمية المحوله',[unit]as'الوحدة',[Buy_price]as'سعر الشراء',[sale_price]as'سعر البيع',[Date]as'التاريخ',[Name]as'اسم المسئول عن التحويل',[Reason]as'سبب التحويل'FROM [dbo].[products_transfer] where store_from=N'" + cbx_storefrom.Text + "' and store_to=N'" + cbx_storeto.Text + "' and convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "");
                }


                Dgv_search.DataSource = tbl;
                  }
            catch (Exception) { }
            if (Dgv_search.Rows.Count >= 1)
            {

                decimal totalQty = 0;
                for (int i = 0; i <= Dgv_search.Rows.Count - i; i++)
                {
                    totalQty += Convert.ToDecimal(Dgv_search.Rows[i].Cells[4].Value);
                }
                txt_total.Text = Math.Round(totalQty, 2).ToString();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string date1;
            string date2;
            date1 = dtp_from.Value.ToString("yyyy-MM-dd");
            date2 = dtp_to.Value.ToString("yyyy-MM-dd");

            if (MessageBox.Show("هل انت متاكد من مسح البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.excetedate("delete from products_transfer where convert( date,Date ,105 ) between '" + date1 + "' and '" + date2 + "'", "تم مسح البيانات بنجاح");
                btn_search_Click(null,null);
            }
        }
    }
}