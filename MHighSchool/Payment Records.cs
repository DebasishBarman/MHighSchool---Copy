using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MHighSchool
{
    public partial class Payment_Records : Form
    {
       SqlConnection con = new SqlConnection("Data Source=DEBA\\DEBA;Initial Catalog=NewSchool;Integrated Security=True");
        public Payment_Records()
        {
            InitializeComponent();
        }

        private void collection_Click(object sender, EventArgs e)
        {
           
            con.Open();
            string count = "Select Count(*) from Fees";
            SqlCommand cmd = new SqlCommand(count,con);
            int s = (int)cmd.ExecuteScalar();
            if (s >= 1)
            {
                DataSet ds = new DataSet();
                string get = "Select * from Fees where Paydate='" + paydate.Value.ToString() + "'";
                SqlCommand cd = new SqlCommand(get, con);
                SqlDataAdapter da = new SqlDataAdapter(get, con);
                da.Fill(ds, "Fees");
                disp.DataSource = ds;
                disp.DataMember = "Fees";
                string sum = "Select Sum(TotalAmount) from Fees where Paydate='"+paydate.Value.ToString()+"'";
                SqlCommand sd = new SqlCommand(sum,con);
                int dis = Convert.ToInt32(sd.ExecuteScalar());
                mo.Text = "Rs"+ dis.ToString();
                con.Close();
            }
            else
            {
                MessageBox.Show("No data found on this date");
            }
            con.Close();
            
        }

    }
}
