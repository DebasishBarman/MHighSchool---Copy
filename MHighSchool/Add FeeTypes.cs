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
    public partial class Add_FeeTypes : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DEBA\\DEBA;Initial Catalog=NewSchool;Integrated Security=True");
        public Add_FeeTypes()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Masters mm = new Masters();
            mm.Show();
        }
        public void datadisplayincombobox()
        {
            con.Open();
            DataSet ds = new DataSet();
            string getclass = "Select Class_name from Class";
            SqlCommand cd = new SqlCommand(getclass, con);
            SqlDataAdapter sda = new SqlDataAdapter(getclass, con);
            sda.Fill(ds);
            cd.ExecuteNonQuery();
            con.Close();
            classname.DisplayMember = "Class_name";
            classname.ValueMember = "Class_name";
            classname.DataSource = ds.Tables[0];
            classname.Enabled = true;

        }


        private void save_Click(object sender, EventArgs e)
        {
            try{
                if (feeid.Text == "" || feename.Text == "" || classname.Text == "" || famt.Text == "")
                    MessageBox.Show("Empty");
                else
                {
                    con.Open();
                    string chk = "Select Count(*) from FeeTypes where Fee_id='" + feeid.Text + "'and Fee_name='" + feename.Text +"'and Class_name='" + classname.Text + "'and Fee_amt='" + famt.Text + "'";
                    SqlCommand cmd = new SqlCommand(chk, con);
                    int rec = (int)cmd.ExecuteScalar();
                    if (rec == 0)
                    {
                        string ins = "Insert into FeeTypes(Fee_id,Fee_name,Class_name,Fee_amt) values('" + feeid.Text + "','" + feename.Text+"','" + classname.Text + "','" + famt.Text + "')";
                        SqlCommand cmd2 = new SqlCommand(ins, con);
                        cmd2.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data Saved");

                    }
                    else
                    {
                        MessageBox.Show("Pls try again");
                        con.Close();
                    }
                }
            }
             catch(SqlException)
             {
                  MessageBox.Show("Error");
                  con.Close();
              }

        }

        private void Add_FeeTypes_Load(object sender, EventArgs e)
        {
            datadisplayincombobox();
        }

        private void feeid_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string get = "Select * from FeeTypes ";
            SqlCommand cmd = new SqlCommand(get,con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                feename.Text = dr["Fee_name"].ToString();
                classname.Text = dr["Class_name"].ToString();
                famt.Text=dr["Fee_amt"].ToString();
            }
            con.Close();
        }
    }
}
