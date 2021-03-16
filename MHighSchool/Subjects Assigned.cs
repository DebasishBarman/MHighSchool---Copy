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
    public partial class Subjects_Assigned : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DEBA\\DEBA;Initial Catalog=NewSchool;Integrated Security=True");
        public Subjects_Assigned()
        {
            InitializeComponent();
        }

        private void Subjects_Assigned_Load(object sender, EventArgs e)
        {
            datadisplayincombobox();
            datadisplayincombobox2();

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
        public void datadisplayincombobox2()
        {
            con.Open();
            DataSet ds = new DataSet();
            string getclass = "Select Stfname from Staff";
            SqlCommand cd = new SqlCommand(getclass, con);
            SqlDataAdapter sda = new SqlDataAdapter(getclass, con);
            sda.Fill(ds);
            cd.ExecuteNonQuery();
            con.Close();
            teacher.DisplayMember = "Stfname";
            teacher.ValueMember = "Stfname";
            teacher.DataSource = ds.Tables[0];
            teacher.Enabled = true;

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Master sms = new Staff_Master();
            sms.Show();
        }

        private void classname_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string get = classname.SelectedItem.ToString();
            SqlCommand cmd = new SqlCommand ("Select Sub_name from Subjects where Class_ID='"+classname.SelectedValue+"'",con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                subname.Text=dr["Sub_name"].ToString();
            }
            con.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string chk = "Select Count(*) from Assigned where Code='"+code.Text+"'and Stfname='"+teacher.Text+"' and Class_name='"+classname.Text+"'and Sub_name='"+subname.Text+"'";
                SqlCommand cmd = new SqlCommand(chk,con);
                int rec=(int)cmd.ExecuteScalar();
                if (rec == 0)
                {
                    string ins = "Insert into Assigned(Code,Stfname,Class_name,Sub_name) values('" + code.Text + "','" + teacher.Text + "','" + classname.Text + "','" + subname.Text + "')";
                    SqlCommand cmd2 = new SqlCommand(ins, con);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Exist");
                }
                con.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("error");
            }
        }

    }
}
