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
    public partial class frm_storeGard : DevExpress.XtraEditors.XtraForm
    {
        public frm_storeGard()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable(); DataTable tblstore = new DataTable();
        private void fillstore()
        {
            cbx_store.DataSource = db.readData("select * from store ", "");
            cbx_store.DisplayMember = "store_Name";
            cbx_store.ValueMember = "store_ID";
        }
        private void showtotal()
        {
            try
            {
                decimal totalrb7h = 0, totalBuy = 0,  totalsale = 0;
                for (int i = 0; i <= Dgv_search.Rows.Count - i; i++)
                {
                   
                    totalrb7h += (Convert.ToDecimal(Dgv_search.Rows[i].Cells[5].Value) - Convert.ToDecimal(Dgv_search.Rows[i].Cells[4].Value))* Convert.ToDecimal(Dgv_search.Rows[i].Cells[3].Value);
                    totalBuy += Convert.ToDecimal(Dgv_search.Rows[i].Cells[4].Value);
                    totalsale +=  Convert.ToDecimal(Dgv_search.Rows[i].Cells[5].Value);

                }

                txt_rep7h.Text = Math.Round(totalrb7h, 2).ToString();
                txt_totalbuy.Text = Math.Round(totalBuy, 2).ToString();
                txt_totalsale.Text = Math.Round(totalsale, 2).ToString();

            }
            catch (Exception) { }
        }
        private void frm_storeGard_Load(object sender, EventArgs e)
        {
            fillstore();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
           tbl.Clear();
            if (rbtn_allstore.Checked == true)
            { 
            tbl = db.readData("SELECT products_Qty.Pro_ID as'رقم المنتج',products.Pro_name as'اسم المنتج', products_Qty.[store_Name]as'اسم المخزن', products_Qty.[Qty]as'الكميه',[Buy_price]as'سعر الشراء', products_Qty.[sale_pricetax]as'سعر البيع'FROM [dbo].[products_Qty], products where products_Qty.Pro_ID  =  products.Pro_ID", "");
            }else
            {
                tbl = db.readData("SELECT products_Qty.Pro_ID as'رقم المنتج',products.Pro_name as'اسم المنتج', products_Qty.[store_Name]as'اسم المخزن', products_Qty.[Qty]as'الكميه',[Buy_price]as'سعر الشراء', products_Qty.[sale_pricetax]as'سعر البيع'FROM [dbo].[products_Qty], products where products_Qty.Pro_ID  =  products.Pro_ID and products_Qty.store_ID="+cbx_store.SelectedValue+"", "");

            }
            Dgv_search.DataSource = tbl;
            if (tbl.Rows.Count >= 1)
            {
                showtotal();
            }
        }

        private void txtbarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                tbl.Clear();
                if (txtbarcode.Text != "")
                {
                    tbl = db.readData("SELECT products_Qty.Pro_ID as'رقم المنتج',products.Pro_name as'اسم المنتج', products_Qty.[store_Name]as'اسم المخزن', products_Qty.[Qty]as'الكميه',[Buy_price]as'سعر الشراء', products_Qty.[sale_pricetax]as'سعر البيع'FROM [dbo].[products_Qty], products where products_Qty.Pro_ID  =  products.Pro_ID and products.[Barcode] =N'" + txtbarcode.Text + "'", "");
                }
            
                Dgv_search.DataSource = tbl;
                if (tbl.Rows.Count >= 1)
                {
                    showtotal();
                }
            }
        }
    }
}