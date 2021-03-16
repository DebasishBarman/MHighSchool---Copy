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
    public partial class Remove_Staff : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DEBA\\DEBA;Initial Catalog=NewSchool;Integrated Security=True");
        public Remove_Staff()
        {
            InitializeComponent();
        }

        private void Remove_Staff_Load(object sender, EventArgs e)
        {

        }

        private void staffid_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Staff  where Stfid='" + staffid.Text + "'", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                
                sdate.Text = sdr["Stfdate"].ToString();
                stfqual.Text = sdr["Stfq"].ToString();
                sname.Text = sdr["Stfname"].ToString();
                sgender.Text = sdr["Stfgen"].ToString();
                sfat.Text = sdr["Stf_fat"].ToString();
                smot.Text = sdr["Stf_mot"].ToString();
                sphno.Text = sdr["Stf_phno"].ToString();
                semail.Text = sdr["Stf_email"].ToString();
                saddr.Text = sdr["Stfaddr"].ToString();

            }
            con.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Master sm = new Staff_Master();
            sm.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (staffid.Text == "")
                {
                    MessageBox.Show("Empty");
                   
                }
                else
                { 
                    con.Open();
                    string del = "Delete from Staff where Stfid='" + staffid.Text + "'";
                    SqlCommand cmd = new SqlCommand(del, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Deleted");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Data Deleted");
                con.Close();
            }
        }
    }
}
