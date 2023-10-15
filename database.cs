using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace sales
{
    class database
    {
        //connection to database
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-NJ3N9G2;Initial Catalog=therd;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        //read data from database
        //select
        public DataTable readData(string stmt, string message)
        {

            DataTable tbl = new DataTable();
            try
            { 
            cmd.Connection = conn;
            cmd.CommandText = stmt;
            conn.Open();
                //looas data from database to tbl
            tbl.Load(cmd.ExecuteReader());
            conn.Close();
                if (message != "")
                { MessageBox.Show(message, "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return tbl;
        }
         
        //insert update delete 
        public bool excetedate(string stmt ,string message)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = stmt;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                if(message!="")
                { MessageBox.Show(message, "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                return true;
            }
            catch(Exception ex)
            {
             return false;
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
