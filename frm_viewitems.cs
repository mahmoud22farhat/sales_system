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
    public partial class frm_viewitems : DevExpress.XtraEditors.XtraForm
    {
        public frm_viewitems()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable(); DataTable tblstore = new DataTable();
        private void fillgroup()
        {
            cbx_group.DataSource = db.readData("select * from prouducts_group ", "");
            cbx_group.DisplayMember = "group_Name";
            cbx_group.ValueMember = "group_ID";
        }
        private void showallitems()
        {
            tbl.Clear();
           tbl= db.readData("SELECT [Pro_ID]as'رقم المنتج',[Pro_name]as'اسم المنتج',[main_UnitName]as'الوحده الرئيسيه',[Qty]as'الكميه الكليه',[gomla_price]as'سعر الجمله',[sale_price]as'سعر التجزأه',[tax_value]as'الضريبه',[sale_pricetax]as'السعر بعد الضريبه',[sale_unitname]as'وحدة البيع',[buy_UnitName]as'وحدة الشراء',[Barcode]as'الباركود',[minQty]as'الحد الادني',[maxdiscound]as'اقصي خصم مسموح',[is_tax]as'هل خاضع للضريبه',prouducts_group.group_Name as'اسم المجموعه'FROM [dbo].[products],prouducts_group where prouducts_group.group_ID=products.group_ID", "");

            Dgv_search.DataSource = tbl;
            showtotal();
        }
            private void frm_viewitems_Load(object sender, EventArgs e)
        {          
                fillgroup();
            showallitems();
        }
        private void showtotal()
        {
            try
            {
                decimal totalQty=0, totalgomla=0,totalpart=0,totaltaxe= 0;
                for (int i = 0; i <= Dgv_search.Rows.Count - i; i++)
                {
                    totalQty += Convert.ToDecimal(Dgv_search.Rows[i].Cells[3].Value);
                    totalgomla += Convert.ToDecimal(Dgv_search.Rows[i].Cells[4].Value) * Convert.ToDecimal(Dgv_search.Rows[i].Cells[3].Value);
                    totalpart += Convert.ToDecimal(Dgv_search.Rows[i].Cells[5].Value)* Convert.ToDecimal(Dgv_search.Rows[i].Cells[3].Value);
                    totaltaxe += Convert.ToDecimal(Dgv_search.Rows[i].Cells[7].Value)* Convert.ToDecimal(Dgv_search.Rows[i].Cells[3].Value);

                }

                txt_totalQty.Text = Math.Round(totalQty, 2).ToString();
                txt_totalall.Text = Math.Round(totalgomla, 2).ToString();
                txt_totalpart.Text = Math.Round(totalpart, 2).ToString();
                txt_totaltaxe.Text = Math.Round(totaltaxe, 2).ToString();

            }
            catch (Exception) { }
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("SELECT [Pro_ID]as'رقم المنتج',[Pro_name]as'اسم المنتج',[main_UnitName]as'الوحده الرئيسيه',[Qty]as'الكميه الكليه',[gomla_price]as'سعر الجمله',[sale_price]as'سعر التجزأه',[tax_value]as'الضريبه',[sale_pricetax]as'السعر بعد الضريبه',[sale_unitname]as'وحدة البيع',[buy_UnitName]as'وحدة الشراء',[Barcode]as'الباركود',[minQty]as'الحد الادني',[maxdiscound]as'اقصي خصم مسموح',[is_tax]as'هل خاضع للضريبه',prouducts_group.group_Name as'اسم المجموعه'FROM [dbo].[products],prouducts_group where prouducts_group.group_ID=products.group_ID and products.group_ID ="+cbx_group.SelectedValue+" ", "");

            Dgv_search.DataSource = tbl;
            showtotal();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("SELECT [Pro_ID]as'رقم المنتج',[Pro_name]as'اسم المنتج',[main_UnitName]as'الوحده الرئيسيه',[Qty]as'الكميه الكليه',[gomla_price]as'سعر الجمله',[sale_price]as'سعر التجزأه',[tax_value]as'الضريبه',[sale_pricetax]as'السعر بعد الضريبه',[sale_unitname]as'وحدة البيع',[buy_UnitName]as'وحدة الشراء',[Barcode]as'الباركود',[minQty]as'الحد الادني',[maxdiscound]as'اقصي خصم مسموح',[is_tax]as'هل خاضع للضريبه',prouducts_group.group_Name as'اسم المجموعه'FROM [dbo].[products],prouducts_group where prouducts_group.group_ID=products.group_ID and products.[Barcode] =N'" + txtbarcode.Text+ "' ", "");

            Dgv_search.DataSource = tbl;
            showtotal();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("SELECT [Pro_ID]as'رقم المنتج',[Pro_name]as'اسم المنتج',[main_UnitName]as'الوحده الرئيسيه',[Qty]as'الكميه الكليه',[gomla_price]as'سعر الجمله',[sale_price]as'سعر التجزأه',[tax_value]as'الضريبه',[sale_pricetax]as'السعر بعد الضريبه',[sale_unitname]as'وحدة البيع',[buy_UnitName]as'وحدة الشراء',[Barcode]as'الباركود',[minQty]as'الحد الادني',[maxdiscound]as'اقصي خصم مسموح',[is_tax]as'هل خاضع للضريبه',prouducts_group.group_Name as'اسم المجموعه'FROM [dbo].[products],prouducts_group where prouducts_group.group_ID=products.group_ID and products.[Pro_name] like N'%" + txtname.Text + "%' ", "");

            Dgv_search.DataSource = tbl;
            showtotal();
        }
    }
}