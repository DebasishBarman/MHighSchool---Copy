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
    public partial class Delete_Student : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DEBA\\DEBA;Initial Catalog=NewSchool;Integrated Security=True");

        public Delete_Student()
        {
            InitializeComponent();
        }

        private void delstudentreg_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from Students  where SReg_no='" + deleteregno.Text + "'", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                stclass.Text = sdr["Class_name"].ToString();
                sdate.Text = sdr["SReg_date"].ToString();
                sname.Text = sdr["SName"].ToString();
                sgender.Text = sdr["SGender"].ToString();
                sfat.Text = sdr["SFather"].ToString();
                smot.Text = sdr["SMother"].ToString();
                sphno.Text = sdr["SPhno"].ToString();
                semail.Text = sdr["SEmail"].ToString();
                saddr.Text = sdr["SAdress"].ToString();

            }
            con.Close();
            deleteregno.Focus();
        }
        public void clear()
        {
            stclass.Text ="";
                sdate.Text = "";
                sname.Text = "";
                sgender.Text = "";
                sfat.Text = "";
                smot.Text = "";
                sphno.Text = "";
                semail.Text = "";
                saddr.Text = "";

        }

        private void delete_Click(object sender, EventArgs e)
        {
           try
           {
                if (deleteregno.Text == "")
                {
                    MessageBox.Show("Empty");
                }
                else
                {
                    con.Open();
                    string del = "Delete from Students where SReg_no='" + deleteregno.Text + "'";
                    SqlCommand cmd = new SqlCommand(del, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted");
                    con.Close();
              }
          }
          catch (SqlException)
          {
             MessageBox.Show("Error");
          }
           deleteregno.Text = "";
           clear();
           deleteregno.Focus();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Main sm = new Student_Main();
            sm.Show();
        }
      }
}
