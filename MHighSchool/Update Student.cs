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
    public partial class Update_Student : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DEBA\\DEBA;Initial Catalog=NewSchool;Integrated Security=True");
        public Update_Student()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Main sm = new Student_Main();
            sm.Show();
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
            show.DisplayMember = "Class_name";
            show.ValueMember = "Class_name";
            show.DataSource = ds.Tables[0];
            show.Enabled = true;
            con.Close();

        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Students  where SReg_no='" + regno.Text + "'", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    show.Text = sdr["Class_name"].ToString();
                    sregdate.Text = sdr["SReg_date"].ToString();
                    sname.Text = sdr["SName"].ToString();
                    sgen.Text = sdr["SGender"].ToString();
                    sfat.Text = sdr["SFather"].ToString();
                    smot.Text = sdr["SMother"].ToString();
                    sphno.Text = sdr["SPhno"].ToString();
                    semail.Text = sdr["SEmail"].ToString();
                    saddr.Text = sdr["SAdress"].ToString();
                    
                }
                con.Close();
        }

        private void Update_Student_Load(object sender, EventArgs e)
        {
            datadisplayincombobox();
  
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
            if (show.Text == "" || sname.Text == "" || sgen.Text == "" || sfat.Text == "" || smot.Text == "" || sphno.Text == "" || semail.Text == "" || saddr.Text == "")
            {
                MessageBox.Show("Empty");
            }
            else
            {
                con.Open();
                string update = "update Students set Class_name='" + show.Text + "',SName='" + sname.Text + "',SGender='" + sgen.Text + "', SFather='" + sfat.Text + "', SMother='" + smot.Text + "', Sphno='" + sphno.Text + "', SEmail='" + semail.Text + "', SAdress='" + saddr.Text + "'  where SReg_no='" + regno.Text + "'";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Updated Successfully");
            }
          }
            catch (SqlException)
            {
                MessageBox.Show("Error");
            }
            regno.Text = "";
            regno.Focus();
        }
    }
}