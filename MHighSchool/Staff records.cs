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
    public partial class Staff_records : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DEBA\\DEBA;Initial Catalog=NewSchool;Integrated Security=True");
        public Staff_records()
        {
            InitializeComponent();
        }

        private void staffdetails_Click(object sender, EventArgs e)
        {
            con.Open();
            DataSet ds = new DataSet();
            string get = "Select * from Staff";
            SqlCommand cmd = new SqlCommand(get,con);
            SqlDataAdapter sda = new SqlDataAdapter(get,con);
            sda.Fill(ds,"Staff");
            gridview.DataSource = ds;
            gridview.DataMember = "Staff";
            con.Close();
        }

        private void subasd_Click(object sender, EventArgs e)
        {
            con.Open();
            DataSet dss = new DataSet();
            string get = "Select * from Subjects";
            SqlCommand cmd = new SqlCommand(get,con);
            SqlDataAdapter sda = new SqlDataAdapter(get,con);
            sda.Fill(dss,"Subjects");
            gridview.DataSource = dss;
            gridview.DataMember = "Subjects";
            con.Close();
        }
    }
}
