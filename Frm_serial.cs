using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
namespace sales
{
    public partial class Frm_serial : Form
    {
        public Frm_serial()
        {
            InitializeComponent();
        }
        private string identifier(string wmiClass, string wmiProperty) 
            //Return a hardware identifier
        {
            string result = "";
            System.Management.ManagementClass mc = new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementObject mo in moc) { 
                //Only get the first one
                if (result == "")
                {
                    try {
                        result = mo[wmiProperty].ToString();
                        break; }
                    catch { } } }
            return result;
        }
           string x = "0";
            private void Frm_serial_Load(object sender, EventArgs e)
            {
           string signature = identifier("Win32_DiskDrive", "Signature");

            string serial = identifier("Win32_DiskDrive", "serialNumber");

            label2.Text = signature;
            label1.Text = serial;
            x = (Convert.ToDecimal(signature)  ).ToString();

            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == x)
            {
                Properties.Settings.Default.Product_key = "yes";
                Properties.Settings.Default.Save();
                MessageBox.Show("تم تفعيل البرنامج بنجاح", "تاكيد");
            }
            else
            {
                MessageBox.Show("خطا", "تاكيد");
                return;
            }
        }
    }
    
}
