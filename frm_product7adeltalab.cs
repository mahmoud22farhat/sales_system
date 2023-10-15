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
    public partial class frm_product7adeltalab : DevExpress.XtraEditors.XtraForm
    {
        public frm_product7adeltalab()
        {
            InitializeComponent();
        }

        database db = new database();
        DataTable tbl = new DataTable();

        private void frm_product7adeltalab_Load(object sender, EventArgs e)
        {
          
            tbl.Clear();

            tbl = db.readData("select Pro_name as'اسم المنتج',Qty as'الكمية الموجودة منه',minQty as'حد الطلب' from products where minQty >=1 and Qty <= minQty ", "");
            Dgv_search.DataSource = tbl;
            txt_total.Text = tbl.Rows.Count +"";
        }
    }
}