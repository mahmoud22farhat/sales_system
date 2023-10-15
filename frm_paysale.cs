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
    public partial class frm_paysale : DevExpress.XtraEditors.XtraForm
    {
        public frm_paysale()
        {
            InitializeComponent();
        }

        private void frm_paysale_Load(object sender, EventArgs e)
        {
            try
            {
                txt_matloop.Text = (Properties.Settings.Default.totalOrder).ToString();

            }
            catch (Exception) { }
            txt_madfooE.Text = "0.0";
            txt_baky.Text = "";
            txt_madfooE.Focus();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
          
            if (txt_madfooE.Text == "") { MessageBox.Show("من فضلك ادخل المبلغ المدفوع", "تأكيد"); return; }


            Properties.Settings.Default.madfou3 = Convert.ToDecimal(txt_madfooE.Text);
            Properties.Settings.Default.baky = Convert.ToDecimal(txt_baky.Text);
            Properties.Settings.Default.chekButton = true;
            
            if(checkVisa.Checked == true)
            {

                Properties.Settings.Default.pay_visa = true;

            }
            else
            {
                Properties.Settings.Default.pay_visa = false;
            }


            Properties.Settings.Default.Save();

            Close();
        }

        private void frm_paysale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Properties.Settings.Default.madfou3 = Convert.ToDecimal(txt_madfooE.Text);
                Properties.Settings.Default.baky = Convert.ToDecimal(txt_baky.Text);
                Properties.Settings.Default.chekButton = true;

                if (checkVisa.Checked == true)
                {

                    Properties.Settings.Default.pay_visa = true;

                }
                else
                {
                    Properties.Settings.Default.pay_visa = false;
                }
                Properties.Settings.Default.Save();

                Close();

            }
            else if (e.KeyCode == Keys.F12)
            {
                Properties.Settings.Default.chekButton = false;
                Properties.Settings.Default.Save();
                Close();
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.chekButton = false;
            Properties.Settings.Default.Save();
            Close();
        }

        private void txt_madfooE_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal baky = Convert.ToDecimal(txt_matloop.Text) - Convert.ToDecimal(txt_madfooE.Text);

                txt_baky.Text = Math.Round(baky, 2).ToString();

            }
            catch (Exception) { }
        }
    }
}