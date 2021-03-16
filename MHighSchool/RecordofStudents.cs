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
    public partial class RecordofStudents : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DEBA\\DEBA;Initial Catalog=NewSchool;Integrated Security=True");
        public RecordofStudents()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (searchbox.Text == "")
            { MessageBox.Show("empty"); }
            else
            {
                DataTable dt = new DataTable();
                string src = "Select * from Students where SName LIKE '%" + searchbox.Text + "%'";
                SqlCommand cmd = new SqlCommand(src, con);
                SqlDataAdapter sda = new SqlDataAdapter(src, con);
                sda.Fill(dt);
                con.Close();
                disp.DataSource = dt;
                searchbox.Focus();
            }
        }

        private void details_Click(object sender, EventArgs e)
        {
            con.Open();
            DataSet ds = new DataSet();
            string shw = "Select * from Students";
            SqlCommand cmd = new SqlCommand(shw,con);
            SqlDataAdapter sda = new SqlDataAdapter(shw,con);
            sda.Fill(ds,"Students");
            con.Close();
            disp.DataSource = ds;
            disp.DataMember = "Students";

        }
      
    }
}
