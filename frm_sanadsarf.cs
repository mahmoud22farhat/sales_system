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
    public partial class frm_sanadsarf : DevExpress.XtraEditors.XtraForm
    {
        public frm_sanadsarf()
        {
            InitializeComponent();
        }
        database db = new database();
        DataTable tbl = new DataTable();
        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select MAX (Order_ID) from sanad_sarf", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))

            {
                txt_id.Text = "1";
            }
            else
            {
                txt_id.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();

            }
            nud_price.Value = 1;
            dtp_date.Text = DateTime.Now.ToShortDateString();
            txt_reason.Clear();
            txt_name.Clear();
            txt_to.Clear();
            btn_add.Enabled = true;
            btn_new.Enabled = true;
            btn_delete.Enabled = false;
            btn_deleteall.Enabled = false;


        }


        int row;
        private void show()
        {
            tbl.Clear();
            tbl = db.readData("select * from sanad_sarf", "");
            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لايوجد بيانات في هذه الشاشة");
            }
            else
            {
                try
                {
                    txt_id.Text = tbl.Rows[row][0].ToString();
                    txt_name.Text = tbl.Rows[row][1].ToString();
                    nud_price.Value = Convert.ToDecimal(tbl.Rows[row][2]);
                    this.Text = tbl.Rows[row][3].ToString();
                    DateTime dt = DateTime.ParseExact(this.Text, "dd/MM/yyyy", null);
                    txt_to.Text = tbl.Rows[row][4].ToString();
                    txt_reason.Text = tbl.Rows[row][5



                        ].ToString();
                    dtp_date.Value = dt;

                    //dtp_date.Text = tbl.Rows[row][2].ToString();

                }
                catch (Exception) { }


            }
            btn_add.Enabled = false;
            btn_new.Enabled = true;
            btn_delete.Enabled = true;
            btn_deleteall.Enabled = true;

        }
        string stock_ID = "";
        private void frm_sanadsarf_Load(object sender, EventArgs e)
        {
           stock_ID =Convert.ToString( Properties.Settings.Default.stock_id);
            AutoNumber();
        }
        private void print()
        {

            int id = Convert.ToInt32(txt_id.Text);
            DataTable tblrpt = new DataTable();

            tblrpt.Clear();
            tblrpt = db.readData("SELECT [Order_ID] as'رقم العمليه',[name] as'اسم المسؤل عن الصرف',[price] as'المبلغ',[Date] as'تاريخ العملية',[to_] as'تم الصرف من',[Reason] as'السبب'FROM [dbo].[sanad_sarf] where Order_ID =" + id + "", "");

            Frm_printing frm = new Frm_printing();

            rpt_sanadsarf rpt = new rpt_sanadsarf();
            frm.crystalReportViewer1.RefreshReport();
            rpt.SetDatabaseLogon("", "", "DESKTOP-M6C24F7", "therd");
            rpt.SetDataSource(tblrpt);
            rpt.SetParameterValue("ID", id);
            frm.crystalReportViewer1.ReportSource = rpt;
            //لتحديد خيارات الطابعه
            System.Drawing.Printing.PrintDocument PrintDocument = new System.Drawing.Printing.PrintDocument();
            rpt.PrintOptions.PrinterName = PrintDocument.PrinterSettings.PrinterName;
            rpt.PrintToPrinter(1, true, 0, 0);
            //  frm.ShowDialog();

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_to.Text == "" || txt_name.Text == "")
            {
                MessageBox.Show("من فضلك ادخل البيانات");
                return;
            }
          decimal stock_money = 0;
            try
            {
               
                stock_money = Convert.ToDecimal(db.readData("select * from stock where stock_ID = " + stock_ID + "", "").Rows[0][1]);
              

            }catch(Exception){ }

            if (nud_price.Value >stock_money )
            {

                MessageBox.Show("المبلغ الموجود في الخزنه غر كافي لاجراء العمليه", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }

            string d = dtp_date.Value.ToString("dd/MM/yyyy");
            db.excetedate("update stock set Mony=Mony - " + nud_price.Value + "where stock_ID =" + stock_ID + "", "");
            db.excetedate("insert into stock_pull (stock_ID ,Mony ,Date ,Name ,Type ,Reason) values (" + stock_ID + "," + nud_price.Value + ",N'" + d + "',N'" + txt_name.Text + "' ,N'سند صرف',N'" + txt_reason.Text + "')", "");

            db.excetedate("insert into sanad_sarf values(" + txt_id.Text + " ,N'" + txt_name.Text + "' ," + nud_price.Value + " ,N'" + d + "' ,N'" + txt_to.Text + "' ,N'" + txt_reason.Text + "')", "تم الادخال بنجاح");

           print();

            AutoNumber();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متاكد من مسح البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string d = dtp_date.Value.ToString("dd/MM/yyyy");

                db.readData("delete from sanad_sarf where Order_ID=" + txt_id.Text + "", "تم مسح البيانات بنجاح");
                AutoNumber();
            }
        }

        private void btn_deleteall_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل انت متاكد من مسح البيانات", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string d = dtp_date.Value.ToString("dd/MM/yyyy");

                db.readData("delete from sanad_sarf ", "تم مسح البيانات بنجاح");
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
                tbl = db.readData("select count(Order_ID) from sanad_sarf ", "");
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
            if (row == 0)
            {
                tbl.Clear();
                tbl = db.readData("select count(Order_ID) from sanad_sarf ", "");
                row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
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
            tbl = db.readData("select count(Order_ID) from sanad_sarf", "");

            row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            show();
        }
    }
}