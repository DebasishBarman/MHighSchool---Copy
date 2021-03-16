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
    public partial class Update_delete_Class : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DEBA\\DEBA;Initial Catalog=NewSchool;Integrated Security=True");
        public Update_delete_Class()
        {
            InitializeComponent();
        }

        private void classcode_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string x = "Select Class_name from Class";
            SqlCommand cmd = new SqlCommand(x,con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                classname.Text=dr["Class_name"].ToString();
            }
            con.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            con.Open();
            string up = "Update Class Set Class_name='"+classname.Text+"' where Class_ID='"+classcode.Text+"' ";
            SqlCommand cmd = new SqlCommand(up,con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            con.Open();
            string up = "Delete from Class where Class_ID='" + classcode.Text + "' ";
            SqlCommand cmd = new SqlCommand(up, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully");
        }
    }
}
