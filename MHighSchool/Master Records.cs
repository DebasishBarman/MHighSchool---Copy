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
    public partial class Master_Records : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DEBA\\DEBA;Initial Catalog=NewSchool;Integrated Security=True");
        public Master_Records()
        {
            InitializeComponent();
        }

        private void classdetails_Click(object sender, EventArgs e)
        {
            con.Open();
            DataSet ds = new DataSet();
            string shw = "Select * from Class";
            SqlCommand cmd = new SqlCommand(shw,con);
            SqlDataAdapter sda = new SqlDataAdapter(shw,con);
            sda.Fill(ds,"Class");
            disp.DataSource = ds;
            disp.DataMember = "Class";
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            DataSet ds = new DataSet();
            string shw = "Select * from Subjects";
            SqlCommand cmd = new SqlCommand(shw, con);
            SqlDataAdapter sda = new SqlDataAdapter(shw, con);
            sda.Fill(ds, "Subjects");
            disp2.DataSource = ds;
            disp2.DataMember = "Subjects";
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            DataSet ds = new DataSet();
            string shw = "Select * from FeeTypes";
            SqlCommand cmd = new SqlCommand(shw, con);
            SqlDataAdapter sda = new SqlDataAdapter(shw, con);
            sda.Fill(ds, "FeeTypes");
            disp3.DataSource = ds;
            disp3.DataMember = "FeeTypes";
            con.Close();
        }
    }
}
