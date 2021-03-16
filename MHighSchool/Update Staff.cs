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
    public partial class Update_Staff : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DEBA\\DEBA;Initial Catalog=NewSchool;Integrated Security=True");
        public Update_Staff()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Master sm = new Staff_Master();
            sm.Show();
        }

        private void regno_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string get = "Select * from Staff where Stfid='"+regno.Text+"'";
            SqlCommand cmd = new SqlCommand(get,con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sname.Text=dr["Stfname"].ToString();
                sgen.Text=dr["Stfgen"].ToString();
                semail.Text=dr["Stf_email"].ToString();
                sphno.Text=dr["Stf_phno"].ToString();
                saddr.Text=dr["Stfaddr"].ToString();
                sfat.Text=dr["Stf_fat"].ToString();
                smot.Text=dr["Stf_mot"].ToString();
                sjdate.Text=dr["Stfdate"].ToString();
                qual.Text=dr["Stfq"].ToString();
            }
            con.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (regno.Text == "" || qual.Text == "" || sname.Text == "" || sgen.Text == "" || sfat.Text == "" || smot.Text == "" || sphno.Text == "" || semail.Text == "" || saddr.Text == "")
            {
                MessageBox.Show("Empty");
            }
            else
            {
                con.Open();
                string upd="Update Staff set Stfname='"+sname.Text+"',Stfgen='"+sgen.Text+"',Stf_fat='"+sfat.Text+"',Stfq='"+qual.Text+"',Stf_mot='"+smot.Text+"',Stf_phno='"+sphno.Text+"',Stf_email='"+semail.Text+"',Stfaddr='"+saddr.Text+"' where Stfid='"+regno.Text+"'";
                SqlCommand cmd=new SqlCommand (upd,con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated");
            }
           
        }
    }
}
